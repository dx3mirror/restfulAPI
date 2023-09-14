

namespace RestFulApiHHRU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrillBlock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrillBlock()
        {
            this.Hole = new HashSet<Hole>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> DrillBlockPoint { get; set; }
    
        public virtual DrillBlockPoint DrillBlockPoint1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hole> Hole { get; set; }
    }
}
