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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetValueButton = new System.Windows.Forms.Button();
            this.ScalarProductButton = new System.Windows.Forms.Button();
            this.VectorProductButton = new System.Windows.Forms.Button();
            this.MixedProductButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ConstTextBox = new System.Windows.Forms.TextBox();
            this.GetAButton = new System.Windows.Forms.Button();
            this.GetBButton = new System.Windows.Forms.Button();
            this.GetCButton = new System.Windows.Forms.Button();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "W = A * const";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "W = A * [B;C]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "W = [A;B]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "W = A * B";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GetValueButton
            // 
            this.GetValueButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GetValueButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GetValueButton.Location = new System.Drawing.Point(145, 28);
            this.GetValueButton.Name = "GetValueButton";
            this.GetValueButton.Size = new System.Drawing.Size(75, 23);
            this.GetValueButton.TabIndex = 4;
            this.GetValueButton.Text = "Вычислить";
            this.GetValueButton.UseVisualStyleBackColor = false;
            this.GetValueButton.Click += new System.EventHandler(this.GetValueButton_Click);
            // 
            // ScalarProductButton
            // 
            this.ScalarProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScalarProductButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ScalarProductButton.Location = new System.Drawing.Point(145, 64);
            this.ScalarProductButton.Name = "ScalarProductButton";
            this.ScalarProductButton.Size = new System.Drawing.Size(75, 23);
            this.ScalarProductButton.TabIndex = 5;
            this.ScalarProductButton.Text = "Вычислить";
            this.ScalarProductButton.UseVisualStyleBackColor = false;
            this.ScalarProductButton.Click += new System.EventHandler(this.ScalarProductButton_Click);
            // 
            // VectorProductButton
            // 
            this.VectorProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.VectorProductButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VectorProductButton.Location = new System.Drawing.Point(145, 98);
            this.VectorProductButton.Name = "VectorProductButton";
            this.VectorProductButton.Size = new System.Drawing.Size(75, 23);
            this.VectorProductButton.TabIndex = 6;
            this.VectorProductButton.Text = "Вычислить";
            this.VectorProductButton.UseVisualStyleBackColor = false;
            this.VectorProductButton.Click += new System.EventHandler(this.VectorProductButton_Click);
            // 
            // MixedProductButton
            // 
            this.MixedProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MixedProductButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MixedProductButton.Location = new System.Drawing.Point(145, 135);
            this.MixedProductButton.Name = "MixedProductButton";
            this.MixedProductButton.Size = new System.Drawing.Size(75, 23);
            this.MixedProductButton.TabIndex = 7;
            this.MixedProductButton.Text = "Вычислить";
            this.MixedProductButton.UseVisualStyleBackColor = false;
            this.MixedProductButton.Click += new System.EventHandler(this.MixedProductButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MixedProductButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VectorProductButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ScalarProductButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GetValueButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 194);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(265, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(265, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "W:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(264, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(265, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "B:";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(315, 21);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(13, 13);
            this.ALabel.TabIndex = 13;
            this.ALabel.Text = "0";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(315, 52);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(13, 13);
            this.BLabel.TabIndex = 14;
            this.BLabel.Text = "0";
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(315, 81);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(13, 13);
            this.CLabel.TabIndex = 15;
            this.CLabel.Text = "0";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Location = new System.Drawing.Point(315, 119);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(13, 13);
            this.WLabel.TabIndex = 16;
            this.WLabel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(22, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "Const = ";
            // 
            // ConstTextBox
            // 
            this.ConstTextBox.Location = new System.Drawing.Point(108, 210);
            this.ConstTextBox.Name = "ConstTextBox";
            this.ConstTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConstTextBox.TabIndex = 18;
            this.ConstTextBox.Text = "0";
            // 
            // GetAButton
            // 
            this.GetAButton.Location = new System.Drawing.Point(501, 13);
            this.GetAButton.Name = "GetAButton";
            this.GetAButton.Size = new System.Drawing.Size(75, 23);
            this.GetAButton.TabIndex = 19;
            this.GetAButton.Text = "Ввести А";
            this.GetAButton.UseVisualStyleBackColor = true;
            this.GetAButton.Click += new System.EventHandler(this.GetAButton_Click);
            // 
            // GetBButton
            // 
            this.GetBButton.Location = new System.Drawing.Point(501, 42);
            this.GetBButton.Name = "GetBButton";
            this.GetBButton.Size = new System.Drawing.Size(75, 23);
            this.GetBButton.TabIndex = 20;
            this.GetBButton.Text = "Ввести В";
            this.GetBButton.UseVisualStyleBackColor = true;
            this.GetBButton.Click += new System.EventHandler(this.GetBButton_Click);
            // 
            // GetCButton
            // 
            this.GetCButton.Location = new System.Drawing.Point(501, 77);
            this.GetCButton.Name = "GetCButton";
            this.GetCButton.Size = new System.Drawing.Size(75, 23);
            this.GetCButton.TabIndex = 21;
            this.GetCButton.Text = "Ввести С";
            this.GetCButton.UseVisualStyleBackColor = true;
            this.GetCButton.Click += new System.EventHandler(this.GetCButton_Click);
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.AutoSize = true;
            this.ExceptionLabel.Location = new System.Drawing.Point(276, 219);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(0, 13);
            this.ExceptionLabel.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 244);
            this.Controls.Add(this.ExceptionLabel);
            this.Controls.Add(this.GetCButton);
            this.Controls.Add(this.GetBButton);
            this.Controls.Add(this.GetAButton);
            this.Controls.Add(this.ConstTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetValueButton;
        private System.Windows.Forms.Button ScalarProductButton;
        private System.Windows.Forms.Button VectorProductButton;
        private System.Windows.Forms.Button MixedProductButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ConstTextBox;
        private System.Windows.Forms.Button GetAButton;
        private System.Windows.Forms.Button GetBButton;
        private System.Windows.Forms.Button GetCButton;
        private System.Windows.Forms.Label ExceptionLabel;
    }
}

