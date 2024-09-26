using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (WordContext context = new WordContext())
            {
                //пара слов
                Word word001 = new Word
                {
                    Name = "Молоток",
                    Description = "Ручной инструмент для обращения с гвоздями"
                };
                Word word002 = new Word
                {
                    Name = "Отвертка",
                    Description = "Ручной инструмент для обращения с шурупами и винтами"
                };
                //добавляем в контекст и сохраняем 
                //context.Words.Add(word001);
                //context.Words.Add(word002);
                //context.SaveChanges();
                Console.WriteLine($"В БД Dictionary добавлены слова {word001.Name} и {word002.Name}.");

                //возвращает наш метод вордс, обращаясь к самой бд
                var _words = context.Words; 
                foreach (var word in _words)
                {
                    Console.WriteLine(word.Name + " - " + word.Description);
                }
                Console.ReadLine();
            }

        }
    }
}
