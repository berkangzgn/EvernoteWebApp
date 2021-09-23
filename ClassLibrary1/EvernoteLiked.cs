using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Evernote.Entities
{
    [Table("Likes")]
    public class EvernoteLiked
    {
            // Id'yi miras EntityBase aracılığıyla miras da alabilirdik, diğer özellikleri istemediğimiz için yapmadık. 
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public virtual EvernoteNote Note { get; set; }
        public virtual EvernoteUser LikedUser { get; set; }
    }
}
