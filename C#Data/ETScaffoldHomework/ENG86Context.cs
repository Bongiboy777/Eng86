using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class ENG86Context : DbContext
    {
        public ENG86Context()
        {
        }

        public ENG86Context(DbContextOptions<ENG86Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Academy> Academies { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<DepartmentSalary> DepartmentSalaries { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employees1 { get; set; }
        public virtual DbSet<Spartan> Spartans { get; set; }
        public virtual DbSet<Stream> Streams { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ENG86;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Academy>(entity =>
            {
                entity.ToTable("ACADEMIES");

                entity.Property(e => e.AcademyId).HasColumnName("academy_ID");

                entity.Property(e => e.AcademyAddress)
                    .IsUnicode(false)
                    .HasColumnName("academy_address")
                    .HasDefaultValueSql("('6th Floor, 125 London Wall, Barbican, London EC2Y 5AS')");

                entity.Property(e => e.AcademyName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("academy_name")
                    .HasDefaultValueSql("('London')");

                entity.Property(e => e.AcademyPopup)
                    .HasColumnName("academy_popup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AcademyStartdate)
                    .HasColumnType("date")
                    .HasColumnName("academy_startdate")
                    .HasDefaultValueSql("('2005-01-01')");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("COURSES");

                entity.Property(e => e.CourseId).HasColumnName("course_ID");

                entity.Property(e => e.CourseDescription)
                    .IsUnicode(false)
                    .HasColumnName("course_description")
                    .HasDefaultValueSql("('Learn to create automation test frameworks in C#')");

                entity.Property(e => e.CourseLength)
                    .HasColumnName("course_length")
                    .HasDefaultValueSql("((12))");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_name")
                    .HasDefaultValueSql("('C# SDET')");

                entity.Property(e => e.StreamId)
                    .HasColumnName("stream_ID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Stream)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.StreamId)
                    .HasConstraintName("FK__COURSES__stream___272FB2E8");
            });

            modelBuilder.Entity<DepartmentSalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DepartmentSalary");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Departmen__Emplo__3607E224");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.ToTable("Employees");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Employee1s)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK__Employees__Depar__4ED38FEE");
            });

            modelBuilder.Entity<Spartan>(entity =>
            {
                entity.Property(e => e.SpartanId).HasColumnName("SpartanID");

                entity.Property(e => e.Achieved)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('2.1')");

                entity.Property(e => e.Course)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Biomedical Engineerig')");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('2020-06-21')");

                entity.Property(e => e.Degree)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BEng(Hons)')");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Bongani')");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Luwemba')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Mr')");

                entity.Property(e => e.University)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('University of Kent')");
            });

            modelBuilder.Entity<Stream>(entity =>
            {
                entity.ToTable("STREAMS");

                entity.Property(e => e.StreamId).HasColumnName("stream_ID");

                entity.Property(e => e.AcademyId)
                    .HasColumnName("academy_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StreamDescription)
                    .IsUnicode(false)
                    .HasColumnName("stream_description")
                    .HasDefaultValueSql("('DevOps, SDET, Machine Learning and more')");

                entity.Property(e => e.StreamName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stream_name")
                    .HasDefaultValueSql("('Engineering')");

                entity.HasOne(d => d.Academy)
                    .WithMany(p => p.Streams)
                    .HasForeignKey(d => d.AcademyId)
                    .HasConstraintName("FK__STREAMS__academy__2176D992");
            });

            modelBuilder.Entity<Trainee>(entity =>
            {
                entity.ToTable("TRAINEES");

                entity.Property(e => e.TraineeId).HasColumnName("trainee_ID");

                entity.Property(e => e.AcademyId)
                    .HasColumnName("academy_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StreamId)
                    .HasColumnName("stream_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TraineeJoindate)
                    .HasColumnType("date")
                    .HasColumnName("trainee_joindate")
                    .HasDefaultValueSql("('2005-01-01')");

                entity.Property(e => e.TraineeName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trainee_name")
                    .HasDefaultValueSql("('Bongani Luwemba')");

                entity.Property(e => e.TrainerId)
                    .HasColumnName("trainer_ID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Academy)
                    .WithMany(p => p.Trainees)
                    .HasForeignKey(d => d.AcademyId)
                    .HasConstraintName("FK__TRAINEES__academ__3671F678");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Trainees)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__TRAINEES__course__3A42875C");

                entity.HasOne(d => d.Stream)
                    .WithMany(p => p.Trainees)
                    .HasForeignKey(d => d.StreamId)
                    .HasConstraintName("FK__TRAINEES__stream__385A3EEA");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Trainees)
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK__TRAINEES__traine__3C2ACFCE");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("TRAINERS");

                entity.Property(e => e.TrainerId).HasColumnName("trainer_ID");

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_ID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.TrainerEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trainer_email")
                    .HasDefaultValueSql("('trainer5@spartaglobal.com')");

                entity.Property(e => e.TrainerJoindate)
                    .HasColumnType("date")
                    .HasColumnName("trainer_joindate")
                    .HasDefaultValueSql("('2005-01-01')");

                entity.Property(e => e.TrainerName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trainer_name")
                    .HasDefaultValueSql("('Nishant Mandal')");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Trainers)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__TRAINERS__course__2ED0D4B0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
