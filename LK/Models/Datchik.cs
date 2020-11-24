using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace LK.Models
{
    public class Datchik
    {
        public int DatId { get; set; }                      // Id Датчика
        public int DatTipe { get; set; }                    // Тип датчика
        public string DatName { get; set; }                 // Название данчика
        public double DatZnach { get; set; }                // показания датчика
        public bool DatOnOff { get; set; }                  // есть данные с датчика или нет
        public DateTime DatDataTime { get; set; }           // дата и время полученных даннх от датчика
        public string DatEdIzm { get; set; }                // Еденици измерения в зависимости от типа датчика
        public double DatMinZnach { get; set; }             // Минимальные значения датчика
        public double DatMaxZnach { get; set; }             // Максимальные значения датчика

    }
    class DatchiksDatabase
    {
        public static IEnumerable<Datchik> Datchiks
        {
            get
            {
                Thread.Sleep(2000);

                List<Datchik> list = new List<Datchik>();
                list.Add(new Datchik() { DatId = 1, DatTipe = 1, DatName = "Температура1", DatZnach = 23.51, DatOnOff = true, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50});
                list.Add(new Datchik() { DatId = 2, DatTipe = 1, DatName = "Температура2", DatZnach = 23.51, DatOnOff = true, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50 });
                list.Add(new Datchik() { DatId = 3, DatTipe = 2, DatName = "Влажность1", DatZnach = 23.51, DatOnOff = false, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50 });
                list.Add(new Datchik() { DatId = 4, DatTipe = 2, DatName = "Влажность2", DatZnach = 23.51, DatOnOff = true, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50 });
                list.Add(new Datchik() { DatId = 5, DatTipe = 3, DatName = "Давление", DatZnach = 23.51, DatOnOff = true, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50 });
                list.Add(new Datchik() { DatId = 6, DatTipe = 4, DatName = "Уровень1", DatZnach = 23.51, DatOnOff = false, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50 });
                list.Add(new Datchik() { DatId = 7, DatTipe = 4, DatName = "Уровень2", DatZnach = 23.51, DatOnOff = true, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50 });
                list.Add(new Datchik() { DatId = 8, DatTipe = 5, DatName = "Проток1", DatZnach = 23.51, DatOnOff = true, DatDataTime = new DateTime(2020, 7, 20, 18, 30, 25), DatEdIzm = " °C", DatMinZnach = 0, DatMaxZnach = 50 });

                return list;
            }
        }

    }
}
