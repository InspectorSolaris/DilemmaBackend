using Dilemma.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Dilemma.DAL.Context
{
    public static class DilemmaDbContextSeed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var dilemmas = new List<Models.Dilemma>()
            {
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Знакомая вам пара сознательно отказывается заводить детей и выбирает карьеру и жизнь в свое удовольствие. Как вы к этому отнесетесь?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Пара расстается после известия о беременности. Из-за этого девушка решает сделать аборт. Какова будет ваша реакция на поступок?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Пара расстается после известия о беременности. Из-за этого девушка решает сделать аборт. Какова будет ваша реакция на поступок?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Вы увидели синяки у вашей соседки. Каковы будут ваши действия?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Ваш приятель рассказал, что наконец-то нашёл занятие себе по душе - стал видеоблоггером. Одобрите ли вы такой выбор?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Вы узнаёте, что ваш однокурсник получил выгодное предложение о работе за границей и собирается переехать, а в перспективе - получить гражданство. Поддержите ли вы его решение?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Вы узнаёте из новостей, что известный стенд-ап комик был оштрафован за неуместную шутку, оскорбляющую чувства верующих людей. Каково будет ваше отношение к этой ситуации?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Встретившись со своим приятелем, вы узнаёте, что его совершеннолетний сын решил совершить трансгендерный переход, приятель поддерживает это решение. Как вы отнесётесь к данной ситуации?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Вы - врач-акушер, принимаете роды. Женщина находится в критическом состоянии, но ее еще можно спасти, однако ребенок умрет. Если вы решите спасти ребенка, то умрет женщина. Какой вариант вы выберите?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "Вы являетесь начальником отдела в компании. Сверху поступает требование сократить одного сотрудника, так как компания столкнулась с финансовыми трудностями. В вашем отделе, помимо вас, работает два человека. Первый сотрудник - женщина, которая, по объективным показателям эффективности работает хуже, однако вам известно, что у нее есть мать-инвалид, за которым она ухаживает и несовершеннолетний ребенок, которого она воспитывает одна. Второй сотрудник - мужчина, который по показателям эффективности значительно превосходит первого сотрудника. Кого решите уволить?"
                },
                new Models.Dilemma()
                {
                    Id = Guid.NewGuid(),
                    Text = "За обучение в ВУЗе платят ваши родители. Вы знаете, что это сильно бьет по их бюджету.  В текущем семестре у вас есть возможность получить большую скидку на обучение, если вы сдадите экзамен на 5. Перед экзаменом профессор сообщил, что есть возможность получить 5 за экзамен, если вы сдадите человека, который списывает, после чего вы не будете деанонимизированы. В ходе экзамена, вы чувствуете, что пятерку не получите, однако вы видите, как ваш хороший друг списывает."
                }
            };

            var min = 0.3;
            var max = 0.9;
            var random = new Random(1337);

            double GetRate()
            {
                return Math.Round(min + (max - min) * random.NextDouble(), 1);
            };

            var solutions = new List<Solution>()
            {
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[0].Id,
                    Text = "Они взрослые люди и должны сами решать, как им жить. Поддержу их выбор внезависимости от своих предпочтений.",
                    Image = "dilemma_1_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[0].Id,
                    Text = "Глупое и бездумное решение. Буду пытаться доказать им, что их выбор не верен.",
                    Image = "dilemma_1_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[1].Id,
                    Text = "Аборт делать ни в коем случае нельзя ведь это ребенок. А вырастить можно и самой. Родные помогут.",
                    Image = "dilemma_2_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[1].Id,
                    Text = "Девушка поступила, как ей казалось правильным. Мы не знаем всех причин и не может судить о ее поступке.",
                    Image = "dilemma_2_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[2].Id,
                    Text = "Как и с любыми другими соседями. Их личная жизнь - это их дело.",
                    Image = "dilemma_3_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[2].Id,
                    Text = "Буду избегать их и показывать свое неодобрение, потому что это не правильно. Постараюсь избежать всех контактов с ними.",
                    Image = "dilemma_3_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[3].Id,
                    Text = "Не буду вмешиваться. Взрослые люди должны разбираться сами. Это не мое дело.",
                    Image = "dilemma_4_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[3].Id,
                    Text = "Постараюсь поговорить с ней. Предложить помощь, если нужно. Помогу справиться со стрессом и страхом.",
                    Image = "dilemma_4_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[4].Id,
                    Text = "Я поддержу приятеля, ведь главное - заниматься тем, что тебе нравится и получать удовольствие.",
                    Image = "dilemma_5_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[4].Id,
                    Text = "Я посоветую приятелю заняться чем-нибудь более серьёзным и полезным для общества.",
                    Image = "dilemma_5_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[5].Id,
                    Text = "Конечно, ведь за границей у него открываются отличные возможности для саморазвития и карьерного роста.",
                    Image = "dilemma_6_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[5].Id,
                    Text = "Не поддержу такое решение, ведь государство вложило огромные силы и средства в его обучение - как в школе, так на бюджетном месте университета. Теперь ему следует дать государству что-то взамен.",
                    Image = "dilemma_6_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[6].Id,
                    Text = "Существуют темы, на которые шутить нельзя, потому что они задевают чувства некоторых людей. Если в обществе есть запретные темы, их не стоит использовать для развлечения.",
                    Image = "dilemma_7_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[6].Id,
                    Text = "Запретных тем нет - если человек хочет высмеять те или иные социокультурные аспекты, он имеет на это полное право. Те, кому это не нравится, могут не слушать.",
                    Image = "dilemma_7_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[7].Id,
                    Text = "Задумаюсь о том, что за подобные аморальные действия по отношению к своему ребёнку стоит лишать родительских прав.",
                    Image = "dilemma_8_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[7].Id,
                    Text = "Порадуюсь о взаимопонимании и поддержке, существующих между между отцом и его ребёнком.",
                    Image = "dilemma_8_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[8].Id,
                    Text = "Нужно спасти ребенка, так как он - будущая ячейка общества.",
                    Image = "dilemma_9_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[8].Id,
                    Text = "Нужно спасти женщину, так как она уже является членом общества, у которого есть социальные связи, близкие люди. Общество получит большую пользу от ее спасения.",
                    Image = "dilemma_9_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[9].Id,
                    Text = "Женщину, так как компания и так испытывает финансовые трудности. Компании непозволительно иметь неэффективного сотрудника.",
                    Image = "dilemma_10_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[9].Id,
                    Text = "Мужчину. У него нет серьезных проблем в жизни, и с поиском работы тоже не будет.",
                    Image = "dilemma_10_solution_2.jpeg",
                    Rate = -GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[10].Id,
                    Text = "Как бы ни была важна дружба, скидка очень сильно нужна. Тем более друг об этом не узнает.",
                    Image = "dilemma_11_solution_1.jpeg",
                    Rate = GetRate()
                },
                new Solution()
                {
                    Id = Guid.NewGuid(),
                    DilemmaId = dilemmas[10].Id,
                    Text = "Искренняя и честная дружба будет важнее.",
                    Image = "dilemma_11_solution_2.jpeg",
                    Rate = -GetRate()
                }
            };

            modelBuilder.Entity<Models.Dilemma>().HasData(dilemmas);
            modelBuilder.Entity<Solution>().HasData(solutions);
        }
    }
}
