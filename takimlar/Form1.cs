using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takimlar
{
    public partial class Form1 : Form
    {
        string[,] takimlar = new string[4, 3]
        {
            {"samet","sadettin","selim"},
            {"muzaffer","eyüp","özlem" },
            {"erdem","necati","bedirhan"},
            {"Mehmet","Burak","Ayşe" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(takimlar[3,0] + " " + takimlar[3,1] + " " + takimlar[3,2]);

            
        }
    }
}
