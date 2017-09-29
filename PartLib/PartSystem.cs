using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartLib
{
    public class PartSystem
    {
        private List<Part> Parts = new List<Part>();
        private List<Accountability> Accountabilities 
            = new List<Accountability>();

        public int NumberOfParts {
            get
            {
                return Parts.Count;
            }
        }

        public int NumberOfAccountabilites {
            get
            {
                return Accountabilities.Count;
            }
        }

        public void AddPart(Part part)
        {
            Parts.Add(part);
        }
        public void AddAccountability(Accountability accountability)
        {
            Accountabilities.Add(accountability);
        }

        public List<Accountability> ResponsibilitesByParty(Part part)
        {
            return Accountabilities.Where(acc =>
                acc.responsible.JuridicalId == part.JuridicalId)
                .ToList();
        }
    }
}
