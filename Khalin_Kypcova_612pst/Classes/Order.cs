﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khalin_Kypcova_612pst.Classes
{
    public class Order
    {
        public static int Id { get; set; } = 0;
        public IUser user { get; set; }
        public Type type { get; set; }
        public DateTime Date { get; set; }
        public Order() { }
        public Order( IUser _user, Type _type, DateTime _date) 
        {
            Id++;
            user = _user;
            type = _type;
            Date = _date;
        }

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
