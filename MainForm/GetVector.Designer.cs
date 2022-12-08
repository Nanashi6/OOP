namespace MainForm
{
    partial class GetVector
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
            this.VectorTextBox = new System.Windows.Forms.TextBox();
            this.GetVectorButton = new System.Windows.Forms.Button();
            this.УчсузешщтДфиуд = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вектор";
            // 
            // VectorTextBox
            // 
            this.VectorTextBox.Location = new System.Drawing.Point(176, 16);
            this.VectorTextBox.Name = "VectorTextBox";
            this.VectorTextBox.Size = new System.Drawing.Size(191, 20);
            this.VectorTextBox.TabIndex = 1;
            // 
            // GetVectorButton
            // 
            this.GetVectorButton.Location = new System.Drawing.Point(243, 54);
            this.GetVectorButton.Name = "GetVectorButton";
            this.GetVectorButton.Size = new System.Drawing.Size(124, 23);
            this.GetVectorButton.TabIndex = 2;
            this.GetVectorButton.Text = "Ввести";
            this.GetVectorButton.UseVisualStyleBackColor = true;
            this.GetVectorButton.Click += new System.EventHandler(this.GetVectorButton_Click);
            // 
            // УчсузешщтДфиуд
            // 
            this.УчсузешщтДфиуд.AutoSize = true;
            this.УчсузешщтДфиуд.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.УчсузешщтДфиуд.Location = new System.Drawing.Point(13, 60);
            this.УчсузешщтДфиуд.Name = "УчсузешщтДфиуд";
            this.УчсузешщтДфиуд.Size = new System.Drawing.Size(0, 20);
            this.УчсузешщтДфиуд.TabIndex = 3;
            // 
            // GetVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 89);
            this.Controls.Add(this.УчсузешщтДфиуд);
            this.Controls.Add(this.GetVectorButton);
            this.Controls.Add(this.VectorTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GetVector";
            this.Text = "GetVector";
            this.Load += new System.EventHandler(this.GetVector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VectorTextBox;
        private System.Windows.Forms.Button GetVectorButton;
        private System.Windows.Forms.Label УчсузешщтДфиуд;
    }
}