using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace ShotChangeIndexer
{
    public partial class frmSCI : Form
    {
        public frmSCI()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFFmpeg.Text = Properties.Settings.Default.FFmpegBinary;
            nmrSensi.Value = decimal.Parse(Properties.Settings.Default.shotSensitive.ToString());
        }

        private void btnStartIndex(object sender, EventArgs e)
        {
            lstFound.Items.Clear();
            lblStatus.Text = "Processing!";
            Cursor.Current = Cursors.WaitCursor;
            Application.UseWaitCursor = true;
            Update();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = txtFFmpeg.Text;
            string moviePath = txtFile.Text.Replace('\\', '/');
            proc.StartInfo.Arguments = "-show_frames -of compact=p=0 -f lavfi \"movie=\\'" + moviePath + "\\',select='gt(scene,"+nmrSensi.Value.ToString().Replace(',', '.')+")\"";
            //textBox1.Text = proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            
            if (!proc.Start())
            {
                MessageBox.Show("Error starting FFmpeg.", "ShotChangeIndexer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            StreamReader reader = proc.StandardOutput;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] keyInfo = line.Split("|".ToCharArray());
                lstFound.Items.Add(keyInfo[4].Replace("pkt_pts_time=", "").ToString());
                lblStatus.Text = "Found " + lstFound.Items.Count.ToString() + " changes";
                Update();
            }
            lblStatus.Text = "Waiting...";
            Cursor.Current = Cursors.Default;
            Application.UseWaitCursor = false;

            if (lstFound.Items.Count != 0)
            {

                btnSave.Enabled = true;

            } else
            {

                btnSave.Enabled = false;

            }

            lblStatus.Text = "Found " + lstFound.Items.Count.ToString() + " changes";

            proc.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ffmpeg.org/");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogInput = new OpenFileDialog();
            dialogInput.Filter = "Video Files|*.mkv;*.wmv;*.avi;*.mp4;*.mp2;*.mov";
            DialogResult searchInput = dialogInput.ShowDialog();
            if (searchInput == DialogResult.OK)
            {
                txtFile.Text = dialogInput.FileName;
            } else
            {
                MessageBox.Show("Please select a valid file.", "ShotChangeIndexer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        private void btnBrowseFF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogFFmpeg = new OpenFileDialog();
            dialogFFmpeg.Filter = "FFprobe Executable|ffprobe.exe";
            DialogResult dialogFFmpegResult = dialogFFmpeg.ShowDialog();
            if (dialogFFmpegResult == DialogResult.OK)
            {
                txtFFmpeg.Text = dialogFFmpeg.FileName;
                Properties.Settings.Default.FFmpegBinary = dialogFFmpeg.FileName;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please select a valid FFprobe binary.", "ShotChangeIndexer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFFmpeg_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FFmpegBinary = txtFFmpeg.Text;
            Properties.Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSaveSCI = new SaveFileDialog();
            dialogSaveSCI.Filter = "ShotChangeIndexer File|*.sci";
            dialogSaveSCI.Title = "Save timing file";
            dialogSaveSCI.ShowDialog();

            if (dialogSaveSCI.FileName != "")
            {

                System.IO.FileStream fs =
                    (System.IO.FileStream)dialogSaveSCI.OpenFile();

                var fw = new StreamWriter(fs);

                foreach (string item in lstFound.Items)
                {
                    fw.WriteLine(item);
                }

                fw.Flush();

                fs.Close();

                MessageBox.Show("The timings have been succesfully saved.", "ShotChangeIndexer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {

                MessageBox.Show("Please select a valid save location.", "ShotChangeIndexer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void nmrSensi_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.shotSensitive = double.Parse(nmrSensi.Value.ToString());
            Properties.Settings.Default.Save();
        }
    }
}
