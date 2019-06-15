using System;
namespace StudentOrganizer.Models
{
    public class StudentModel
    {
        public int      id          { get; set; }
        public string   firstName   { get; set; }
        public string   lastName    { get; set; }
        public int      age         { get; set; }
        public string   status      { get; set; }
    }
}
