﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Ilhyo Sung
// Student number: 301001793
// Date last modified: 21/07/2019
// Program description: This program will accept weight, height from user and calculate user's BMI.
// Revision history
// 21/07/2019 Create UI
// 22/07/2019 Add funtionalities

namespace COMP123_S2019_Assignment4_BMICalculator
{
    public partial class BMICalculator : Form
    {
        public string outputString { get; set; }
        public bool decimalExists { get; set; }
        public float outputValue { get; set; }
        public TextBox ActiveTextBox { get; set; }
        
        public float BMI;
        public BMICalculator()
        {
            InitializeComponent();
        }        
        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {            
            HeightUnitLabel.Text = "in";         
            WeightUnitLabel.Text = "lbs";
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";

        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {            
            HeightUnitLabel.Text = "cm";            
            WeightUnitLabel.Text = "kg";
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
        }

        private void ActiveTextBox_Click(object sender, EventArgs e)
        {
            if (ActiveTextBox != null)
            {
                ActiveTextBox.BackColor = Color.White;
                ActiveTextBox = null;
            }
            ActiveTextBox = sender as TextBox;
            ActiveTextBox.BackColor = Color.LightBlue;
            if (ActiveTextBox.Text != "0")
            {
                NumberResultLabel.Text = ActiveTextBox.Text;
                outputString = ActiveTextBox.Text;
            }
            ResultPanel.Visible = false;
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();

            int buttonValue;
            bool resultCondition = int.TryParse(tag, out buttonValue);

            // If the use pressed a number button
            if (resultCondition)
            {
                int maxSize = 3;
                if (decimalExists)
                {
                    maxSize = 5;
                }

                if ((outputString != "0") && (NumberResultLabel.Text.Count() < maxSize))
                {
                    outputString += tag;
                    NumberResultLabel.Text = outputString;
                }
            }
            // if the user pressed a button that is not a number
            if (!resultCondition)
            {
                switch (tag)
                {
                    case "clear":
                        Clear_NumericKeyboard();
                        break;
                    case "back":
                        Remove_LastCharacterFromResultLabel();
                        break;
                    case "done":
                        Finalize_Output();
                        break;
                    case "decimal":
                        Add_DecimalToResultLabel();
                        break;
                }
            }
        }
        private void Add_DecimalToResultLabel()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }
        private void Finalize_Output()
        {
            if (outputString == string.Empty)
            {
                outputString = "0";
            }            
            if (ActiveTextBox != null)
            {
                outputValue = float.Parse(outputString);
                ActiveTextBox.Text = outputValue.ToString();
                ActiveTextBox.BackColor = Color.White;
                ActiveTextBox = null;
            }            
            Clear_NumericKeyboard();            
        }
        private void Remove_LastCharacterFromResultLabel()
        {
            if (outputString.Length > 0)
            {

                var lastChar = outputString.Substring(outputString.Length - 1);
                if (lastChar == ".")
                {
                    decimalExists = false;
                }
                outputString = outputString.Remove(outputString.Length - 1);

                if (outputString.Length == 0)
                {
                    outputString = "0";
                }
                NumberResultLabel.Text = outputString;
            }
        }
        private void Clear_NumericKeyboard()
        {
            NumberResultLabel.Text = "0";
            outputString = String.Empty;
            decimalExists = false;
            outputValue = 0.0f;
        }
        private void Calculate()
        {
            float weight = float.Parse(WeightTextBox.Text);
            float height;
            float imperialConst;
            if (MetricButton.Checked)
            {
                height = float.Parse(HeightTextBox.Text) / 100;
            }
            else
            {
                height = float.Parse(HeightTextBox.Text);
            }
            if (ImperialButton.Checked)
            {
                imperialConst = 703;
            }
            else
            {
                imperialConst = 1;
            }
            BMI = (weight * imperialConst) / (height * height);
            BMITextBox.Text = Math.Round(BMI, 1).ToString();
        }
        private void Show_ResultTextBox()
        {
            if (BMI < 18.5)
            {
                ResultTextBox.Text = "Underweight" + Environment.NewLine + "(less than 18.5)";
            } else if (BMI >= 18.5 && BMI < 25)
            {
                ResultTextBox.Text = "Normal" + Environment.NewLine + "(18.5 to 24.9)";
            } else if (BMI >= 25 && BMI < 30)
            {
                ResultTextBox.Text = "Overweight" + Environment.NewLine + "(25 to 29.9)";
            } else
            {
                ResultTextBox.Text = "Obese" + Environment.NewLine + "(30 or greater)";
            }
        }
        private void Show_NormalRange()
        {
            float minNormalWeightRange;
            float maxNormalWeightRange;
            float height = float.Parse(HeightTextBox.Text);
            string unit;
            if (ImperialButton.Checked == true)
            {
                minNormalWeightRange = (float)18.5 * height * height / 703;
                maxNormalWeightRange = (float)25.0 * height * height / 703;
                unit = "lbs";
            } else
            {
                minNormalWeightRange = (float)18.5 * height * height / 10000;
                maxNormalWeightRange = (float)25.0 * height * height / 10000;
                unit = "kg";
            }
            NormalRangeTextBox.Text = "A normal adult weight for" + Environment.NewLine + "this height is"
                + Environment.NewLine + "between " + Math.Round(minNormalWeightRange, 1) + "-" + Math.Round(maxNormalWeightRange, 1) + " " + unit;
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (WeightTextBox.Text != "0" && HeightTextBox.Text != "0")
            {
                Calculate();
                Show_ResultTextBox();
                Show_NormalRange();
                ResultPanel.Visible = true;
            }            
            if (ActiveTextBox != null)
            {
                ActiveTextBox.BackColor = Color.White;
            }            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            WeightTextBox.Text = "0";
            HeightTextBox.Text = "0";
            ImperialButton.Checked = true;
            ResultPanel.Visible = false;
        }
    }
}
