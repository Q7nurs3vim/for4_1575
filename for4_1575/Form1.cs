namespace for4_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();

            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);

            for (int i = baslangic; i <= bitis; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}