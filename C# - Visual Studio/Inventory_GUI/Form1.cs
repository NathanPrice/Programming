using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            ListViewItem lvi = new ListViewItem(txtItemName.Text);

            lvi.SubItems.Add(txtItemDescript.Text);
            lvi.SubItems.Add(txtQuantity.Text);
            lvi.SubItems.Add(txtUnitPrice.Text);
            lvi.SubItems.Add(txtRetailPrice.Text);

            listView1.Items.Add(lvi);
            /*
            txtItemName.Text = "";
            txtItemDescript.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            txtRetailPrice.Text = "";
            */                
            
            // Saves entries
            using (StreamWriter save = new StreamWriter("save.txt", true))
            {
                save.WriteLine(txtItemName.Text + "," + txtItemDescript.Text + "," + txtQuantity.Text + "," + txtUnitPrice.Text + "," + txtRetailPrice.Text + ",");
            }

            txtItemName.Text = "";
            txtItemDescript.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            txtRetailPrice.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //FileStream save = File.Open("save.txt", FileMode.Open, FileAccess.Read);
            StreamReader save_read = new StreamReader("save.txt");
            string line;
            while ((line = save_read.ReadLine()) != null)
            {

                ListViewItem lvi = new ListViewItem();

                String[] format = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                lvi.Text = format[0];
                lvi.SubItems.Add(format[1]);
                lvi.SubItems.Add(format[2]);
                lvi.SubItems.Add(format[3]);
                lvi.SubItems.Add(format[4]);
                listView1.Items.Add(lvi);

            }

            save_read.Close();


        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






    }
}
