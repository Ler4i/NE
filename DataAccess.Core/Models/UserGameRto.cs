using System.ComponentModel.DataAnnotations.Schema;

namespace PS223020ne.DataAccess.Core.Models
{
    [Table("UserGame")]
    public class UserGameRto
    {
        public int Id { get; set; }


        public int UserId { get; set; }
        public UserRto User { get; set; }

        public int GameId { get; set; }
        public GameRto Games { get; set; }
    }
}
