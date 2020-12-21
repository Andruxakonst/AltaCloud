using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;  //подключаем EntityFrameworkCore




namespace LK.Models
{
    public class DBContext : DbContext //Обязательное наследоване от класса DbContext
    {
        public DbSet<Data> Datas { get; set; } // Users будет таблица в БД user  
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении (БД будет user как в строке соединения, данные будут браться из таблицы Users)
        }
    }
}

