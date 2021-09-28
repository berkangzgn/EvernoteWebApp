using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Evernote.Entities;

namespace Evernote.DataAccessLayer
{   
    public class Initializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
            // Seed : Db oluştuktan sonra örnek data basılırken kullanılır
        protected override void Seed(DatabaseContext context)
        {
                // Adding admin
            EvernoteUser admin = new EvernoteUser()
            {
                Name            = "Berkan",
                Surname         = "Gezgin",
                Email           = "bgezgin@protonmail.com",
                ActivateGuid    = Guid.NewGuid(),
                IsActive        = true,
                IsAdmin         = true,
                Username        = "bgezgin",
                Password        = "1234.",
                CreatedOn       = DateTime.Now,
                ModifiedOn      = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "bgezgin"
            };
                // Adding admin to db
            context.Users.Add(admin);

                // Adding standart user
            EvernoteUser standartUser = new EvernoteUser()
            {
                Name            = "Berkan",
                Surname         = "Gezgin",
                Email           = "bgerkanezgin.bg2014@gmail.com",
                ActivateGuid    = Guid.NewGuid(),
                IsActive        = true,
                IsAdmin         = false,
                Username        = "berkang",
                Password        = "1234.",
                CreatedOn       = DateTime.Now.AddHours(1),
                ModifiedOn      = DateTime.Now.AddMinutes(65),
                ModifiedUsername = "berkang"
            };
                // Adding users to db
            context.Users.Add(standartUser);

                // Adding user
            for (int i = 0; i < 8; i++)
            {
                EvernoteUser user = new EvernoteUser()
                {
                    Name            = FakeData.NameData.GetFirstName(),
                    Surname         = FakeData.NameData.GetSurname(),
                    Email           = FakeData.NetworkData.GetEmail(),
                    ActivateGuid    = Guid.NewGuid(),
                    IsActive        = true,
                    IsAdmin         = false,
                    Username        = $"user{i}",
                    Password        = "1234.",
                    CreatedOn       = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedOn      = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedUsername = $"user{i}"
                };
                    // Adding users to db
                context.Users.Add(user);
            }
            context.SaveChanges();

            // User list for using
            List<EvernoteUser> userlist = context.Users.ToList();
                // Adding category
            for (int i = 0; i < 10; i++)
            {
                EvernoteCategory category = new EvernoteCategory()
                {
                    Title       = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    CreatedOn   = DateTime.Now,
                    ModifiedOn  = DateTime.Now,
                    ModifiedUsername = "bgezgin",
                };
                context.Categories.Add(category);
                
                

                    // Adding notes
                for (int k = 0; k < FakeData.NumberData.GetNumber(5,9); k++)
                {
                    EvernoteUser owner = userlist[FakeData.NumberData.GetNumber(0, 6)];
                    
                    EvernoteNote note = new EvernoteNote()
                    {
                        Title       = FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5,25)),
                        Text        = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1,3)),
                        IsDraft     = false,
                        LikeCount   = FakeData.NumberData.GetNumber(1,9),
                            // Yazarına kişiler listesinden random kişi atıyoruz
                        Owner       = owner,
                        CreatedOn   = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedOn  = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedUsername = owner.Username,
                    };
                    category.Notes.Add(note);

                        // Adding comments
                    for (int j = 0; j < FakeData.NumberData.GetNumber(3,5); j++)
                    {
                        EvernoteUser comment_owner = userlist[FakeData.NumberData.GetNumber(0, userlist.Count - 1)];

                        EvernoteComment comment = new EvernoteComment()
                        {
                            Text        = FakeData.TextData.GetSentence(),
                            Owner       = comment_owner,
                            CreatedOn   = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedOn  = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedUsername = comment_owner.Username,
                        };
                        note.Comments.Add(comment);
                    }

                        // Adding likes
                    for (int m = 0; m < note.LikeCount; m++)
                    {
                        EvernoteLiked liked = new EvernoteLiked()
                        {
                            LikedUser = userlist[m]
                        };
                        note.Likes.Add(liked);
                    }
                }
            }
                // SaveChanges çalışmadığı sürece verileri insert etmiş sayılmayız.
            context.SaveChanges();
        }
    }
}
