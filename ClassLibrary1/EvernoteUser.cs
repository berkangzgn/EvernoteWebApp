using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Evernote.Entities
{
    public class EvernoteUser : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
            // Kullanıcıyı aktif etmek için göndereceğimiz mail linki evernote.com/user/active/1 gibi bir link olursa güvensiz ortam oluşacağından dolayı böyle bir link kullanamayız.
            // Bu yüzden guid kullanmamız gerekiyor.
        public bool IsActive { get; set; }
        public Guid ActivateGuid { get; set; }
        public bool IsAdmin { get; set; }

            // 1'e *, *'a 1 ya da *'a * ilişkilerde bu ilişkiyi alttaki satırla tanımlayabiliriz.
        public virtual List<EvernoteNote> Notes { get; set; }
        public virtual List<EvernoteComment> Comments { get; set; }
        public virtual List<EvernoteLiked> Likes { get; set; }
    }
}
