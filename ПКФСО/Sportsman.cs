using System;

namespace ПКФСО
{
    public class Sportsman
    {
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string LastName { get; set; }
        
        public string Group { get; set; }
        public string Сategory { get; set; }
        public Coach Coach { get; set; }
    }
}