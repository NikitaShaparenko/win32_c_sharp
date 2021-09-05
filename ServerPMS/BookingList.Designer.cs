namespace ServerPMS
{
    partial class BookingList
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.dbblID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblIDRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblNumPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblCheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblDateIncoming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblCheckOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddblDateOutComing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblBookingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblAdultPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblPayingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblBookingSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblMealType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblCreatingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblPassportSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblPassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblPassportOutcomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblUnitCodeU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblUnitCodeU2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbblPassportWhomitwasgiven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbblID,
            this.dbblIDRoom,
            this.dbblName,
            this.dbblNumPlaces,
            this.dbblCheckInTime,
            this.dbblDateIncoming,
            this.dbblCheckOutTime,
            this.ddblDateOutComing,
            this.dbblBookingStatus,
            this.dbblAdultPlaces,
            this.dbblPayingCost,
            this.dbblPayed,
            this.dbblDept,
            this.dbblBookingSource,
            this.dbblMealType,
            this.dbblComment,
            this.dbblCreatingDate,
            this.dbblBirthday,
            this.dbblPassportSeries,
            this.dbblPassportNumber,
            this.dbblPassportOutcomeDate,
            this.dbblUnitCodeU1,
            this.dbblUnitCodeU2,
            this.dbblPassportWhomitwasgiven});
            this.dgvBooking.Location = new System.Drawing.Point(0, 33);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowTemplate.Height = 23;
            this.dgvBooking.Size = new System.Drawing.Size(747, 763);
            this.dgvBooking.TabIndex = 0;
            // 
            // dbblID
            // 
            this.dbblID.HeaderText = "Идентификатор брони";
            this.dbblID.Name = "dbblID";
            // 
            // dbblIDRoom
            // 
            this.dbblIDRoom.HeaderText = "ID комнаты";
            this.dbblIDRoom.Name = "dbblIDRoom";
            // 
            // dbblName
            // 
            this.dbblName.HeaderText = "Имя";
            this.dbblName.Name = "dbblName";
            // 
            // dbblNumPlaces
            // 
            this.dbblNumPlaces.HeaderText = "Количество занимаемых мест";
            this.dbblNumPlaces.Name = "dbblNumPlaces";
            // 
            // dbblCheckInTime
            // 
            this.dbblCheckInTime.HeaderText = "Время чекина";
            this.dbblCheckInTime.Name = "dbblCheckInTime";
            // 
            // dbblDateIncoming
            // 
            this.dbblDateIncoming.HeaderText = "Дата заезда";
            this.dbblDateIncoming.Name = "dbblDateIncoming";
            // 
            // dbblCheckOutTime
            // 
            this.dbblCheckOutTime.HeaderText = "Время чекаута";
            this.dbblCheckOutTime.Name = "dbblCheckOutTime";
            // 
            // ddblDateOutComing
            // 
            this.ddblDateOutComing.HeaderText = "Дата выезда";
            this.ddblDateOutComing.Name = "ddblDateOutComing";
            // 
            // dbblBookingStatus
            // 
            this.dbblBookingStatus.HeaderText = "Статус брони";
            this.dbblBookingStatus.Name = "dbblBookingStatus";
            // 
            // dbblAdultPlaces
            // 
            this.dbblAdultPlaces.HeaderText = "Мест (взрослых)";
            this.dbblAdultPlaces.Name = "dbblAdultPlaces";
            // 
            // dbblPayingCost
            // 
            this.dbblPayingCost.HeaderText = "Сумма оплаты";
            this.dbblPayingCost.Name = "dbblPayingCost";
            // 
            // dbblPayed
            // 
            this.dbblPayed.HeaderText = "Оплачено";
            this.dbblPayed.Name = "dbblPayed";
            // 
            // dbblDept
            // 
            this.dbblDept.HeaderText = "Долг";
            this.dbblDept.Name = "dbblDept";
            // 
            // dbblBookingSource
            // 
            this.dbblBookingSource.HeaderText = "Источник оплаты";
            this.dbblBookingSource.Name = "dbblBookingSource";
            // 
            // dbblMealType
            // 
            this.dbblMealType.HeaderText = "Тип питания";
            this.dbblMealType.Name = "dbblMealType";
            // 
            // dbblComment
            // 
            this.dbblComment.HeaderText = "Комментарий";
            this.dbblComment.Name = "dbblComment";
            // 
            // dbblCreatingDate
            // 
            this.dbblCreatingDate.HeaderText = "Дата создания";
            this.dbblCreatingDate.Name = "dbblCreatingDate";
            // 
            // dbblBirthday
            // 
            this.dbblBirthday.HeaderText = "Дата рождения";
            this.dbblBirthday.Name = "dbblBirthday";
            // 
            // dbblPassportSeries
            // 
            this.dbblPassportSeries.HeaderText = "Серия паспорта";
            this.dbblPassportSeries.Name = "dbblPassportSeries";
            // 
            // dbblPassportNumber
            // 
            this.dbblPassportNumber.HeaderText = "Номер паспорта";
            this.dbblPassportNumber.Name = "dbblPassportNumber";
            // 
            // dbblPassportOutcomeDate
            // 
            this.dbblPassportOutcomeDate.HeaderText = "Дата выдачи паспорта";
            this.dbblPassportOutcomeDate.Name = "dbblPassportOutcomeDate";
            // 
            // dbblUnitCodeU1
            // 
            this.dbblUnitCodeU1.HeaderText = "Код подразделения 1";
            this.dbblUnitCodeU1.Name = "dbblUnitCodeU1";
            // 
            // dbblUnitCodeU2
            // 
            this.dbblUnitCodeU2.HeaderText = "Код подразделения 2";
            this.dbblUnitCodeU2.Name = "dbblUnitCodeU2";
            // 
            // dbblPassportWhomitwasgiven
            // 
            this.dbblPassportWhomitwasgiven.HeaderText = "Кем выдан паспорт";
            this.dbblPassportWhomitwasgiven.Name = "dbblPassportWhomitwasgiven";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(342, -76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 749);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBooking);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BookingList";
            this.Text = "Список броней";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblIDRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblNumPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblCheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblDateIncoming;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblCheckOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddblDateOutComing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblBookingStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblAdultPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblPayingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblBookingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblMealType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblCreatingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblPassportSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblPassportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblPassportOutcomeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblUnitCodeU1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblUnitCodeU2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbblPassportWhomitwasgiven;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}