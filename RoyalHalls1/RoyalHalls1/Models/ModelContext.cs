using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RoyalHalls1.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<HallsTime> HallsTimes { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=JOR15_User52;PASSWORD=O2000A;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("JOR15_USER52")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("ABOUT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Descriotion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIOTION");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PHOTO");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("CONTACT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Messeages)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MESSEAGES");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");
            });

            modelBuilder.Entity<Hall>(entity =>
            {
                entity.HasKey(e => e.HId)
                    .HasName("SYS_C00269750");

                entity.ToTable("HALLS");

                entity.Property(e => e.HId)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("H_ID");

                entity.Property(e => e.HAddress)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("H_ADDRESS");

                entity.Property(e => e.HDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("H_DESCRIPTION");

                entity.Property(e => e.HName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("H_NAME");

                entity.Property(e => e.HPhoto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("H_PHOTO");

                entity.Property(e => e.HPrice)
                    .HasColumnType("NUMBER")
                    .HasColumnName("H_PRICE");
            });

            modelBuilder.Entity<HallsTime>(entity =>
            {
                entity.ToTable("HALLS_TIME");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.FullDate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FULL_DATE");

                entity.Property(e => e.HallId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HALL_ID");

                entity.Property(e => e.TimeFromto)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TIME_FROMTO");

                entity.HasOne(d => d.Hall)
                    .WithMany(p => p.HallsTimes)
                    .HasForeignKey(d => d.HallId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("HALLTIME_FK");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("HOME");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.GalImg1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GAL_IMG1");

                entity.Property(e => e.GalImg2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GAL_IMG2");

                entity.Property(e => e.GalImg3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GAL_IMG3");

                entity.Property(e => e.GalImg4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GAL_IMG4");

                entity.Property(e => e.LogoImage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LOGO_IMAGE");

                entity.Property(e => e.Medialink1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MEDIALINK1");

                entity.Property(e => e.Medialink2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MEDIALINK2");

                entity.Property(e => e.Medialink3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MEDIALINK3");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.SImage1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("S_IMAGE1");

                entity.Property(e => e.SImage2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("S_IMAGE2");

                entity.Property(e => e.SImage3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("S_IMAGE3");

                entity.Property(e => e.Title)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Titledesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLEDESC");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("PAYMENT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ballance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BALLANCE");

                entity.Property(e => e.CardName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CARD_NAME");

                entity.Property(e => e.Cvv)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CVV");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXPIRATION_DATE");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERS_PAYMENT_FK");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("REPORT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RepDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REP_DATE");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("RESERVATION");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Datefrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEFROM");

                entity.Property(e => e.Dateto)
                    .HasColumnType("DATE")
                    .HasColumnName("DATETO");

                entity.Property(e => e.FullTime)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FULL_TIME");

                entity.Property(e => e.HallsId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HALLS_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTAL_PRICE");

                entity.Property(e => e.UsersId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERS_ID");

                entity.HasOne(d => d.Halls)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.HallsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERS_HALLS_FK1");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERS_HALLS_FK");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RId)
                    .HasName("SYS_C00269743");

                entity.ToTable("ROLE");

                entity.Property(e => e.RId)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("R_ID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIAL");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CONTENT");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FNAME");

                entity.Property(e => e.Lname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LNAME");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PHOTO");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Userpassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERPASSWORD");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERS_FK");
            });

            modelBuilder.HasSequence("DEPID");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
