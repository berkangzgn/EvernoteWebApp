using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Evernote.Entities
{
    public class EvernoteLiked
    {
            // Id'yi miras EntityBase aracılığıyla miras da alabilirdik, diğer özellikleri istemediğimiz için yapmadık. 
        public int Id { get; set; }
        
        public virtual EvernoteNote Note { get; set; }
        public virtual EvernoteUser LikedUser { get; set; }
    }
}
