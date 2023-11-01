namespace school_wpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupSubject")]
    public partial class GroupSubject
    {
        public int id { get; set; }

        public int group_id { get; set; }

        public int subject_id { get; set; }

        public virtual Group Group { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
