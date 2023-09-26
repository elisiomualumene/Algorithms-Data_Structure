namespace _017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            string Name = input.Text;

            int base_age = Int32.Parse(age.Text);


            int days = 365 * base_age;

            value.Text = Name.ToUpper() + " , VOCÉ JÁ VIVEU " + days.ToString() + " DIAS ";
        }

        private void cleaner_Click(object sender, EventArgs e)
        {
            input.Clear();
            age.Clear();
            value.Text = "";
        }
    }
}