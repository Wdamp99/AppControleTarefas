namespace ControleTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tarefa = txtTarefa.Text;
            string dataLimite = dateDataLimite.Text;

            dataGridView.Rows.Add(tarefa, dataLimite);

            txtTarefa.Text = "";
            dateDataLimite.Text = "";
            salvarDados();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja continuar?", "Confirmação", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                    salvarDados();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.");
            }
        }
        private void salvarDados()
        {
            using (StreamWriter sw = new StreamWriter("dados.txt"))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string linha = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            linha += cell.Value.ToString() + ";";
                        }
                        sw.WriteLine(linha.TrimEnd(';'));
                    }
                }
            }
        }

        private void carregarDados()
        {
            if (File.Exists("dados.txt"))
            {
                using (StreamReader sr = new StreamReader("dados.txt"))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] valores = linha.Split(';');

                        if (valores.Length == dataGridView.ColumnCount)
                            dataGridView.Rows.Add(valores);
                        else
                        {
                            MessageBox.Show("O número de colunas no arquivo não corresponde ao DataGridView.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo especificado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}