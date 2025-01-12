﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;


namespace Biblioteca.Services
{
    public class Controller
    {
        public bool ValidarEmail(string email)
        {
            // Cria a expressao regular de validacao
            string regexEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, regexEmail, RegexOptions.IgnoreCase); 
        }

        public bool ValidarCPF(string cpf)
        {
            // Cria a expressao regular de validacao
            string regexCPF = @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$";
            return Regex.IsMatch(cpf, regexCPF, RegexOptions.IgnoreCase);
        }

        public void Cancelar()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {
                //Chama a tela principal
                Form1 form = new Form1();
                form.Show();
            }
        }

    }
}
