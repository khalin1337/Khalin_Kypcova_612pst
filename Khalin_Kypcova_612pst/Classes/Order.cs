using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khalin_Kypcova_612pst.Classes
{
    public class Order
    {
        public int Id { get; set; }
        public User user { get; set; }
        public Type type { get; set; }
        public DateTimeOffset Date { get; set; }

    }
    public enum Type
    {
       Укладка,
       Стрижка,
       Нігті,
       Фарбування,
       Вії,
       Брови,
       Косметолог
    }
}
