namespace school_wpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer
    {
        public int id { get; set; }

        public int question_id { get; set; }

        [Required]
        [StringLength(255)]
        public string answer_text { get; set; }

        public bool is_correct { get; set; }

        public virtual Question Question { get; set; }
    }
}
