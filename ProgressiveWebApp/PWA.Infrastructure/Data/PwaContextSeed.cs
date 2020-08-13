using Microsoft.EntityFrameworkCore;
using PWA.Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace PWA.Infrastructure.Data
{
    public class PwaContextSeed
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new List<Game>()
                {
                    new Game() { 
                        Id = new Guid("df36357f-84d6-452f-8780-abc6eca660c8"), 
                        CreatedDate = new DateTime(2020, 08, 13), 
                        Title = "Duolingo: Учи языки бесплатно",  
                        Description = "Дуолинго - самое популярное приложение в мире в категории “Обучение”. Присоединяйся и учи английский язык! С нами уже более 150 млн. человек!",
                        Rate = 4.7,
                        CreatedBy = "system",
                        Url = "https://play.google.com/store/apps/details?id=com.duolingo"
                    },
                    new Game() {
                        Id = new Guid("ed755eab-4719-4f73-93bc-631d624a9319"),
                        CreatedDate = new DateTime(2020, 08, 13),
                        Title = "inDriver - Выгоднее, чем такси",
                        Description = "Используйте альтернативный заказ такси онлайн в Нур-Султане, Алматы и более 300 городах в 31 стране мира. Лучшее приложение, чтобы экономить на городских поездках и в междугородних путешествиях по стране.",
                        Rate = 4.6,
                        CreatedBy = "system",
                        Url = "https://play.google.com/store/apps/details?id=sinet.startup.inDriver"
                    },
                    new Game() {
                        Id = new Guid("f285207d-839e-490d-897e-ac44222eecf0"),
                        CreatedDate = new DateTime(2020, 08, 13),
                        Title = "Udemy - онлайн-курсы",
                        Description = "Udemy — образовательная онлайн-платформа предлагает более 130 000 видеокурсов, созданных опытными преподавателями.",
                        Rate = 4.4,
                        CreatedBy = "system",
                        Url = "https://play.google.com/store/apps/details?id=com.udemy.android"
                    }
                }
            ); 
            modelBuilder.Entity<Comment>().HasData(
                new List<Comment>()
                {
                    new Comment()
                    {
                        CommentId = new Guid("8511af97-53ef-4cf7-9516-311ceb65abd5"),
                        GameId = new Guid("df36357f-84d6-452f-8780-abc6eca660c8"),
                        UserId = new Guid("74239187-19ab-4b09-9d91-559371ebfb0d"),
                        CreatedBy = "system",
                        CreatedDate = new DateTime(2020, 08, 13),
                        Text = "Отличное приложение, но из-за бага в японском языке, на Hiragana 4, правильный ответ дублируется и выбор между ними словно лотерея, или ты выбрал правильный правильный ответ, или ты выбрал не тот правильный ответ, так что жизнь у тебя мы отберём. Все 4 раза мимо за один тест.",
                        Rate = 5
                    },
                    new Comment()
                    {
                        CommentId = new Guid("f741b418-c84d-497b-a1a6-ca3b6f59145c"),
                        GameId = new Guid("f285207d-839e-490d-897e-ac44222eecf0"),
                        UserId = new Guid("2570cebf-25a8-49ed-be0a-3b28c26278be"),
                        CreatedBy = "system",
                        CreatedDate = new DateTime(2020, 08, 13),
                        Text = "Купила курс, на почту пришла благодарность в смс оповещение, но в программе нет ни одного смс. При попытке связаться с автором не нашла ,как это сделать ,соответственно. и как скачать уроки . Плюс сайт не работает ,как и приложение. Никуда написать не могу. Господа, ответьте...",
                        Rate = 1
                    }
                }
            );
        }
    }
}
