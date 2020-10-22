using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Venezia.Models
{
    [Table("utilisateur", Schema = "venezia")]
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Nom utilisateur", Prompt = "Votre identité sur internet")]
        public string Username { get; set; }

        [Display(Name = "Mot de passe", Prompt = "Votre mot de passe super secret")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Prompt = "Votre email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Statut administrateur")]
        public bool IsAdmin { get; set; }
    }
}