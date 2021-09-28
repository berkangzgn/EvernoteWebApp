using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evernote.Entities
{
    public class EntityBase
    {
            // PrimaryKey olması için [Key], otomatik artması için [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
            
            // [Required] - Boş geçilemez olmasını istiyorsak bu anahtar kelimeyi eklemeliyiz. Ancak DataTime zaten boş geçilemez
        public DateTime CreatedOn { get; set; }
        
        public DateTime ModifiedOn { get; set; }
            
            // Notu oluştuuran kullanıcı silindiğinde veya beklenmeyen bir olay geliştiğinde vs db tarafında sorun yaşamamak için kullanıcıya daha rahat ulaşabilmek için username tutuyoruz.
            // Zaten kullanıcıya özgün olacağı için db tarafından ulaşmak daha kolay olur. 
        [Required, StringLength(30)]
        public string ModifiedUsername { get; set; }
    }
}
