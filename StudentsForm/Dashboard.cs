namespace StudentsForm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lg=new();
            lg.ShowDialog();
        }
    }
}