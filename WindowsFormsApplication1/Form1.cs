using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
           // Environment.CurrentDirectory = Environment.GetEnvironmentVariable("dir");
            // Process.Start(startInfo);

            startInfo.Arguments = Application.StartupPath+"Продукция";

            Process.Start(startInfo);
            
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }


        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }


        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.SteelBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.SteelBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.SteelBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.SteelBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.SteelBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

           // Process.Start(startInfo);

            startInfo.Arguments = "www.vibropribor.ru";

            Process.Start(startInfo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process.Start(startInfo);

            startInfo.Arguments = Environment.CurrentDirectory;

            Process.Start(startInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process.Start(startInfo);

            startInfo.Arguments = Environment.CurrentDirectory+"Разрешительные документы";

            Process.Start(startInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process.Start(startInfo);

            startInfo.Arguments = Environment.CurrentDirectory + "Программное обеспечение";

            Process.Start(startInfo);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.SteelBlue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process.Start(startInfo);

            startInfo.Arguments = Environment.CurrentDirectory + "Продукция\\ДВСТ";

            Process.Start(startInfo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process.Start(startInfo);

            startInfo.Arguments = Environment.CurrentDirectory + "Продукция\\ВТ-101";

            Process.Start(startInfo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process.Start(startInfo);

            startInfo.Arguments = Environment.CurrentDirectory + "Продукция\\УКЗМ";

            Process.Start(startInfo);
        }



        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.SteelBlue;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.SteelBlue;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.ForeColor = Color.White;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.ForeColor = Color.SteelBlue;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            // Process.Start(startInfo);

            startInfo.Arguments = Environment.CurrentDirectory + "Продукция\\ДВСТ";

            Process.Start(startInfo);
            //label1.Text = startInfo.Arguments;
        }


    }
}
