using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Evernote.Entities
{
    [Table("Categories")]
    public class EvernoteCategory : EntityBase
    {
        [Required, StringLength(200)]
        public string Title { get; set; }
        
        [StringLength(200)]
        public string Description { get; set; }

            // Başka class'la ilgili olduğu için virtual olarak tanımladık.
        public virtual List<EvernoteNote> Notes { get; set; }
        
            // Otomatik olarak listeyi oluşturuyoruz. Veri eklerken null hatası almamak istiyoruz
        public EvernoteCategory()
        {
            Notes = new List<EvernoteNote>();
        }
    }
}
