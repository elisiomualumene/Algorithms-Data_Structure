namespace _018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if(int.TryParse(input1.Text, out int gasolina) && int.TryParse(input2.Text, out int preco)) {
                value.Text = (preco / gasolina).ToString() + " litros ";
            }
        }
    }
}