namespace BlocoDeNotas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvarOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string Caminho = saveFileDialog1.FileName;
            File.WriteAllText(Caminho, txbJanela.Text);
        }
    }
}