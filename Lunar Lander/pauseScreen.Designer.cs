namespace Lunar_Lander
{
    partial class pauseScreen
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
            this.titleLabel6 = new System.Windows.Forms.Label();
            this.yesLabel = new System.Windows.Forms.Label();
            this.noLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel6
            // 
            this.titleLabel6.AutoSize = true;
            this.titleLabel6.Font = new System.Drawing.Font("8BIT WONDER", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel6.ForeColor = System.Drawing.Color.White;
            this.titleLabel6.Location = new System.Drawing.Point(34, 46);
            this.titleLabel6.Name = "titleLabel6";
            this.titleLabel6.Size = new System.Drawing.Size(258, 13);
            this.titleLabel6.TabIndex = 0;
            this.titleLabel6.Text = "Exit to the Main Menu";
            // 
            // yesLabel
            // 
            this.yesLabel.AutoSize = true;
            this.yesLabel.Font = new System.Drawing.Font("8BIT WONDER", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesLabel.ForeColor = System.Drawing.Color.White;
            this.yesLabel.Location = new System.Drawing.Point(42, 116);
            this.yesLabel.Name = "yesLabel";
            this.yesLabel.Size = new System.Drawing.Size(41, 12);
            this.yesLabel.TabIndex = 1;
            this.yesLabel.Text = "Yes";
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.Font = new System.Drawing.Font("8BIT WONDER", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLabel.ForeColor = System.Drawing.Color.White;
            this.noLabel.Location = new System.Drawing.Point(170, 116);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(29, 12);
            this.noLabel.TabIndex = 2;
            this.noLabel.Text = "No";
            // 
            // pauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.yesLabel);
            this.Controls.Add(this.titleLabel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pauseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pauseScreen";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pauseScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel6;
        private System.Windows.Forms.Label yesLabel;
        private System.Windows.Forms.Label noLabel;
    }
}