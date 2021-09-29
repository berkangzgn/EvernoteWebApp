﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Evernote.DataAccessLayer;
using Evernote.DataAccessLayer.Abstract;
using Evernote.Entities;

namespace Evernote.DataAccessLayer.EntityFramework
{
        // T değişkenine integer vs tarzı değerler atamamaları için bu koşulu yazdık. T tipi class olmak zorunda
    class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;

        public Repository()
        {
            _objectSet = db.Set<T>();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }

            // Programcı kendi isteğine göre listeyi döndürebilmesi için List olarak değil IQuerable olarak tanımlayabiliriz.
        public List<T> List(Expression<Func<T,bool>>where)
        {
            return _objectSet.Where(where).ToList();
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {
            return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

            // Sadece Repository class içerisinde kullanılabilmesi için private olarak kullandık.
        public int Save()
        {
            return db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
    }
}