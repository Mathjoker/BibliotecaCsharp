using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models {
    internal class Funcionarios :Pessoa{

        public int Matricula { get; set; }
        public String Cargo { get; set; }


        public Funcionarios() {

        }

        public Funcionarios(string nome, DateTime dataNascimento, string cPF, string email, string senha, string telefone, int matricula, String cargo) 
            : base(nome, dataNascimento, cPF, email, senha, telefone){
            Matricula = matricula;
            Cargo = cargo;
        }


    }
}
