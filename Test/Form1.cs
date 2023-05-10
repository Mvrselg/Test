using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        Form2 form2;

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (textBox1.Text == "")
                MessageBox.Show("Введите имя");
            else
            {
                form2.Show(); 
                Hide();
            }
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"result.txt", true);
            writer.WriteLine(" ");
            writer.WriteLine(" ____________________________________________________ ");
            writer.WriteLine(" ");
            writer.WriteLine("Новая попыка.");
            writer.WriteLine(" ");
            writer.WriteLine("Дата прохождения {0}", date);
            writer.WriteLine("Уважемый, " + name);
            writer.Close();




        }
    }
}
