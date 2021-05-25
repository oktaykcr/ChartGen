namespace ChartGen
{
    partial class ChartSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartSettingsForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowAxisGridLines = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSeriesLineStyle = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownSeriesThickness = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxSeries = new System.Windows.Forms.CheckedListBox();
            this.buttonSeriesColor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSeriesName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonRemoveSeries = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.groupBoxAxisGridLines = new System.Windows.Forms.GroupBox();
            this.buttonGridLineColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxGridLineStyle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTextColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBorderColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBgColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeriesThickness)).BeginInit();
            this.groupBoxAxisGridLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxShowAxisGridLines);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBoxAxisGridLines);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonTextColor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonBorderColor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonBgColor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDownFontSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSubTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxTitle);
            this.groupBox2.Location = new System.Drawing.Point(15, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 576);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBoxShowAxisGridLines
            // 
            this.checkBoxShowAxisGridLines.AutoSize = true;
            this.checkBoxShowAxisGridLines.Location = new System.Drawing.Point(168, 42);
            this.checkBoxShowAxisGridLines.Name = "checkBoxShowAxisGridLines";
            this.checkBoxShowAxisGridLines.Size = new System.Drawing.Size(125, 17);
            this.checkBoxShowAxisGridLines.TabIndex = 14;
            this.checkBoxShowAxisGridLines.Text = "Show Axis Grid Lines";
            this.checkBoxShowAxisGridLines.UseVisualStyleBackColor = true;
            this.checkBoxShowAxisGridLines.CheckedChanged += new System.EventHandler(this.checkBoxShowAxisGridLines_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.comboBoxSeriesLineStyle);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDownSeriesThickness);
            this.groupBox1.Controls.Add(this.checkedListBoxSeries);
            this.groupBox1.Controls.Add(this.buttonSeriesColor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxSeriesName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonRemoveSeries);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonImportData);
            this.groupBox1.Location = new System.Drawing.Point(156, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 364);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // comboBoxSeriesLineStyle
            // 
            this.comboBoxSeriesLineStyle.FormattingEnabled = true;
            this.comboBoxSeriesLineStyle.Location = new System.Drawing.Point(12, 127);
            this.comboBoxSeriesLineStyle.Name = "comboBoxSeriesLineStyle";
            this.comboBoxSeriesLineStyle.Size = new System.Drawing.Size(148, 21);
            this.comboBoxSeriesLineStyle.TabIndex = 12;
            this.comboBoxSeriesLineStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeriesLineStyle_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Series Line Style:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Series Thickness:";
            // 
            // numericUpDownSeriesThickness
            // 
            this.numericUpDownSeriesThickness.Location = new System.Drawing.Point(85, 80);
            this.numericUpDownSeriesThickness.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSeriesThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeriesThickness.Name = "numericUpDownSeriesThickness";
            this.numericUpDownSeriesThickness.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSeriesThickness.TabIndex = 9;
            this.numericUpDownSeriesThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeriesThickness.ValueChanged += new System.EventHandler(this.numericUpDownSeriesThickness_ValueChanged);
            // 
            // checkedListBoxSeries
            // 
            this.checkedListBoxSeries.FormattingEnabled = true;
            this.checkedListBoxSeries.Location = new System.Drawing.Point(10, 194);
            this.checkedListBoxSeries.Name = "checkedListBoxSeries";
            this.checkedListBoxSeries.Size = new System.Drawing.Size(153, 139);
            this.checkedListBoxSeries.TabIndex = 8;
            this.checkedListBoxSeries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxSeries_ItemCheck);
            // 
            // buttonSeriesColor
            // 
            this.buttonSeriesColor.Location = new System.Drawing.Point(10, 79);
            this.buttonSeriesColor.Name = "buttonSeriesColor";
            this.buttonSeriesColor.Size = new System.Drawing.Size(63, 23);
            this.buttonSeriesColor.TabIndex = 7;
            this.buttonSeriesColor.Text = "Select";
            this.buttonSeriesColor.UseVisualStyleBackColor = true;
            this.buttonSeriesColor.Click += new System.EventHandler(this.buttonSeriesColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Series Color:";
            // 
            // textBoxSeriesName
            // 
            this.textBoxSeriesName.Location = new System.Drawing.Point(10, 40);
            this.textBoxSeriesName.Name = "textBoxSeriesName";
            this.textBoxSeriesName.Size = new System.Drawing.Size(150, 20);
            this.textBoxSeriesName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Series Name:";
            // 
            // buttonRemoveSeries
            // 
            this.buttonRemoveSeries.Location = new System.Drawing.Point(10, 335);
            this.buttonRemoveSeries.Name = "buttonRemoveSeries";
            this.buttonRemoveSeries.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveSeries.TabIndex = 3;
            this.buttonRemoveSeries.Text = "Remove";
            this.buttonRemoveSeries.UseVisualStyleBackColor = true;
            this.buttonRemoveSeries.Click += new System.EventHandler(this.buttonRemoveSeries_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Series:";
            // 
            // buttonImportData
            // 
            this.buttonImportData.Location = new System.Drawing.Point(10, 152);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(150, 23);
            this.buttonImportData.TabIndex = 0;
            this.buttonImportData.Text = "Import From Excel";
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // groupBoxAxisGridLines
            // 
            this.groupBoxAxisGridLines.Controls.Add(this.buttonGridLineColor);
            this.groupBoxAxisGridLines.Controls.Add(this.label8);
            this.groupBoxAxisGridLines.Controls.Add(this.comboBoxGridLineStyle);
            this.groupBoxAxisGridLines.Controls.Add(this.label7);
            this.groupBoxAxisGridLines.Location = new System.Drawing.Point(156, 65);
            this.groupBoxAxisGridLines.Name = "groupBoxAxisGridLines";
            this.groupBoxAxisGridLines.Size = new System.Drawing.Size(181, 135);
            this.groupBoxAxisGridLines.TabIndex = 12;
            this.groupBoxAxisGridLines.TabStop = false;
            this.groupBoxAxisGridLines.Text = "Axis Grid Line Settings";
            // 
            // buttonGridLineColor
            // 
            this.buttonGridLineColor.Location = new System.Drawing.Point(10, 93);
            this.buttonGridLineColor.Name = "buttonGridLineColor";
            this.buttonGridLineColor.Size = new System.Drawing.Size(120, 23);
            this.buttonGridLineColor.TabIndex = 3;
            this.buttonGridLineColor.Text = "Select";
            this.buttonGridLineColor.UseVisualStyleBackColor = true;
            this.buttonGridLineColor.Click += new System.EventHandler(this.buttonGridLineColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Color:";
            // 
            // comboBoxGridLineStyle
            // 
            this.comboBoxGridLineStyle.FormattingEnabled = true;
            this.comboBoxGridLineStyle.Location = new System.Drawing.Point(10, 36);
            this.comboBoxGridLineStyle.Name = "comboBoxGridLineStyle";
            this.comboBoxGridLineStyle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGridLineStyle.TabIndex = 1;
            this.comboBoxGridLineStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxGridLineStyle_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grid Line Style:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Text Color:";
            // 
            // buttonTextColor
            // 
            this.buttonTextColor.Location = new System.Drawing.Point(19, 269);
            this.buttonTextColor.Name = "buttonTextColor";
            this.buttonTextColor.Size = new System.Drawing.Size(120, 23);
            this.buttonTextColor.TabIndex = 10;
            this.buttonTextColor.Text = "Select";
            this.buttonTextColor.UseVisualStyleBackColor = true;
            this.buttonTextColor.Click += new System.EventHandler(this.buttonTextColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Border Color:";
            // 
            // buttonBorderColor
            // 
            this.buttonBorderColor.Location = new System.Drawing.Point(19, 225);
            this.buttonBorderColor.Name = "buttonBorderColor";
            this.buttonBorderColor.Size = new System.Drawing.Size(120, 23);
            this.buttonBorderColor.TabIndex = 8;
            this.buttonBorderColor.Text = "Select";
            this.buttonBorderColor.UseVisualStyleBackColor = true;
            this.buttonBorderColor.Click += new System.EventHandler(this.buttonBorderColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Background Color:";
            // 
            // buttonBgColor
            // 
            this.buttonBgColor.Location = new System.Drawing.Point(19, 181);
            this.buttonBgColor.Name = "buttonBgColor";
            this.buttonBgColor.Size = new System.Drawing.Size(120, 23);
            this.buttonBgColor.TabIndex = 6;
            this.buttonBgColor.Text = "Select";
            this.buttonBgColor.UseVisualStyleBackColor = true;
            this.buttonBgColor.Click += new System.EventHandler(this.buttonBgColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Font Size:";
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(19, 133);
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFontSize.TabIndex = 4;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.numericUpDownFontSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubTitle:";
            // 
            // textBoxSubTitle
            // 
            this.textBoxSubTitle.Location = new System.Drawing.Point(19, 91);
            this.textBoxSubTitle.Name = "textBoxSubTitle";
            this.textBoxSubTitle.Size = new System.Drawing.Size(120, 20);
            this.textBoxSubTitle.TabIndex = 2;
            this.textBoxSubTitle.TextChanged += new System.EventHandler(this.textBoxSubTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(19, 42);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(120, 20);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(644, 19);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonReset);
            this.groupBox3.Controls.Add(this.plotView);
            this.groupBox3.Location = new System.Drawing.Point(10, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 557);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chart";
            // 
            // plotView
            // 
            this.plotView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView.Location = new System.Drawing.Point(6, 48);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(713, 491);
            this.plotView.TabIndex = 0;
            this.plotView.Text = "plotView1";
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plotView.SizeChanged += new System.EventHandler(this.plotView_SizeChanged);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Location = new System.Drawing.Point(1092, 609);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 4;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(1011, 609);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(930, 609);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(792, 617);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "X";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownWidth.Location = new System.Drawing.Point(691, 612);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownWidth.TabIndex = 10;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownHeight.Location = new System.Drawing.Point(813, 612);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownHeight.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1154, 591);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 16;
            // 
            // ChartSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 644);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChartSettingsForm";
            this.Text = "ChartGen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeriesThickness)).EndInit();
            this.groupBoxAxisGridLines.ResumeLayout(false);
            this.groupBoxAxisGridLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBgColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTextColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBorderColor;
        private System.Windows.Forms.GroupBox groupBoxAxisGridLines;
        private System.Windows.Forms.ComboBox comboBoxGridLineStyle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGridLineColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxShowAxisGridLines;
        private System.Windows.Forms.GroupBox groupBox3;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRemoveSeries;
        private System.Windows.Forms.TextBox textBoxSeriesName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSeriesColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeries;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownSeriesThickness;
        private System.Windows.Forms.ComboBox comboBoxSeriesLineStyle;
        private System.Windows.Forms.Label label14;
    }
}

