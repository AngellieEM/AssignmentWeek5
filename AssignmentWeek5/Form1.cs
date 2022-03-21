using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentWeek5
{
    public partial class FormMateri : Form
    {
        public FormMateri()
        {
            InitializeComponent();
        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            
        }

        public DataTable InputData =new DataTable();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxData.Text);

            //nda tau pak menyerah udah aku utak atik, tapi klo nda pake ini bakal output di label
            if (listBox1.Items.Contains(textBoxData.Text))
            {
                MessageBox.Show("Input Kembar!");
            }

        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormMateri_Load(object sender, EventArgs e)
        {
            InputData.Columns.Add();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutputTulisan.Text = listBox1.SelectedItem.ToString();
        }
    }
}
