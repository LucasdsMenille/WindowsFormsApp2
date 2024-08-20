using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as caixas de texto
            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            lstProdutos.Items.Clear();
            totalCompra = 0;
            lblTotal.Text = "Total: R$0,00";


            //Move o texto para zero na Label
            lblTotal.Text = "0";

            //Move o cursor para o text box
            txtProduto.Focus();

        }

        public void btnInserir_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos TextBoxes
            string nomeProduto = txtProduto.Text;
            string qtdeProduto = txtQtde.Text;
            string precoProduto = txtValor.Text;

            // Verifica se os campos não estão vazios
            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(precoProduto))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(precoProduto))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Tenta converter o preço para decimal
            if (decimal.TryParse(precoProduto, out decimal preco))
            {
                // Adiciona o produto à lista
                string produto = $"Nome: {nomeProduto},Quantidade: R${qtdeProduto:F2} Preço: R${preco:F2}";
                lstProdutos.Items.Add(produto);

                // Atualiza o total da compra
                AtualizarTotal(preco);

                // Limpa os campos após adicionar
                txtProduto.Clear();
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("O preço deve ser um valor numérico válido.");
            }
        }

        private decimal totalCompra = 0;

        private void AtualizarTotal(decimal precoProduto)
        {
            totalCompra += precoProduto;
            lblTotal.Text = $"Total: R${totalCompra:F2}";
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
