using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;

namespace MapControlApplication1
{
    public partial class RenderLayerLine : Form
    {
        IFeatureLayer m_featureLayer;
        public MainForm m_fraMain;

        public RenderLayerLine()
        {
            InitializeComponent();
        }

        public RenderLayerLine(IFeatureLayer featureLayer, MainForm frm)
        {
            InitializeComponent();
            m_featureLayer = featureLayer;
            m_fraMain = frm;

            //Get properties of the current symbol
            IGeoFeatureLayer geoFeatureLayer = featureLayer as IGeoFeatureLayer;
            IFeatureRenderer featureRenderer = geoFeatureLayer.Renderer;
            if (featureRenderer is ISimpleRenderer)
            {
                ISimpleRenderer simpleRenderer = geoFeatureLayer.Renderer as ISimpleRenderer;
                ISimpleLineSymbol simpleLineSymbol = simpleRenderer.Symbol as ISimpleLineSymbol;

                if (simpleLineSymbol != null)
                {
                    //Get the width of line
                    tbSize.Text = simpleLineSymbol.Width.ToString();

                    //Get the color of line
                    IRgbColor rgbColor = new RgbColorClass();
                    rgbColor = simpleLineSymbol.Color as IRgbColor;
                    tbRed.Text = rgbColor.Red.ToString();
                    tbGreen.Text = rgbColor.Green.ToString();
                    tbBlue.Text = rgbColor.Blue.ToString();

                    //Change the value of track bar
                    tkbSize.Value = int.Parse(tbSize.Text);
                }
            }
        }

        private void tkbSize_Scroll(object sender, EventArgs e)
        {
            //Change the text in TextBox when the value of track bar changes
            tbSize.Text = tkbSize.Value.ToString();
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            //Show color dialog
            colorDialog1.ShowDialog();
            tbRed.Text = colorDialog1.Color.R.ToString();
            tbGreen.Text = colorDialog1.Color.G.ToString();
            tbBlue.Text = colorDialog1.Color.B.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            IGeoFeatureLayer geoFeatureLayer = m_featureLayer as IGeoFeatureLayer;

            //Create a new simple line symbol
            ISimpleLineSymbol simpleLineSymbol = new SimpleLineSymbolClass();
            simpleLineSymbol.Style = esriSimpleLineStyle.esriSLSSolid;
            simpleLineSymbol.Width = int.Parse(tbSize.Text);

            //Change the color of line
            IRgbColor rgbColor = new RgbColorClass();
            rgbColor.Red = int.Parse(tbRed.Text);
            rgbColor.Blue = int.Parse(tbBlue.Text);
            rgbColor.Green = int.Parse(tbGreen.Text);
            simpleLineSymbol.Color = rgbColor;

            //Change the properties of line
            ISimpleRenderer simpleRenderer = new SimpleRendererClass();
            simpleRenderer.Symbol = simpleLineSymbol as ISymbol;
            geoFeatureLayer.Renderer = simpleRenderer as IFeatureRenderer;

            m_fraMain.RefreshMap();
            m_fraMain.RefreshTOCControl();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
