namespace OdemeFormuTechCareer
{
    public partial class Form1 : Form
    {
        string secilenRenk = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dogumYili = Convert.ToInt32(txtYazi.Text);
            Insan i = new Insan();
            int gelenYas = i.yasiniz(dogumYili);

            lblMesaj.Text = "Yaþýnýz " + gelenYas + " - " + i.yasHesap(gelenYas);
            MessageBox.Show("Yaþýnýz " + gelenYas + " - " + i.yasHesap(gelenYas));
            lblMesaj.Text = "Seçilen Renk:" + secilenRenk;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hoþ geldiniz");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lblMesaj.Text = "Seçilen renk:" + comboBox1.SelectedItem;
            secilenRenk = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblRenk.Text = "Seçilen renk: " + secilenRenk;
        }
    }
}