using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCommerce.Objets
{
    internal class Jeton
    {
        private int _id;
        private string _numtag;
        private string _nom;
        private DateTime _date;

        public Jeton(int id, string numtag, string nom, DateTime date)
        {
            _id = id;
            _numtag = numtag;
            _nom = nom;
            _date = date;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Numtag
        {
            get { return _numtag; }
            set { _numtag = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
