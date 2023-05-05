/****************************************************************************\

 Projekt : MBLittleProfessor
 Sprache : C#
 Compiler: MS Visual Studio 2008
 Autor   : Manfred Becker
 E-Mail  : mani.becker@web.de
 Url     : https://github.com/ManiBecker/MBLittleProfessor
 Modul   : Form1.cs
 Version : 1.00
 Datum   : 28.04.2023

\****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MBLittleProfessor
{
    public partial class FormMain : Form
    {
        private static ClassMBLittleProfessorRuntime cLPRT;
        private int nRatingIndex = 4, nRatingDirection = -1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cLPRT = new ClassMBLittleProfessorRuntime();
            timerDisplay.Enabled = true;
            //Test
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            cLPRT.Start();
        }

        private void buttonLevel_Click(object sender, EventArgs e)
        {
            cLPRT.NextLevel();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            cLPRT.NextAddition();
        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            cLPRT.NextSubtraction();
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            cLPRT.NextMultiplication();
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            cLPRT.NextDivision();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cLPRT.SetInput(9);
        }

        private void button1x1_Click(object sender, EventArgs e)
        {
            cLPRT.Next1x1();
        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            if (labelExercise.Text != cLPRT.GetExercise())
            {
                labelExercise.Text = cLPRT.GetExercise();
            }

            if (labelInput.Text != cLPRT.GetInput())
            {
                labelInput.Text = cLPRT.GetInput();
            }

            if (labelLevel.Text != cLPRT.GetLevel())
            {
                labelLevel.Text = cLPRT.GetLevel();
            }

            if (labelHint.Text != cLPRT.GetHint())
            {
                labelHint.Text = cLPRT.GetHint();
                if (labelHint.Text == "Input?")
                    labelIcon.Text = "?";
                else if (labelHint.Text == "Error!")
                    labelIcon.Text = "L"; // :(
                else if (labelHint.Text == "Solution")
                    labelIcon.Text = "K"; // :|
                else if (labelHint.Text == "Correct!")
                    labelIcon.Text = "J"; // :)
            }

            if (labelResult.Text != cLPRT.GetResult())
            {
                labelResult.Text = cLPRT.GetResult();
            }

            if (labelRating.Text != cLPRT.GetRating())
            {
                labelRating.Text = cLPRT.GetRating();
            }

            if (cLPRT.GetSolutionNoteTicker() > 0)
            {
                cLPRT.DecSolutionNoteTicker();

                if (cLPRT.GetSolutionNoteTicker() == 1)
                {
                    cLPRT.ShowSolutionNote();
                }
            }

            if (cLPRT.GetNextCalculationTicker() > 0)
            {
                cLPRT.DecNextCalculationTicker();

                if (cLPRT.GetNextCalculationTicker() == 1)
                {
                    cLPRT.NextCalculation();
                }
            }

            if (cLPRT.GetSameCalculationTicker() > 0)
            {
                cLPRT.DecSameCalculationTicker();

                if (cLPRT.GetSameCalculationTicker() == 1)
                {
                    cLPRT.SameCalculation();
                }
            }

            if (cLPRT.GetRndCalculationTicker() > 0)
            {
                cLPRT.DecRndCalculationTicker();
                int ticker = cLPRT.GetRndCalculationTicker();

                if (ticker > 0 && ticker <= 4)
                {
                    int op = ticker - 1;
                    labelExercise.Text = "   " + cLPRT.GetMathOperation() + "  =";
                    labelHint.Text = "+,-,*,/ ?";
                }
                else if (ticker > 4 && ticker <= 50)
                {
                    labelExercise.Text = "   " + cLPRT.GetMathOperation() + cLPRT.GetOP2().ToString() + "=";
                    labelHint.Text = "OP2?";
                }
            }

            if (cLPRT.GetShowCompleteResultTicker() > 0)
            {
                cLPRT.DecShowCompleteResultTicker();

                if (cLPRT.GetNumberOfFalseCalculations() == 0)
                {
                    labelRating.Text = "    *    ".Substring(nRatingIndex, 5);
                    nRatingIndex = nRatingIndex + nRatingDirection;
                    if (nRatingIndex == 0 || nRatingIndex == 4) nRatingDirection = nRatingDirection * -1;
                }

                if (cLPRT.GetShowCompleteResultTicker() == 1)
                {
                    cLPRT.ResetCalculations();
                    cLPRT.NextCalculation();
                }
            }
        }

        private void checkBoxHint_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Visible = checkBoxHint.Checked;
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Überprüfe, ob die Escape-Taste gedrückt wurde
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            // Überprüfen, ob eine Zifferntaste gedrückt wurde (von der Haupttastatur oder der numerischen Tastatur)
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                int nZiffer = -1;

                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                {
                    nZiffer = e.KeyCode - Keys.D0;
                }
                else
                {
                    nZiffer = e.KeyCode - Keys.NumPad0;
                }

                if( nZiffer>=0 && nZiffer<=9 )
                    cLPRT.SetInput(nZiffer);
            }

            // Überprüfe, ob eine der Funktionstasten +,-,*,/,S,L,R,H gedrückt wurde
            if (e.KeyCode == Keys.Add || (e.Shift == false && e.KeyValue == 187))
            {
                cLPRT.NextAddition();
            }
            else if (e.KeyCode == Keys.Subtract || (e.Shift == false && e.KeyValue == 189))
            {
                cLPRT.NextSubtraction();
            }
            else if (e.KeyCode == Keys.Multiply || (e.Shift == true && e.KeyValue == 187))
            {
                cLPRT.NextMultiplication();
            }
            else if (e.KeyCode == Keys.Divide || (e.Shift == true && e.KeyValue == 55))
            {
                cLPRT.NextDivision();
            }
            else if (e.KeyCode == Keys.S)
            {
                cLPRT.Start();
            }
            else if (e.KeyCode == Keys.L)
            {
                cLPRT.NextLevel();
            }
            else if (e.KeyCode == Keys.R)
            {
                cLPRT.Next1x1();
            }
            else if (e.KeyCode == Keys.H)
            {
                checkBoxHint.Checked = !checkBoxHint.Checked;
            }
        }
    }
}
