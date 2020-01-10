using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Record
    {
        public string Name { get; set; }
        public int Id { get; }
        private static List<Record> record_Instances = new List<Record> {};

        public Record(string name)
        {
            Name = name;
            record_Instances.Add(this);
            Id = record_Instances.Count;
        }
    }
}