using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace falastroes_no_comando.Models
{
    public class Proposal
    {
        public int IdProposal { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public ICollection<Political_has_Proposal> Political_Has_Proposals { get; set; }
    }
}