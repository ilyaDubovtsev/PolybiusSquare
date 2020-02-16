namespace PolybiusSquare
{
    partial class Form1
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
            this.DecryptedText = new System.Windows.Forms.TextBox();
            this.CryptedText = new System.Windows.Forms.TextBox();
            this.DecryptedTextLabel = new System.Windows.Forms.Label();
            this.CryptedTextLabel = new System.Windows.Forms.Label();
            this.CryptKey = new System.Windows.Forms.TextBox();
            this.DecryptKey = new System.Windows.Forms.TextBox();
            this.DecryptKeyLabel = new System.Windows.Forms.Label();
            this.CryptKeyLabel = new System.Windows.Forms.Label();
            this.Crypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DecryptedText
            // 
            this.DecryptedText.Location = new System.Drawing.Point(12, 39);
            this.DecryptedText.Multiline = true;
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.Size = new System.Drawing.Size(282, 237);
            this.DecryptedText.TabIndex = 0;
            // 
            // CryptedText
            // 
            this.CryptedText.Location = new System.Drawing.Point(505, 39);
            this.CryptedText.Multiline = true;
            this.CryptedText.Name = "CryptedText";
            this.CryptedText.Size = new System.Drawing.Size(282, 237);
            this.CryptedText.TabIndex = 1;
            // 
            // DecryptedTextLabel
            // 
            this.DecryptedTextLabel.AutoSize = true;
            this.DecryptedTextLabel.Location = new System.Drawing.Point(9, 23);
            this.DecryptedTextLabel.Name = "DecryptedTextLabel";
            this.DecryptedTextLabel.Size = new System.Drawing.Size(125, 13);
            this.DecryptedTextLabel.TabIndex = 2;
            this.DecryptedTextLabel.Text = "Дешифрованный текст";
            // 
            // CryptedTextLabel
            // 
            this.CryptedTextLabel.AutoSize = true;
            this.CryptedTextLabel.Location = new System.Drawing.Point(503, 23);
            this.CryptedTextLabel.Name = "CryptedTextLabel";
            this.CryptedTextLabel.Size = new System.Drawing.Size(111, 13);
            this.CryptedTextLabel.TabIndex = 3;
            this.CryptedTextLabel.Text = "Шифрованный текст";
            // 
            // CryptKey
            // 
            this.CryptKey.Location = new System.Drawing.Point(12, 310);
            this.CryptKey.Name = "CryptKey";
            this.CryptKey.Size = new System.Drawing.Size(281, 20);
            this.CryptKey.TabIndex = 4;
            // 
            // DecryptKey
            // 
            this.DecryptKey.Location = new System.Drawing.Point(505, 310);
            this.DecryptKey.Name = "DecryptKey";
            this.DecryptKey.Size = new System.Drawing.Size(281, 20);
            this.DecryptKey.TabIndex = 5;
            // 
            // DecryptKeyLabel
            // 
            this.DecryptKeyLabel.AutoSize = true;
            this.DecryptKeyLabel.Location = new System.Drawing.Point(503, 294);
            this.DecryptKeyLabel.Name = "DecryptKeyLabel";
            this.DecryptKeyLabel.Size = new System.Drawing.Size(112, 13);
            this.DecryptKeyLabel.TabIndex = 6;
            this.DecryptKeyLabel.Text = "Ключ дешифрования";
            // 
            // CryptKeyLabel
            // 
            this.CryptKeyLabel.AutoSize = true;
            this.CryptKeyLabel.Location = new System.Drawing.Point(12, 294);
            this.CryptKeyLabel.Name = "CryptKeyLabel";
            this.CryptKeyLabel.Size = new System.Drawing.Size(100, 13);
            this.CryptKeyLabel.TabIndex = 7;
            this.CryptKeyLabel.Text = "Ключ шифрования";
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(316, 82);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(163, 23);
            this.Crypt.TabIndex = 8;
            this.Crypt.Text = "Зашифровать >>";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(319, 214);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(163, 23);
            this.Decrypt.TabIndex = 9;
            this.Decrypt.Text = "<< Дешифровать";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.CryptKeyLabel);
            this.Controls.Add(this.DecryptKeyLabel);
            this.Controls.Add(this.DecryptKey);
            this.Controls.Add(this.CryptKey);
            this.Controls.Add(this.CryptedTextLabel);
            this.Controls.Add(this.DecryptedTextLabel);
            this.Controls.Add(this.CryptedText);
            this.Controls.Add(this.DecryptedText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DecryptedText;
        private System.Windows.Forms.TextBox CryptedText;
        private System.Windows.Forms.Label DecryptedTextLabel;
        private System.Windows.Forms.Label CryptedTextLabel;
        private System.Windows.Forms.TextBox CryptKey;
        private System.Windows.Forms.TextBox DecryptKey;
        private System.Windows.Forms.Label DecryptKeyLabel;
        private System.Windows.Forms.Label CryptKeyLabel;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.Button Decrypt;
    }
}

