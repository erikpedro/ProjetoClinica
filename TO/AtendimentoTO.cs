using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class AtendimentoTO {

        public PacienteTO Paciente { get; set; }
        public int Id { get; set; }

        public int Anamnese { get; set; }

        public int ExameFisico { get; set; }

        public string CIDPrincipal { get; set; }
   



    }

}
