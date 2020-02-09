 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateGentelella.Models
{
    public class PacienteClinica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}