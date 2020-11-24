using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK.Models
{
    public class Objekt
    {
        public int ObjektId { get; set; }                           // Id Объекта
        public string ObjektUser { get; set; }                      // Ответственный за объект
        public string ObjektAddr { get; set; }                      // Место расположения объекта
        public string ObjektName { get; set; }                      // Название объекта
        public string ObjektKontakts { get; set; }                  // Контакты ответственных за объект сотрудников
        public string ObjektDocsAdrr { get; set; }                  // Cсылка на документы по объекту

    }
    class ObjektDatabase
    {
       
        public static IEnumerable<Objekt> Objekt
        {
            
            get
            {
                //Thread.Sleep(2000);
                string UserLodin = "Andruxakonst@yandex.ru";
                List<Objekt> list = new List<Objekt>();
                list.Add(new Objekt() { ObjektId = 1, ObjektUser = UserLodin, ObjektAddr = "Адрес 1", ObjektName = "Объект 1", ObjektKontakts = "1234567890", ObjektDocsAdrr = "documents/obj1"});
                list.Add(new Objekt() { ObjektId = 1, ObjektUser = UserLodin, ObjektAddr = "Адрес 2", ObjektName = "Объект 2", ObjektKontakts = "1234567890", ObjektDocsAdrr = "documents/obj1" });
                list.Add(new Objekt() { ObjektId = 1, ObjektUser = UserLodin, ObjektAddr = "Адрес 3", ObjektName = "Объект 3", ObjektKontakts = "1234567890", ObjektDocsAdrr = "documents/obj1" });
                list.Add(new Objekt() { ObjektId = 1, ObjektUser = UserLodin, ObjektAddr = "Адрес 4", ObjektName = "Объект 4", ObjektKontakts = "1234567890", ObjektDocsAdrr = "documents/obj1" });
                list.Add(new Objekt() { ObjektId = 1, ObjektUser = UserLodin, ObjektAddr = "Адрес 5", ObjektName = "Объект 5", ObjektKontakts = "1234567890", ObjektDocsAdrr = "documents/obj1" });
                list.Add(new Objekt() { ObjektId = 1, ObjektUser = UserLodin, ObjektAddr = "Адрес 6", ObjektName = "Объект 6", ObjektKontakts = "1234567890", ObjektDocsAdrr = "documents/obj1" });
                return list;
            }
        }

    }
}
