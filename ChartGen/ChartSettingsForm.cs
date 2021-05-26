using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartGen
{
    public partial class ChartSettingsForm : Form
    {
        private PlotModel _plotModel;

        private OxyColor _selectedSeriesColor = OxyColors.Black;

        public ChartSettingsForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            CreateMenuBar();

            _plotModel = CreateBasicModel();

            textBoxTitle.Text = "Title";
            textBoxSubTitle.Text = "Sub Title";
            numericUpDownFontSize.Value = 10;
            buttonTextColor.BackColor = Color.Black;
            FillLineStylesComboBox();
            checkBoxShowAxisGridLines.Checked = true;
            checkedListBoxSeries.DisplayMember = "Title";

            textBoxSeriesName.Text = "NewSeries";
            buttonSeriesColor.BackColor = Color.Black;

            numericUpDownWidth.Value = plotView.Width;
            numericUpDownHeight.Value = plotView.Height;

            this.plotView.Model = _plotModel;
        }

        private PlotModel CreateBasicModel()
        {
            PlotModel model = new PlotModel();

            model.Axes.Add(new LinearAxis() { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis() { Position = AxisPosition.Left });

            return model;
        }

        private PlotModel CloneAdjustedPlotModel()
        {
            PlotModel model = CreateBasicModel();

            if (_plotModel != null)
            {
                model.PlotAreaBackground = _plotModel.PlotAreaBackground;
                model.PlotAreaBorderColor = _plotModel.PlotAreaBorderColor;
                model.TextColor = _plotModel.TextColor;
                model.Title = _plotModel.Title;
                model.Subtitle = _plotModel.Subtitle;
                model.DefaultFontSize = _plotModel.DefaultFontSize;
                model.LegendTextColor = _plotModel.LegendTextColor;

                // Set if the Axes Exists
                if (_plotModel.Axes != null)
                {
                    for (int i = 0; i < _plotModel.Axes.Count; i++)
                    {
                        model.Axes[i].MajorGridlineStyle = _plotModel.Axes[i].MajorGridlineStyle;
                        model.Axes[i].MajorGridlineColor = _plotModel.Axes[i].MajorGridlineColor;
                    }
                }

                // Set if the Series Exists
                if (_plotModel.Series != null)
                {
                    model.Series.Clear();
                    for (int i = 0; i < _plotModel.Series.Count; i++)
                    {
                        LineSeries series = new LineSeries();
                        series.ItemsSource = ((LineSeries)_plotModel.Series[i]).ItemsSource;
                        series.Title = _plotModel.Series[i].Title;
                        series.Color = ((LineSeries)_plotModel.Series[i]).Color;
                        series.LineStyle = ((LineSeries)_plotModel.Series[i]).LineStyle;
                        series.StrokeThickness = ((LineSeries)_plotModel.Series[i]).StrokeThickness;

                        model.Series.Add(series);
                    }
                }
            }

            return model;
        }

        private void FillLineStylesComboBox()
        {
            comboBoxGridLineStyle.DataSource = Enum.GetNames(typeof(LineStyle));
            comboBoxSeriesLineStyle.DataSource = Enum.GetNames(typeof(LineStyle));
        }

        private OxyColor ShowColorDialog(object sender)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = MyDialog.Color;
                return OxyColor.FromRgb(MyDialog.Color.R, MyDialog.Color.G, MyDialog.Color.B);
            }

            Color buttonColor = ((Button)sender).BackColor;
            return OxyColor.FromRgb(buttonColor.R, buttonColor.G, buttonColor.B);
        }

        #region PlotModel Properties
        private void buttonBgColor_Click(object sender, EventArgs e)
        {
            _plotModel.PlotAreaBackground = ShowColorDialog(sender);
            _plotModel.InvalidatePlot(true);
        }

        private void buttonBorderColor_Click(object sender, EventArgs e)
        {
            _plotModel.PlotAreaBorderColor = ShowColorDialog(sender);
            _plotModel.InvalidatePlot(true);
        }

        private void buttonTextColor_Click(object sender, EventArgs e)
        {
            _plotModel.TextColor = ShowColorDialog(sender);
            _plotModel.InvalidatePlot(true);
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            _plotModel.Title = textBoxTitle.Text;
            _plotModel.InvalidatePlot(true);
        }

        private void textBoxSubTitle_TextChanged(object sender, EventArgs e)
        {
            _plotModel.Subtitle = textBoxSubTitle.Text;
            _plotModel.InvalidatePlot(true);
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            _plotModel.DefaultFontSize = decimal.ToDouble(numericUpDownFontSize.Value);
            _plotModel.InvalidatePlot(true);
        }
        #endregion

        #region GridLine
        private void checkBoxShowAxisGridLines_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowAxisGridLines.Checked)
            {
                groupBoxAxisGridLines.Visible = true;
                comboBoxGridLineStyle.SelectedIndex = 0;
            } 
            else
            {
                comboBoxGridLineStyle.SelectedItem = "None";
                groupBoxAxisGridLines.Visible = false;
            }
            _plotModel.InvalidatePlot(true);
        }

        private void comboBoxGridLineStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LineStyle style = (LineStyle)Enum.Parse(typeof(LineStyle), comboBoxGridLineStyle.SelectedItem.ToString());
            foreach (var item in _plotModel.Axes)
            {
                item.MajorGridlineStyle = style;
            }
            _plotModel.InvalidatePlot(true);
        }

        private void buttonGridLineColor_Click(object sender, EventArgs e)
        {
            OxyColor color = ShowColorDialog(sender);
            foreach (var item in _plotModel.Axes)
            {
                item.MajorGridlineColor = color;
            }
            _plotModel.InvalidatePlot(true);
        }
        #endregion

        #region Data

        private DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
            {
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";
            }
            else
            {
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';";
            }
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    con.Open();
                    DataTable dtSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    if (dtSchema == null || dtSchema.Rows.Count < 1)
                    {
                        throw new Exception("Error: Could not determine the name of the first worksheet.");
                    }
                    string firstSheetName = dtSchema.Rows[0].Field<string>("TABLE_NAME");

                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [" + firstSheetName + "]", con);
                    oleAdpt.Fill(dtexcel);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show("Excel Read Error!");
                }
            }
            return dtexcel;
        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxSeriesName.Text))
            {
                MessageBox.Show("Please enter 'Series Name'", "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Excel (*.xlsx, *.xls)|*.xlsx;*.xls;";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string fileExt = Path.GetExtension(selectedFilePath);
                DataTable dtExcel = ReadExcel(selectedFilePath, fileExt);

                List<DataPoint> data = new List<DataPoint>();
                for (int i = 0; i < dtExcel.Rows.Count; i++)
                {
                    double x = double.Parse(dtExcel.Rows[i][0].ToString());
                    double y = double.Parse(dtExcel.Rows[i][1].ToString());
                    data.Add(new DataPoint(x, y));
                }

                AddLineSeriesWithDataPoints(data);
            }
        }

        private void AddLineSeriesWithDataPoints(List<DataPoint> data)
        {
            LineSeries series = new LineSeries();
            series.ItemsSource = data;
            series.Title = textBoxSeriesName.Text;
            series.Color = _selectedSeriesColor;
            series.StrokeThickness = (double)numericUpDownSeriesThickness.Value;

            _plotModel.LegendTextColor = series.Color;

            checkedListBoxSeries.Items.Add(series, true);

            _plotModel.Series.Add(series);
            _plotModel.InvalidatePlot(true);
        }

        private void buttonRemoveSeries_Click(object sender, EventArgs e)
        {
            Series selected = (Series)checkedListBoxSeries.SelectedItem;
            if (selected != null)
            {
                checkedListBoxSeries.Items.Remove(selected);
                _plotModel.Series.Remove(selected);
                _plotModel.InvalidatePlot(true);
            }
        }

        private void buttonSeriesColor_Click(object sender, EventArgs e)
        {
            _selectedSeriesColor = ShowColorDialog(buttonSeriesColor);

            LineSeries selected = (LineSeries)checkedListBoxSeries.SelectedItem;
            if(selected != null)
            {
                selected.Color = _selectedSeriesColor;
                _plotModel.InvalidatePlot(false);
            }
        }

        private void checkedListBoxSeries_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            LineSeries selected = (LineSeries)checkedListBoxSeries.SelectedItem;

            if(selected == null)
            {
                return;
            }

            if (!checkedListBoxSeries.GetItemChecked(checkedListBoxSeries.SelectedIndex))
            {
                selected.IsVisible = true;
            }
            else
            {
                selected.IsVisible = false;
            }
            _plotModel.InvalidatePlot(false);
        }

        private void numericUpDownSeriesThickness_ValueChanged(object sender, EventArgs e)
        {
            LineSeries selected = (LineSeries)checkedListBoxSeries.SelectedItem;
            if(selected != null)
            {
                selected.StrokeThickness = (double)numericUpDownSeriesThickness.Value;
                _plotModel.InvalidatePlot(false);
            }
        }

        private void comboBoxSeriesLineStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LineStyle style = (LineStyle)Enum.Parse(typeof(LineStyle), comboBoxSeriesLineStyle.SelectedItem.ToString());
            LineSeries selectedSeries = (LineSeries)checkedListBoxSeries.SelectedItem;

            if(selectedSeries != null)
            {
                selectedSeries.LineStyle = style;
            }
            _plotModel.InvalidatePlot(false);
        }
        #endregion

        #region PlotModel Other
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ChartForm"];
            if (fc != null)
            {
                fc.Close();
            }

            PlotModel model = CloneAdjustedPlotModel();
            ChartPreviewForm chartForm = new ChartPreviewForm(model);
            chartForm.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG Dosyası|*.png";
            save.OverwritePrompt = true;
            save.DefaultExt = "png";
            save.FileName = "ChartGen_" + DateTime.Now.ToString("yyyyMMdd-HHMMss");

            if (save.ShowDialog() == DialogResult.OK)
            {
                _plotModel.ResetAllAxes();
                var pngExporter = new PngExporter { Width = (int)numericUpDownWidth.Value, Height = (int)numericUpDownHeight.Value };
                pngExporter.ExportToFile(_plotModel, save.FileName);
            }
        }

        private void plotView_SizeChanged(object sender, EventArgs e)
        {
            numericUpDownWidth.Value = plotView.Width;
            numericUpDownHeight.Value = plotView.Height;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            _plotModel.ResetAllAxes();
            var pngExporter = new PngExporter { Width = (int)numericUpDownWidth.Value, Height = (int)numericUpDownHeight.Value };
            var bitmap = pngExporter.ExportToBitmap(_plotModel);
            Clipboard.SetImage(bitmap);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _plotModel.ResetAllAxes();
            _plotModel.InvalidatePlot(false);
        }

        private void CreateMenuBar()
        {
            this.Menu = new MainMenu();
            this.Menu.MenuItems.Add("About", new EventHandler(buttonMenuItemAbout_Click));
        }

        private void buttonMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/oktaykcr/ChartGen \nVersion: 1.0.1", "About", MessageBoxButtons.OK);
        }
        #endregion
    }
}
