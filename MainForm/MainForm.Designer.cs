namespace MainForm
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.CheckTransportButton = new System.Windows.Forms.Button();
            this.TypeOfTransportComboBox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLabel = new System.Windows.Forms.Label();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.AdventureComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseTypeTicketComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseTypeTicketLabel = new System.Windows.Forms.Label();
            this.TextPriceLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FindTicketButton = new System.Windows.Forms.Button();
            this.BuyTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketTypeList = new System.Windows.Forms.ComboBox();
            this.AdventureList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TransportList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BuyTicketButton
            // 
            this.BuyTicketButton.Location = new System.Drawing.Point(14, 13);
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.Size = new System.Drawing.Size(92, 43);
            this.BuyTicketButton.TabIndex = 0;
            this.BuyTicketButton.Text = "Купить билет";
            this.BuyTicketButton.UseVisualStyleBackColor = true;
            this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
            // 
            // CheckTransportButton
            // 
            this.CheckTransportButton.Location = new System.Drawing.Point(13, 63);
            this.CheckTransportButton.Name = "CheckTransportButton";
            this.CheckTransportButton.Size = new System.Drawing.Size(92, 47);
            this.CheckTransportButton.TabIndex = 1;
            this.CheckTransportButton.Text = "Просмотр доступного транспорта";
            this.CheckTransportButton.UseVisualStyleBackColor = true;
            this.CheckTransportButton.Click += new System.EventHandler(this.CheckTransportButton_Click);
            // 
            // TypeOfTransportComboBox
            // 
            this.TypeOfTransportComboBox.FormattingEnabled = true;
            this.TypeOfTransportComboBox.Items.AddRange(new object[] {
            "plane",
            "bus",
            "train"});
            this.TypeOfTransportComboBox.Location = new System.Drawing.Point(262, 12);
            this.TypeOfTransportComboBox.Name = "TypeOfTransportComboBox";
            this.TypeOfTransportComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeOfTransportComboBox.TabIndex = 2;
            this.TypeOfTransportComboBox.Visible = false;
            this.TypeOfTransportComboBox.Leave += new System.EventHandler(this.TypeOfTransportComboBox_Leave);
            // 
            // TransportTypeLabel
            // 
            this.TransportTypeLabel.AutoSize = true;
            this.TransportTypeLabel.Location = new System.Drawing.Point(144, 15);
            this.TransportTypeLabel.Name = "TransportTypeLabel";
            this.TransportTypeLabel.Size = new System.Drawing.Size(112, 13);
            this.TransportTypeLabel.TabIndex = 3;
            this.TransportTypeLabel.Text = "Выберите транспорт";
            this.TransportTypeLabel.Visible = false;
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(404, 16);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(84, 13);
            this.ChooseLabel.TabIndex = 4;
            this.ChooseLabel.Text = "Выберите рейс";
            this.ChooseLabel.Visible = false;
            // 
            // AdventureComboBox
            // 
            this.AdventureComboBox.FormattingEnabled = true;
            this.AdventureComboBox.Location = new System.Drawing.Point(494, 12);
            this.AdventureComboBox.Name = "AdventureComboBox";
            this.AdventureComboBox.Size = new System.Drawing.Size(121, 21);
            this.AdventureComboBox.TabIndex = 5;
            this.AdventureComboBox.Visible = false;
            // 
            // ChooseTypeTicketComboBox
            // 
            this.ChooseTypeTicketComboBox.FormattingEnabled = true;
            this.ChooseTypeTicketComboBox.Location = new System.Drawing.Point(262, 40);
            this.ChooseTypeTicketComboBox.Name = "ChooseTypeTicketComboBox";
            this.ChooseTypeTicketComboBox.Size = new System.Drawing.Size(121, 21);
            this.ChooseTypeTicketComboBox.TabIndex = 6;
            this.ChooseTypeTicketComboBox.Visible = false;
            // 
            // ChooseTypeTicketLabel
            // 
            this.ChooseTypeTicketLabel.AutoSize = true;
            this.ChooseTypeTicketLabel.Location = new System.Drawing.Point(144, 43);
            this.ChooseTypeTicketLabel.Name = "ChooseTypeTicketLabel";
            this.ChooseTypeTicketLabel.Size = new System.Drawing.Size(115, 13);
            this.ChooseTypeTicketLabel.TabIndex = 7;
            this.ChooseTypeTicketLabel.Text = "Выберите тип билета";
            this.ChooseTypeTicketLabel.Visible = false;
            // 
            // TextPriceLabel
            // 
            this.TextPriceLabel.AutoSize = true;
            this.TextPriceLabel.Location = new System.Drawing.Point(337, 89);
            this.TextPriceLabel.Name = "TextPriceLabel";
            this.TextPriceLabel.Size = new System.Drawing.Size(100, 13);
            this.TextPriceLabel.TabIndex = 8;
            this.TextPriceLabel.Text = "Стоимость билета";
            this.TextPriceLabel.Visible = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(458, 89);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 13);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Visible = false;
            // 
            // FindTicketButton
            // 
            this.FindTicketButton.Location = new System.Drawing.Point(340, 63);
            this.FindTicketButton.Name = "FindTicketButton";
            this.FindTicketButton.Size = new System.Drawing.Size(112, 23);
            this.FindTicketButton.TabIndex = 10;
            this.FindTicketButton.Text = "Найти билет";
            this.FindTicketButton.UseVisualStyleBackColor = true;
            this.FindTicketButton.Visible = false;
            this.FindTicketButton.Click += new System.EventHandler(this.FindTicketButton_Click);
            // 
            // BuyTicket
            // 
            this.BuyTicket.Location = new System.Drawing.Point(346, 389);
            this.BuyTicket.Name = "BuyTicket";
            this.BuyTicket.Size = new System.Drawing.Size(112, 23);
            this.BuyTicket.TabIndex = 18;
            this.BuyTicket.Text = "Купить";
            this.BuyTicket.UseVisualStyleBackColor = true;
            this.BuyTicket.Visible = false;
            this.BuyTicket.Click += new System.EventHandler(this.BuyTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберите тип билета";
            this.label1.Visible = false;
            // 
            // TicketTypeList
            // 
            this.TicketTypeList.FormattingEnabled = true;
            this.TicketTypeList.Location = new System.Drawing.Point(238, 362);
            this.TicketTypeList.Name = "TicketTypeList";
            this.TicketTypeList.Size = new System.Drawing.Size(121, 21);
            this.TicketTypeList.TabIndex = 16;
            this.TicketTypeList.Visible = false;
            // 
            // AdventureList
            // 
            this.AdventureList.FormattingEnabled = true;
            this.AdventureList.Location = new System.Drawing.Point(470, 334);
            this.AdventureList.Name = "AdventureList";
            this.AdventureList.Size = new System.Drawing.Size(121, 21);
            this.AdventureList.TabIndex = 15;
            this.AdventureList.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберите рейс";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Выберите транспорт";
            this.label3.Visible = false;
            // 
            // TypeList
            // 
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Items.AddRange(new object[] {
            "plane",
            "bus",
            "train"});
            this.TypeList.Location = new System.Drawing.Point(238, 334);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(121, 21);
            this.TypeList.TabIndex = 12;
            this.TypeList.Visible = false;
            this.TypeList.Leave += new System.EventHandler(this.TypeList_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Кол-во билетов";
            this.label4.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // TransportList
            // 
            this.TransportList.Location = new System.Drawing.Point(112, 13);
            this.TransportList.Name = "TransportList";
            this.TransportList.Size = new System.Drawing.Size(677, 315);
            this.TransportList.TabIndex = 21;
            this.TransportList.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TransportList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuyTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketTypeList);
            this.Controls.Add(this.AdventureList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.FindTicketButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TextPriceLabel);
            this.Controls.Add(this.ChooseTypeTicketLabel);
            this.Controls.Add(this.ChooseTypeTicketComboBox);
            this.Controls.Add(this.AdventureComboBox);
            this.Controls.Add(this.ChooseLabel);
            this.Controls.Add(this.TransportTypeLabel);
            this.Controls.Add(this.TypeOfTransportComboBox);
            this.Controls.Add(this.CheckTransportButton);
            this.Controls.Add(this.BuyTicketButton);
            this.Name = "MainForm";
            this.Text = "Transport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.Button CheckTransportButton;
        private System.Windows.Forms.ComboBox TypeOfTransportComboBox;
        private System.Windows.Forms.Label TransportTypeLabel;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.ComboBox AdventureComboBox;
        private System.Windows.Forms.ComboBox ChooseTypeTicketComboBox;
        private System.Windows.Forms.Label ChooseTypeTicketLabel;
        private System.Windows.Forms.Label TextPriceLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button FindTicketButton;
        private System.Windows.Forms.Button BuyTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TicketTypeList;
        private System.Windows.Forms.ComboBox AdventureList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox TransportList;
    }
}

