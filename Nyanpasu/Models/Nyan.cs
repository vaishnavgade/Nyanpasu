using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyanpasu.Models
{
    public class Nyan
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public string[] Comments { get; set; }
    }
}
