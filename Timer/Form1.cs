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
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public Form1()
        {
            InitializeComponent();
        }

        // Stopwatch
        Stopwatch stopWatch1 = new Stopwatch();
        Stopwatch stopWatch2 = new Stopwatch();
        Stopwatch stopWatch3 = new Stopwatch();

        // Play or Pause
        private bool play1 = false;
        private bool play2 = false;
        private bool play3 = false;

        


        // Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Font
            byte[] fontData = Properties.Resources.DSEG7Modern_Bold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            Font digiFont = new Font(fonts.Families[0], 24.0F);
            txtTime1.Font = digiFont;
            txtTime2.Font = digiFont;
            txtTime3.Font = digiFont;
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
        }

        // Stopwatch 1 - Stop
        private void btnStop1_Click(object sender, EventArgs e)
        {
            play1 = false;
            btnPlay1.BackgroundImage = Properties.Resources.Play_48x48;
            timer1.Stop();
            stopWatch1.Stop();
            stopWatch1.Reset();
        }

        // Stopwatch 2 - Play or Pause
        private void btnPlay2_Click(object sender, EventArgs e)
        {
            if (play2)
            {
                play2 = false;
                btnPlay2.BackgroundImage = Properties.Resources.Play_48x48;
                timer2.Stop();
                stopWatch2.Stop();
            }
            else
            {
                play2 = true;
                btnPlay2.BackgroundImage = Properties.Resources.Pause_48x48;
                timer2.Start();
                stopWatch2.Start();
            }
        }

        // Stopwatch 2 - Write time in textbox
        private void timer2_Tick(object sender, EventArgs e)
        {
            txtTime2.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch2.Elapsed);
        }

        // Stopwatch 2 - Stop
        private void btnStop2_Click(object sender, EventArgs e)
        {
            play2 = false;
            btnPlay2.BackgroundImage = Properties.Resources.Play_48x48;
            timer2.Stop();
            stopWatch2.Stop();
            stopWatch2.Reset();
        }

        // Stopwatch 3 - Play or Pause
        private void btnPlay3_Click(object sender, EventArgs e)
        {
            if (play3)
            {
                play3 = false;
                btnPlay3.BackgroundImage = Properties.Resources.Play_48x48;
                timer3.Stop();
                stopWatch3.Stop();
            }
            else
            {
                play3 = true;
                btnPlay3.BackgroundImage = Properties.Resources.Pause_48x48;
                timer3.Start();
                stopWatch3.Start();
            }
        }

        // Stopwatch 3 - Write time in textbox
        private void timer3_Tick(object sender, EventArgs e)
        {
            txtTime3.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch3.Elapsed);
        }

        // Stopwatch 3 - Stop
        private void btnStop3_Click(object sender, EventArgs e)
        {
            play3 = false;
            btnPlay3.BackgroundImage = Properties.Resources.Play_48x48;
            timer3.Stop();
            stopWatch3.Stop();
            stopWatch3.Reset();
        }
    }
}
