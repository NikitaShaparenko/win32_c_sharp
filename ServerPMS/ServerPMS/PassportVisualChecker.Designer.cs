namespace ServerPMS
{
    partial class PassportVisualChecker
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
            this.components = new System.ComponentModel.Container();
            this.picFirst = new System.Windows.Forms.PictureBox();
            this.picSecond = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.txtpb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picFourth = new System.Windows.Forms.PictureBox();
            this.picThird = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picFifth = new System.Windows.Forms.PictureBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFifth)).BeginInit();
            this.SuspendLayout();
            // 
            // picFirst
            // 
            this.picFirst.Location = new System.Drawing.Point(59, 26);
            this.picFirst.Name = "picFirst";
            this.picFirst.Size = new System.Drawing.Size(75, 75);
            this.picFirst.TabIndex = 0;
            this.picFirst.TabStop = false;
            // 
            // picSecond
            // 
            this.picSecond.Location = new System.Drawing.Point(59, 118);
            this.picSecond.Name = "picSecond";
            this.picSecond.Size = new System.Drawing.Size(75, 75);
            this.picSecond.TabIndex = 1;
            this.picSecond.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Проверка серии паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Проверка номера паспорта";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(59, 315);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(641, 23);
            this.pbProgress.TabIndex = 4;
            // 
            // txtpb
            // 
            this.txtpb.AutoSize = true;
            this.txtpb.Location = new System.Drawing.Point(335, 315);
            this.txtpb.Name = "txtpb";
            this.txtpb.Size = new System.Drawing.Size(50, 21);
            this.txtpb.TabIndex = 5;
            this.txtpb.Text = "100%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Код подразделения";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Проверка возраста";
            // 
            // picFourth
            // 
            this.picFourth.Location = new System.Drawing.Point(447, 118);
            this.picFourth.Name = "picFourth";
            this.picFourth.Size = new System.Drawing.Size(75, 75);
            this.picFourth.TabIndex = 7;
            this.picFourth.TabStop = false;
            // 
            // picThird
            // 
            this.picThird.Location = new System.Drawing.Point(447, 26);
            this.picThird.Name = "picThird";
            this.picThird.Size = new System.Drawing.Size(75, 75);
            this.picThird.TabIndex = 6;
            this.picThird.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Проверка действительности паспорта";
            // 
            // picFifth
            // 
            this.picFifth.Location = new System.Drawing.Point(215, 215);
            this.picFifth.Name = "picFifth";
            this.picFifth.Size = new System.Drawing.Size(75, 75);
            this.picFifth.TabIndex = 10;
            this.picFifth.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(27, 359);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(133, 21);
            this.txtStatus.TabIndex = 12;
            this.txtStatus.Text = "Статус проверки:";
            // 
            // tProgress
            // 
            this.tProgress.Enabled = true;
            this.tProgress.Tick += new System.EventHandler(this.tProgress_Tick);
            // 
            // PassportVisualChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 409);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picFifth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picFourth);
            this.Controls.Add(this.picThird);
            this.Controls.Add(this.txtpb);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSecond);
            this.Controls.Add(this.picFirst);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PassportVisualChecker";
            this.Text = "PassportVisualChecker";
            this.Load += new System.EventHandler(this.PassportVisualChecker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFifth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFirst;
        private System.Windows.Forms.PictureBox picSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label txtpb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picFourth;
        private System.Windows.Forms.PictureBox picThird;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picFifth;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Timer tProgress;
    }
}