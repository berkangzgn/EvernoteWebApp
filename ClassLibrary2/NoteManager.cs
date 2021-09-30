using Evernote.DataAccessLayer.EntityFramework;
using Evernote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.BusinessLayer
{
    public class NoteManager
    {
        private Repository<EvernoteNote> repo_note = new Repository<EvernoteNote>();

        public List<EvernoteNote> GetAllNote()
        {
            return repo_note.List();
        }
    }
}
