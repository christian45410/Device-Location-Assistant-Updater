using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                label3.Text = File.ReadAllText(@"\\SERVERNAME\District\Admin\Technology\Desktop Services\CL\Software\DLA\Updates\version\version_update.txt");
                if (File.Exists("DLA.exe"))
                {
                    File.Delete("DLA.exe");
                }
                await Task.Delay(4000);
                File.Copy(@"\\SERVERNAME\District\Admin\Technology\Desktop Services\CL\Software\DLA\Updates\files\current\DLA.exe", Application.StartupPath + @"\DLA.exe");
                Process.Start(Application.StartupPath + @"\DLA.exe");
                Environment.Exit(0);
            }

            catch (Exception)
            {

            }

        }
    }
}
