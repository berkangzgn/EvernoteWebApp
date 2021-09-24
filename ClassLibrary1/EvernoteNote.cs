using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Evernote.Entities
{
    [Table("Notes")]
    public class EvernoteNote : EntityBase
    {
        [Required, StringLength(20)]
        public string Title { get; set; }
        
        [Required, StringLength(200)]
        public string Text { get; set; }
        
        public bool IsDraft { get; set; }
        
        public int LikeCount { get; set; }
        
        public int CategoryId { get; set; }

            // Bir kullanıcının birden çok notu olabilir ama bir notun bir kullanıcısı olacağı için list olarak tutmadık.
        public virtual EvernoteUser Owner { get; set; }
        public virtual EvernoteCategory EvernoteCategory { get; set; }
        public virtual List<EvernoteComment> Comments { get; set; }
        public virtual List<EvernoteLiked> Likes { get; set; }

        public EvernoteNote()
        {
            Comments = new List<EvernoteComment>();
            Likes = new List<EvernoteLiked>();
        }
    }
}
