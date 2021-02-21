using System;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
    }
}