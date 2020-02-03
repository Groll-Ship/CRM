using System;

namespace data.Models
{
    public class Teacher : IEntity
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
    }
}
