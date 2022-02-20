using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020ne.DataAccess.Core.Models
{
    [Table("User")] //аннотация    
    public class UserRto
    {
        [Key]  public int Id { get; set; }
        public long PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }



        #region Relationship Scheme
        public List<UserGameRto> UserGames { get; set; }
        #endregion
    }
}
