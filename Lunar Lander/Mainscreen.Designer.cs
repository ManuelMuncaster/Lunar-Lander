namespace Lunar_Lander
{
    partial class Mainscreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(203, 249);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(81, 13);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Launch Mission";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(212, 283);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(60, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Highscores";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(228, 314);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(24, 13);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Exit";
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.label1);
            this.Name = "Mainscreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Mainscreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}
