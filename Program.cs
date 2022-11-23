using System;
using ежедневник;

namespace Ezednevnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stranitsa();
        }
        static void Stranitsa()
        {
            int stranitsa = 0;
            int arrowPosition = 1;

            Stranitsa stranitsa1 = new Stranitsa()
            {
                data = new DateTime(2022, 11, 20),
                St = new string[] { "дело а", "Фигня чтобы расширить код", "Разделительная ы", "Чтобы выйти из описания заметки нажмите на верхнюю или нижнюю стрелку. Переключать ежедненик можно при помощи стрелок", "Чтобы выйти из ежедневника нажмите на esc" }
            };
            Stranitsa stranitsa2 = new Stranitsa()
            {
                data = new DateTime(2022, 11, 21),
                St = new string[] { "дело а", "Фигня чтобы расширить код", "Фигня чтобы расширить код"}
            };
            Stranitsa stranitsa3 = new Stranitsa()
            {
                data = new DateTime(2022, 10, 22),
                St = new string[] { "дело а", "Фигня чтобы расширить код", "Фигня чтобы расширить код"}
            };
            Stranitsa stranitsa4 = new Stranitsa()
            {
                data = new DateTime(2022, 10, 23),
                St = new string[] { "дело а", "Фигня чтобы расширить код", "Фигня чтобы расширить код"}
            };

            Console.SetCursorPosition(0, arrowPosition);
            Cursor(stranitsa1);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        arrowPosition = 1;

                        if (stranitsa == 0)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                            stranitsa++;
                        }
                        else if (stranitsa == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa3);
                            stranitsa++;
                        }
                        else if (stranitsa == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa4);
                            stranitsa++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        arrowPosition = 1;
                        if (stranitsa == 3)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa3);
                            stranitsa--;
                        }

                        else if (stranitsa == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                            stranitsa--;
                        }
                        else if (stranitsa == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa1);
                            stranitsa--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (key.Key == ConsoleKey.DownArrow && stranitsa == 0)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa1);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && stranitsa == 1)
                        {
                            arrowPosition++;
                            if (arrowPosition > 5)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && stranitsa == 2)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa3);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && stranitsa == 3)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa4);
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (key.Key == ConsoleKey.UpArrow && stranitsa == 0)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa1);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && stranitsa == 1)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa2);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && stranitsa == 2)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa3);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && stranitsa == 3)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            Cursor(stranitsa4);
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (stranitsa)
                        {
                            case 0:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("дело а");
                                    Console.WriteLine($"Выбрана дата: {stranitsa1.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("я хз куда это попадёт");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Фигня чтобы расширить код");
                                    Console.WriteLine($"Выбрана дата: {stranitsa1.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("я хз куда это попадёт");
                                }
                                break;
                            case 1:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("дело а");
                                    Console.WriteLine($"Выбрана дата: {stranitsa2.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Фигня чтобы расширить код");
                                    Console.WriteLine($"Выбрана дата: {stranitsa2.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");
                                }
                                else if (arrowPosition == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Фигня чтобы расширить код");
                                    Console.WriteLine($"Выбрана дата: {stranitsa2.data}");
                                    Console.WriteLine("описание ежедненика");
                                    Console.WriteLine("Я хз куда это попадёт");
                                }
                                break;
                            case 2:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("дело а");
                                    Console.WriteLine($"Выбарана дата: {stranitsa3.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Фигня чтобы расширить код");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");
                                }
                                else if (arrowPosition == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Фигня чтобы расширить код");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");

                                }
                                break;
                            case 3:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("дело а");
                                    Console.WriteLine($"Выбарана дата: {stranitsa4.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Фигня чтобы расширить код");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");
                                }
                                else if (arrowPosition == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Фигня чтобы расширить код");
                                    Console.WriteLine($"Выбрана дата: {stranitsa3.data}");
                                    Console.WriteLine("Описание ежедневника");
                                    Console.WriteLine("Я хз куда это попадёт");

                                }
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void Cursor(ежедневник.Stranitsa currentPage)
        {
            Console.WriteLine("==0");
            Console.SetCursorPosition(3, 0);
            Console.WriteLine(currentPage.data);
            Console.CursorVisible = false;

            int i = 1;
            foreach (string n in currentPage.St)
            {
                i++;
                Console.SetCursorPosition(3, i);
                Console.WriteLine(n);
            }
        }
    }
}