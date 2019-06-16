using System;
namespace StudentOrganizer.Entities
{
    //Entity for interaction with database 
    public class Student
    {
        public int      Id { get; set; }
        public string   FirstName { get; set; }
        public string   LastName { get; set; }
        public int      Age { get; set; }
        public string   Status { get; set; }
    }
}
