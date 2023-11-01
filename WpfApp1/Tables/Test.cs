namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? created_by { get; set; }

        public DateTime? created_at { get; set; }

        public int? subject_id { get; set; }

        public int? duration { get; set; }

        [StringLength(20)]
        public string grading_scale { get; set; }
    }
}
