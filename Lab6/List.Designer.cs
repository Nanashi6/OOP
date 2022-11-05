namespace Lab6
{
    partial class List
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
            this.ListButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.ListBox();
            this.dateTicketListButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AverageTicketButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.MinColTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListButton
            // 
            this.ListButton.Location = new System.Drawing.Point(497, 13);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(108, 38);
            this.ListButton.TabIndex = 1;
            this.ListButton.Text = "Вывести список всех билетов";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // textBox
            // 
            this.textBox.FormattingEnabled = true;
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(469, 329);
            this.textBox.TabIndex = 2;
            // 
            // dateTicketListButton
            // 
            this.dateTicketListButton.Location = new System.Drawing.Point(497, 105);
            this.dateTicketListButton.Name = "dateTicketListButton";
            this.dateTicketListButton.Size = new System.Drawing.Size(108, 40);
            this.dateTicketListButton.TabIndex = 3;
            this.dateTicketListButton.Text = "Кол-во билетов на заданную дату";
            this.dateTicketListButton.UseVisualStyleBackColor = true;
            this.dateTicketListButton.Click += new System.EventHandler(this.dateTicketListButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // AverageTicketButton
            // 
            this.AverageTicketButton.Location = new System.Drawing.Point(497, 235);
            this.AverageTicketButton.Name = "AverageTicketButton";
            this.AverageTicketButton.Size = new System.Drawing.Size(108, 50);
            this.AverageTicketButton.TabIndex = 5;
            this.AverageTicketButton.Text = "Среднее кол-во билетов по местам";
            this.AverageTicketButton.UseVisualStyleBackColor = true;
            this.AverageTicketButton.Click += new System.EventHandler(this.AverageTicketButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(497, 181);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(497, 208);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // MinColTicketButton
            // 
            this.MinColTicketButton.Location = new System.Drawing.Point(497, 291);
            this.MinColTicketButton.Name = "MinColTicketButton";
            this.MinColTicketButton.Size = new System.Drawing.Size(108, 51);
            this.MinColTicketButton.TabIndex = 8;
            this.MinColTicketButton.Text = "Минимальное число билетов на дату";
            this.MinColTicketButton.UseVisualStyleBackColor = true;
            this.MinColTicketButton.Click += new System.EventHandler(this.MinColTicketButton_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 362);
            this.Controls.Add(this.MinColTicketButton);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.AverageTicketButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTicketListButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ListButton);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.ListBox textBox;
        private System.Windows.Forms.Button dateTicketListButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AverageTicketButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button MinColTicketButton;
    }
}