//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            this.Sales = new HashSet<Sales>();
        }
    
        public int ID_Book { get; set; }
        public string NameBook { get; set; }
        public Nullable<int> ID_Theme { get; set; }
        public Nullable<int> ID_Author { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> DrawingOfBook { get; set; }
        public Nullable<System.DateTime> DateOfPublish { get; set; }
        public Nullable<int> Pages { get; set; }
        public int Quantity { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Themes Themes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
