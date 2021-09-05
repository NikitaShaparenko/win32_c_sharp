namespace ServerPMS
{
    partial class RTFFullScreenViewer
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
            this.rtfText = new System.Windows.Forms.RichTextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfText
            // 
            this.rtfText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfText.Location = new System.Drawing.Point(0, 0);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(1029, 749);
            this.rtfText.TabIndex = 0;
            this.rtfText.Text = "";
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(911, 2);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 36);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // RTFFullScreenViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 749);
            this.ControlBox = false;
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.rtfText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RTFFullScreenViewer";
            this.Text = "Полноэкранный просмотр";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtfText;
        private System.Windows.Forms.Button bClose;
    }
}