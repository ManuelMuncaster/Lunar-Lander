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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.mainscreenPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainscreenPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("8BIT WONDER", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(294, 97);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(799, 67);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Lunar Lander";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(518, 419);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(361, 27);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Launch Mission";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.Color.White;
            this.highScoreLabel.Location = new System.Drawing.Point(571, 462);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(268, 27);
            this.highScoreLabel.TabIndex = 2;
            this.highScoreLabel.Text = "Highscores";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(643, 510);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(106, 27);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Exit";
            // 
            // mainscreenPicture
            // 
            this.mainscreenPicture.Image = global::Lunar_Lander.Properties.Resources.landerFinal2;
            this.mainscreenPicture.Location = new System.Drawing.Point(633, 206);
            this.mainscreenPicture.Name = "mainscreenPicture";
            this.mainscreenPicture.Size = new System.Drawing.Size(116, 110);
            this.mainscreenPicture.TabIndex = 4;
            this.mainscreenPicture.TabStop = false;
            // 
            // titleLabel3
            // 
            this.titleLabel3.AutoSize = true;
            this.titleLabel3.Font = new System.Drawing.Font("8BIT WONDER", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel3.ForeColor = System.Drawing.Color.Lime;
            this.titleLabel3.Location = new System.Drawing.Point(431, 604);
            this.titleLabel3.Name = "titleLabel3";
            this.titleLabel3.Size = new System.Drawing.Size(539, 20);
            this.titleLabel3.TabIndex = 5;
            this.titleLabel3.Text = "Press Green to Select Options";
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.titleLabel3);
            this.Controls.Add(this.mainscreenPicture);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Mainscreen";
            this.Size = new System.Drawing.Size(1366, 768);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Mainscreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainscreenPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox mainscreenPicture;
        private System.Windows.Forms.Label titleLabel3;
    }
}
