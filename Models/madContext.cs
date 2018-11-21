using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mad3.Models
{
    public partial class madContext : DbContext
    {
        public madContext()
        {
        }

        public madContext(DbContextOptions<madContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Days> Days { get; set; }
        public virtual DbSet<Degrees> Degrees { get; set; }
        public virtual DbSet<DegreesHistory> DegreesHistory { get; set; }
        public virtual DbSet<DegreesHistoryLog> DegreesHistoryLog { get; set; }
        public virtual DbSet<DegreesLog> DegreesLog { get; set; }
        public virtual DbSet<DegreesMax> DegreesMax { get; set; }
        public virtual DbSet<DegreesPublish> DegreesPublish { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<Inbox> Inbox { get; set; }
        public virtual DbSet<Levels> Levels { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<Relations> Relations { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Semesters> Semesters { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Times> Times { get; set; }
        public virtual DbSet<TimeTable> TimeTable { get; set; }
        public virtual DbSet<UserKinds> UserKinds { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersModules> UsersModules { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
        public virtual DbSet<Years> Years { get; set; }

        // Unable to generate entity type for table 'public.password_resets'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=mad;Username=postgres;Password=Lion@king");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.ToTable("addresses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuildingNum)
                    .HasColumnName("building_num")
                    .HasMaxLength(100);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(255);

                entity.Property(e => e.FlatNum)
                    .HasColumnName("flat_num")
                    .HasMaxLength(100);

                entity.Property(e => e.MoreDetials).HasColumnName("more_detials");

                entity.Property(e => e.PrimaryAddress)
                    .HasColumnName("primary_address")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("Refcountries151");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Refusers189");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("cities");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CCode)
                    .HasColumnName("c_code")
                    .HasMaxLength(30);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("countries");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(30);

                entity.Property(e => e.CountryA)
                    .HasColumnName("country_a")
                    .HasMaxLength(30);

                entity.Property(e => e.CountryE)
                    .HasColumnName("country_e")
                    .HasMaxLength(30);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.NationalityA)
                    .HasColumnName("nationality_a")
                    .HasMaxLength(30);

                entity.Property(e => e.NationalityAF)
                    .HasColumnName("nationality_a_f")
                    .HasMaxLength(30);

                entity.Property(e => e.NationalityE)
                    .HasColumnName("nationality_e")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneCode)
                    .HasColumnName("phone_code")
                    .HasMaxLength(30);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.ToTable("customers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(0) without time zone");
            });

            modelBuilder.Entity<Days>(entity =>
            {
                entity.ToTable("days");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DayA)
                    .HasColumnName("day_a")
                    .HasMaxLength(100);

                entity.Property(e => e.DayE)
                    .HasColumnName("day_e")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Degrees>(entity =>
            {
                entity.ToTable("degrees");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.FinalOral)
                    .HasColumnName("final_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinalPractical)
                    .HasColumnName("final_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(100);

                entity.Property(e => e.MedOral)
                    .HasColumnName("med_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedPractical)
                    .HasColumnName("med_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedYear)
                    .HasColumnName("med_year")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SemeterId).HasColumnName("semeter_id");

                entity.Property(e => e.SerialId).HasColumnName("serial_id");

                entity.Property(e => e.StdId).HasColumnName("std_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<DegreesHistory>(entity =>
            {
                entity.ToTable("degrees_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.FinalOral)
                    .HasColumnName("final_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinalPractical)
                    .HasColumnName("final_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(100);

                entity.Property(e => e.MedOral)
                    .HasColumnName("med_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedPractical)
                    .HasColumnName("med_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedYear)
                    .HasColumnName("med_year")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Percent).HasColumnName("percent");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.Property(e => e.StdId).HasColumnName("std_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<DegreesHistoryLog>(entity =>
            {
                entity.ToTable("degrees_history_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasColumnName("action_name")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.FinalOral)
                    .HasColumnName("final_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinalPractical)
                    .HasColumnName("final_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(100);

                entity.Property(e => e.MedOral)
                    .HasColumnName("med_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedPractical)
                    .HasColumnName("med_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedYear)
                    .HasColumnName("med_year")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Percent).HasColumnName("percent");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.Property(e => e.StdId).HasColumnName("std_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<DegreesLog>(entity =>
            {
                entity.ToTable("degrees_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionName)
                    .HasColumnName("action_name")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.FinalOral)
                    .HasColumnName("final_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinalPractical)
                    .HasColumnName("final_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedOral)
                    .HasColumnName("med_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedPractical)
                    .HasColumnName("med_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedYear)
                    .HasColumnName("med_year")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SemeterId).HasColumnName("semeter_id");

                entity.Property(e => e.SerialId).HasColumnName("serial_id");

                entity.Property(e => e.StdId).HasColumnName("std_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<DegreesMax>(entity =>
            {
                entity.ToTable("degrees_max");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.FinalOral)
                    .HasColumnName("final_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinalPractical)
                    .HasColumnName("final_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedOral)
                    .HasColumnName("med_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedPractical)
                    .HasColumnName("med_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedYear)
                    .HasColumnName("med_year")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SemeterId).HasColumnName("semeter_id");

                entity.Property(e => e.StdId).HasColumnName("std_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<DegreesPublish>(entity =>
            {
                entity.ToTable("degrees_publish");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Final).HasColumnName("final");

                entity.Property(e => e.FinalOral)
                    .HasColumnName("final_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinalPractical)
                    .HasColumnName("final_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedOral)
                    .HasColumnName("med_oral")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedPractical)
                    .HasColumnName("med_practical")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MedYear)
                    .HasColumnName("med_year")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SemeterId).HasColumnName("semeter_id");

                entity.Property(e => e.StdId).HasColumnName("std_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.ToTable("events");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllDay)
                    .HasColumnName("all_day")
                    .HasMaxLength(255);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasMaxLength(255);

                entity.Property(e => e.EventTypeId).HasColumnName("event_type_id");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasMaxLength(255);

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grade");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DegreeFrom).HasColumnName("degree_from");

                entity.Property(e => e.DegreeTo).HasColumnName("degree_to");

                entity.Property(e => e.Grade1)
                    .HasColumnName("grade")
                    .HasMaxLength(100);

                entity.Property(e => e.GradeArabic)
                    .HasColumnName("grade_arabic")
                    .HasMaxLength(100);

                entity.Property(e => e.GradeEnglish)
                    .HasColumnName("grade_english")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Inbox>(entity =>
            {
                entity.ToTable("inbox");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttacheId).HasColumnName("attache_id");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.FromUser).HasColumnName("from_user");

                entity.Property(e => e.Read)
                    .HasColumnName("read")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.ToUser).HasColumnName("to_user");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(0) without time zone");
            });

            modelBuilder.Entity<Levels>(entity =>
            {
                entity.ToTable("levels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LevelArabic)
                    .HasColumnName("level_arabic")
                    .HasMaxLength(100);

                entity.Property(e => e.LevelCode)
                    .HasColumnName("level_code")
                    .HasMaxLength(100);

                entity.Property(e => e.LevelEnglish)
                    .HasColumnName("level_english")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.ToTable("locations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Building)
                    .HasColumnName("building")
                    .HasMaxLength(100);

                entity.Property(e => e.Capacity)
                    .HasColumnName("capacity")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(100);

                entity.Property(e => e.LevelId)
                    .HasColumnName("level_id")
                    .HasMaxLength(100);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(100);

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.SchoolId).HasColumnName("school_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration)
                    .IsRequired()
                    .HasColumnName("migration")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.ToTable("modules");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("notifications");

                entity.HasIndex(e => new { e.NotifiableId, e.NotifiableType })
                    .HasName("notifications_notifiable_id_notifiable_type_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.NotifiableId).HasColumnName("notifiable_id");

                entity.Property(e => e.NotifiableType)
                    .IsRequired()
                    .HasColumnName("notifiable_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ReadAt)
                    .HasColumnName("read_at")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(0) without time zone");
            });

            modelBuilder.Entity<Parents>(entity =>
            {
                entity.ToTable("parents");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.RelationId).HasColumnName("relation_id");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Parents)
                    .HasForeignKey<Parents>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers149");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.RelationId)
                    .HasConstraintName("Refrelations193");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("Refstudnets157");
            });

            modelBuilder.Entity<Relations>(entity =>
            {
                entity.ToTable("relations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("religion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Schools>(entity =>
            {
                entity.ToTable("schools");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AName)
                    .HasColumnName("a_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.EName)
                    .IsRequired()
                    .HasColumnName("e_name")
                    .HasMaxLength(100);

                entity.Property(e => e.MoreInfo).HasColumnName("more_info");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Semesters>(entity =>
            {
                entity.ToTable("semesters");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ControlSemester)
                    .HasColumnName("control_semester")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.SemesterCode)
                    .HasColumnName("semester_code")
                    .HasMaxLength(100);

                entity.Property(e => e.SemsterId).HasColumnName("semster_id");

                entity.Property(e => e.StudySemester)
                    .HasColumnName("study_semester")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.ToTable("students");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Students)
                    .HasForeignKey<Students>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers178");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("Reflevels172");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("Refstatus176");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.ToTable("subjects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character(255)");

                entity.Property(e => e.Cr).HasColumnName("cr");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.SchoolId).HasColumnName("school_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character(255)");

                entity.Property(e => e.TitleE)
                    .HasColumnName("title_e")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedDate).HasColumnName("updated_date");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("Reflevels201");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Task)
                    .IsRequired()
                    .HasColumnName("task")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(0) without time zone");
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.ToTable("teachers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("character varying");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Teachers)
                    .HasForeignKey<Teachers>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers148");
            });

            modelBuilder.Entity<Times>(entity =>
            {
                entity.ToTable("times");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<TimeTable>(entity =>
            {
                entity.ToTable("time_table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.SchoolId).HasColumnName("school_id");

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.TimeTable)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("Refdays166");

                entity.HasOne(d => d.EndTimeNavigation)
                    .WithMany(p => p.TimeTableEndTimeNavigation)
                    .HasForeignKey(d => d.EndTime)
                    .HasConstraintName("Reftimes165");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.TimeTable)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("Reflevels171");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TimeTable)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("Reflocations167");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.TimeTable)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("Refsemesters170");

                entity.HasOne(d => d.StartTimeNavigation)
                    .WithMany(p => p.TimeTableStartTimeNavigation)
                    .HasForeignKey(d => d.StartTime)
                    .HasConstraintName("Reftimes164");
            });

            modelBuilder.Entity<UserKinds>(entity =>
            {
                entity.ToTable("user_kinds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasColumnType("character(255)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AName)
                    .HasColumnName("a_name")
                    .HasColumnType("character(255)");

                entity.Property(e => e.AName1)
                    .HasColumnName("a_name1")
                    .HasColumnType("character(100)");

                entity.Property(e => e.AName2)
                    .HasColumnName("a_name2")
                    .HasColumnType("character(100)");

                entity.Property(e => e.AName3)
                    .HasColumnName("a_name3")
                    .HasColumnType("character(100)");

                entity.Property(e => e.AName4)
                    .HasColumnName("a_name4")
                    .HasColumnType("character(100)");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.BirthCountryId).HasColumnName("birth_country_id");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("character(100)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.EName)
                    .HasColumnName("e_name")
                    .HasColumnType("character(255)");

                entity.Property(e => e.EName1)
                    .HasColumnName("e_name1")
                    .HasColumnType("character(100)");

                entity.Property(e => e.EName2)
                    .HasColumnName("e_name2")
                    .HasColumnType("character(100)");

                entity.Property(e => e.EName3)
                    .HasColumnName("e_name3")
                    .HasColumnType("character(100)");

                entity.Property(e => e.EName4)
                    .HasColumnName("e_name4")
                    .HasColumnType("character(100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("mobile_number")
                    .HasColumnType("character(10)");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.RelgionId).HasColumnName("relgion_id");

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(100);

                entity.Property(e => e.SchoolId).HasColumnName("school_id");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TelphoneNumber)
                    .HasColumnName("telphone_number")
                    .HasColumnType("character(100)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserImg)
                    .HasColumnName("user_img")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("Refgender190");

                entity.HasOne(d => d.Kind)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.KindId)
                    .HasConstraintName("Refuser_kinds150");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("Refcountries195");

                entity.HasOne(d => d.Relgion)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RelgionId)
                    .HasConstraintName("Refreligion192");
            });

            modelBuilder.Entity<UsersModules>(entity =>
            {
                entity.ToTable("users_modules");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessPage)
                    .HasColumnName("access_page")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Confirm)
                    .HasColumnName("confirm")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatePage)
                    .HasColumnName("create_page")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.Property(e => e.PrintPage)
                    .HasColumnName("print_page")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatePage)
                    .HasColumnName("update_page")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.ToTable("user_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasColumnType("character(255)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Years>(entity =>
            {
                entity.ToTable("years");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Control)
                    .HasColumnName("control")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Study)
                    .HasColumnName("study")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.YearId).HasColumnName("year_id");
            });
        }
    }
}
