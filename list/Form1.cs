using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Dictionary<int,person> contacts = new Dictionary<int,person>();
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            contacts.Add(i, new person() { name= textBox1.Text,age= textBox3.Text,phone= textBox2.Text } );

            MessageBox.Show(contacts[i].name);
            i++;
            textBox5.Text = textBox5.Text+contacts[i].name;
        }

      
    }


    class person
    {
        public string name;
        public string age;
        public string phone;
    }
}
