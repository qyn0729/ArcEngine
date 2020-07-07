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
    public partial class RenderLayerFill : Form
    {
        IFeatureLayer m_featureLayer;
        public MainForm m_fraMain;

        public RenderLayerFill()
        {
            InitializeComponent();
        }

        public RenderLayerFill(IFeatureLayer featureLayer, MainForm frm)
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
                ISimpleFillSymbol simpleFillSymbol = simpleRenderer.Symbol as ISimpleFillSymbol;

                if (simpleFillSymbol != null)
                {
                    //Get the width of outline
                    tbOutlineWidth.Text = simpleFillSymbol.Outline.Width.ToString();


                    //Get the fill color
                    IRgbColor rgbColorFill = new RgbColorClass();
                    rgbColorFill = simpleFillSymbol.Color as IRgbColor;
                    tbRedFill.Text = rgbColorFill.Red.ToString();
                    tbGreenFill.Text = rgbColorFill.Green.ToString();
                    tbBlueFill.Text = rgbColorFill.Blue.ToString();

                    //Get the color of outline
                    IRgbColor rgbColorOutline = new RgbColorClass();
                    rgbColorOutline = simpleFillSymbol.Outline.Color as IRgbColor;
                    tbRedOutline.Text = rgbColorOutline.Red.ToString();
                    tbGreenOutline.Text = rgbColorOutline.Green.ToString();
                    tbBlueOutline.Text = rgbColorOutline.Blue.ToString();

                    //Change the value of track bar
                    tkbOutlineWidth.Value = (int)System.Convert.ToDouble(tbOutlineWidth.Text);
                }

            }

        }

        private void tkbSize_Scroll(object sender, EventArgs e)
        {
            //Change the text in TextBox when the value of track bar changes
            tbOutlineWidth.Text = tkbOutlineWidth.Value.ToString();
        }

        private void btnColorDialogFill_Click(object sender, EventArgs e)
        {
            //Show color dialog for fill color
            colorDialog1.ShowDialog();
            tbRedFill.Text = colorDialog1.Color.R.ToString();
            tbGreenFill.Text = colorDialog1.Color.G.ToString();
            tbBlueFill.Text = colorDialog1.Color.B.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Create a new simple fill symbol
            IGeoFeatureLayer geoFeatureLayer = m_featureLayer as IGeoFeatureLayer;
            ISimpleFillSymbol simpleFillSymbol = new SimpleFillSymbolClass();
            simpleFillSymbol.Style = esriSimpleFillStyle.esriSFSSolid;

            //Create a new simple line symbol for outline
            ISimpleLineSymbol Outline = new SimpleLineSymbolClass();

            //Change the width of outline
            Outline.Width = int.Parse(tbOutlineWidth.Text);

            //Change the fill color
            IRgbColor rgbColorFill = new RgbColorClass();
            rgbColorFill.Red = int.Parse(tbRedFill.Text);
            rgbColorFill.Blue = int.Parse(tbBlueFill.Text);
            rgbColorFill.Green = int.Parse(tbGreenFill.Text);
            simpleFillSymbol.Color = rgbColorFill;

            //Change the color of outline
            IRgbColor rgbColorOutline = new RgbColorClass();
            rgbColorOutline.Red = int.Parse(tbRedOutline.Text);
            rgbColorOutline.Blue = int.Parse(tbBlueOutline.Text);
            rgbColorOutline.Green = int.Parse(tbGreenOutline.Text);
            Outline.Color = rgbColorOutline;

            //Change the properties of polygon's outline
            simpleFillSymbol.Outline = Outline;

            //Change the properties of polygon
            ISimpleRenderer simpleRenderer = new SimpleRendererClass();
            simpleRenderer.Symbol = simpleFillSymbol as ISymbol;
            geoFeatureLayer.Renderer = simpleRenderer as IFeatureRenderer;

            m_fraMain.RefreshMap();
            m_fraMain.RefreshTOCControl();
            this.Close();
        }

        private void btnColorDialogOutline_Click(object sender, EventArgs e)
        {
            //Show color dialog for outline
            colorDialog1.ShowDialog();
            tbRedOutline.Text = colorDialog1.Color.R.ToString();
            tbGreenOutline.Text = colorDialog1.Color.G.ToString();
            tbBlueOutline.Text = colorDialog1.Color.B.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
