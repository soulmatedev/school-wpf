using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfApp1
{
    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Answer_Option> Answer_Option { get; set; }
        public virtual DbSet<Assigned_Test> Assigned_Test { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Group_Subject> Group_Subject { get; set; }
        public virtual DbSet<Head_Teacher> Head_Teacher { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Teacher_Subject> Teacher_Subject { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Test_Result> Test_Result { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Answer_Option>()
                .Property(e => e.answer_text)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Head_Teacher>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Head_Teacher>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.question_text)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.hint)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.question_type)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.grading_scale)
                .IsUnicode(false);
        }
    }
}
