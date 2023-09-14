

namespace RestFulApiHHRU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrillBlockPoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrillBlockPoint()
        {
            this.DrillBlock = new HashSet<DrillBlock>();
        }
    
        public int Id { get; set; }
        public Nullable<int> DrillBlockId { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> X { get; set; }
        public Nullable<int> Y { get; set; }
        public Nullable<int> Z { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrillBlock> DrillBlock { get; set; }
    }
}
