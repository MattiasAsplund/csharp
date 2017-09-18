using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public class Cirkus
    {
        private string namn;
        private Dictionary<Artist, int> ArtistFöreställningarDictionary = 
            new Dictionary<Artist, int>();
        public Cirkus(string namn)
        {
            this.namn = namn;
        }

        public void Anställ(Artist artist)
        {
            ArtistFöreställningarDictionary.Add(artist, 0);
        }

        public void ArtistUppträdande(Artist artist)
        {
            ArtistFöreställningarDictionary[artist]++;
        }

        public override string ToString()
        {
            var message = $"Cirkusen {this.namn} har {this.AntalArtister} artister.";
            foreach (var artistFöreställningarEntry in ArtistFöreställningarDictionary)
            {
                string gånger = "gång";
                if (artistFöreställningarEntry.Value > 1)
                    gånger += "er";
                message += $" {artistFöreställningarEntry.Key.namn} har uppträtt {artistFöreställningarEntry.Value} {gånger}.";
            }
            Debug.WriteLine(message);
            return message;
        }

        public int AntalArtister
        {
            get
            {
                return this.ArtistFöreställningarDictionary.Count;
            }
        }
    }
}
