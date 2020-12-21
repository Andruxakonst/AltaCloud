using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Подключаем EntityFrameworkCore
using LK.Models;


namespace LK.Controllers
{
    public class DataController : Controller
    {

        //обязательный кусок кода для соединения с БД
        private DBContext db;
        public DataController(DBContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Data()
        {
            return View(await db.Datas.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> GetDatas() //public async string Hello(int id)
        {
            //int ID = id;
            //string hello = "Ваш ID - ";
            //User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
            return Json(await db.Datas.ToListAsync());
        }
        // GET: DataController
        //Передать в тестовую въюшку

        /*public JsonResult Hello(int id) //public async string Hello(int id)
        {
            int ID = id;
            string hello = "Ваш ID - ";
            //User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
            return Json($"{hello} {ID}");
        }*/


    }
}
