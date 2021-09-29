using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataAccessLayer.MySql
{
    class RepositoryBase
    {
    }

    //protected static DatabaseContext db;
    //private static object _lock = new object();

    //// Projenin new'lenmesini istemediğimiz için alttaki fonksiyonu yazıyoruz.
    //// Miras alan sadece new'leyebilir.

    //protected RepositoryBase()
    //{
    //    CreateContext();
    //}

    //// Static yapma nedenimiz üstte yazdığımız protected'den kaynaklı new'leyemediğimiz için yazıyoruz.
    //private static void CreateContext()
    //{
    //    if (db == null)
    //    {
    //        // Multithread (aynı anda birden çok iş yapan) programlar yazdığımızda if'in içerisine 2 iş parçacığı girip 2 kez new'leme yapabiliyor.
    //        // Bunu önlemek için lock metodunu kullanıyoruz.
    //        lock (_lock)
    //        {
    //            if (db == null)
    //            {
    //                db = new DatabaseContext();
    //            }
    //        }
    //    }
    //}
}
