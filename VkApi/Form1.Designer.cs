namespace VkApi
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiGetImagesButton = new System.Windows.Forms.Button();
            this.ownerIdTextBox = new System.Windows.Forms.TextBox();
            this.uiAlbumIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiGetImagesButton
            // 
            this.uiGetImagesButton.Location = new System.Drawing.Point(12, 38);
            this.uiGetImagesButton.Name = "uiGetImagesButton";
            this.uiGetImagesButton.Size = new System.Drawing.Size(100, 23);
            this.uiGetImagesButton.TabIndex = 0;
            this.uiGetImagesButton.Text = "GetImages";
            this.uiGetImagesButton.UseVisualStyleBackColor = true;
            this.uiGetImagesButton.Click += new System.EventHandler(this.uiGetImagesButton_Click);
            // 
            // ownerIdTextBox
            // 
            this.ownerIdTextBox.Location = new System.Drawing.Point(12, 12);
            this.ownerIdTextBox.Name = "ownerIdTextBox";
            this.ownerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerIdTextBox.TabIndex = 1;
            this.ownerIdTextBox.Text = "68372827";
            // 
            // uiAlbumIdTextBox
            // 
            this.uiAlbumIdTextBox.Location = new System.Drawing.Point(163, 12);
            this.uiAlbumIdTextBox.Name = "uiAlbumIdTextBox";
            this.uiAlbumIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiAlbumIdTextBox.TabIndex = 2;
            this.uiAlbumIdTextBox.Text = "wall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.uiAlbumIdTextBox);
            this.Controls.Add(this.ownerIdTextBox);
            this.Controls.Add(this.uiGetImagesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiGetImagesButton;
        private System.Windows.Forms.TextBox ownerIdTextBox;
        private System.Windows.Forms.TextBox uiAlbumIdTextBox;
    }
}

