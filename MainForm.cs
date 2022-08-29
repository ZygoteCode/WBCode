using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;

public partial class MainForm : MetroSuite.MetroForm
{
    [DllImport("psapi.dll")]
    static extern int EmptyWorkingSet(IntPtr hwProc);

    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetProcessWorkingSetSize(IntPtr process, UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);

    public MainForm()
    {
        InitializeComponent();

        CheckForIllegalCrossThreadCalls = false;
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

        new Thread(clearRam).Start(); 
    }

    public void clearRam()
    {
        while (true)
        {
            Thread.Sleep(500);

            EmptyWorkingSet(Process.GetCurrentProcess().Handle);

            GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();

            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Process.GetCurrentProcess().Kill();
    }

    private void metroButton2_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            pictureBox1.BackgroundImage.Save(saveFileDialog1.FileName);
            saveFileDialog1.FileName = "";
        }
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
        pictureBox1.BackgroundImage = WBCode.ConvertTextToBitmap(metroTextbox1.Text);
    }

    private void metroButton3_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            Image image = Image.FromFile(openFileDialog1.FileName);
            openFileDialog1.FileName = "";

            if (image.Width != 256 || image.Height != 256)
            {
                MessageBox.Show("Invalid image size (256x256 is needed).", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            pictureBox2.BackgroundImage = image;
        }
    }

    private void metroButton4_Click(object sender, EventArgs e)
    {
        if (pictureBox2.BackgroundImage != null)
        {
            metroTextbox2.Text = WBCode.ConvertBitmapToText((Bitmap)pictureBox2.BackgroundImage);
        }
        else
        {
            MessageBox.Show("The loaded image cannot be nothing!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }    
    }

    private void metroButton5_Click(object sender, EventArgs e)
    {
        if (pictureBox1.BackgroundImage != null)
        {
            Clipboard.SetImage(pictureBox1.BackgroundImage);
        }
        else
        {
            MessageBox.Show("The loaded image cannot be nothing!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void metroButton6_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(metroTextbox2.Text);
    }

    private void metroButton7_Click(object sender, EventArgs e)
    {
        if (Clipboard.GetImage() != null)
        {
            Image image = Clipboard.GetImage();

            if (image.Width != 256 || image.Height != 256)
            {
                MessageBox.Show("Invalid image size (256x256 is needed).", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            pictureBox2.BackgroundImage = image;
        }
        else
        {
            MessageBox.Show("The image in the Clipboard cannot be nothing!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void metroButton8_Click(object sender, EventArgs e)
    {
        metroTextbox1.Text = Clipboard.GetText();
    }
}