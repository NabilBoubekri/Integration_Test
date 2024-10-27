using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_Unitaire_1
{
    public interface IUser
    {
        public bool add(Item item);
        public bool isValid();
        public bool save();

    }
    public class User:IUser
    {
        public string? email {  get; set; }
        public string? nom { get; set; }
        public string? prenom { get; set; }
        public string? password { get; set; }
        public DateTime date_Naissance;
        public List<Item> Items;

        public User() { }

        public User(string email, string nom, string prenom, DateTime date_Naissance, string password)
        {
            this.email = email;
            this.nom = nom;
            this.prenom = prenom;
            this.date_Naissance = date_Naissance;
            this.password = password;
            Items = new List<Item>();
        }
        public bool add(Item item)
        {
            foreach (Item unItem in Items)
            {
                if(unItem.name == item.name)
                {
                    return false;
                }
            }
            if (Items.Count > 10)
            {
                return false;
            }
            if (Items.Count > 0)
            {
                if ((item.dateCreation - Items[Items.Count - 1].dateCreation).TotalMinutes < 30 || !isValid())
                {
                    return false;
                }
            }
            Items.Add(item);
            if(Items.Count == 8)
            {
                sendEmail();
            }
            return true;
        }

        public bool isValid()
        {
            if (string.IsNullOrEmpty(email) || 
                string.IsNullOrEmpty(this.prenom) || 
                string.IsNullOrEmpty(this.nom) || string.IsNullOrEmpty(this.password))
            {
                return false;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(this.email);
            bool validPassword = this.password.Any(char.IsDigit) && 
                this.password.Any(char.IsLower) && 
                this.password.Any(char.IsUpper) && 
                (this.password.Length>=8 && this.password.Length<=40);
            if (match.Success && DateTime.Now.Year - date_Naissance.Year > 13 && validPassword)
            {
                return true;
            }
            return false;
        }
        public virtual bool save()
        {
            throw new InvalidOperationException("Methode n'existe pas");
        }
        public virtual bool sendEmail()
        {
            throw new InvalidOperationException("Methode n'existe pas");
        }
    }
}
