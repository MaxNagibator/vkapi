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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uiAutorizeButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.uiGetMessagesButton = new System.Windows.Forms.Button();
            this.uiInboxMessagesComboBox = new System.Windows.Forms.ComboBox();
            this.uiOutboxMessagesComboBox = new System.Windows.Forms.ComboBox();
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
            this.ownerIdTextBox.Text = "31951957";
            // 
            // uiAlbumIdTextBox
            // 
            this.uiAlbumIdTextBox.Location = new System.Drawing.Point(163, 12);
            this.uiAlbumIdTextBox.Name = "uiAlbumIdTextBox";
            this.uiAlbumIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiAlbumIdTextBox.TabIndex = 2;
            this.uiAlbumIdTextBox.Text = "wall";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "GetFriendsId";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // uiAutorizeButton
            // 
            this.uiAutorizeButton.Location = new System.Drawing.Point(12, 351);
            this.uiAutorizeButton.Name = "uiAutorizeButton";
            this.uiAutorizeButton.Size = new System.Drawing.Size(807, 36);
            this.uiAutorizeButton.TabIndex = 5;
            this.uiAutorizeButton.Text = "autorize";
            this.uiAutorizeButton.UseVisualStyleBackColor = true;
            this.uiAutorizeButton.Click += new System.EventHandler(this.uiAutorizeButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(825, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(431, 518);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("https://oauth.vk.com/oauth/authorize?client_id=4347048&redirect_uri=https://oauth" +
        ".vk.com/blank.html&response_type=token&scope=4194303&v=&state=&display=mobile", System.UriKind.Absolute);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "token";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(719, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uiGetMessagesButton
            // 
            this.uiGetMessagesButton.Location = new System.Drawing.Point(12, 393);
            this.uiGetMessagesButton.Name = "uiGetMessagesButton";
            this.uiGetMessagesButton.Size = new System.Drawing.Size(807, 23);
            this.uiGetMessagesButton.TabIndex = 9;
            this.uiGetMessagesButton.Text = "GetMessages";
            this.uiGetMessagesButton.UseVisualStyleBackColor = true;
            this.uiGetMessagesButton.Click += new System.EventHandler(this.uiGetMessagesButton_Click);
            // 
            // uiInboxMessagesComboBox
            // 
            this.uiInboxMessagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiInboxMessagesComboBox.FormattingEnabled = true;
            this.uiInboxMessagesComboBox.Location = new System.Drawing.Point(12, 422);
            this.uiInboxMessagesComboBox.Name = "uiInboxMessagesComboBox";
            this.uiInboxMessagesComboBox.Size = new System.Drawing.Size(807, 21);
            this.uiInboxMessagesComboBox.TabIndex = 10;
            // 
            // uiOutboxMessagesComboBox
            // 
            this.uiOutboxMessagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiOutboxMessagesComboBox.FormattingEnabled = true;
            this.uiOutboxMessagesComboBox.Location = new System.Drawing.Point(12, 449);
            this.uiOutboxMessagesComboBox.Name = "uiOutboxMessagesComboBox";
            this.uiOutboxMessagesComboBox.Size = new System.Drawing.Size(807, 21);
            this.uiOutboxMessagesComboBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 518);
            this.Controls.Add(this.uiOutboxMessagesComboBox);
            this.Controls.Add(this.uiInboxMessagesComboBox);
            this.Controls.Add(this.uiGetMessagesButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.uiAutorizeButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button uiAutorizeButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button uiGetMessagesButton;
        private System.Windows.Forms.ComboBox uiInboxMessagesComboBox;
        private System.Windows.Forms.ComboBox uiOutboxMessagesComboBox;
    }
}

