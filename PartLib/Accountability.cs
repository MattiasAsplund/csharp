using System;
using System.Collections.Generic;
using System.Text;

namespace PartLib
{
    public class Accountability
    {
        public Part commissioner;
        public Part responsible;
        public string roleName;

        public Accountability(Part commissioner, 
            Part responsible,
            string roleName)
        {
            this.commissioner = commissioner;
            this.responsible = responsible;
            this.roleName = roleName;
        }
        public override string ToString()
        {
            return $"{responsible.Name}, {roleName} på {commissioner.Name}";
        }
    }
}
