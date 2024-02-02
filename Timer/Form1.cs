using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {

        // Font
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [In] ref uint pcFonts);

        public Form1()
        {
            InitializeComponent();
        }

        // Stopwatch
        Stopwatch stopWatch1 = new Stopwatch();

        // Play or Pause
        private bool play1 = false;

        // Default String
        private string defaultString = "00:00:00";

        // Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Font
            byte[] fontData = Properties.Resources.DSEG7Modern_Bold;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);
            Font digiFont = new Font(fonts.Families[0], 24.0F);
            txtTime1.Font = digiFont;
            txtTime2.Font = digiFont;
            txtTime1.Text = defaultString;
            txtTime2.Text = defaultString;
        }

        // Stopwatch 1 - Play or Pause
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            if (play1)
            {
                play1 = false;
                btnPlay1.BackgroundImage = Properties.Resources.Play_48x48;
                timer1.Stop();
                stopWatch1.Stop();
            }
            else
            {
                play1 = true;
                btnPlay1.BackgroundImage = Properties.Resources.Pause_48x48;
                timer1.Start();
                stopWatch1.Start();
            }
        }

        // Stopwatch 1 - Write time in textbox
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime1.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch1.Elapsed);
            if (txtTime2.Text != defaultString && txtTime1.Text == txtTime2.Text)
            {
                MessageBox.Show("Timer Is Stop", Text, MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.ServiceNotification);
                btnStop1_Click(sender, e);
            }
        }

        // Stopwatch 1 - Stop
        private void btnStop1_Click(object sender, EventArgs e)
        {
            txtTime1.Text = defaultString;
            play1 = false;
            btnPlay1.BackgroundImage = Properties.Resources.Play_48x48;
            timer1.Stop();
            stopWatch1.Stop();
            stopWatch1.Reset();
        }
    }
}
