namespace ServerPMS
{
    partial class uc_todaymenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt1DayOccupation = new System.Windows.Forms.Label();
            this.txt1DayOccupatedRooms = new System.Windows.Forms.Label();
            this.txt1DayAvaliableRooms = new System.Windows.Forms.Label();
            this.txt1DayTotalPlaces = new System.Windows.Forms.Label();
            this.txt1DayTotalRooms = new System.Windows.Forms.Label();
            this.txt1DayBirthdays = new System.Windows.Forms.Label();
            this.txt1DayLiving = new System.Windows.Forms.Label();
            this.txt1DayOutcoming = new System.Windows.Forms.Label();
            this.txt1DayIncoming = new System.Windows.Forms.Label();
            this.txtRPToday = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt1DayOccupation);
            this.panel7.Controls.Add(this.txt1DayOccupatedRooms);
            this.panel7.Controls.Add(this.txt1DayAvaliableRooms);
            this.panel7.Controls.Add(this.txt1DayTotalPlaces);
            this.panel7.Controls.Add(this.txt1DayTotalRooms);
            this.panel7.Controls.Add(this.txt1DayBirthdays);
            this.panel7.Controls.Add(this.txt1DayLiving);
            this.panel7.Controls.Add(this.txt1DayOutcoming);
            this.panel7.Controls.Add(this.txt1DayIncoming);
            this.panel7.Controls.Add(this.txtRPToday);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 111);
            this.panel7.TabIndex = 16;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // txt1DayOccupation
            // 
            this.txt1DayOccupation.AutoSize = true;
            this.txt1DayOccupation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayOccupation.Location = new System.Drawing.Point(353, 78);
            this.txt1DayOccupation.Name = "txt1DayOccupation";
            this.txt1DayOccupation.Size = new System.Drawing.Size(80, 19);
            this.txt1DayOccupation.TabIndex = 10;
            this.txt1DayOccupation.Text = "$Загрузка:";
            // 
            // txt1DayOccupatedRooms
            // 
            this.txt1DayOccupatedRooms.AutoSize = true;
            this.txt1DayOccupatedRooms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayOccupatedRooms.Location = new System.Drawing.Point(353, 56);
            this.txt1DayOccupatedRooms.Name = "txt1DayOccupatedRooms";
            this.txt1DayOccupatedRooms.Size = new System.Drawing.Size(132, 19);
            this.txt1DayOccupatedRooms.TabIndex = 9;
            this.txt1DayOccupatedRooms.Text = "$Занято номеров:";
            // 
            // txt1DayAvaliableRooms
            // 
            this.txt1DayAvaliableRooms.AutoSize = true;
            this.txt1DayAvaliableRooms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayAvaliableRooms.Location = new System.Drawing.Point(353, 33);
            this.txt1DayAvaliableRooms.Name = "txt1DayAvaliableRooms";
            this.txt1DayAvaliableRooms.Size = new System.Drawing.Size(153, 19);
            this.txt1DayAvaliableRooms.TabIndex = 8;
            this.txt1DayAvaliableRooms.Text = "$Свободно номеров:";
            // 
            // txt1DayTotalPlaces
            // 
            this.txt1DayTotalPlaces.AutoSize = true;
            this.txt1DayTotalPlaces.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayTotalPlaces.Location = new System.Drawing.Point(176, 78);
            this.txt1DayTotalPlaces.Name = "txt1DayTotalPlaces";
            this.txt1DayTotalPlaces.Size = new System.Drawing.Size(95, 19);
            this.txt1DayTotalPlaces.TabIndex = 7;
            this.txt1DayTotalPlaces.Text = "$Всего мест:";
            // 
            // txt1DayTotalRooms
            // 
            this.txt1DayTotalRooms.AutoSize = true;
            this.txt1DayTotalRooms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayTotalRooms.Location = new System.Drawing.Point(176, 56);
            this.txt1DayTotalRooms.Name = "txt1DayTotalRooms";
            this.txt1DayTotalRooms.Size = new System.Drawing.Size(123, 19);
            this.txt1DayTotalRooms.TabIndex = 6;
            this.txt1DayTotalRooms.Text = "$Всего номеров:";
            // 
            // txt1DayBirthdays
            // 
            this.txt1DayBirthdays.AutoSize = true;
            this.txt1DayBirthdays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayBirthdays.Location = new System.Drawing.Point(176, 34);
            this.txt1DayBirthdays.Name = "txt1DayBirthdays";
            this.txt1DayBirthdays.Size = new System.Drawing.Size(123, 19);
            this.txt1DayBirthdays.TabIndex = 4;
            this.txt1DayBirthdays.Text = "$Дни рождения:";
            // 
            // txt1DayLiving
            // 
            this.txt1DayLiving.AutoSize = true;
            this.txt1DayLiving.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayLiving.Location = new System.Drawing.Point(13, 78);
            this.txt1DayLiving.Name = "txt1DayLiving";
            this.txt1DayLiving.Size = new System.Drawing.Size(109, 19);
            this.txt1DayLiving.TabIndex = 3;
            this.txt1DayLiving.Text = "$Проживания:";
            // 
            // txt1DayOutcoming
            // 
            this.txt1DayOutcoming.AutoSize = true;
            this.txt1DayOutcoming.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayOutcoming.Location = new System.Drawing.Point(13, 56);
            this.txt1DayOutcoming.Name = "txt1DayOutcoming";
            this.txt1DayOutcoming.Size = new System.Drawing.Size(76, 19);
            this.txt1DayOutcoming.TabIndex = 2;
            this.txt1DayOutcoming.Text = "$Выезды:";
            // 
            // txt1DayIncoming
            // 
            this.txt1DayIncoming.AutoSize = true;
            this.txt1DayIncoming.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1DayIncoming.Location = new System.Drawing.Point(13, 34);
            this.txt1DayIncoming.Name = "txt1DayIncoming";
            this.txt1DayIncoming.Size = new System.Drawing.Size(72, 19);
            this.txt1DayIncoming.TabIndex = 1;
            this.txt1DayIncoming.Text = "$Заезды:";
            // 
            // txtRPToday
            // 
            this.txtRPToday.AutoSize = true;
            this.txtRPToday.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRPToday.Location = new System.Drawing.Point(13, 9);
            this.txtRPToday.Name = "txtRPToday";
            this.txtRPToday.Size = new System.Drawing.Size(194, 19);
            this.txtRPToday.TabIndex = 0;
            this.txtRPToday.Text = "Сегодня, $ месяц, ##:##:##";
            // 
            // uc_todaymenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Name = "uc_todaymenu";
            this.Size = new System.Drawing.Size(536, 118);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label txt1DayOccupation;
        private System.Windows.Forms.Label txt1DayOccupatedRooms;
        private System.Windows.Forms.Label txt1DayAvaliableRooms;
        private System.Windows.Forms.Label txt1DayTotalPlaces;
        private System.Windows.Forms.Label txt1DayTotalRooms;
        private System.Windows.Forms.Label txt1DayBirthdays;
        private System.Windows.Forms.Label txt1DayLiving;
        private System.Windows.Forms.Label txt1DayOutcoming;
        private System.Windows.Forms.Label txt1DayIncoming;
        private System.Windows.Forms.Label txtRPToday;
    }
}
