//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API
{
    using System;
    using System.Collections.Generic;
    
    public partial class value
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public value()
        {
            this.BoardIds = new HashSet<BoardId>();
        }
    
        public int id { get; set; }
        public Nullable<int> board_id { get; set; }
        public Nullable<decimal> temperature { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardId> BoardIds { get; set; }
    }
}
