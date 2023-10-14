namespace MengerjakanGUI1
{
    public partial class Form1 : Form
    {
        List<Instansi> listInstansi = new List<Instansi>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("ABC", "Jember", "satu@gmail.com", new DateOnly(2004, 03, 31), true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (entriData entriBaru = new entriData())
            {
                if (entriBaru.ShowDialog() == DialogResult.OK)
                {
                    Instansi newInstance = entriBaru.GetInstansi();
                    listInstansi.Add(newInstance);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listInstansi;

                    entriBaru.Close();
                }
                else
                {
                    entriBaru.Close();
                }
            }
        }
    }
}