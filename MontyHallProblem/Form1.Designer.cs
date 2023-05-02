namespace MontyHallProblem
{
    partial class MontyWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllYesToggle = new System.Windows.Forms.RadioButton();
            this.AllNoToggle = new System.Windows.Forms.RadioButton();
            this.RandomToggle = new System.Windows.Forms.RadioButton();
            this.SwitchLabel = new System.Windows.Forms.Label();
            this.IterationInput = new System.Windows.Forms.TextBox();
            this.RunCountQ = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.PlayerPercent = new System.Windows.Forms.Label();
            this.DetailedGames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AllYesToggle
            // 
            this.AllYesToggle.AutoSize = true;
            this.AllYesToggle.Location = new System.Drawing.Point(38, 102);
            this.AllYesToggle.Name = "AllYesToggle";
            this.AllYesToggle.Size = new System.Drawing.Size(59, 19);
            this.AllYesToggle.TabIndex = 0;
            this.AllYesToggle.TabStop = true;
            this.AllYesToggle.Text = "All Yes";
            this.AllYesToggle.UseVisualStyleBackColor = true;
            this.AllYesToggle.CheckedChanged += new System.EventHandler(this.SwitchOption_Changed);
            // 
            // AllNoToggle
            // 
            this.AllNoToggle.AutoSize = true;
            this.AllNoToggle.Location = new System.Drawing.Point(117, 102);
            this.AllNoToggle.Name = "AllNoToggle";
            this.AllNoToggle.Size = new System.Drawing.Size(58, 19);
            this.AllNoToggle.TabIndex = 1;
            this.AllNoToggle.TabStop = true;
            this.AllNoToggle.Text = "All No";
            this.AllNoToggle.UseVisualStyleBackColor = true;
            this.AllNoToggle.CheckedChanged += new System.EventHandler(this.SwitchOption_Changed);
            // 
            // RandomToggle
            // 
            this.RandomToggle.AutoSize = true;
            this.RandomToggle.Location = new System.Drawing.Point(197, 102);
            this.RandomToggle.Name = "RandomToggle";
            this.RandomToggle.Size = new System.Drawing.Size(70, 19);
            this.RandomToggle.TabIndex = 2;
            this.RandomToggle.TabStop = true;
            this.RandomToggle.Text = "Random";
            this.RandomToggle.UseVisualStyleBackColor = true;
            this.RandomToggle.CheckedChanged += new System.EventHandler(this.SwitchOption_Changed);
            // 
            // SwitchLabel
            // 
            this.SwitchLabel.AutoSize = true;
            this.SwitchLabel.Location = new System.Drawing.Point(33, 80);
            this.SwitchLabel.Name = "SwitchLabel";
            this.SwitchLabel.Size = new System.Drawing.Size(238, 15);
            this.SwitchLabel.TabIndex = 3;
            this.SwitchLabel.Text = "Should the contestant switch when offered?";
            // 
            // IterationInput
            // 
            this.IterationInput.Location = new System.Drawing.Point(96, 42);
            this.IterationInput.Name = "IterationInput";
            this.IterationInput.Size = new System.Drawing.Size(100, 23);
            this.IterationInput.TabIndex = 4;
            // 
            // RunCountQ
            // 
            this.RunCountQ.AutoSize = true;
            this.RunCountQ.Location = new System.Drawing.Point(30, 24);
            this.RunCountQ.Name = "RunCountQ";
            this.RunCountQ.Size = new System.Drawing.Size(241, 15);
            this.RunCountQ.TabIndex = 5;
            this.RunCountQ.Text = "How many times should the simulation run?";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(109, 129);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // PlayerPercent
            // 
            this.PlayerPercent.AutoSize = true;
            this.PlayerPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerPercent.Location = new System.Drawing.Point(34, 210);
            this.PlayerPercent.Name = "PlayerPercent";
            this.PlayerPercent.Size = new System.Drawing.Size(262, 23);
            this.PlayerPercent.TabIndex = 8;
            this.PlayerPercent.Text = "The player won 50% of all games";
            this.PlayerPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailedGames
            // 
            this.DetailedGames.AutoSize = true;
            this.DetailedGames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DetailedGames.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailedGames.Location = new System.Drawing.Point(27, 179);
            this.DetailedGames.Name = "DetailedGames";
            this.DetailedGames.Size = new System.Drawing.Size(278, 22);
            this.DetailedGames.TabIndex = 9;
            this.DetailedGames.Text = "Out of {n_1} games, the player won {n_2}";
            this.DetailedGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MontyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 252);
            this.Controls.Add(this.DetailedGames);
            this.Controls.Add(this.PlayerPercent);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.RunCountQ);
            this.Controls.Add(this.IterationInput);
            this.Controls.Add(this.SwitchLabel);
            this.Controls.Add(this.RandomToggle);
            this.Controls.Add(this.AllNoToggle);
            this.Controls.Add(this.AllYesToggle);
            this.Name = "MontyWindow";
            this.Text = "Monty Hall Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton AllYesToggle;
        private RadioButton AllNoToggle;
        private RadioButton RandomToggle;
        private Label SwitchLabel;
        private TextBox IterationInput;
        private Label RunCountQ;
        private Button RunButton;
        private Label PlayerPercent;
        private Label DetailedGames;
    }
}