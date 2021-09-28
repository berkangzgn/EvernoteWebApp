using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Evernote.Entities
{
    [Table("Comments")]
    public class EvernoteComment : EntityBase
    {
        [Required, StringLength(150)]
        public string Text { get; set; }

        public virtual EvernoteNote Note { get; set; }
        public virtual EvernoteUser Owner { get; set; }
    }
}
