using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateGentelella.Models
{
    public class PacienteClinicaPlanoSaude
    {
        public int Id { get; set; }
        public int PacienteClinicaId { get; set; }
        public string PlanoSaude { get; set; }
        public float ValorLiberado { get; set; }
    }
}