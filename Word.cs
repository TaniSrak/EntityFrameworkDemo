using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkDemo
{
    internal class Word //класс для хранения слова и его толкования
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
