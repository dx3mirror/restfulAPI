

namespace RestFulApiHHRU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HolePoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HolePoint()
        {
            this.Hole = new HashSet<Hole>();
        }
    
        public int Id { get; set; }
        public Nullable<int> HoleId { get; set; }
        public Nullable<int> X { get; set; }
        public Nullable<int> Y { get; set; }
        public Nullable<int> Z { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hole> Hole { get; set; }
    }
}
