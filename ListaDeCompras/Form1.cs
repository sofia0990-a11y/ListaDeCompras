using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //verificar se txbproduto está vazio:
            if (txbprodutos.Text.Length == 0)
            {
                MessageBox.Show("O nome do produto não pode estar  vazia!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Mudar cordo fundo e a cor da letra:
                txbprodutos.BackColor = Color.Red;
                txbprodutos.BackColor = Color.White;

            } else if (txbprodutos.Text.Length <2)

            {
                MessageBox.Show("O nome do produto precisa ter no minimo duas letras",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                  //verificar se o item está na lista:
                  if(libCompras.Items.Contains(txbprodutos.Text))
                {
                    MessageBox.Show($" já Existe{txbprodutos.Text} na lista!",
                      "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                  // Adicionar o item na lista
             libCompras.Items.Add(txbprodutos.Text);
                MessageBox.Show($"{txbprodutos.Text} foi adicionado na lista de compras!",
                 "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar o campo:
                txbprodutos.Text = "";
                txbprodutos.Clear();

                //Retornar a cor normal
                txbprodutos.BackColor = Color.White;
                txbprodutos.BackColor= Color.Black;

                //Limpar o campo
                txbprodutos.Text = "";
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("tem certeza que deseja apagar tudo? ",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // se optar por sim apagar
            if(resposta == DialogResult.Yes)
            {
                libCompras.Items.Clear();
            }



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {   
            //verificar se o usuario não inseriu nada:
            if (libCompras.SelectedIndex == -1) 
            {
                MessageBox.Show("Selicione um item para remover!",
                 "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {      
                // Salvar temporariamente o nome do item que será removido:
                string itemremovido = libCompras.SelectedItem.ToString();
                
                //Remover item selecionado:
                libCompras.Items.Remove(libCompras.SelectedIndex);
                MessageBox.Show($" O item já foi removido da lista!",
                      "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txbprodutos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                 //pressionar o btn Adicionar:
                 btnAdicionar.PerformClick();
            }
        }
    }
}
