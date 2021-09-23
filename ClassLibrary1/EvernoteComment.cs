using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Evernote.Entities
{
    public class EvernoteComment : EntityBase
    {
        public string Text { get; set; }

        public virtual EvernoteNote Note { get; set; }
        public virtual EvernoteUser Owner { get; set; }
    }
}
