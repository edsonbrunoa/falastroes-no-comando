using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace falastroes_no_comando.Models
{
    public class Political_has_Proposal
    {
        [Key]
        public int IdPolitical_has_Proposal { get; set; }
        public int IdPolitical { get; set; }
        public int IdProposal { get; set; }
        public Political Political { get; set; }
        public Proposal Proposal { get; set; }


    }
}