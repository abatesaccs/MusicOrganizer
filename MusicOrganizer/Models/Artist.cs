using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public int Id { get; }
        public List<Record> Records { get; set; }
        private static List<Artist> _instances = new List<Artist> {};

        public Artist(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
            Records = new List<Record>{};
        }

        public static List<Artist> GetAll()
        {
            return _instances;
        }
    }
}