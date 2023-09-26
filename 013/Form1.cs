namespace _013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = date.Value;

            int idadeAnos = DateTime.Today.Year - dataNascimento.Year;

            if (DateTime.Today < dataNascimento.AddYears(idadeAnos))
            {
                idadeAnos--;
            }

            int idadeMeses = idadeAnos * 12;

            int idadeSemanas = (int)((DateTime.Today - dataNascimento).TotalDays / 7);

            int idadeDias = (int)(DateTime.Today - dataNascimento).TotalDays;

            list.Items.Clear();
            list.Items.Add($"Idade da Pessoa em anos: {idadeAnos}");
            list.Items.Add($"Idade da Pessoa em meses: {idadeMeses}");
            list.Items.Add($"Idade da Pessoa em semanas: {idadeSemanas}");
            list.Items.Add($"Idade da Pessoa em dias: {idadeDias}");

        }
    }
}