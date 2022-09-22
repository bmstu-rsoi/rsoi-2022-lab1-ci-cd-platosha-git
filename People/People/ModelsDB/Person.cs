using System;
using System.Collections.Generic;

#nullable disable

namespace People.ModelsDB
{
    public partial class Person
    {
        public int Personid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
