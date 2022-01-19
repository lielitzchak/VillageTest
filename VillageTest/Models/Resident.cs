using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VillageTest.Models
{
    public class Resident
    {
        int id;
        string fathersName;
        string gender;
        bool isBornInVillage;
        DateTime birthDay;
        public Resident(int _id, string _fathersName, string _gender, bool _isBornInVillage, DateTime _birthDay)
        {
            this.id = _id;
            this.fathersName = _fathersName;
            this.gender = _gender;
            this.isBornInVillage = _isBornInVillage;
            this.birthDay = _birthDay;
        }
        //Add-Migration CreateTable

            public Resident() { }
        public int Id { get; set; }
        public string FathersName { get; set; }
        public int Gender { get; set; }
        public bool IsBornInVillage { get; set; }
        public DateTime BirthDay { get; set; }
        //ID , מגדר, האם נולד בכפר ותאריך לידה.
    }
}