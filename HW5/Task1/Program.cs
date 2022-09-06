namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gradebook = new Dictionary<string, int>()
            {
                {"Иванов", 8 },
                {"Петров", 9 },
                {"Густой", 2 },
                {"Серов", 3 },
                {"Белов", 6 },
                {"Чернышевский", 9 }
            };

            Console.WriteLine("1. Добавить оценку ученика" + Environment.NewLine +
                              "2. Изменить оценку ученика" + Environment.NewLine +
                              "3. Удалить оценку ученика" + Environment.NewLine +
                              "4. Вывести всех учеников" + Environment.NewLine +
                              "5. Вывести среднее арифметическое всех оценок" + Environment.NewLine +
                              "6. Вывести фамилии учеников, которые имеют самую высокую оценку" + Environment.NewLine +
                              "7. Вывести фамилии учеников, которые имеют оценку большую или равную 8" + Environment.NewLine +
                              "8. Вывести фамилии учеников, которые имеют оценку меньшую или равную 4." + Environment.NewLine +
                              "9. Закончить программу"
                              );

            int resp = 0;
            while (resp != 9)
            {
                Console.Write("Выберите действие: ");
                bool isnum = int.TryParse(Console.ReadLine(), out resp);
                while (!isnum || (resp < 1 || resp > 9))
                {
                    Console.WriteLine("Ошибка. Введите число от 1 до 9.");
                    isnum = int.TryParse(Console.ReadLine(), out resp);
                }

                Menu enteredAct = (Menu)resp;

                switch (enteredAct)
                {
                    case Menu.Add:
                        {
                            Console.Write("Введите фамилию ученика: ");
                            string fam = Console.ReadLine();
                            fam = fam.Trim();
                            while (gradebook.ContainsKey(fam) || string.IsNullOrEmpty(fam))
                            {
                                Console.WriteLine("Ошибка. Введите нового ученика.");
                                fam = Console.ReadLine();
                                fam = fam.Trim();
                            }
                            Console.Write("Введите оценку ученика: ");
                            int mark = 0;
                            isnum = int.TryParse(Console.ReadLine(), out mark);
                            while (!isnum || (mark < 0 || mark > 10))
                            {
                                Console.WriteLine("Оценка не может быть меньше 0 и больше 10. Введите заново.");
                                isnum = int.TryParse(Console.ReadLine(), out mark);
                            }
                            gradebook.Add(fam, mark);
                            break;
                        }

                    case Menu.Change:
                        {
                            Console.Write("Введите фамилию ученика: ");
                            string fam = Console.ReadLine();
                            fam = fam.Trim();
                            while (!gradebook.ContainsKey(fam) || string.IsNullOrEmpty(fam))
                            {
                                Console.WriteLine("Ошибка. Введите существующего ученика.");
                                fam = Console.ReadLine();
                                fam = fam.Trim();
                            }
                            Console.Write("Введите оценку ученика: ");
                            int mark = 0;
                            isnum = int.TryParse(Console.ReadLine(), out mark);
                            while (!isnum || (mark < 0 || mark > 10))
                            {
                                Console.WriteLine("Оценка не может быть меньше 0 и больше 10. Введите заново.");
                                isnum = int.TryParse(Console.ReadLine(), out mark);
                            }
                            gradebook[fam] = mark;
                            break;
                        }

                    case Menu.Remove:
                        {
                            Console.Write("Введите фамилию ученика: ");
                            string fam = Console.ReadLine();
                            fam = fam.Trim();
                            while (!gradebook.ContainsKey(fam))
                            {
                                Console.WriteLine("Такой ученик не был найден");
                                fam = Console.ReadLine();
                                fam = fam.Trim();
                            }
                            gradebook.Remove(fam);
                            break;
                        }

                    case Menu.DisplayAll:
                        {
                            foreach (KeyValuePair<string, int> fam in gradebook)
                            {
                                Console.WriteLine($"{fam.Key} - {fam.Value}");
                            }
                            break;
                        }

                    case Menu.Average:
                        {
                            double sum = 0;
                            foreach (int mark in gradebook.Values)
                            {
                                sum += mark;
                            }
                            double average = sum / gradebook.Count;
                            //Console.WriteLine("Среднее арифметическое всех оценок: {0}", Math.Round(average, 2)); //Почему это сработало?
                            Console.WriteLine(string.Format("Среднее арифметическое всех оценок: {0:F2}", average));
                            break;
                        }

                    case Menu.TopStudents:
                        {
                            int max = 0;
                            foreach(int mark in gradebook.Values)
                            {
                                if (mark > max)
                                {
                                    max = mark;
                                }
                            }
                            foreach (KeyValuePair<string, int> grade in gradebook)
                            {
                                if (grade.Value == max)
                                {
                                    Console.WriteLine($"{grade.Key}");
                                }
                            }
                            break;
                        }

                    case Menu.Mark8ormore:
                        {
                            foreach (KeyValuePair<string, int> grade in gradebook)
                            {
                                if (grade.Value >= 8)
                                {
                                    Console.WriteLine($"{grade.Key}");
                                }
                            }
                            break;
                        }

                    case Menu.Mark4orless:
                        {
                            foreach (KeyValuePair<string, int> grade in gradebook)
                            {
                                if (grade.Value <= 4)
                                {
                                    Console.WriteLine($"{grade.Key}");
                                }
                            }
                            break;
                        }

                    case Menu.Exit:
                        {
                            Console.WriteLine("Выход из программы");
                            break;
                        }    
                }
            }

            Console.ReadKey();
        }
    }
}