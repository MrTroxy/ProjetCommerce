using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCommerce.Objets
{
    internal class Produit
    {
        private int _id;
        private string _nom;
        private string _description;
        private double _prix;
        private int _quantite;

        public Produit(int id, string nom, string description, double prix, int quantite)
        {
            _id = id;
            _nom = nom;
            _description = description;
            _prix = prix;
            _quantite = quantite;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Quantite
        {
            get { return _quantite; }
        }
        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
    }
}
