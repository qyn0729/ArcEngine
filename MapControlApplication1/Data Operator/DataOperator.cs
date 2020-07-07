using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace MapControlApplication1
{
    class DataOperator
    {
        public IMap m_map;

        //Input map
        public DataOperator(IMap map)
        {
            m_map = map;
        }

        public ILayer GetLayerByName(string sLayerName)
        {
            //
            if(sLayerName == "" || m_map == null)
            {
                return null;
            }

            //layer traversal, return the layer with the required name
            for (int i = 0; i < m_map.LayerCount; i++)
            {
                if(m_map.get_Layer(i).Name == sLayerName)
                {
                    return m_map.get_Layer(i);
                }
            }

            //return null if the required layer doesn't exist
            return null;
        }

        public DataTable GetDataTable(IFeatureCursor featureCursor, IFeatureLayer featureLayer)
        {
            IFeature feature;

            //return null if the first feature cannot be found
            feature = featureCursor.NextFeature();
            if (feature == null)
            {
                return null;
            }

            //Get the geometry type of shapes
            string geometryType = GeometryType(featureLayer);

            //Create data table
            DataTable dataTable = new DataTable();

            //Create data columns and add them into data table
            DataColumn dataColumn = new DataColumn();
            IField field = null;
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                dataColumn = new DataColumn();
                field = featureLayer.FeatureClass.Fields.get_Field(i);
                dataColumn.ColumnName = field.AliasName;
                dataColumn.DataType = Type.GetType("System.String");
                dataTable.Columns.Add(dataColumn);
            }

            //Input values into data rows
            DataRow dataRow;
            while (feature != null)
            {
                dataRow = dataTable.NewRow();

                //Traverse all columns and get their values
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (featureLayer.FeatureClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry)
                    {
                        dataRow[i] = geometryType;
                    }
                    else
                    {
                        dataRow[i] = feature.get_Value(i);
                    }

                }
                dataTable.Rows.Add(dataRow);
                feature = featureCursor.NextFeature();
            }

            return dataTable;
        }

        public DataTable GetDataTable(ILayer layer)
        {
            //Get layer by name and change it into IFeatureLayer
            
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            if(featureLayer == null)
            {
                return null;
            }

            //Get the geometry type of shapes
            string geometryType = GeometryType(featureLayer);

            //Using "Search" to traverse all the features stored in this layer
            IFeature feature;
            IFeatureCursor featureCursor = featureLayer.Search(null, false);

            //return null if the first feature cannot be found
            feature = featureCursor.NextFeature();
            if(feature == null)
            {
                return null;
            }

            //Create data table
            DataTable dataTable = new DataTable();

            //Create data columns and add them into data table
            DataColumn dataColumn = new DataColumn();
            IField field = null;
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                dataColumn = new DataColumn();
                field = featureLayer.FeatureClass.Fields.get_Field(i);
                dataColumn.ColumnName = field.AliasName;
                dataColumn.DataType = Type.GetType("System.String");
                dataTable.Columns.Add(dataColumn);
            }

            //Input values into data rows
            DataRow dataRow;
            while(feature != null)
            {
                dataRow = dataTable.NewRow();

                //Traverse all columns and get their values
                for(int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if(featureLayer.FeatureClass.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry)
                    {
                        dataRow[i] = geometryType;
                    }
                    else
                    {
                        dataRow[i] = feature.get_Value(i);
                    }
                    
                }
                dataTable.Rows.Add(dataRow);
                feature = featureCursor.NextFeature();
            }

            return dataTable;

        }

        //Return the geometry type of feature layer
        public string GeometryType(IFeatureLayer featureLayer)
        {
            if(featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPoint)
            {
                return "Point";
            }
            else if(featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolygon)
            {
                return "Polygon";
            }
            else if(featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolyline)
            {
                return "Polyline";
            }
            return "";
        }

        //Function: Create Shapefile
        //Date: 2019/4/12
        public IFeatureClass CreateShapefile(IFields fields, string sParentDirectory, 
            string sWorkspaceName, //the name of the folder that contains the shapefile
            string sFilename, 
            string sGeometryType)//the geometry type of shapefile
        {
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
            IWorkspaceName workspaceName = workspaceFactory.Create(sParentDirectory, sWorkspaceName, null, 0);
            ESRI.ArcGIS.esriSystem.IName name = workspaceName as ESRI.ArcGIS.esriSystem.IName;

            IWorkspace workspace = (IWorkspace)name.Open();
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;

            IFieldsEdit fieldsEdit = fields as IFieldsEdit;

            IFieldEdit fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "OID";
            fieldEdit.AliasName_2 = "序号";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
            fieldsEdit.AddField((IField)fieldEdit);

            fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "Name";
            fieldEdit.AliasName_2 = "名称";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;
            fieldsEdit.AddField((IField)fieldEdit);

            //Change shape type
            IGeometryDefEdit geoDefEdit = new GeometryDefClass();
            ISpatialReference spatialReference = m_map.SpatialReference;
            geoDefEdit.SpatialReference_2 = spatialReference;
            if(sGeometryType == "Point")
            {
                geoDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
            }
            else if (sGeometryType == "Line")
            {
                geoDefEdit.GeometryType_2 = esriGeometryType.esriGeometryLine;
            }
            else if (sGeometryType == "Polygon")
            {
                geoDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
            }

            //change shapetype
            fieldEdit = new FieldClass();
            string sShapeFieldName = "Shape";
            fieldEdit.Name_2 = sShapeFieldName;
            fieldEdit.AliasName_2 = "形状";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
            fieldEdit.GeometryDef_2 = geoDefEdit;
            fieldsEdit.AddField((IField)fieldEdit);
           
            //create feature class
            IFeatureClass featureClass = featureWorkspace.CreateFeatureClass(sFilename,
                fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
            if(featureClass == null)
            {
                return null;
            }
            return featureClass;
        }

        public bool AddFeatureClassToMap(IFeatureClass featureClass, string sLayerName)
        {
            if(featureClass == null || sLayerName == "" || m_map == null)
            {
                return false;
            }

            //Operate the feature class as feature layer
            IFeatureLayer featureLayer = new FeatureLayerClass();
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = sLayerName;

            //Change feature layer into layer
            ILayer layer = featureLayer as ILayer;
            if(layer == null)
            {
                return false;
            }

            //add the newly created layer to the map
            m_map.AddLayer(layer);
            IActiveView activeView = m_map as IActiveView;
            if(activeView == null)
            {
                return false;
            }

            //refresh the active view and show the newly added layer
            activeView.Refresh();
            return true;
        }

        //Function: Create feature
        //Date: 2019/4/17
        public IFeature AddGeometryToLayer(string sLayerName, IGeometry geometry)
        {
            if(sLayerName == "" || geometry == null || m_map == null)
            {
                return null;
            }
            
            //Find the layer
            ILayer layer = null;
            for(int i = 0; i < m_map.LayerCount; i++)
            {
                layer = m_map.get_Layer(i);
                if(layer.Name == sLayerName)
                {
                    break;
                }
                layer = null;
            }

            if(layer == null)
            {
                return null;
            }

            IFeatureLayer featureLayer = layer as IFeatureLayer;
            IFeatureClass featureClass = featureLayer.FeatureClass;

            IFeature feature = featureClass.CreateFeature();
            if(feature == null)
            {
                return null;
            }

            //Input geometry as the feature's shape
            feature.Shape = geometry;
            if(feature == null)
            {
                return null;
            }

            IActiveView activeView = m_map as IActiveView;
            if(activeView == null)
            {
                return null;
            }

            //Refresh
            activeView.Refresh();
            return feature;
        }



    }
}
