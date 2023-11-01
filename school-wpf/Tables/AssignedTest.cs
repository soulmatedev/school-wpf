namespace school_wpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssignedTest")]
    public partial class AssignedTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssignedTest()
        {
            TestResult = new HashSet<TestResult>();
        }

        public int id { get; set; }

        public int test_id { get; set; }

        public int attempts_allowed { get; set; }

        public int assigned_by { get; set; }

        public int assigned_to { get; set; }

        public DateTime? assigned_at { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestResult> TestResult { get; set; }
    }
}
