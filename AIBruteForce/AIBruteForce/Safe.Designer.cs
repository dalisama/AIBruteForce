namespace AIBruteForce
{
    partial class Safe
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
            this.CombinationTxtBox = new System.Windows.Forms.TextBox();
            this.PopulationTxtBox = new System.Windows.Forms.TextBox();
            this.MutationRateTxtBox = new System.Windows.Forms.TextBox();
            this.BruteForceBtn = new System.Windows.Forms.Button();
            this.populationlbl = new System.Windows.Forms.Label();
            this.mutationRateLbl = new System.Windows.Forms.Label();
            this.BestDNaLbl = new System.Windows.Forms.Label();
            this.BestFitnesslbl = new System.Windows.Forms.Label();
            this.PopulationDnaMltylineTxtBox = new System.Windows.Forms.TextBox();
            this.Generationlbl = new System.Windows.Forms.Label();
            this.CrossOverComBoBox = new System.Windows.Forms.ComboBox();
            this.crossoverlbl = new System.Windows.Forms.Label();
            this.fitnessMethodLbl = new System.Windows.Forms.Label();
            this.FitnessComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CombinationTxtBox
            // 
            this.CombinationTxtBox.Location = new System.Drawing.Point(34, 59);
            this.CombinationTxtBox.Name = "CombinationTxtBox";
            this.CombinationTxtBox.Size = new System.Drawing.Size(329, 26);
            this.CombinationTxtBox.TabIndex = 0;
            // 
            // PopulationTxtBox
            // 
            this.PopulationTxtBox.Location = new System.Drawing.Point(258, 199);
            this.PopulationTxtBox.Name = "PopulationTxtBox";
            this.PopulationTxtBox.Size = new System.Drawing.Size(67, 26);
            this.PopulationTxtBox.TabIndex = 1;
            // 
            // MutationRateTxtBox
            // 
            this.MutationRateTxtBox.Location = new System.Drawing.Point(258, 249);
            this.MutationRateTxtBox.Name = "MutationRateTxtBox";
            this.MutationRateTxtBox.Size = new System.Drawing.Size(67, 26);
            this.MutationRateTxtBox.TabIndex = 2;
            // 
            // BruteForceBtn
            // 
            this.BruteForceBtn.Location = new System.Drawing.Point(182, 401);
            this.BruteForceBtn.Name = "BruteForceBtn";
            this.BruteForceBtn.Size = new System.Drawing.Size(143, 37);
            this.BruteForceBtn.TabIndex = 3;
            this.BruteForceBtn.Text = "brute force";
            this.BruteForceBtn.UseVisualStyleBackColor = true;
            this.BruteForceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // populationlbl
            // 
            this.populationlbl.AutoSize = true;
            this.populationlbl.Location = new System.Drawing.Point(39, 205);
            this.populationlbl.Name = "populationlbl";
            this.populationlbl.Size = new System.Drawing.Size(84, 20);
            this.populationlbl.TabIndex = 4;
            this.populationlbl.Text = "Population";
            // 
            // mutationRateLbl
            // 
            this.mutationRateLbl.AutoSize = true;
            this.mutationRateLbl.Location = new System.Drawing.Point(39, 252);
            this.mutationRateLbl.Name = "mutationRateLbl";
            this.mutationRateLbl.Size = new System.Drawing.Size(103, 20);
            this.mutationRateLbl.TabIndex = 5;
            this.mutationRateLbl.Text = "Mutation rate";
            // 
            // BestDNaLbl
            // 
            this.BestDNaLbl.AutoSize = true;
            this.BestDNaLbl.Location = new System.Drawing.Point(39, 94);
            this.BestDNaLbl.Name = "BestDNaLbl";
            this.BestDNaLbl.Size = new System.Drawing.Size(163, 20);
            this.BestDNaLbl.TabIndex = 6;
            this.BestDNaLbl.Text = "Best in the population";
            // 
            // BestFitnesslbl
            // 
            this.BestFitnesslbl.AutoSize = true;
            this.BestFitnesslbl.Location = new System.Drawing.Point(39, 125);
            this.BestFitnesslbl.Name = "BestFitnesslbl";
            this.BestFitnesslbl.Size = new System.Drawing.Size(91, 20);
            this.BestFitnesslbl.TabIndex = 7;
            this.BestFitnesslbl.Text = "best fitness";
            // 
            // PopulationDnaMltylineTxtBox
            // 
            this.PopulationDnaMltylineTxtBox.Location = new System.Drawing.Point(391, 59);
            this.PopulationDnaMltylineTxtBox.Multiline = true;
            this.PopulationDnaMltylineTxtBox.Name = "PopulationDnaMltylineTxtBox";
            this.PopulationDnaMltylineTxtBox.Size = new System.Drawing.Size(397, 379);
            this.PopulationDnaMltylineTxtBox.TabIndex = 8;
            // 
            // Generationlbl
            // 
            this.Generationlbl.AutoSize = true;
            this.Generationlbl.Location = new System.Drawing.Point(236, 125);
            this.Generationlbl.Name = "Generationlbl";
            this.Generationlbl.Size = new System.Drawing.Size(89, 20);
            this.Generationlbl.TabIndex = 9;
            this.Generationlbl.Text = "Generation";
            // 
            // CrossOverComBoBox
            // 
            this.CrossOverComBoBox.FormattingEnabled = true;
            this.CrossOverComBoBox.Items.AddRange(new object[] {
            "the fittest",
            "fifty-fifty",
            "default"});
            this.CrossOverComBoBox.Location = new System.Drawing.Point(204, 292);
            this.CrossOverComBoBox.Name = "CrossOverComBoBox";
            this.CrossOverComBoBox.Size = new System.Drawing.Size(121, 28);
            this.CrossOverComBoBox.TabIndex = 10;
            // 
            // crossoverlbl
            // 
            this.crossoverlbl.AutoSize = true;
            this.crossoverlbl.Location = new System.Drawing.Point(35, 300);
            this.crossoverlbl.Name = "crossoverlbl";
            this.crossoverlbl.Size = new System.Drawing.Size(141, 20);
            this.crossoverlbl.TabIndex = 11;
            this.crossoverlbl.Text = "CrossOver method";
            // 
            // fitnessMethodLbl
            // 
            this.fitnessMethodLbl.AutoSize = true;
            this.fitnessMethodLbl.Location = new System.Drawing.Point(39, 347);
            this.fitnessMethodLbl.Name = "fitnessMethodLbl";
            this.fitnessMethodLbl.Size = new System.Drawing.Size(119, 20);
            this.fitnessMethodLbl.TabIndex = 13;
            this.fitnessMethodLbl.Text = "Fitness method";
            // 
            // FitnessComboBox
            // 
            this.FitnessComboBox.FormattingEnabled = true;
            this.FitnessComboBox.Items.AddRange(new object[] {
            "simple",
            "Times 100",
            "Times 1000",
            "Times 10000",
            "Exp"});
            this.FitnessComboBox.Location = new System.Drawing.Point(204, 339);
            this.FitnessComboBox.Name = "FitnessComboBox";
            this.FitnessComboBox.Size = new System.Drawing.Size(121, 28);
            this.FitnessComboBox.TabIndex = 12;
            // 
            // Safe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fitnessMethodLbl);
            this.Controls.Add(this.FitnessComboBox);
            this.Controls.Add(this.crossoverlbl);
            this.Controls.Add(this.CrossOverComBoBox);
            this.Controls.Add(this.Generationlbl);
            this.Controls.Add(this.PopulationDnaMltylineTxtBox);
            this.Controls.Add(this.BestFitnesslbl);
            this.Controls.Add(this.BestDNaLbl);
            this.Controls.Add(this.mutationRateLbl);
            this.Controls.Add(this.populationlbl);
            this.Controls.Add(this.BruteForceBtn);
            this.Controls.Add(this.MutationRateTxtBox);
            this.Controls.Add(this.PopulationTxtBox);
            this.Controls.Add(this.CombinationTxtBox);
            this.Name = "Safe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CombinationTxtBox;
        private System.Windows.Forms.TextBox PopulationTxtBox;
        private System.Windows.Forms.TextBox MutationRateTxtBox;
        private System.Windows.Forms.Button BruteForceBtn;
        private System.Windows.Forms.Label populationlbl;
        private System.Windows.Forms.Label mutationRateLbl;
        private System.Windows.Forms.Label BestDNaLbl;
        private System.Windows.Forms.Label BestFitnesslbl;
        private System.Windows.Forms.TextBox PopulationDnaMltylineTxtBox;
        private System.Windows.Forms.Label Generationlbl;
        private System.Windows.Forms.ComboBox CrossOverComBoBox;
        private System.Windows.Forms.Label crossoverlbl;
        private System.Windows.Forms.Label fitnessMethodLbl;
        private System.Windows.Forms.ComboBox FitnessComboBox;
    }
}

