namespace Lab6
{
    partial class changeTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TicketColBox = new System.Windows.Forms.TextBox();
            this.changeTicketButton = new System.Windows.Forms.Button();
            this.BalconyRadioButton = new System.Windows.Forms.RadioButton();
            this.LoggiaRadioButton = new System.Windows.Forms.RadioButton();
            this.parerreRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newParerreRadioButton = new System.Windows.Forms.RadioButton();
            this.newLoggiaRadioButton = new System.Windows.Forms.RadioButton();
            this.newBalconyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущая дата:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новая дата:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во билетов:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // TicketColBox
            // 
            this.TicketColBox.Location = new System.Drawing.Point(109, 59);
            this.TicketColBox.Name = "TicketColBox";
            this.TicketColBox.Size = new System.Drawing.Size(138, 20);
            this.TicketColBox.TabIndex = 5;
            // 
            // changeTicketButton
            // 
            this.changeTicketButton.Location = new System.Drawing.Point(109, 188);
            this.changeTicketButton.Name = "changeTicketButton";
            this.changeTicketButton.Size = new System.Drawing.Size(138, 23);
            this.changeTicketButton.TabIndex = 6;
            this.changeTicketButton.Text = "Изменить";
            this.changeTicketButton.UseVisualStyleBackColor = true;
            this.changeTicketButton.Click += new System.EventHandler(this.changeTicketButton_Click);
            // 
            // BalconyRadioButton
            // 
            this.BalconyRadioButton.AutoSize = true;
            this.BalconyRadioButton.Location = new System.Drawing.Point(6, 67);
            this.BalconyRadioButton.Name = "BalconyRadioButton";
            this.BalconyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.BalconyRadioButton.TabIndex = 3;
            this.BalconyRadioButton.Text = "Балкон";
            this.BalconyRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoggiaRadioButton
            // 
            this.LoggiaRadioButton.AutoSize = true;
            this.LoggiaRadioButton.Location = new System.Drawing.Point(6, 43);
            this.LoggiaRadioButton.Name = "LoggiaRadioButton";
            this.LoggiaRadioButton.Size = new System.Drawing.Size(65, 17);
            this.LoggiaRadioButton.TabIndex = 2;
            this.LoggiaRadioButton.Text = "Лоджия";
            this.LoggiaRadioButton.UseVisualStyleBackColor = true;
            // 
            // parerreRadioButton
            // 
            this.parerreRadioButton.AutoSize = true;
            this.parerreRadioButton.Checked = true;
            this.parerreRadioButton.Location = new System.Drawing.Point(6, 19);
            this.parerreRadioButton.Name = "parerreRadioButton";
            this.parerreRadioButton.Size = new System.Drawing.Size(62, 17);
            this.parerreRadioButton.TabIndex = 1;
            this.parerreRadioButton.TabStop = true;
            this.parerreRadioButton.Text = "Партер";
            this.parerreRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Старое место";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Новое место";
            // 
            // newParerreRadioButton
            // 
            this.newParerreRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.newParerreRadioButton.AutoSize = true;
            this.newParerreRadioButton.Checked = true;
            this.newParerreRadioButton.Location = new System.Drawing.Point(6, 14);
            this.newParerreRadioButton.Name = "newParerreRadioButton";
            this.newParerreRadioButton.Size = new System.Drawing.Size(62, 17);
            this.newParerreRadioButton.TabIndex = 1;
            this.newParerreRadioButton.TabStop = true;
            this.newParerreRadioButton.Text = "Партер";
            this.newParerreRadioButton.UseVisualStyleBackColor = true;
            // 
            // newLoggiaRadioButton
            // 
            this.newLoggiaRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.newLoggiaRadioButton.AutoSize = true;
            this.newLoggiaRadioButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.newLoggiaRadioButton.Location = new System.Drawing.Point(6, 38);
            this.newLoggiaRadioButton.Name = "newLoggiaRadioButton";
            this.newLoggiaRadioButton.Size = new System.Drawing.Size(65, 17);
            this.newLoggiaRadioButton.TabIndex = 2;
            this.newLoggiaRadioButton.Text = "Лоджия";
            this.newLoggiaRadioButton.UseVisualStyleBackColor = true;
            // 
            // newBalconyRadioButton
            // 
            this.newBalconyRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.newBalconyRadioButton.AutoSize = true;
            this.newBalconyRadioButton.Location = new System.Drawing.Point(6, 62);
            this.newBalconyRadioButton.Name = "newBalconyRadioButton";
            this.newBalconyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.newBalconyRadioButton.TabIndex = 3;
            this.newBalconyRadioButton.Text = "Балкон";
            this.newBalconyRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parerreRadioButton);
            this.groupBox1.Controls.Add(this.LoggiaRadioButton);
            this.groupBox1.Controls.Add(this.BalconyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(109, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 97);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newParerreRadioButton);
            this.groupBox2.Controls.Add(this.newLoggiaRadioButton);
            this.groupBox2.Controls.Add(this.newBalconyRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(222, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 97);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // changeTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 233);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changeTicketButton);
            this.Controls.Add(this.TicketColBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changeTicket";
            this.Text = "changeTicket";
            this.Load += new System.EventHandler(this.changeTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox TicketColBox;
        private System.Windows.Forms.Button changeTicketButton;
        private System.Windows.Forms.RadioButton BalconyRadioButton;
        private System.Windows.Forms.RadioButton LoggiaRadioButton;
        private System.Windows.Forms.RadioButton parerreRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton newParerreRadioButton;
        private System.Windows.Forms.RadioButton newLoggiaRadioButton;
        private System.Windows.Forms.RadioButton newBalconyRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}