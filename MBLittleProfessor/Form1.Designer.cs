namespace MBLittleProfessor
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.labelIcon = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelExercise = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLevel = new System.Windows.Forms.Button();
            this.button1x1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.buttonMUL = new System.Windows.Forms.Button();
            this.buttonSUB = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.timerDisplay = new System.Windows.Forms.Timer(this.components);
            this.checkBoxHint = new System.Windows.Forms.CheckBox();
            this.groupBoxDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxDisplay.Controls.Add(this.labelIcon);
            this.groupBoxDisplay.Controls.Add(this.labelHint);
            this.groupBoxDisplay.Controls.Add(this.labelLevel);
            this.groupBoxDisplay.Controls.Add(this.labelInput);
            this.groupBoxDisplay.Controls.Add(this.labelExercise);
            this.groupBoxDisplay.Location = new System.Drawing.Point(37, 85);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(176, 41);
            this.groupBoxDisplay.TabIndex = 0;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "groupBox1";
            // 
            // labelIcon
            // 
            this.labelIcon.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelIcon.Location = new System.Drawing.Point(150, -1);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(26, 26);
            this.labelIcon.TabIndex = 4;
            this.labelIcon.Text = "?";
            this.labelIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHint
            // 
            this.labelHint.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(69, 25);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(101, 16);
            this.labelHint.TabIndex = 3;
            this.labelHint.Text = "FAIL";
            this.labelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLevel
            // 
            this.labelLevel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(3, 25);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(58, 16);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "Level:3";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(90, 2);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(59, 23);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "1234";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelExercise
            // 
            this.labelExercise.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExercise.Location = new System.Drawing.Point(3, 2);
            this.labelExercise.Name = "labelExercise";
            this.labelExercise.Size = new System.Drawing.Size(96, 23);
            this.labelExercise.TabIndex = 0;
            this.labelExercise.Text = "180/ 5=";
            this.labelExercise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Gold;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(21, 277);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(43, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLevel
            // 
            this.buttonLevel.BackColor = System.Drawing.Color.Gold;
            this.buttonLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevel.Location = new System.Drawing.Point(21, 309);
            this.buttonLevel.Name = "buttonLevel";
            this.buttonLevel.Size = new System.Drawing.Size(43, 23);
            this.buttonLevel.TabIndex = 2;
            this.buttonLevel.Text = "Level";
            this.buttonLevel.UseVisualStyleBackColor = false;
            this.buttonLevel.Click += new System.EventHandler(this.buttonLevel_Click);
            // 
            // button1x1
            // 
            this.button1x1.BackColor = System.Drawing.Color.Tomato;
            this.button1x1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1x1.Location = new System.Drawing.Point(22, 339);
            this.button1x1.Name = "button1x1";
            this.button1x1.Size = new System.Drawing.Size(43, 23);
            this.button1x1.TabIndex = 3;
            this.button1x1.Text = "1 x 1";
            this.button1x1.UseVisualStyleBackColor = false;
            this.button1x1.Click += new System.EventHandler(this.button1x1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(108, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(150, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(67, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(108, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(150, 309);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gold;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(67, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gold;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(108, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gold;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(150, 278);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Gold;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(108, 372);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(33, 23);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDIV
            // 
            this.buttonDIV.BackColor = System.Drawing.Color.Tomato;
            this.buttonDIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDIV.Location = new System.Drawing.Point(194, 245);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(31, 28);
            this.buttonDIV.TabIndex = 14;
            this.buttonDIV.Text = "/";
            this.buttonDIV.UseVisualStyleBackColor = false;
            this.buttonDIV.Click += new System.EventHandler(this.buttonDIV_Click);
            // 
            // buttonMUL
            // 
            this.buttonMUL.BackColor = System.Drawing.Color.Tomato;
            this.buttonMUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMUL.Location = new System.Drawing.Point(194, 284);
            this.buttonMUL.Name = "buttonMUL";
            this.buttonMUL.Size = new System.Drawing.Size(31, 28);
            this.buttonMUL.TabIndex = 15;
            this.buttonMUL.Text = "X";
            this.buttonMUL.UseVisualStyleBackColor = false;
            this.buttonMUL.Click += new System.EventHandler(this.buttonMUL_Click);
            // 
            // buttonSUB
            // 
            this.buttonSUB.BackColor = System.Drawing.Color.Tomato;
            this.buttonSUB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSUB.Location = new System.Drawing.Point(194, 322);
            this.buttonSUB.Name = "buttonSUB";
            this.buttonSUB.Size = new System.Drawing.Size(31, 28);
            this.buttonSUB.TabIndex = 16;
            this.buttonSUB.Text = "-";
            this.buttonSUB.UseVisualStyleBackColor = false;
            this.buttonSUB.Click += new System.EventHandler(this.buttonSUB_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.Tomato;
            this.buttonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(194, 361);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(31, 28);
            this.buttonADD.TabIndex = 17;
            this.buttonADD.Text = "+";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // labelRating
            // 
            this.labelRating.BackColor = System.Drawing.Color.Transparent;
            this.labelRating.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.Yellow;
            this.labelRating.Location = new System.Drawing.Point(44, 38);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(163, 26);
            this.labelRating.TabIndex = 18;
            this.labelRating.Text = "*****";
            this.labelRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelResult.Location = new System.Drawing.Point(215, 454);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 17);
            this.labelResult.TabIndex = 19;
            this.labelResult.Text = "1234";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResult.Visible = false;
            // 
            // timerDisplay
            // 
            this.timerDisplay.Tick += new System.EventHandler(this.timerDisplay_Tick);
            // 
            // checkBoxHint
            // 
            this.checkBoxHint.AutoSize = true;
            this.checkBoxHint.Location = new System.Drawing.Point(0, 454);
            this.checkBoxHint.Name = "checkBoxHint";
            this.checkBoxHint.Size = new System.Drawing.Size(45, 17);
            this.checkBoxHint.TabIndex = 20;
            this.checkBoxHint.Text = "Hint";
            this.checkBoxHint.UseVisualStyleBackColor = true;
            this.checkBoxHint.CheckedChanged += new System.EventHandler(this.checkBoxHint_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBLittleProfessor.Properties.Resources.MBLittleProfessor1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(252, 468);
            this.Controls.Add(this.checkBoxHint);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonSUB);
            this.Controls.Add(this.buttonMUL);
            this.Controls.Add(this.buttonDIV);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1x1);
            this.Controls.Add(this.buttonLevel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "MB Little Professor v1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.groupBoxDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLevel;
        private System.Windows.Forms.Button button1x1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.Button buttonMUL;
        private System.Windows.Forms.Button buttonSUB;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Label labelExercise;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Timer timerDisplay;
        private System.Windows.Forms.CheckBox checkBoxHint;
        private System.Windows.Forms.Label labelIcon;
    }
}

