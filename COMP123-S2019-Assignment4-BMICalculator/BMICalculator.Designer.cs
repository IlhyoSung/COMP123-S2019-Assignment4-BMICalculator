namespace COMP123_S2019_Assignment4_BMICalculator
{
    partial class BMICalculator
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
            this.CalculatorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.NumberResultLabel = new System.Windows.Forms.Label();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MyBMILabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.NormalRangeTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CalculatorPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorPanel
            // 
            this.CalculatorPanel.ColumnCount = 4;
            this.CalculatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.CalculatorPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.CalculatorPanel.Controls.Add(this.DoneButton, 3, 3);
            this.CalculatorPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.CalculatorPanel.Controls.Add(this.TwoButton, 1, 3);
            this.CalculatorPanel.Controls.Add(this.OneButton, 0, 3);
            this.CalculatorPanel.Controls.Add(this.ClearButton, 3, 2);
            this.CalculatorPanel.Controls.Add(this.SixButton, 2, 2);
            this.CalculatorPanel.Controls.Add(this.FiveButton, 1, 2);
            this.CalculatorPanel.Controls.Add(this.FourButton, 0, 2);
            this.CalculatorPanel.Controls.Add(this.BackButton, 3, 1);
            this.CalculatorPanel.Controls.Add(this.NineButton, 2, 1);
            this.CalculatorPanel.Controls.Add(this.EightButton, 1, 1);
            this.CalculatorPanel.Controls.Add(this.SevenButton, 0, 1);
            this.CalculatorPanel.Controls.Add(this.NumberResultLabel, 0, 0);
            this.CalculatorPanel.Location = new System.Drawing.Point(12, 204);
            this.CalculatorPanel.Name = "CalculatorPanel";
            this.CalculatorPanel.RowCount = 5;
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorPanel.Size = new System.Drawing.Size(280, 225);
            this.CalculatorPanel.TabIndex = 0;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SeaGreen;
            this.CalculatorPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZeroButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 183);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(134, 39);
            this.ZeroButton.TabIndex = 16;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DecimalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecimalButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.Location = new System.Drawing.Point(143, 183);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(64, 39);
            this.DecimalButton.TabIndex = 14;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(213, 138);
            this.DoneButton.Name = "DoneButton";
            this.CalculatorPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(64, 84);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ThreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreeButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(143, 138);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(64, 39);
            this.ThreeButton.TabIndex = 10;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.SeaGreen;
            this.TwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwoButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(73, 138);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(64, 39);
            this.TwoButton.TabIndex = 9;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.SeaGreen;
            this.OneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OneButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 138);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(64, 39);
            this.OneButton.TabIndex = 8;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.Orange;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(213, 93);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(64, 39);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.SeaGreen;
            this.SixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SixButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(143, 93);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(64, 39);
            this.SixButton.TabIndex = 6;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.SeaGreen;
            this.FiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiveButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(73, 93);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(64, 39);
            this.FiveButton.TabIndex = 5;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.SeaGreen;
            this.FourButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FourButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 93);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(64, 39);
            this.FourButton.TabIndex = 4;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.SeaGreen;
            this.NineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NineButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(143, 48);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(64, 39);
            this.NineButton.TabIndex = 2;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SeaGreen;
            this.EightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EightButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(73, 48);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(64, 39);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SeaGreen;
            this.SevenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SevenButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 48);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(64, 39);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // NumberResultLabel
            // 
            this.NumberResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberResultLabel.AutoSize = true;
            this.NumberResultLabel.BackColor = System.Drawing.Color.White;
            this.NumberResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculatorPanel.SetColumnSpan(this.NumberResultLabel, 4);
            this.NumberResultLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberResultLabel.Location = new System.Drawing.Point(3, 0);
            this.NumberResultLabel.Name = "NumberResultLabel";
            this.NumberResultLabel.Size = new System.Drawing.Size(274, 45);
            this.NumberResultLabel.TabIndex = 17;
            this.NumberResultLabel.Tag = "result";
            this.NumberResultLabel.Text = "0";
            this.NumberResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Checked = true;
            this.ImperialButton.Location = new System.Drawing.Point(27, 12);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(128, 31);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Location = new System.Drawing.Point(169, 12);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(106, 31);
            this.MetricButton.TabIndex = 1;
            this.MetricButton.Text = "Metric";
            this.MetricButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(7, 58);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(138, 27);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeightTextBox.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HeightTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeightTextBox.Location = new System.Drawing.Point(151, 55);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(90, 38);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.Text = "0";
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightTextBox.Click += new System.EventHandler(this.ActiveTextBox_Click);
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Location = new System.Drawing.Point(247, 58);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(35, 27);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "in";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(247, 107);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(48, 27);
            this.WeightUnitLabel.TabIndex = 7;
            this.WeightUnitLabel.Text = "lbs";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeightTextBox.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WeightTextBox.Location = new System.Drawing.Point(151, 104);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(90, 38);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.Text = "0";
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightTextBox.Click += new System.EventHandler(this.ActiveTextBox_Click);
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(7, 107);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(142, 27);
            this.MyWeightLabel.TabIndex = 5;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.Location = new System.Drawing.Point(9, 155);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(192, 40);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(205, 155);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 40);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MyBMILabel
            // 
            this.MyBMILabel.AutoSize = true;
            this.MyBMILabel.Location = new System.Drawing.Point(-2, 10);
            this.MyBMILabel.Name = "MyBMILabel";
            this.MyBMILabel.Size = new System.Drawing.Size(104, 27);
            this.MyBMILabel.TabIndex = 10;
            this.MyBMILabel.Text = "My BMI";
            // 
            // BMITextBox
            // 
            this.BMITextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BMITextBox.Location = new System.Drawing.Point(108, 7);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(175, 38);
            this.BMITextBox.TabIndex = 11;
            this.BMITextBox.Text = "BMI";
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ResultPanel.Controls.Add(this.BMIProgressBar);
            this.ResultPanel.Controls.Add(this.ResultTextBox);
            this.ResultPanel.Controls.Add(this.NormalRangeTextBox);
            this.ResultPanel.Controls.Add(this.MyBMILabel);
            this.ResultPanel.Controls.Add(this.BMITextBox);
            this.ResultPanel.Location = new System.Drawing.Point(9, 201);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(287, 228);
            this.ResultPanel.TabIndex = 12;
            this.ResultPanel.Visible = false;
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.BackColor = System.Drawing.Color.White;
            this.BMIProgressBar.Location = new System.Drawing.Point(3, 51);
            this.BMIProgressBar.Maximum = 50;
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(280, 27);
            this.BMIProgressBar.Step = 100;
            this.BMIProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BMIProgressBar.TabIndex = 14;
            this.BMIProgressBar.Value = 25;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultTextBox.Location = new System.Drawing.Point(3, 84);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(280, 56);
            this.ResultTextBox.TabIndex = 13;
            this.ResultTextBox.Text = "Normal (18.5 to 24.9)";
            // 
            // NormalRangeTextBox
            // 
            this.NormalRangeTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NormalRangeTextBox.Location = new System.Drawing.Point(3, 148);
            this.NormalRangeTextBox.Multiline = true;
            this.NormalRangeTextBox.Name = "NormalRangeTextBox";
            this.NormalRangeTextBox.Size = new System.Drawing.Size(280, 78);
            this.NormalRangeTextBox.TabIndex = 12;
            this.NormalRangeTextBox.Text = "A normal adult weight for this height is \r\nbetween 132.3-178.8 lbs";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.SeaGreen;
            this.BackButton.BackgroundImage = global::COMP123_S2019_Assignment4_BMICalculator.Properties.Resources.backbutton;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(213, 48);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 39);
            this.BackButton.TabIndex = 3;
            this.BackButton.Tag = "back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.WeightUnitLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.HeightUnitLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.MyHeightLabel);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.CalculatorPanel);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.CalculatorPanel.ResumeLayout(false);
            this.CalculatorPanel.PerformLayout();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorPanel;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label MyBMILabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox NormalRangeTextBox;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Label NumberResultLabel;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
    }
}

