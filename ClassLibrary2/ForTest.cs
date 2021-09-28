using Evernote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.BusinessLayer
{
    public class ForTest
    {
        public ForTest()
        {
            //DataAccessLayer.DatabaseContext db = new DataAccessLayer.DatabaseContext();
            //    // Database tablo çağırarak oluşturmak için;
            //    // CreateIfNotExists Db çağırır ama örnek data oluşumunu tetiklemez
            //// db.Database.CreateIfNotExists();
            //db.Categories.ToList();

            Repository<EvernoteCategory> repo = new Repository<EvernoteCategory>();
            repo.List();
        }
    }
}
