using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;

namespace MapControlApplication1
{
    class TryMapAnalysis
    {

        public bool QueryIntersect(string srcLayerName, string tgtLayerName,
            IMap iMap, esriSpatialRelationEnum spatialRel)
        {
            DataOperator dataOperator = new DataOperator(iMap);

            //Get layer by name
            IFeatureLayer iSrcLayer = (IFeatureLayer)dataOperator.GetLayerByName(srcLayerName);
            IFeatureLayer iTgtLayer = (IFeatureLayer)dataOperator.GetLayerByName(tgtLayerName);

            //using query filter to get geom
            IGeometry geom;
            IFeature feature;
            IFeatureCursor featCursor;
            IFeatureClass srcFeatClass;
            IQueryFilter queryFilter = new QueryFilter();
            queryFilter.WhereClause = "CONTINENT='Asia'"; //set query clause
            featCursor = iTgtLayer.FeatureClass.Search(queryFilter, false);
            feature = featCursor.NextFeature();
            geom = feature.Shape;

            //city attributes filter
            srcFeatClass = iSrcLayer.FeatureClass;
            ISpatialFilter spatialFilter = new SpatialFilter();
            spatialFilter.Geometry = geom;
            spatialFilter.WhereClause = "POP_RANK>5";
            spatialFilter.SpatialRel = (ESRI.ArcGIS.Geodatabase.esriSpatialRelEnum)spatialRel;

            //select features
            IFeatureSelection featureSelection = (IFeatureSelection)iSrcLayer;
            featureSelection.SelectFeatures(spatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);

            ISelectionSet selectionSet = featureSelection.SelectionSet;
            ICursor cursor;
            selectionSet.Search(null, true, out cursor);
            IFeatureCursor featureCursor = cursor as IFeatureCursor;
            if (selectionSet.Count > 0)
            {
                DataBoard dataBoard = new DataBoard(iMap, dataOperator.GetDataTable(featureCursor, iSrcLayer));
                dataBoard.cbEnabledFalse();
                dataBoard.Show();
            }


            return true;
        }

        public bool Buffer(string layerName, string sWhere, int iSize, IMap iMap)
        {
            IFeatureClass featureClass;
            IFeature feature;
            IGeometry geometry;

            DataOperator dataOperator = new DataOperator(iMap);
            IFeatureLayer featureLayer = (IFeatureLayer)dataOperator.GetLayerByName(layerName);

            featureClass = featureLayer.FeatureClass;
            IQueryFilter queryFilter = new QueryFilter();
            queryFilter.WhereClause = sWhere;
            IFeatureCursor featureCursor;
            featureCursor = (IFeatureCursor)featureClass.Search(queryFilter, false);
            int count = featureClass.FeatureCount(queryFilter);

            feature = featureCursor.NextFeature();
            geometry = feature.Shape;

            ITopologicalOperator ipTO = (ITopologicalOperator)geometry;
            IGeometry iGeomBuffer = ipTO.Buffer(iSize);

            ISpatialFilter spatialFilter = new SpatialFilter();
            spatialFilter.Geometry = iGeomBuffer;
            spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIndexIntersects;

            IFeatureSelection featureSelection = (IFeatureSelection)featureLayer;
            featureSelection.SelectFeatures(spatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);

            return true;
        }
    }
}
