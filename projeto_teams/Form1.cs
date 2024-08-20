namespace projeto_teams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            //adiciona os itens manualmewnte no combo box
            combo.Items.Add(txttexto.Text);
            //exibe a qtd de itens bno combo box
            txtqtd.Text = combo.Items.Count.ToString();

            txttexto.Clear();
            //move o foco para a caiuxa de texto
            txttexto.Select();
        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            //ordena a lista no combo
            combo.Sorted = true;
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (combo.SelectedIndex != -1)
            {
                combo.Items.RemoveAt(combo.SelectedIndex);

                txtqtd.Text = combo.Items.Count.ToString();

                combo.ResetText();
            }
        }

        private void dados_Click(object sender, EventArgs e)
        {
            if(combo.SelectedIndex != -1) 
            {
                //exibe o indice do combo 
                txtcombo.Text= combo.Items.Count.ToString(); 
                //exibe o texto do combo 
                txttexc.Text = combo.Items.Count.ToString();
            }
        }
    }
}
