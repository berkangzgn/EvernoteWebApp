using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Evernote.Entities
{
    public class EvernoteCategory : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }

            // Başka class'la ilgili olduğu için virtual olarak tanımladık.
        public virtual List<EvernoteNote> Notes { get; set; }
    }
}
