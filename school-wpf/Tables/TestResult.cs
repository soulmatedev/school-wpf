namespace school_wpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestResult")]
    public partial class TestResult
    {
        public int id { get; set; }

        public int? assigned_test_id { get; set; }

        public DateTime start_time { get; set; }

        public DateTime finish_time { get; set; }

        public virtual AssignedTest AssignedTest { get; set; }
    }
}
