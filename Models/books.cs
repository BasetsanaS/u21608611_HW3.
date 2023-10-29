//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace u21608611_HW3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class books
    {
        [Key]
        public int bookId { get; set; }

        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "Book name is required")]
        [StringLength(100, ErrorMessage = "Book name cannot exceed 100 characters")]
        public string name { get; set; }

        [Display(Name = "Page Count")]
        [Range(1, int.MaxValue, ErrorMessage = "Page count must be greater than 0")]
        public Nullable<int> pagecount { get; set; }

        [Display(Name = "Points")]
        [Range(0, int.MaxValue, ErrorMessage = "Points must be non-negative")]
        public Nullable<int> point { get; set; }

        [Display(Name = "Author ID")]
        [Required(ErrorMessage = "Author ID is required")]
        public Nullable<int> authorId { get; set; }

        [Display(Name = "Type ID")]
        [Required(ErrorMessage = "Type ID is required")]
        public Nullable<int> typeId { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        public virtual authors authors { get; set; }
        public virtual types types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<borrows> borrows { get; set; }
    }
}

