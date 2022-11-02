namespace Lab6
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.payButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(12, 12);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(139, 28);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Купить билет";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(12, 46);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(139, 29);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Изменить дату билета";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(12, 81);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(139, 29);
            this.listButton.TabIndex = 2;
            this.listButton.Text = "Список билетов";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 116);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(139, 30);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить билет";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 157);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.payButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

