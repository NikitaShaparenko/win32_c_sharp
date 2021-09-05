namespace ServerPMS
{
    partial class Database
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
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.databaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseAdultPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseChildrenPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseMoneyVector10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.databaseID,
            this.databaseNames,
            this.databaseAdultPlaces,
            this.databaseChildrenPlaces,
            this.databaseMoneyVector1,
            this.databaseMoneyVector2,
            this.databaseMoneyVector3,
            this.databaseMoneyVector4,
            this.databaseMoneyVector5,
            this.databaseMoneyVector6,
            this.databaseMoneyVector7,
            this.databaseMoneyVector8,
            this.databaseMoneyVector9,
            this.databaseMoneyVector10});
            this.dgvDatabase.Location = new System.Drawing.Point(0, 43);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.RowTemplate.Height = 23;
            this.dgvDatabase.Size = new System.Drawing.Size(800, 380);
            this.dgvDatabase.TabIndex = 0;
            // 
            // databaseID
            // 
            this.databaseID.HeaderText = "Идентификаторы номеров";
            this.databaseID.Name = "databaseID";
            // 
            // databaseNames
            // 
            this.databaseNames.HeaderText = "Названия различных номеров";
            this.databaseNames.Name = "databaseNames";
            // 
            // databaseAdultPlaces
            // 
            this.databaseAdultPlaces.HeaderText = "Взрослых мест";
            this.databaseAdultPlaces.Name = "databaseAdultPlaces";
            // 
            // databaseChildrenPlaces
            // 
            this.databaseChildrenPlaces.HeaderText = "Детских мест";
            this.databaseChildrenPlaces.Name = "databaseChildrenPlaces";
            // 
            // databaseMoneyVector1
            // 
            this.databaseMoneyVector1.HeaderText = "Вектор цен 1 (будни)";
            this.databaseMoneyVector1.Name = "databaseMoneyVector1";
            // 
            // databaseMoneyVector2
            // 
            this.databaseMoneyVector2.HeaderText = "Вектор цен 2 (выходные)";
            this.databaseMoneyVector2.Name = "databaseMoneyVector2";
            // 
            // databaseMoneyVector3
            // 
            this.databaseMoneyVector3.HeaderText = "Вектор цен 3";
            this.databaseMoneyVector3.Name = "databaseMoneyVector3";
            // 
            // databaseMoneyVector4
            // 
            this.databaseMoneyVector4.HeaderText = "Вектор цен 4";
            this.databaseMoneyVector4.Name = "databaseMoneyVector4";
            // 
            // databaseMoneyVector5
            // 
            this.databaseMoneyVector5.HeaderText = "Вектор цен 5";
            this.databaseMoneyVector5.Name = "databaseMoneyVector5";
            // 
            // databaseMoneyVector6
            // 
            this.databaseMoneyVector6.HeaderText = "Вектор цен 6";
            this.databaseMoneyVector6.Name = "databaseMoneyVector6";
            // 
            // databaseMoneyVector7
            // 
            this.databaseMoneyVector7.HeaderText = "Вектор цен 7";
            this.databaseMoneyVector7.Name = "databaseMoneyVector7";
            // 
            // databaseMoneyVector8
            // 
            this.databaseMoneyVector8.HeaderText = "Вектор цен 8";
            this.databaseMoneyVector8.Name = "databaseMoneyVector8";
            // 
            // databaseMoneyVector9
            // 
            this.databaseMoneyVector9.HeaderText = "Вектор цен 9";
            this.databaseMoneyVector9.Name = "databaseMoneyVector9";
            // 
            // databaseMoneyVector10
            // 
            this.databaseMoneyVector10.HeaderText = "Вектор цен 10";
            this.databaseMoneyVector10.Name = "databaseMoneyVector10";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDatabase);
            this.Name = "Database";
            this.Text = "База данных номеров";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseAdultPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseChildrenPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector1;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector2;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector3;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector4;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector5;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector6;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector7;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector8;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector9;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseMoneyVector10;
        private System.Windows.Forms.Button button1;
    }
}