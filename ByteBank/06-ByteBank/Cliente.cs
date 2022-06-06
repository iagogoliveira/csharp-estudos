﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string Cpf {
            get
            {
                return _cpf;
            }
            set
            {
                //Escrever a lógica de validação do cpf
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
