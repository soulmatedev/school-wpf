namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Assigned_Test
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? test_id { get; set; }

        public int? attempts_allowed { get; set; }

        public int? assigned_by { get; set; }

        public int? assigned_to { get; set; }

        public DateTime? assigned_at { get; set; }
    }
}
