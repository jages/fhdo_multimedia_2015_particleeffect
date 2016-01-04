namespace ParticleTest
{
    partial class Form1
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
            this.FontainButton = new System.Windows.Forms.Button();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FontainButton
            // 
            this.FontainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FontainButton.Location = new System.Drawing.Point(17, 403);
            this.FontainButton.Margin = new System.Windows.Forms.Padding(4);
            this.FontainButton.Name = "FontainButton";
            this.FontainButton.Size = new System.Drawing.Size(100, 30);
            this.FontainButton.TabIndex = 1;
            this.FontainButton.Text = "Fountain";
            this.FontainButton.UseVisualStyleBackColor = true;
            this.FontainButton.Click += new System.EventHandler(this.FontainButton_Click);
            // 
            // DrawBox
            // 
            this.DrawBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrawBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawBox.Location = new System.Drawing.Point(12, 12);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(701, 386);
            this.DrawBox.TabIndex = 3;
            this.DrawBox.TabStop = false;
            this.DrawBox.Click += new System.EventHandler(this.DrawBox_Click);
            this.DrawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBox_Paint);
            this.DrawBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 448);
            this.Controls.Add(this.DrawBox);
            this.Controls.Add(this.FontainButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ParticleTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FontainButton;
        private System.Windows.Forms.PictureBox DrawBox;
    }
}

