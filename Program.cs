using System;

namespace TaskJunior2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandUserDataInput = "1";
            const string CommandUserDataOutput = "2";
            const string CommandDise = "3";
            const string CommandCleaningConsole = "4";
            const string CommandExitFromConsole = "5";

            Random random = new Random();
            
            int firstValueRandom = 0;
            int finishValueRandom = 7;
            int triesCountForDise;
            int ageUser;
            int userInputForDise;

            string userInput;
            string nameUser;
            string zodiacSign;
            string workUser;

            bool isWork = true;

            Console.WriteLine("Приветствую вас в самом не технологическом компьютере во всем мире!\n");

            while (isWork)
            {
                Console.WriteLine("Выберете следующую команду: \n" +
                                 $"{CommandUserDataInput} - Ввод ваших пользовательских данных: \n" +
                                 $"{CommandUserDataOutput} - Вывод данных об администраторе: \n" +
                                 $"{CommandDise} - Игральная кость.\n" +
                                 $"{CommandCleaningConsole} - Очистка консоли.\n" +
                                 $"{CommandExitFromConsole} - Выход.\n");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandUserDataInput:

                        Console.WriteLine("Приветствую очаровательный человек, который все таки решил пройти мой социальный опрос о таком наилучшем и великим человеком как вы =)))\nИтак начнем:");
                        Console.Write("Как тебя звать 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
                        nameUser = Console.ReadLine();

                        Console.Write("Сколько столетий ты прожил 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
                        ageUser = Convert.ToInt32(Console.ReadLine());

                        Console.Write("К какому богу ты приклоняешься из ЗНАКОВ ЗАДИАКА 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
                        zodiacSign = Console.ReadLine();

                        Console.Write("Каким ремеслом ты занимаешься в реальном МИРЕ 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
                        workUser = Console.ReadLine();

                        Console.WriteLine($"\nООО ВЕЛИКИЙ {nameUser}, которому {ageUser} столетий, который прислуживает богу {zodiacSign} и '{workUser}' ремесло которое приносит данному " +
                                          $"Господину каждый день не только удовольствие, но и горы золота и женщин!!!\n\n");
                        break;

                    case CommandUserDataOutput:

                        Console.WriteLine("Меня зовут Мансур мне 20 годиков, обучаюсь в ЯЮниор и надеюсь после успешного обученя зарабатывать, конечно же ни сразу, но со временнем 10000000000$ в месяц)))" +
                                          "\nНапишите небольшой отзыв о программе, пожалуйста)");
                        Console.ReadLine();

                        Console.WriteLine("Спасибо за отзыв!\n");
                        break;

                    case CommandDise:
                        
                        int numberForRandom = random.Next(firstValueRandom, finishValueRandom);
                        triesCountForDise = 3;

                        Console.WriteLine("Угадайте какое число выпадет в игральной кости.\n" +
                                         $"Что у вас за число? У вас {triesCountForDise} попытки отгадать.");

                        for (int i = 0; i < triesCountForDise; ++i)
                        {
                            Console.Write("Введите число от 1 до 6: ");
                            userInputForDise = Convert.ToInt32(Console.ReadLine());

                            if (userInputForDise == numberForRandom)
                            {
                                Console.WriteLine($"Вы правы, это было число {numberForRandom}.\n");
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Не верно, попробуйте еще раз.\n");
                            }
                        }

                        if (triesCountForDise >= 0)
                        {
                            Console.WriteLine($"Вы проиграли. Верным числом было {numberForRandom}.\n");
                        }
                        break;

                    case CommandCleaningConsole:
                        Console.Clear();
                        break;

                    case CommandExitFromConsole:
                        isWork = false;
                        Console.WriteLine("Программа завершена.");
                        break;

                    default:
                        Console.WriteLine("Вы ввели не верную комманду!!!\n" +
                                          "Введите номер команды предложенных ниже)))\n");
                        break;

                }
            }
        }
    }
}

