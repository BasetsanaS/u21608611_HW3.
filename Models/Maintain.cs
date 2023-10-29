using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21608611_HW3.Models
{
    public class Maintain
    {
        public List<types> typeData { get; set; }
        public List<authors> authorData { get; set; }
        public List<borrows> borrowData { get; set; }
    }
}