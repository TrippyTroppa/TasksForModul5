using System;

namespace TasksForModul5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string lastName, int age, string[] petNames, string[] favoriteColors) userData = GetUserData();
            ShowUserData(userData);
        }

        static (string name, string lastName, int age, string[] petNames, string[] favoriteColors) GetUserData()
        {
            string name = "";
            string lastName = "";
            int age = 0;
            string[] petNames = null;
            string[] favoriteColors = null;
            bool hasPet = false;

          
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            
            Console.Write("Введите фамилию: ");
            lastName = Console.ReadLine();

            
            age = GetCorrectInt("Введите возраст: ");

            
            Console.Write("У вас есть питомец? (да/нет): ");
            string petAnswer = Console.ReadLine().ToLower();
            if (petAnswer == "да")
            {
                hasPet = true;
                int petCount = GetCorrectInt("Введите количество питомцев: ");
                petNames = GetPetNames(petCount);
            }

            
            int colorCount = GetCorrectInt("Введите количество любимых цветов: ");
            favoriteColors = GetFavoriteColors(colorCount);

            return (name, lastName, age, petNames, favoriteColors);
        }

        static string[] GetPetNames(int count)
        {
            string[] names = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Введите кличку питомца номер {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            return names;
        }

        static string[] GetFavoriteColors(int count)
        {
            string[] colors = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Введите любимый цвет номер {i + 1}: ");
                colors[i] = Console.ReadLine();
            }
            return colors;
        }

        static int GetCorrectInt(string prompt)
        {
            int number;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число больше 0.");
                }
            } while (!isValid);

            return number;
        }

        static void ShowUserData((string name, string lastName, int age, string[] petNames, string[] favoriteColors) data)
        {
            Console.WriteLine("\nДанные пользователя:");
            Console.WriteLine($"Имя: {data.name}");
            Console.WriteLine($"Фамилия: {data.lastName}");
            Console.WriteLine($"Возраст: {data.age}");

            if (data.petNames != null && data.petNames.Length > 0)
            {
                Console.WriteLine("Клички питомцев:");
                foreach (string petName in data.petNames)
                {
                    Console.WriteLine($"- {petName}");
                }
            }
            else
            {
                Console.WriteLine("Питомцев нет.");
            }

            Console.WriteLine("Любимые цвета:");
            foreach (string color in data.favoriteColors)
            {
                Console.WriteLine($"- {color}");
            }
        }
    }
}
