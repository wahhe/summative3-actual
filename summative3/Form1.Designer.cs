namespace summative3
{
    partial class summative
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.exploreButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Orator Std", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(81, 72);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(253, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "XXX MISSION";
            // 
            // exploreButton
            // 
            this.exploreButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exploreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.exploreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.exploreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exploreButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.exploreButton.Location = new System.Drawing.Point(112, 252);
            this.exploreButton.Name = "exploreButton";
            this.exploreButton.Size = new System.Drawing.Size(188, 65);
            this.exploreButton.TabIndex = 1;
            this.exploreButton.Text = "EXPLORE";
            this.exploreButton.UseVisualStyleBackColor = false;
            this.exploreButton.Click += new System.EventHandler(this.exploreButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(60, 44);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 23);
            this.outputLabel.TabIndex = 2;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.Location = new System.Drawing.Point(115, 194);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(0, 25);
            this.loadLabel.TabIndex = 3;
            // 
            // summative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(420, 373);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exploreButton);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "summative";
            this.Text = "Summative3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exploreButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label loadLabel;
    }
}

