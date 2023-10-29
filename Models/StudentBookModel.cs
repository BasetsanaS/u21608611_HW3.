using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace u21608611_HW3.Models
{
    public class StudentBookModel
    {
        public IEnumerable<students> studentData { get; set; }
        public IEnumerable<books> bookData { get; set; }

    }
}