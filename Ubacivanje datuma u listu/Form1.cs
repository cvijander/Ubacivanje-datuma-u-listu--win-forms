namespace Ubacivanje_datuma_u_listu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            //  MessageBox.Show("Odabrali ste: " + datum.ToShortDateString());
            //listBox1.Items.Add(datum.ToShortDateString());
            listBox1.Items.Add(datum.Day + ". " + datum.Month + ". " + datum.Year + ".");
        }
    }
}