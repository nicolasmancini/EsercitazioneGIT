using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGIT
{
    class Brano
    {
        private string _titolo;
        private string _autore;
        public string Titolo { get; set; }
        public string Autore { get; set; }
        private float _durata;
        public float Durata
        {
            get
            {
                return _durata;
            }
            set
            {
                if (value > 0)
                    _durata = value;
                else
                    throw new Exception("Errore");
            }
        }
        public Brano(float durata,string titolo,string autore)
        {
            Durata = durata;
            Titolo = titolo;
            Autore = autore;
        }
        public bool ShortSong(float durata)
        {
            if (_durata < durata)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return Durata +" "+ Titolo +" "+ Autore;
        }

    }
}
