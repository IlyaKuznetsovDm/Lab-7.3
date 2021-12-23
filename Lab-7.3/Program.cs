using System;

namespace lab7_3
{
    class Program
    {
        //средний уровень - 8 вариант
        struct Book
        {
            public string fio;
            public int god_rozjdeniya;
            public string dolzjnost;
            public int zarplata;

            public Book(string a, int b, string c, int d)
            {
                fio = a;
                god_rozjdeniya = b;
                dolzjnost = c;
                zarplata = d;
            }
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Информация");
            Console.WriteLine("----------");
            Book[] X = new Book[10];
            X[0].fio = "Сидоров Антон Дмитриевич";
            X[0].god_rozjdeniya = 1984;
            X[0].dolzjnost = " [бухгалтер] ";
            X[0].zarplata = 29810;

            X[1] = new Book("Ситько Юлия Максимовна", 2003, " [IT-менеджер] ", 54200);
            X[2] = new Book("Калишенко Андрей Алексеевич", 1999, " [веб-дизайнер] ", 51490);
            X[3] = new Book("Сидоренко Алена Васильевна", 2002, " [повар] ", 28184);
            X[4] = new Book("Бобова Светлана Викторовна", 1987, " [кондитер] ", 33875);
            X[5] = new Book("Комисар Илья Георгиевич", 1991, " [менеджер по продажам] ", 27913);
            X[6] = new Book("Мищак Данил Денисович", 1998, " [политолог] ", 42818);
            X[7] = new Book("Зубко Евгений Захарович", 2002, " [культуролог] ", 34688);
            X[8] = new Book("Шевчук Ян Игоревич", 2000, " [логист] ", 38482);
            X[9] = new Book("Ящук Лев Макарович", 1995, " [HR-менеджер] ", 63414);
            {
                for (int i = 0; i <= 9; i++)
                {
                    Console.WriteLine(X[i].fio + ": " + X[i].god_rozjdeniya + " год " + X[i].dolzjnost + X[i].zarplata + " руб");

                }
            }
            double max = X[0].god_rozjdeniya;
            int z = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i].god_rozjdeniya > max)
                {
                    max = X[i].god_rozjdeniya;
                    z = i;
                }
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Самый младший сотрудник и информация о нем:");
            Console.WriteLine("Фио: {0} \nГод рождения: {1}\nДолжность: {2}\nЗарплата: {3} руб", X[z].fio, X[z].god_rozjdeniya, X[z].dolzjnost, X[z].zarplata);





        }

    }

}

