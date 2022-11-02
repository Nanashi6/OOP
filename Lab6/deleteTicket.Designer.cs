namespace Lab6
{
    partial class deleteTicket
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TicketColBox = new System.Windows.Forms.TextBox();
            this.deleteTicketButton = new System.Windows.Forms.Button();
            this.BalconyRadioButton = new System.Windows.Forms.RadioButton();
            this.LoggiaRadioButton = new System.Windows.Forms.RadioButton();
            this.parerreRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите дату:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во билетов:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicketColBox
            // 
            this.TicketColBox.Location = new System.Drawing.Point(129, 48);
            this.TicketColBox.Name = "TicketColBox";
            this.TicketColBox.Size = new System.Drawing.Size(132, 20);
            this.TicketColBox.TabIndex = 4;
            // 
            // deleteTicketButton
            // 
            this.deleteTicketButton.Location = new System.Drawing.Point(129, 146);
            this.deleteTicketButton.Name = "deleteTicketButton";
            this.deleteTicketButton.Size = new System.Drawing.Size(131, 23);
            this.deleteTicketButton.TabIndex = 5;
            this.deleteTicketButton.Text = "Отменить билет";
            this.deleteTicketButton.UseVisualStyleBackColor = true;
            this.deleteTicketButton.Click += new System.EventHandler(this.deleteTicketButton_Click);
            // 
            // BalconyRadioButton
            // 
            this.BalconyRadioButton.AutoSize = true;
            this.BalconyRadioButton.Location = new System.Drawing.Point(129, 123);
            this.BalconyRadioButton.Name = "BalconyRadioButton";
            this.BalconyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.BalconyRadioButton.TabIndex = 10;
            this.BalconyRadioButton.TabStop = true;
            this.BalconyRadioButton.Text = "Балкон";
            this.BalconyRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoggiaRadioButton
            // 
            this.LoggiaRadioButton.AutoSize = true;
            this.LoggiaRadioButton.Location = new System.Drawing.Point(129, 99);
            this.LoggiaRadioButton.Name = "LoggiaRadioButton";
            this.LoggiaRadioButton.Size = new System.Drawing.Size(65, 17);
            this.LoggiaRadioButton.TabIndex = 9;
            this.LoggiaRadioButton.TabStop = true;
            this.LoggiaRadioButton.Text = "Лоджия";
            this.LoggiaRadioButton.UseVisualStyleBackColor = true;
            // 
            // parerreRadioButton
            // 
            this.parerreRadioButton.AutoSize = true;
            this.parerreRadioButton.Location = new System.Drawing.Point(129, 75);
            this.parerreRadioButton.Name = "parerreRadioButton";
            this.parerreRadioButton.Size = new System.Drawing.Size(62, 17);
            this.parerreRadioButton.TabIndex = 8;
            this.parerreRadioButton.TabStop = true;
            this.parerreRadioButton.Text = "Партер";
            this.parerreRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 177);
            this.Controls.Add(this.BalconyRadioButton);
            this.Controls.Add(this.LoggiaRadioButton);
            this.Controls.Add(this.parerreRadioButton);
            this.Controls.Add(this.deleteTicketButton);
            this.Controls.Add(this.TicketColBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "deleteTicket";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.deleteTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TicketColBox;
        private System.Windows.Forms.Button deleteTicketButton;
        private System.Windows.Forms.RadioButton BalconyRadioButton;
        private System.Windows.Forms.RadioButton LoggiaRadioButton;
        private System.Windows.Forms.RadioButton parerreRadioButton;
    }
}