namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test_Result
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? assigned_test_id { get; set; }

        public TimeSpan? start_time { get; set; }

        public TimeSpan? end_time { get; set; }

        public double? score { get; set; }
    }
}
