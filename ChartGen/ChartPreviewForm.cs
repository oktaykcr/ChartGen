using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartGen
{
    public partial class ChartPreviewForm : Form
    {
        private PlotModel _plotModel;

        public ChartPreviewForm(PlotModel model)
        {
            InitializeComponent();

            _plotModel = model;

            this.plotView.Model = model;
            this.plotView.InvalidatePlot(true);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _plotModel.ResetAllAxes();
            _plotModel.InvalidatePlot(false);
        }
    }
}
