using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolybiusSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            var square = new PolybiusSquare();

            var decryptedText = DecryptedText.Text.ToUpper();
            var cryptKey = CryptKey.Text.ToUpper();

            CryptedText.Text = square.PolibiusEncrypt(decryptedText, cryptKey);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            var square = new PolybiusSquare();

            var cryptedText = CryptedText.Text.ToUpper();
            var decryptKey = DecryptKey.Text.ToUpper();

            DecryptedText.Text = square.PolybiusDecrypt(cryptedText, decryptKey);
        }
    }
}
