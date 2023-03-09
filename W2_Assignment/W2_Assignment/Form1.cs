namespace W2_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttSubmit_Click(object sender, EventArgs e)
        {
            string adult = "You are an adult";
            string minor = "You are a minor";
            int umur = Convert.ToInt32(boxAge.Text);
            if (umur < 18)
            {
                MessageBox.Show("Name : " + boxName.Text + "\nEmail : " + boxEmail.Text + "\n"+ minor);
            }
            else
            {
                MessageBox.Show("Name : " + boxName.Text + "\nEmail : " + boxEmail.Text + "\n" + adult);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            boxName.Text= string.Empty;
            boxEmail.Text= string.Empty;
            boxAge.Text= string.Empty;
            boxPH.Text= string.Empty;
        }
    }
}