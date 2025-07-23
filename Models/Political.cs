using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace falastroes_no_comando.Models
{
    public class Political
    {
        public int IdPolitical { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Percent { get; set; }
        public string Status_2 { get; set; }
        public ICollection<Political_has_Proposal> political_Has_Proposals { get; set; }
    }
}