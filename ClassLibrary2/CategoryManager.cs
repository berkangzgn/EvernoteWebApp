using Evernote.DataAccessLayer.EntityFramework;
using Evernote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.BusinessLayer
{
    public class CategoryManager
    {
        //public override int Delete(EvernoteCategory category)
        //{
        //    NoteManager noteManager = new NoteManager();
        //    LikedManager likedManager = new LikedManager();
        //    CommentManager commentManager = new CommentManager();

        //    // Kategori ile ilişkili notların silinmesi gerekiyor.
        //    foreach (Note note in category.Notes.ToList())
        //    {

        //        // Note ile ilişikili like'ların silinmesi.
        //        foreach (Liked like in note.Likes.ToList())
        //        {
        //            likedManager.Delete(like);
        //        }

        //        // Note ile ilişkili comment'lerin silinmesi
        //        foreach (Comment comment in note.Comments.ToList())
        //        {
        //            commentManager.Delete(comment);
        //        }

        //        noteManager.Delete(note);
        //    }

        //    return base.Delete(category);
        //}

        private Repository<EvernoteCategory> repo_category = new Repository<EvernoteCategory>();
        
        public List<EvernoteCategory> GetEvernoteCategories()
        {
            return repo_category.List();
        }
    }
}