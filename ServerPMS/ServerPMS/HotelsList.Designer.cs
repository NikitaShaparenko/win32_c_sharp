namespace ServerPMS
{
    partial class HotelsList
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
            this.dgvHL = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.bAdultsMinusOne = new System.Windows.Forms.Button();
            this.bAdultsPlusOne = new System.Windows.Forms.Button();
            this.bChildrenPlusOne = new System.Windows.Forms.Button();
            this.bChildrenMinusOne = new System.Windows.Forms.Button();
            this.txtAdultPlaces = new System.Windows.Forms.TextBox();
            this.txtChildrenPlaces = new System.Windows.Forms.TextBox();
            this.rbExisting = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.gbTiming = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tMode = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCost1Daily = new System.Windows.Forms.NumericUpDown();
            this.numCost2Weekends = new System.Windows.Forms.NumericUpDown();
            this.hlid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hlnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hlAdults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hlChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hlmoneyvector1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hlmoneyvector2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHL)).BeginInit();
            this.gbTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost1Daily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost2Weekends)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHL
            // 
            this.dgvHL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hlid,
            this.hlnames,
            this.hlAdults,
            this.hlChildren,
            this.hlmoneyvector1,
            this.hlmoneyvector2});
            this.dgvHL.Location = new System.Drawing.Point(13, 45);
            this.dgvHL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHL.MultiSelect = false;
            this.dgvHL.Name = "dgvHL";
            this.dgvHL.ReadOnly = true;
            this.dgvHL.RowTemplate.Height = 23;
            this.dgvHL.Size = new System.Drawing.Size(449, 262);
            this.dgvHL.TabIndex = 0;
            this.dgvHL.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Перечень номеров в отеле:";
            // 
            // txtAction
            // 
            this.txtAction.AutoSize = true;
            this.txtAction.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAction.Location = new System.Drawing.Point(31, 315);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(206, 25);
            this.txtAction.TabIndex = 3;
            this.txtAction.Text = "Добавление номеров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название номера:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Взрослых мест:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Детских мест:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(177, 426);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(266, 29);
            this.txtRoomName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID номера:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(124, 371);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(130, 29);
            this.txtid.TabIndex = 10;
            // 
            // bAdultsMinusOne
            // 
            this.bAdultsMinusOne.Location = new System.Drawing.Point(178, 466);
            this.bAdultsMinusOne.Name = "bAdultsMinusOne";
            this.bAdultsMinusOne.Size = new System.Drawing.Size(66, 29);
            this.bAdultsMinusOne.TabIndex = 14;
            this.bAdultsMinusOne.Text = "- 1";
            this.bAdultsMinusOne.UseVisualStyleBackColor = true;
            this.bAdultsMinusOne.Click += new System.EventHandler(this.bAdultsMinusOne_Click);
            // 
            // bAdultsPlusOne
            // 
            this.bAdultsPlusOne.Location = new System.Drawing.Point(377, 466);
            this.bAdultsPlusOne.Name = "bAdultsPlusOne";
            this.bAdultsPlusOne.Size = new System.Drawing.Size(66, 29);
            this.bAdultsPlusOne.TabIndex = 15;
            this.bAdultsPlusOne.Text = "+ 1";
            this.bAdultsPlusOne.UseVisualStyleBackColor = true;
            this.bAdultsPlusOne.Click += new System.EventHandler(this.bAdultsPlusOne_Click);
            // 
            // bChildrenPlusOne
            // 
            this.bChildrenPlusOne.Location = new System.Drawing.Point(377, 511);
            this.bChildrenPlusOne.Name = "bChildrenPlusOne";
            this.bChildrenPlusOne.Size = new System.Drawing.Size(66, 29);
            this.bChildrenPlusOne.TabIndex = 17;
            this.bChildrenPlusOne.Text = "+ 1";
            this.bChildrenPlusOne.UseVisualStyleBackColor = true;
            this.bChildrenPlusOne.Click += new System.EventHandler(this.bChildrenPlusOne_Click);
            // 
            // bChildrenMinusOne
            // 
            this.bChildrenMinusOne.Location = new System.Drawing.Point(178, 508);
            this.bChildrenMinusOne.Name = "bChildrenMinusOne";
            this.bChildrenMinusOne.Size = new System.Drawing.Size(66, 29);
            this.bChildrenMinusOne.TabIndex = 16;
            this.bChildrenMinusOne.Text = "- 1";
            this.bChildrenMinusOne.UseVisualStyleBackColor = true;
            this.bChildrenMinusOne.Click += new System.EventHandler(this.bChildrenMinusOne_Click);
            // 
            // txtAdultPlaces
            // 
            this.txtAdultPlaces.BackColor = System.Drawing.Color.White;
            this.txtAdultPlaces.Location = new System.Drawing.Point(258, 467);
            this.txtAdultPlaces.Name = "txtAdultPlaces";
            this.txtAdultPlaces.ReadOnly = true;
            this.txtAdultPlaces.Size = new System.Drawing.Size(100, 29);
            this.txtAdultPlaces.TabIndex = 18;
            this.txtAdultPlaces.Text = "0";
            this.txtAdultPlaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChildrenPlaces
            // 
            this.txtChildrenPlaces.BackColor = System.Drawing.Color.White;
            this.txtChildrenPlaces.Location = new System.Drawing.Point(258, 511);
            this.txtChildrenPlaces.Name = "txtChildrenPlaces";
            this.txtChildrenPlaces.ReadOnly = true;
            this.txtChildrenPlaces.Size = new System.Drawing.Size(100, 29);
            this.txtChildrenPlaces.TabIndex = 19;
            this.txtChildrenPlaces.Text = "0";
            this.txtChildrenPlaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbExisting
            // 
            this.rbExisting.AutoSize = true;
            this.rbExisting.Location = new System.Drawing.Point(17, 59);
            this.rbExisting.Name = "rbExisting";
            this.rbExisting.Size = new System.Drawing.Size(146, 25);
            this.rbExisting.TabIndex = 22;
            this.rbExisting.Text = "Редактирование";
            this.rbExisting.UseVisualStyleBackColor = true;
            this.rbExisting.CheckedChanged += new System.EventHandler(this.rbExisting_CheckedChanged);
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Checked = true;
            this.rbNew.Location = new System.Drawing.Point(17, 28);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(76, 25);
            this.rbNew.TabIndex = 21;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "Новый";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // gbTiming
            // 
            this.gbTiming.Controls.Add(this.rbNew);
            this.gbTiming.Controls.Add(this.rbExisting);
            this.gbTiming.Location = new System.Drawing.Point(273, 315);
            this.gbTiming.Name = "gbTiming";
            this.gbTiming.Size = new System.Drawing.Size(170, 100);
            this.gbTiming.TabIndex = 23;
            this.gbTiming.TabStop = false;
            this.gbTiming.Text = "Текущий режим";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(230, 653);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 36);
            this.button5.TabIndex = 24;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(349, 653);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 36);
            this.button6.TabIndex = 25;
            this.button6.Text = "Закрыть";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tMode
            // 
            this.tMode.Enabled = true;
            this.tMode.Tick += new System.EventHandler(this.tPlaces_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Стоимость номера (будни):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Стоимость номера (выходные):";
            // 
            // numCost1Daily
            // 
            this.numCost1Daily.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCost1Daily.Location = new System.Drawing.Point(290, 563);
            this.numCost1Daily.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCost1Daily.Name = "numCost1Daily";
            this.numCost1Daily.Size = new System.Drawing.Size(120, 29);
            this.numCost1Daily.TabIndex = 28;
            this.numCost1Daily.Tag = "";
            this.numCost1Daily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCost1Daily.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numCost2Weekends
            // 
            this.numCost2Weekends.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCost2Weekends.Location = new System.Drawing.Point(290, 608);
            this.numCost2Weekends.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCost2Weekends.Name = "numCost2Weekends";
            this.numCost2Weekends.Size = new System.Drawing.Size(120, 29);
            this.numCost2Weekends.TabIndex = 29;
            this.numCost2Weekends.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCost2Weekends.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // hlid
            // 
            this.hlid.HeaderText = "Идентификаторы номеров";
            this.hlid.Name = "hlid";
            this.hlid.ReadOnly = true;
            // 
            // hlnames
            // 
            this.hlnames.HeaderText = "Названия различных номеров";
            this.hlnames.Name = "hlnames";
            this.hlnames.ReadOnly = true;
            // 
            // hlAdults
            // 
            this.hlAdults.HeaderText = "Взрослых мест";
            this.hlAdults.Name = "hlAdults";
            this.hlAdults.ReadOnly = true;
            // 
            // hlChildren
            // 
            this.hlChildren.HeaderText = "Детских мест";
            this.hlChildren.Name = "hlChildren";
            this.hlChildren.ReadOnly = true;
            // 
            // hlmoneyvector1
            // 
            this.hlmoneyvector1.HeaderText = "Цена будни";
            this.hlmoneyvector1.Name = "hlmoneyvector1";
            this.hlmoneyvector1.ReadOnly = true;
            // 
            // hlmoneyvector2
            // 
            this.hlmoneyvector2.HeaderText = "Цена выходные";
            this.hlmoneyvector2.Name = "hlmoneyvector2";
            this.hlmoneyvector2.ReadOnly = true;
            // 
            // HotelsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 697);
            this.ControlBox = false;
            this.Controls.Add(this.numCost2Weekends);
            this.Controls.Add(this.numCost1Daily);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gbTiming);
            this.Controls.Add(this.txtChildrenPlaces);
            this.Controls.Add(this.txtAdultPlaces);
            this.Controls.Add(this.bChildrenPlusOne);
            this.Controls.Add(this.bChildrenMinusOne);
            this.Controls.Add(this.bAdultsPlusOne);
            this.Controls.Add(this.bAdultsMinusOne);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHL);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HotelsList";
            this.Text = "Список отелей и номеров";
            this.Load += new System.EventHandler(this.HotelsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHL)).EndInit();
            this.gbTiming.ResumeLayout(false);
            this.gbTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost1Daily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost2Weekends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button bAdultsMinusOne;
        private System.Windows.Forms.Button bAdultsPlusOne;
        private System.Windows.Forms.Button bChildrenPlusOne;
        private System.Windows.Forms.Button bChildrenMinusOne;
        private System.Windows.Forms.TextBox txtAdultPlaces;
        private System.Windows.Forms.TextBox txtChildrenPlaces;
        private System.Windows.Forms.RadioButton rbExisting;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.GroupBox gbTiming;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer tMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCost1Daily;
        private System.Windows.Forms.NumericUpDown numCost2Weekends;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlnames;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlAdults;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlmoneyvector1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlmoneyvector2;
    }
}