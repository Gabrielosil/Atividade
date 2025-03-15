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
                MessageBox.Show("Placa V�lida");
            }
            else
            {
                MessageBox.Show("Placa Inv�lida");
            }
        }

        private string FormatarPlaca(string placa)
        {
            // Remove todos os caracteres n�o alfanum�ricos
            placa = Regex.Replace(placa, @"[^a-zA-Z0-9]", "");

            // Adiciona o h�fen ap�s as tr�s primeiras letras
            if (placa.Length == 7)
            {
                placa = placa.Insert(3, "-");
            }

            return placa;
        }

        private bool ValidarPlaca(string placa)
        {
            // Express�o regular para validar o formato "aaa-1111" aceitando letras de "a-z" e n�meros de "0-9"
            string padrao = @"^[a-zA-Z]{3}-\d{4}$";
            return Regex.IsMatch(placa, padrao);
        }
    }
}