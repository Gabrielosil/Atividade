using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _1Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            placa = FormatarPlaca(placa);

            if (ValidarPlaca(placa))
            {
                MessageBox.Show("Placa Válida");
            }
            else
            {
                MessageBox.Show("Placa Inválida");
            }
        }

        private string FormatarPlaca(string placa)
        {
            // Remove todos os caracteres não alfanuméricos
            placa = Regex.Replace(placa, @"[^a-zA-Z0-9]", "");

            // Adiciona o hífen após as três primeiras letras
            if (placa.Length == 7)
            {
                placa = placa.Insert(3, "-");
            }

            return placa;
        }

        private bool ValidarPlaca(string placa)
        {
            // Expressão regular para validar o formato "aaa-1111" aceitando letras de "a-z" e números de "0-9"
            string padrao = @"^[a-zA-Z]{3}-\d{4}$";
            return Regex.IsMatch(placa, padrao);
        }
    }
}