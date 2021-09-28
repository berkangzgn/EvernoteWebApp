using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Evernote.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
            // Notu oluştuuran kullanıcı silindiğinde veya beklenmeyen bir olay geliştiğinde vs db tarafında sorun yaşamamak için kullanıcıya daha rahat ulaşabilmek için username tutuyoruz.
            // Zaten kullanıcıya özgün olacağı için db tarafından ulaşmak daha kolay olur. 
        public string ModifiedUsername { get; set; }
    }
}
