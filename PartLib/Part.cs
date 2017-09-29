using System;

namespace PartLib
{
    public class Part
    {
        public Part(string name, string juridicalId)
        {
            this.Name = name;
            this.JuridicalId = juridicalId;
        }
        public string Name { get; set; }
        public string JuridicalId { get; set; }
        public override string ToString()
        {
            return $"{Name} ({JuridicalId})";
        }
    }
}
