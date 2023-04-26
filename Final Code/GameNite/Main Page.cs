namespace GameNite
{
    public partial class Main_Page : Form
    {
        Log_In log_In = new Log_In();
        Sign_In sign_In = new Sign_In();
        Cart checkOut = new Cart();
        public Main_Page()
        {
            InitializeComponent();
        }

        private void lnkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_In.Show();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_In.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            checkOut.Show();
        }
    }
}