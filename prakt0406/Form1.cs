using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt0406
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void random(float[] massiv)
        {
            Random rand = new Random();
            for(int i  = 0; i < massiv.Length; i++)
            {
                massiv[i] = rand.Next(-20, 20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[] massiv = new float[10];
            random(massiv);
            float min = massiv[0];
            for (int i= 0;i< massiv.Length;i++){
                if(massiv[i] < min)
                {
                    min = massiv[i];
                }
                text_box_massiva.Text += massiv[i].ToString() + "\n";
            }
            text_box_minimalnogo.Text = min.ToString();

        }
    }
}
