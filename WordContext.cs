using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkDemo
{
    internal class WordContext : DbContext
    {
        public  WordContext() : base("DbConnection") //описание контекста
        {
            
        }
        
        public DbSet<Word> Words { get; set; } //авто свойство 

        //настройки подключения


    }
}
