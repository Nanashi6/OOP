namespace Lab6
{
    partial class payTicket
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
            this.TicketColBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payTicketButton = new System.Windows.Forms.Button();
            this.parerreRadioButton = new System.Windows.Forms.RadioButton();
            this.LoggiaRadioButton = new System.Windows.Forms.RadioButton();
            this.BalconyRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.MinimumSize = new System.Drawing.Size(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите дату:";
            // 
            // TicketColBox
            // 
            this.TicketColBox.Location = new System.Drawing.Point(153, 44);
            this.TicketColBox.Name = "TicketColBox";
            this.TicketColBox.Size = new System.Drawing.Size(120, 20);
            this.TicketColBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите кол-во билетов:";
            // 
            // payTicketButton
            // 
            this.payTicketButton.Location = new System.Drawing.Point(153, 150);
            this.payTicketButton.Name = "payTicketButton";
            this.payTicketButton.Size = new System.Drawing.Size(120, 23);
            this.payTicketButton.TabIndex = 4;
            this.payTicketButton.Text = "Купить";
            this.payTicketButton.UseVisualStyleBackColor = true;
            this.payTicketButton.Click += new System.EventHandler(this.payTicketButton_Click);
            // 
            // parerreRadioButton
            // 
            this.parerreRadioButton.AutoSize = true;
            this.parerreRadioButton.Checked = true;
            this.parerreRadioButton.Location = new System.Drawing.Point(153, 71);
            this.parerreRadioButton.Name = "parerreRadioButton";
            this.parerreRadioButton.Size = new System.Drawing.Size(62, 17);
            this.parerreRadioButton.TabIndex = 5;
            this.parerreRadioButton.TabStop = true;
            this.parerreRadioButton.Tag = "Parterre";
            this.parerreRadioButton.Text = "Партер";
            this.parerreRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoggiaRadioButton
            // 
            this.LoggiaRadioButton.AutoSize = true;
            this.LoggiaRadioButton.Location = new System.Drawing.Point(153, 95);
            this.LoggiaRadioButton.Name = "LoggiaRadioButton";
            this.LoggiaRadioButton.Size = new System.Drawing.Size(65, 17);
            this.LoggiaRadioButton.TabIndex = 6;
            this.LoggiaRadioButton.Text = "Лоджия";
            this.LoggiaRadioButton.UseVisualStyleBackColor = true;
            // 
            // BalconyRadioButton
            // 
            this.BalconyRadioButton.AutoSize = true;
            this.BalconyRadioButton.Location = new System.Drawing.Point(153, 119);
            this.BalconyRadioButton.Name = "BalconyRadioButton";
            this.BalconyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.BalconyRadioButton.TabIndex = 7;
            this.BalconyRadioButton.Text = "Балкон";
            this.BalconyRadioButton.UseVisualStyleBackColor = true;
            // 
            // payTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 185);
            this.Controls.Add(this.BalconyRadioButton);
            this.Controls.Add(this.LoggiaRadioButton);
            this.Controls.Add(this.parerreRadioButton);
            this.Controls.Add(this.payTicketButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TicketColBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "payTicket";
            this.Text = "Покупка билета";
            this.Load += new System.EventHandler(this.payTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TicketColBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button payTicketButton;
        private System.Windows.Forms.RadioButton parerreRadioButton;
        private System.Windows.Forms.RadioButton LoggiaRadioButton;
        private System.Windows.Forms.RadioButton BalconyRadioButton;
    }
}