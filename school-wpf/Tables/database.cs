using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace school_wpf
{
    public partial class database : DbContext
    {
        public database()
            : base("name=database")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<AssignedTest> AssignedTest { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupSubject> GroupSubject { get; set; }
        public virtual DbSet<HeadTeacher> HeadTeacher { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestResult> TestResult { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Answer>()
                .Property(e => e.answer_text)
                .IsUnicode(false);

            modelBuilder.Entity<AssignedTest>()
                .HasMany(e => e.TestResult)
                .WithOptional(e => e.AssignedTest)
                .HasForeignKey(e => e.assigned_test_id);

            modelBuilder.Entity<Group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.GroupSubject)
                .WithRequired(e => e.Group)
                .HasForeignKey(e => e.subject_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Student)
                .WithOptional(e => e.Group)
                .HasForeignKey(e => e.group_id);

            modelBuilder.Entity<HeadTeacher>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<HeadTeacher>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.question_text)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.question_hint)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.qestion_type)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Answer)
                .WithRequired(e => e.Question)
                .HasForeignKey(e => e.question_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.GroupSubject)
                .WithRequired(e => e.Subject)
                .HasForeignKey(e => e.group_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Test)
                .WithRequired(e => e.Subject)
                .HasForeignKey(e => e.subject_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Teacher)
                .WithMany(e => e.Subject)
                .Map(m => m.ToTable("TeacherSubject").MapLeftKey("subject_id").MapRightKey("teacher_id"));

            modelBuilder.Entity<Teacher>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.AssignedTest)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.assigned_by)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Test)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.test_created_by)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.test_name)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.test_description)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Question)
                .WithRequired(e => e.Test)
                .HasForeignKey(e => e.test_id)
                .WillCascadeOnDelete(false);
        }
    }
}
