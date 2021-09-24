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
            // Seed : Db oluştuktan sonrs örnek data basılırken kullanılır
        protected override void Seed(DatabaseContext context)
        {
                // Adding admin
            EvernoteUser admin = new EvernoteUser()
            {
                Name = "Berkan",
                Surname = "Gezgin",
                Email = "bgezgin@protonmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "bgezgin",
                Password = "1234.",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "bgezgin"
            };

                // Adding standart user
            EvernoteUser standartUser = new EvernoteUser()
            {
                Name = "Berkan",
                Surname = "Gezgin",
                Email = "bgerkanezgin.bg2014@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "berkang",
                Password = "1234.",
                CreatedOn = DateTime.Now.AddHours(1),
                ModifiedOn = DateTime.Now.AddMinutes(65),
                ModifiedUsername = "berkang"
            };
                // Adding users to db
            context.Users.Add(admin);
            context.Users.Add(standartUser);

                // Adding user
            for (int i = 0; i < 8; i++)
            {
                EvernoteUser user = new EvernoteUser()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Email = FakeData.NetworkData.GetEmail(),
                    ActivateGuid = Guid.NewGuid(),
                    IsActive = true,
                    IsAdmin = true,
                    Username = $"user{i}",
                    Password = "1234.",
                    CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedUsername = $"user{i}"
                };
                context.Users.Add(user);
            }
            context.SaveChanges();

                // Adding category
            for (int i = 0; i < 10; i++)
            {
                EvernoteCategory category = new EvernoteCategory()
                {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedUsername = "bgezgin",
                };

                    // Adding notes
                for (int k = 0; k < FakeData.NumberData.GetNumber(4,8); k++)
                {
                    EvernoteNote note = new EvernoteNote()
                    {
                        Title = FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5,25)),
                        Text = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1,3)),
                        IsDraft = false,
                        LikeCount = FakeData.NumberData.GetNumber(0,200),
                            // Yazarına bi admin bi standart kullanıcı atıyoruz
                        Owner = (k%2==0)?admin:standartUser,
                        CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedUsername = (k % 2 == 0) ? admin.Username : standartUser.Username
                    };
                    category.Notes.Add(note);

                    // Adding comments
                    for (int j = 0; j < FakeData.NumberData.GetNumber(3,5); j++)
                    {
                        EvernoteComment comment = new EvernoteComment()
                        {
                            Text = FakeData.TextData.GetSentence(),
                            Owner = (j % 2 == 0) ? admin : standartUser,
                            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedUsername = (j % 2 == 0) ? admin.Username : standartUser.Username
                        };
                        note.Comments.Add(comment);
                    }
                }
            }
        }
    }
}
