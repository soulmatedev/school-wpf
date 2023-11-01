namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? test_id { get; set; }

        [StringLength(100)]
        public string question_text { get; set; }

        [StringLength(50)]
        public string hint { get; set; }

        public int? weight { get; set; }

        [StringLength(50)]
        public string question_type { get; set; }
    }
}
