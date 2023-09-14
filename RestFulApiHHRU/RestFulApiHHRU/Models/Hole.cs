

namespace RestFulApiHHRU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> DrillBlockId { get; set; }
        public Nullable<int> Depth { get; set; }
        public Nullable<int> DrillBlock { get; set; }
        public Nullable<int> HolePoints { get; set; }
    
        public virtual DrillBlock DrillBlock1 { get; set; }
        public virtual HolePoint HolePoint { get; set; }
    }
}
