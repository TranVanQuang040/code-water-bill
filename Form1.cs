namespace App_tiennuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string email = "VanQuang";
        string password = "123";

        bool Check(string email, string password)
        {           
            if (email == this.email && password == this.password)
            {
                return true;
            }
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check(txbEmail.Text, tbxpass.Text))
            {
                Input1 login = new Input1();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid email or password", "Error", MessageBoxButtons.OK);
            }

        }

        private void tbxpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
