namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public string test1 = "user_test_string";
        private string test2 = "user_test_string";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string userId = "gwise";
            Console.WriteLine(userId);
            this.lblUserId.Text = userId;
        }
    }
}