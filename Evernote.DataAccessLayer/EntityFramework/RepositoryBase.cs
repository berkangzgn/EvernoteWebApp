using Evernote.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataAccessLayer.EntityFramework
{
        // SingletonPattern : Bir projede çalışırken bir nesnenin sadece bir kopyası olmasını istiyorsak bu pattern'i kullanırız.
        
        // SingletonPattern yazmazsak DatabaseContext'i comment ve user için 2 kez new'lemeye zorluyoruz.
        // Ancak bu durumda birden fazla kez db oluşturmaya çalıştığı için program hata veriyor. Biz de bunun önüne geçmek için bu pattern'i yazdık.
    public class RepositoryBase
    {
        protected static DatabaseContext db;
        private static object _lock = new object();

            // Projenin new'lenmesini istemediğimiz için alttaki fonksiyonu yazıyoruz.
            // Miras alan sadece new'leyebilir.
        protected RepositoryBase()
        {
            CreateContext();
        }
            
            // Static yapma nedenimiz üstte yazdığımız protected'den kaynaklı new'leyemediğimiz için yazıyoruz.
        private static void CreateContext()
        {
            if (db == null)
            {
                    // Multithread (aynı anda birden çok iş yapan) programlar yazdığımızda if'in içerisine 2 iş parçacığı girip 2 kez new'leme yapabiliyor.
                    // Bunu önlemek için lock metodunu kullanıyoruz.
                lock (_lock)
                {
                    if(db == null)
                    {
                        db = new DatabaseContext();
                    }
                }
            }
        }
    }
}
