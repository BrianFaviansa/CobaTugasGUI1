using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MengerjakanGUI1;

namespace MengerjakanGUI1
{
    public partial class entriData : Form
    {
        public entriData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Instansi GetInstansi()
        {
            Instansi newInstance = new Instansi();
            newInstance.Nama = textBox1.Text;
            newInstance.Kota = textBox2.Text;
            newInstance.Email = textBox3.Text;
            newInstance.Kategori = comboBox1.SelectedItem.ToString();
            newInstance.TglBerdiri = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            newInstance.Status_Aktif = checkBox1.Checked;

            return newInstance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
