using System;

namespace data.Models
{
    public class Teachers : IEntity
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
    }
}
