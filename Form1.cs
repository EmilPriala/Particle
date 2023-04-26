using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAlg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyGraphics g = new MyGraphics();
        Map demo = new Map();


        private void Form1_Load(object sender, EventArgs e)
        {
            g.InitGraph(pictureBox1);
            demo.Width = pictureBox1.Width;
            demo.Height = pictureBox1.Height;
            demo.Init(50);
            demo.Draw(g.grp);
            g.RefreshGraph();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            demo.Tick();
            g.ClearGraph();
            demo.Draw(g.grp);
            g.RefreshGraph();
        }
    }
}
