using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lub_44
{
    public partial class Form2 : Form
    {
        public Cars theclass1 = null;
        public Form2(Cars t)
        {
            theclass1 = t;
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            theclass1.Name = textBox1.Text.Trim();
            theclass1.Country = textBox2.Text.Trim();
            theclass1.Motor = textBox3.Text.Trim();
            theclass1.ObDviguna = double.Parse(textBox4.Text.Trim());
            theclass1.PotugDviguna = int.Parse(textBox5.Text.Trim());
            theclass1.MaxSpeed = double.Parse(textBox6.Text.Trim());
            theclass1.Rnasto = double.Parse(textBox7.Text.Trim());
            theclass1.DiameterDisk = double.Parse(textBox8.Text.Trim());
            theclass1.NewCar = checkBox1.Checked;
            theclass1.Automaticgearbox = checkBox2.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (theclass1 != null)
            {
                textBox1.Text = theclass1.Name;
                textBox2.Text = theclass1.Country;
                textBox3.Text = theclass1.Motor;
                textBox4.Text = theclass1.ObDviguna.ToString();
                textBox5.Text = theclass1.PotugDviguna.ToString("000");
                textBox6.Text = theclass1.MaxSpeed.ToString("0000");
                textBox7.Text = theclass1.Rnasto.ToString();
                textBox8.Text = theclass1.DiameterDisk.ToString();
                checkBox1.Checked = theclass1.NewCar;
                checkBox2.Checked = theclass1.Automaticgearbox;
            }

        }

   
    }
}
