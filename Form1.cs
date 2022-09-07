using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashCalc
{
    public partial class frmHashCalc : Form
    {
        public frmHashCalc()
        {
            InitializeComponent();
        }

        private void frmHashCalc_Load(object sender, EventArgs e)
        {
            ActiveControl = btnFile;
            cbbHash.SelectedIndex = 0;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            txtHash.Clear();
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string file = openFile.FileName;
                try
                {
                    txtFile.AppendText(file);
                    progressBar1.Increment(1);
                }
                catch (IOException)
                {
                }
            }
        }

        public string KiemTraMD5(string file)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(File.OpenRead(file));
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
        public string KiemTraSHA1(string file)
        {
            using (var sha1 = SHA1.Create())
            {
                var hash = sha1.ComputeHash(File.OpenRead(file));
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
        public string KiemTraSHA256(string file)
        {
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(File.OpenRead(file));
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            txtHash.Clear();

            if (cbbHash.Text == "MD5")
            {
                txtHash.AppendText(KiemTraMD5(txtFile.Text));
                progressBar1.Increment(100);
            }
            else if (cbbHash.Text == "SHA1")
            {
                txtHash.AppendText(KiemTraSHA1(txtFile.Text));
            }
            else if (cbbHash.Text == "SHA256")
            {
                txtHash.AppendText(KiemTraSHA256(txtFile.Text));
            }

        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sao chép thành công!");
            Clipboard.SetText(txtHash.Text);
        }
    }
}
