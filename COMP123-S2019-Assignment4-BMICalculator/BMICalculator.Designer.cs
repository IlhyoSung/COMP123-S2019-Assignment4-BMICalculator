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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.NormalRangeTextBox = new System.Windows.Forms.TextBox();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
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
            this.CalculatorPanel.Controls.Add(this.ZeroButton, 0, 3);
            this.CalculatorPanel.Controls.Add(this.DecimalButton, 2, 3);
            this.CalculatorPanel.Controls.Add(this.DoneButton, 3, 2);
            this.CalculatorPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.CalculatorPanel.Controls.Add(this.TwoButton, 1, 2);
            this.CalculatorPanel.Controls.Add(this.OneButton, 0, 2);
            this.CalculatorPanel.Controls.Add(this.button7, 3, 1);
            this.CalculatorPanel.Controls.Add(this.SixButton, 2, 1);
            this.CalculatorPanel.Controls.Add(this.FiveButton, 1, 1);
            this.CalculatorPanel.Controls.Add(this.FourButton, 0, 1);
            this.CalculatorPanel.Controls.Add(this.BackButton, 3, 0);
            this.CalculatorPanel.Controls.Add(this.NineButton, 2, 0);
            this.CalculatorPanel.Controls.Add(this.EightButton, 1, 0);
            this.CalculatorPanel.Controls.Add(this.SevenButton, 0, 0);
            this.CalculatorPanel.Location = new System.Drawing.Point(12, 226);
            this.CalculatorPanel.Name = "CalculatorPanel";
            this.CalculatorPanel.RowCount = 4;
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorPanel.Size = new System.Drawing.Size(280, 203);
            this.CalculatorPanel.TabIndex = 0;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Checked = true;
            this.ImperialButton.Location = new System.Drawing.Point(35, 12);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(128, 31);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialButton.UseVisualStyleBackColor = true;
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
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(7, 67);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(138, 27);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.HeightTextBox.Location = new System.Drawing.Point(151, 64);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.Text = "inches";
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Location = new System.Drawing.Point(257, 67);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(35, 27);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "in";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(257, 116);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(48, 27);
            this.WeightUnitLabel.TabIndex = 7;
            this.WeightUnitLabel.Text = "lbs";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.WeightTextBox.Location = new System.Drawing.Point(151, 113);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.Text = "pounds";
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(7, 116);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(142, 27);
            this.MyWeightLabel.TabIndex = 5;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(9, 171);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(192, 40);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(205, 171);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 40);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // MyBMILabel
            // 
            this.MyBMILabel.AutoSize = true;
            this.MyBMILabel.Location = new System.Drawing.Point(-2, 11);
            this.MyBMILabel.Name = "MyBMILabel";
            this.MyBMILabel.Size = new System.Drawing.Size(104, 27);
            this.MyBMILabel.TabIndex = 10;
            this.MyBMILabel.Text = "My BMI";
            // 
            // BMITextBox
            // 
            this.BMITextBox.ForeColor = System.Drawing.Color.DimGray;
            this.BMITextBox.Location = new System.Drawing.Point(108, 8);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(175, 38);
            this.BMITextBox.TabIndex = 11;
            this.BMITextBox.Text = "BMI";
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ResultPanel.Controls.Add(this.ResultTextBox);
            this.ResultPanel.Controls.Add(this.NormalRangeTextBox);
            this.ResultPanel.Controls.Add(this.MyBMILabel);
            this.ResultPanel.Controls.Add(this.BMITextBox);
            this.ResultPanel.Location = new System.Drawing.Point(12, 435);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(287, 203);
            this.ResultPanel.TabIndex = 12;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultTextBox.Location = new System.Drawing.Point(3, 54);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(280, 35);
            this.ResultTextBox.TabIndex = 13;
            this.ResultTextBox.Text = "Normal (18.5 to 24.9)";
            // 
            // NormalRangeTextBox
            // 
            this.NormalRangeTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NormalRangeTextBox.Location = new System.Drawing.Point(3, 96);
            this.NormalRangeTextBox.Multiline = true;
            this.NormalRangeTextBox.Name = "NormalRangeTextBox";
            this.NormalRangeTextBox.Size = new System.Drawing.Size(280, 104);
            this.NormalRangeTextBox.TabIndex = 12;
            this.NormalRangeTextBox.Text = "A normal adult weight for your height is \r\nbetween 132.3-178.8 lbs";
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(64, 44);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(73, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(64, 44);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(143, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(64, 44);
            this.NineButton.TabIndex = 2;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackButton.Location = new System.Drawing.Point(213, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 44);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(3, 53);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(64, 44);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(73, 53);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(64, 44);
            this.FiveButton.TabIndex = 5;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(143, 53);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(64, 44);
            this.SixButton.TabIndex = 6;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(213, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(3, 103);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(64, 44);
            this.OneButton.TabIndex = 8;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(73, 103);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(64, 44);
            this.TwoButton.TabIndex = 9;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(143, 103);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(64, 44);
            this.ThreeButton.TabIndex = 10;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DoneButton.Location = new System.Drawing.Point(213, 103);
            this.DoneButton.Name = "DoneButton";
            this.CalculatorPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(64, 94);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(143, 153);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(64, 44);
            this.DecimalButton.TabIndex = 14;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.CalculatorPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Location = new System.Drawing.Point(3, 153);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(134, 44);
            this.ZeroButton.TabIndex = 16;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.CalculatorPanel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.HeightUnitLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.MyHeightLabel);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.ImperialButton);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.CalculatorPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
    }
}

