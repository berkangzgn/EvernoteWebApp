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
        private Repository<EvernoteUser> repo_user = new Repository<EvernoteUser>();
        private Repository<EvernoteCategory> repo_category = new Repository<EvernoteCategory>();
        private Repository<EvernoteComment> repo_comment = new Repository<EvernoteComment>();
        private Repository<EvernoteNote> repo_note = new Repository<EvernoteNote>();

        public ForTest()
        {
            //DataAccessLayer.DatabaseContext db = new DataAccessLayer.DatabaseContext();
            //    // Database tablo çağırarak oluşturmak için;
            //    // CreateIfNotExists Db çağırır ama örnek data oluşumunu tetiklemez
            //// db.Database.CreateIfNotExists();
            //db.Categories.ToList();

            List<EvernoteCategory> categories = repo_category.List();
                // Koşullu List
            List<EvernoteCategory> categories_filt = repo_category.List(x => x.Id >5);
        }

        public void InsertTest()
        {
            int result = repo_user.Insert(new EvernoteUser() 
            {
                Name = "deneme",
                Surname = "deneme2",
                Email = "bgerkanezgin.bg2014@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                Username = "deneme",
                Password = "1234.",
                CreatedOn = DateTime.Now.AddHours(1),
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "den"
            });
        }

            // Save/savechanges metodu sadece update üzerinde çağırılır. if içeriisindeki " .Update(user) " yerine " .Save() " şeklinde kullanılabilir.
        public void UpdateTest()
        {
            EvernoteUser user = repo_user.Find(x => x.Username == "deneme");
            if ( user != null)
            {
                user.Username = "xx";
                int result = repo_user.Update(user);
            }
        }

        public void DeleteTest()
        {
            EvernoteUser user = repo_user.Find(x => x.Username == "xx");
            if (repo_user != null) 
            {
                int result = repo_user.Delete(user);
            }
        }

        public void CommentTest()
        {
            EvernoteUser owner = repo_user.Find(x => x.Id == 1);
            EvernoteNote note = repo_note.Find(x => x.Id == 3);

            EvernoteComment comment = new EvernoteComment() 
            {
                Text = "deneme", 
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "berkang",
                Note = note,
                Owner = owner
            };

            repo_comment.Insert(comment);
        }
    }
}