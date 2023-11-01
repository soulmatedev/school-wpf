namespace school_wpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Answer = new HashSet<Answer>();
        }

        public int id { get; set; }

        public int test_id { get; set; }

        [Required]
        [StringLength(255)]
        public string question_text { get; set; }

        [StringLength(50)]
        public string question_hint { get; set; }

        public int question_weight { get; set; }

        [Required]
        [StringLength(50)]
        public string qestion_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answer { get; set; }

        public virtual Test Test { get; set; }
    }
}
