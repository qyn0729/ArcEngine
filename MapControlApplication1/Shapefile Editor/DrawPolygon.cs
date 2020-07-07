using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using MapControlApplication1.Data_Operator;

namespace MapControlApplication1.Shapefile_Editor
{
    public class DrawPolygon : BaseTool
    {
        IMap m_map;
        MainForm m_frmMain;
        string sLayerName;
        public DrawPolygon(string s, IMap map, MainForm frm)
        {
            m_map = map;
            m_frmMain = frm;
            sLayerName = s;
        }
        private IGeometry _polygon = null;
        private INewPolygonFeedback _polyFeedback = null;
        private IPoint _startPoint = null;
        private IPoint _endPoint = null;

        private bool _drawStart = false;
        public bool get_drawStart()
        {
            return _drawStart;
        }
        public void set_drawStart(bool start)
        {
            _drawStart = start;
        }
        
        public void set_startPoint(IPoint point)
        {
            _startPoint = point;
        }

        public void set_polyFeedback(IPoint point)
        {
            _polyFeedback.Start(point);
        }

        private int flag = 0;
        public int get_flag()
        {
            return flag;
        }
        public void set_flag(int f)
        {
            flag = f;
        }

        protected ESRI.ArcGIS.Controls.AxMapControl myMapControl = null;
        protected ESRI.ArcGIS.Controls.IHookHelper myHook;

        //Return the reasult
        public IGeometry Polygon
        {
            get { return _polygon; }
        }

        public override void OnCreate(object hook)
        {           
            if (myHook == null)
            {
                myHook = new ESRI.ArcGIS.Controls.HookHelperClass();               
            }
            myHook.Hook = hook;
            if (_drawStart)
            {
                (myHook.Hook as IMapControl3).CurrentTool = this;
                _polyFeedback = new NewPolygonFeedbackClass();
                _polyFeedback.Display = myHook.ActiveView.ScreenDisplay;
            }
        }

        public override void OnClick()
        {
            _polygon = null;
            _drawStart = true;

            (myHook.Hook as IMapControl3).CurrentTool = this;
            _polyFeedback = new NewPolygonFeedbackClass();
        }

        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            if(Button == 1)
            {
                if(_drawStart && _startPoint == null)
                {
                    _startPoint = (myHook.FocusMap as IActiveView).ScreenDisplay.
                        DisplayTransformation.ToMapPoint(X, Y);
                    _polyFeedback.Start(_startPoint);
                }
                else if(_drawStart)
                {
                    _endPoint = (myHook.FocusMap as IActiveView).ScreenDisplay.
                        DisplayTransformation.ToMapPoint(X, Y);
                    _polyFeedback.AddPoint(_endPoint);
                }
            }
        }

        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            if(_startPoint != null)
            {
                IPoint movePoint = (myHook.FocusMap as IActiveView).ScreenDisplay.
                    DisplayTransformation.ToMapPoint(X, Y);
                _polyFeedback.MoveTo(movePoint);
            }
        }

        public override void Refresh(int hDC)
        {
            base.Refresh(hDC);
            if(_polyFeedback != null)
            {
                (_polyFeedback as IDisplayFeedback).Refresh(hDC);
            }
        }

        public override void OnDblClick() //Stop drawing polygon
        {
            if(_drawStart)
            {
                _polygon = _polyFeedback.Stop();
                DataOperator dataOperator = new DataOperator(m_map);
                ILayer layer = dataOperator.GetLayerByName(sLayerName);
                IFeatureLayer featureLayer = layer as IFeatureLayer;
                IFeature feature = dataOperator.AddGeometryToLayer(sLayerName, _polygon); //Add the new geometry to layer
                AddFeature addFeature = new AddFeature(feature, m_map, m_frmMain);
                addFeature.ShowDialog(); //Change the attributes
                _startPoint = null;
            }           
        }

    }
}
