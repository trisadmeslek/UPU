using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPU_GUI
{
    public partial class frmUpuGui : Form
    {
        public frmUpuGui()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog1.FileName))
            {
                FileInfo info = new FileInfo(openFileDialog1.FileName);

                if (info.Extension != ".unitypackage")
                {
                    ShowMessageForRightExtension();
                    return;
                }
                txtPackage.Text = openFileDialog1.FileName;
                btnUnpack.Focus();
            }
        }

        void ShowMessageForRightExtension()
        {
            ShowMessage("Please choose a file with \".unitypackage\" extension");
        }

        void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPackage.Text))
                return;

            Process.Start(new ProcessStartInfo
            {
                FileName = "UnityPackager.exe",
                //UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = "unpack " + "\"" + txtPackage.Text + "\" \"" + txtPackage.Text + "_unpacked" + "\""
            });;
        }
    }
}
