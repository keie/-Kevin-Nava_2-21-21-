using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class Album
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}