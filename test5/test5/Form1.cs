using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace test5
{
    public partial class Form1 : Form
    {
        // Content item for the combo box
        private class Item
        {
            public string Name;
            public Item(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        public Form1()
        {
            InitializeComponent();
            // Put some stuff in the combo box
            comboBox1.Items.Add(new Item("SUV"));
            comboBox1.Items.Add(new Item("Sedan"));
            comboBox1.Items.Add(new Item("Luxury"));
            comboBox1.Items.Add(new Item("Minivan"));
            comboBox1.Items.Add(new Item("Sports"));
            comboBox2.Items.Add(new Item("Toyota"));
            comboBox2.Items.Add(new Item("Honda"));
            comboBox2.Items.Add(new Item("Nissan"));
            comboBox2.Items.Add(new Item("Ford"));
            comboBox2.Items.Add(new Item("Lexus"));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the Value property
            Item itm = (Item)comboBox1.SelectedItem;
            Console.WriteLine("{0}", itm.Name);
   
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the Value property
            Item itm = (Item)comboBox2.SelectedItem;
            Console.WriteLine("{0}", itm.Name);
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string selection = comboBox1.SelectedItem.ToString();
                string selection2 = comboBox2.SelectedItem.ToString();
                Form2 fm2 = new Form2();
                fm2.ShowDialog();


            }
            else
            {
                return;
            }
        }
    }
}
