using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dilemma.DAL.Migrations
{
    public partial class AddRealDilemmaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("1dd7f1aa-7ecf-4804-9bff-1862e01a5b0a"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("25f1de4e-5dbd-4b12-b4fd-53cc9194f672"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("66a360e7-2ee4-4dba-82b6-5efd83402081"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("717e11a7-2fe7-43eb-a2ce-699eeaf3d9d7"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("aa39be35-41c5-411e-923d-a1139cef286b"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("fd7d0f5d-738c-46e4-957c-4abfec5b8c1a"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"));

            migrationBuilder.InsertData(
                table: "Dilemmas",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("c402251d-10a7-402d-afb2-295cf7046fdc"), "Знакомая вам пара сознательно отказывается заводить детей и выбирает карьеру и жизнь в свое удовольствие. Как вы к этому отнесетесь?" },
                    { new Guid("f85ee938-d711-49d4-a6a1-8de2231e26dd"), "Пара расстается после известия о беременности. Из-за этого девушка решает сделать аборт. Какова будет ваша реакция на поступок?" },
                    { new Guid("94b9bb67-0cf1-47dc-a92e-746f44d7252f"), "Пара расстается после известия о беременности. Из-за этого девушка решает сделать аборт. Какова будет ваша реакция на поступок?" },
                    { new Guid("6582873e-3515-4388-9aec-79091acd0094"), "Вы увидели синяки у вашей соседки. Каковы будут ваши действия?" },
                    { new Guid("9f90a090-2a70-45e3-b45b-ce9ceda9f616"), "Ваш приятель рассказал, что наконец-то нашёл занятие себе по душе - стал видеоблоггером. Одобрите ли вы такой выбор?" },
                    { new Guid("152ad382-fcef-4a44-82aa-4476798881dd"), "Вы узнаёте, что ваш однокурсник получил выгодное предложение о работе за границей и собирается переехать, а в перспективе - получить гражданство. Поддержите ли вы его решение?" },
                    { new Guid("bf269761-6bfb-4c77-91c8-e5a8e390c746"), "Вы узнаёте из новостей, что известный стенд-ап комик был оштрафован за неуместную шутку, оскорбляющую чувства верующих людей. Каково будет ваше отношение к этой ситуации?" },
                    { new Guid("a7cd9705-26d2-401b-8131-24618b6143e2"), "Встретившись со своим приятелем, вы узнаёте, что его совершеннолетний сын решил совершить трансгендерный переход, приятель поддерживает это решение. Как вы отнесётесь к данной ситуации?" },
                    { new Guid("6956ccc6-6d27-49f7-9ed3-39044ecfee6a"), "Вы - врач-акушер, принимаете роды. Женщина находится в критическом состоянии, но ее еще можно спасти, однако ребенок умрет. Если вы решите спасти ребенка, то умрет женщина. Какой вариант вы выберите?" },
                    { new Guid("65ed6b61-70de-400a-aa01-23c4b11d8e96"), "Вы являетесь начальником отдела в компании. Сверху поступает требование сократить одного сотрудника, так как компания столкнулась с финансовыми трудностями. В вашем отделе, помимо вас, работает два человека. Первый сотрудник - женщина, которая, по объективным показателям эффективности работает хуже, однако вам известно, что у нее есть мать-инвалид, за которым она ухаживает и несовершеннолетний ребенок, которого она воспитывает одна. Второй сотрудник - мужчина, который по показателям эффективности значительно превосходит первого сотрудника. Кого решите уволить?" },
                    { new Guid("33bffdc8-05af-4dc1-a16f-75fa8c72793a"), "За обучение в ВУЗе платят ваши родители. Вы знаете, что это сильно бьет по их бюджету.  В текущем семестре у вас есть возможность получить большую скидку на обучение, если вы сдадите экзамен на 5. Перед экзаменом профессор сообщил, что есть возможность получить 5 за экзамен, если вы сдадите человека, который списывает, после чего вы не будете деанонимизированы. В ходе экзамена, вы чувствуете, что пятерку не получите, однако вы видите, как ваш хороший друг списывает." }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "DilemmaId", "Image", "Rate", "Text" },
                values: new object[,]
                {
                    { new Guid("1106eb04-c329-4269-aaf1-1a23597f0ad4"), new Guid("c402251d-10a7-402d-afb2-295cf7046fdc"), "dilemma_1_solution_1.jpeg", 0.40000000000000002, "Они взрослые люди и должны сами решать, как им жить. Поддержу их выбор внезависимости от своих предпочтений." },
                    { new Guid("95582cfb-c260-4ec2-bf61-6923e332d278"), new Guid("65ed6b61-70de-400a-aa01-23c4b11d8e96"), "dilemma_10_solution_2.jpeg", -0.29999999999999999, "Мужчину. У него нет серьезных проблем в жизни, и с поиском работы тоже не будет." },
                    { new Guid("c08b86b1-2347-4097-8ffd-6cddc5984c49"), new Guid("65ed6b61-70de-400a-aa01-23c4b11d8e96"), "dilemma_10_solution_1.jpeg", 0.80000000000000004, "Женщину, так как компания и так испытывает финансовые трудности. Компании непозволительно иметь неэффективного сотрудника." },
                    { new Guid("61d1e5d9-09c2-40ae-811d-e39f622b5341"), new Guid("6956ccc6-6d27-49f7-9ed3-39044ecfee6a"), "dilemma_9_solution_2.jpeg", -0.90000000000000002, "Нужно спасти женщину, так как она уже является членом общества, у которого есть социальные связи, близкие люди. Общество получит большую пользу от ее спасения." },
                    { new Guid("335c3917-2c0c-443f-94fc-daf3db63c554"), new Guid("6956ccc6-6d27-49f7-9ed3-39044ecfee6a"), "dilemma_9_solution_1.jpeg", 0.80000000000000004, "Нужно спасти ребенка, так как он - будущая ячейка общества." },
                    { new Guid("7ccf98ab-e030-4f6a-8df5-26005c4be448"), new Guid("a7cd9705-26d2-401b-8131-24618b6143e2"), "dilemma_8_solution_2.jpeg", -0.29999999999999999, "Порадуюсь о взаимопонимании и поддержке, существующих между между отцом и его ребёнком." },
                    { new Guid("21729881-ef78-4605-8b4a-d8919e47b3c4"), new Guid("a7cd9705-26d2-401b-8131-24618b6143e2"), "dilemma_8_solution_1.jpeg", 0.80000000000000004, "Задумаюсь о том, что за подобные аморальные действия по отношению к своему ребёнку стоит лишать родительских прав." },
                    { new Guid("22e6fc6d-e8ce-4f44-9f96-1ba05b02a93c"), new Guid("bf269761-6bfb-4c77-91c8-e5a8e390c746"), "dilemma_7_solution_2.jpeg", -0.29999999999999999, "Запретных тем нет - если человек хочет высмеять те или иные социокультурные аспекты, он имеет на это полное право. Те, кому это не нравится, могут не слушать." },
                    { new Guid("96500b2b-9e81-466f-b722-4d3370ed2e86"), new Guid("bf269761-6bfb-4c77-91c8-e5a8e390c746"), "dilemma_7_solution_1.jpeg", 0.80000000000000004, "Существуют темы, на которые шутить нельзя, потому что они задевают чувства некоторых людей. Если в обществе есть запретные темы, их не стоит использовать для развлечения." },
                    { new Guid("b8dd2a6e-1636-4f6b-8394-046e5bd7ffcc"), new Guid("152ad382-fcef-4a44-82aa-4476798881dd"), "dilemma_6_solution_2.jpeg", -0.5, "Не поддержу такое решение, ведь государство вложило огромные силы и средства в его обучение - как в школе, так на бюджетном месте университета. Теперь ему следует дать государству что-то взамен." },
                    { new Guid("a1d867b0-1945-4e79-8675-4e6ca912c200"), new Guid("152ad382-fcef-4a44-82aa-4476798881dd"), "dilemma_6_solution_1.jpeg", 0.5, "Конечно, ведь за границей у него открываются отличные возможности для саморазвития и карьерного роста." },
                    { new Guid("2343e27b-c648-4ed6-889f-0c79518dec55"), new Guid("9f90a090-2a70-45e3-b45b-ce9ceda9f616"), "dilemma_5_solution_2.jpeg", -0.5, "Я посоветую приятелю заняться чем-нибудь более серьёзным и полезным для общества." },
                    { new Guid("f470c0d5-ae07-4ed3-b2c4-8df3574176ba"), new Guid("9f90a090-2a70-45e3-b45b-ce9ceda9f616"), "dilemma_5_solution_1.jpeg", 0.5, "Я поддержу приятеля, ведь главное - заниматься тем, что тебе нравится и получать удовольствие." },
                    { new Guid("f562b4fc-0df5-46a4-bc87-8dc58c40d0ef"), new Guid("6582873e-3515-4388-9aec-79091acd0094"), "dilemma_4_solution_2.jpeg", -0.40000000000000002, "Постараюсь поговорить с ней. Предложить помощь, если нужно. Помогу справиться со стрессом и страхом." },
                    { new Guid("95dc0a17-d1c1-454c-a198-d4cfa3210a84"), new Guid("6582873e-3515-4388-9aec-79091acd0094"), "dilemma_4_solution_1.jpeg", 0.90000000000000002, "Не буду вмешиваться. Взрослые люди должны разбираться сами. Это не мое дело." },
                    { new Guid("90de8c66-0fc0-4f03-ad04-c4a38bc26524"), new Guid("94b9bb67-0cf1-47dc-a92e-746f44d7252f"), "dilemma_3_solution_2.jpeg", -0.90000000000000002, "Буду избегать их и показывать свое неодобрение, потому что это не правильно. Постараюсь избежать всех контактов с ними." },
                    { new Guid("b02e022c-3c28-4556-a492-4cb48dc3e731"), new Guid("94b9bb67-0cf1-47dc-a92e-746f44d7252f"), "dilemma_3_solution_1.jpeg", 0.80000000000000004, "Как и с любыми другими соседями. Их личная жизнь - это их дело." },
                    { new Guid("c6bc174d-49ff-4a19-8444-08fd7e0cdc70"), new Guid("f85ee938-d711-49d4-a6a1-8de2231e26dd"), "dilemma_2_solution_2.jpeg", -0.90000000000000002, "Девушка поступила, как ей казалось правильным. Мы не знаем всех причин и не может судить о ее поступке." },
                    { new Guid("6ff67647-49cc-4098-9d58-a6cd3d4c6fcf"), new Guid("f85ee938-d711-49d4-a6a1-8de2231e26dd"), "dilemma_2_solution_1.jpeg", 0.5, "Аборт делать ни в коем случае нельзя ведь это ребенок. А вырастить можно и самой. Родные помогут." },
                    { new Guid("980f4abf-acce-4057-ad3d-49e668b94838"), new Guid("c402251d-10a7-402d-afb2-295cf7046fdc"), "dilemma_1_solution_2.jpeg", -0.40000000000000002, "Глупое и бездумное решение. Буду пытаться доказать им, что их выбор не верен." },
                    { new Guid("a9e4c772-a9f2-49dd-8852-83232b6b1b13"), new Guid("33bffdc8-05af-4dc1-a16f-75fa8c72793a"), "dilemma_11_solution_1.jpeg", 0.59999999999999998, "Как бы ни была важна дружба, скидка очень сильно нужна. Тем более друг об этом не узнает." },
                    { new Guid("d024b44e-3bcb-40d7-95db-7e73d6ef9258"), new Guid("33bffdc8-05af-4dc1-a16f-75fa8c72793a"), "dilemma_11_solution_2.jpeg", -0.80000000000000004, "Искренняя и честная дружба будет важнее." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("1106eb04-c329-4269-aaf1-1a23597f0ad4"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("21729881-ef78-4605-8b4a-d8919e47b3c4"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("22e6fc6d-e8ce-4f44-9f96-1ba05b02a93c"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("2343e27b-c648-4ed6-889f-0c79518dec55"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("335c3917-2c0c-443f-94fc-daf3db63c554"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("61d1e5d9-09c2-40ae-811d-e39f622b5341"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("6ff67647-49cc-4098-9d58-a6cd3d4c6fcf"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("7ccf98ab-e030-4f6a-8df5-26005c4be448"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("90de8c66-0fc0-4f03-ad04-c4a38bc26524"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("95582cfb-c260-4ec2-bf61-6923e332d278"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("95dc0a17-d1c1-454c-a198-d4cfa3210a84"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("96500b2b-9e81-466f-b722-4d3370ed2e86"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("980f4abf-acce-4057-ad3d-49e668b94838"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("a1d867b0-1945-4e79-8675-4e6ca912c200"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("a9e4c772-a9f2-49dd-8852-83232b6b1b13"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("b02e022c-3c28-4556-a492-4cb48dc3e731"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("b8dd2a6e-1636-4f6b-8394-046e5bd7ffcc"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("c08b86b1-2347-4097-8ffd-6cddc5984c49"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("c6bc174d-49ff-4a19-8444-08fd7e0cdc70"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("d024b44e-3bcb-40d7-95db-7e73d6ef9258"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("f470c0d5-ae07-4ed3-b2c4-8df3574176ba"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("f562b4fc-0df5-46a4-bc87-8dc58c40d0ef"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("152ad382-fcef-4a44-82aa-4476798881dd"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("33bffdc8-05af-4dc1-a16f-75fa8c72793a"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("6582873e-3515-4388-9aec-79091acd0094"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("65ed6b61-70de-400a-aa01-23c4b11d8e96"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("6956ccc6-6d27-49f7-9ed3-39044ecfee6a"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("94b9bb67-0cf1-47dc-a92e-746f44d7252f"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("9f90a090-2a70-45e3-b45b-ce9ceda9f616"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("a7cd9705-26d2-401b-8131-24618b6143e2"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("bf269761-6bfb-4c77-91c8-e5a8e390c746"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("c402251d-10a7-402d-afb2-295cf7046fdc"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("f85ee938-d711-49d4-a6a1-8de2231e26dd"));

            migrationBuilder.InsertData(
                table: "Dilemmas",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"), "Dilemma 1" },
                    { new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"), "Dilemma 2" },
                    { new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"), "Dilemma 3" }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "DilemmaId", "Image", "Rate", "Text" },
                values: new object[,]
                {
                    { new Guid("66a360e7-2ee4-4dba-82b6-5efd83402081"), new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"), "dilemma_1_solution_1.jpeg", 0.69999999999999996, "Dilemma 1 Solution 1" },
                    { new Guid("717e11a7-2fe7-43eb-a2ce-699eeaf3d9d7"), new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"), "dilemma_1_solution_2.jpeg", -0.40000000000000002, "Dilemma 1 Solution 2" },
                    { new Guid("1dd7f1aa-7ecf-4804-9bff-1862e01a5b0a"), new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"), "dilemma_1_solution_1.jpeg", 0.40000000000000002, "Dilemma 2 Solution 1" },
                    { new Guid("25f1de4e-5dbd-4b12-b4fd-53cc9194f672"), new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"), "dilemma_1_solution_2.jpeg", -0.5, "Dilemma 2 Solution 2" },
                    { new Guid("aa39be35-41c5-411e-923d-a1139cef286b"), new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"), "dilemma_1_solution_1.jpeg", 0.59999999999999998, "Dilemma 3 Solution 1" },
                    { new Guid("fd7d0f5d-738c-46e4-957c-4abfec5b8c1a"), new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"), "dilemma_1_solution_2.jpeg", -0.20000000000000001, "Dilemma 3 Solution 2" }
                });
        }
    }
}
