using System.Windows.Forms;

namespace GameNite
{
    public partial class Main_Page : Form
    {
        Log_In log_In = new Log_In();
        Sign_In sign_In = new Sign_In();
        Cart cart = new Cart();
        Accessories accessories = new Accessories();
        Books books = new Books();
        BoardGames boardGames = new BoardGames();
        CardGames cardGames = new CardGames();


        // can call this in other classes with Main_Page.orders

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

            cart.Show();
        }

        private void lnkAccessories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            accessories.Show();
        }

        private void lnkBoardGames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boardGames.Show();
        }

        private void lnkBooks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            books.Show();
        }

        private void lnkCardGames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cardGames.Show();
        }
    }
}