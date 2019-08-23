using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Sinema.Context
{
    public class SinemaContext : DbContext
    {
        public SinemaContext() : base("SinemaConnStr")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketDetail> TicketDetails { get; set; }
        public DbSet<TicketDetail_Seat> TicketDetail_Seats { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<SinemaContext>(new CreateDatabaseIfNotExists<SinemaContext>());
            modelBuilder.Entity<Ticket>()
                .HasRequired(t => t.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.CustomerId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Ticket>()
                .HasRequired(t => t.Seance)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.SeanceId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<TicketDetail>()
                .HasRequired(td => td.Ticket)
                .WithMany(t => t.TicketDetails)
                .HasForeignKey(td => td.TicketId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Seance>()
                .HasRequired(s => s.Movie)
                .WithMany(m => m.Seances)
                .HasForeignKey(s => s.MovieId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Seance>()
                .HasRequired(s => s.Hall)
                .WithMany(h => h.Seances)
                .HasForeignKey(s => s.HallId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Seat>()
                .HasRequired(s => s.Hall)
                .WithMany(s => s.Seats)
                .HasForeignKey(s => s.HallId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<TicketDetail_Seat>()
                .HasRequired(tds => tds.TicketDetail)
                .WithMany(td => td.TicketDetail_Seats)
                .HasForeignKey(tds => tds.TicketDetailId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<TicketDetail_Seat>()
                .HasRequired(tds => tds.Seat)
                .WithMany(s => s.TicketDetail_Seats)
                .HasForeignKey(tds => tds.SeatId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
               .HasRequired(r => r.User)
               .WithMany(u => u.Roles)
               .HasForeignKey(r => r.UserId)
               .WillCascadeOnDelete(false);


            modelBuilder.Entity<Customer>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Customer>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<Customer>()
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(p => p.Surname)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(p => p.Phone)
                .HasMaxLength(11)
                .IsFixedLength()
                .IsOptional();

            modelBuilder.Entity<Hall>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<Hall>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Hall>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<Hall>()
                .Property(p => p.Hall_Code)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Hall>()
                .Property(p => p.Seating_Capacity)
                .IsRequired();

            modelBuilder.Entity<Movie>()
              .Property(p => p.Id)
              .HasColumnOrder(0);
            modelBuilder.Entity<Movie>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Movie>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<Movie>()
                .Property(p => p.Movie_Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(p => p.Movie_Type)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(p => p.Movie_Duration_InMinute)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(p => p.Director)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(p => p.Banner)
                .IsOptional();

            modelBuilder.Entity<Seance>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<Seance>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Seance>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<Seance>()
                .Property(p => p.Start_Time)
                .HasColumnType("datetime2")
                .IsRequired();
            modelBuilder.Entity<Seance>()
                .Property(p => p.End_Time)
                .HasColumnType("datetime2")
                .IsRequired();

            modelBuilder.Entity<Seat>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<Seat>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Seat>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<Seat>()
                .Property(p => p.Price)
                .IsRequired();
            modelBuilder.Entity<Seat>()
                .Property(p => p.Seat_Type)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Ticket>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<Ticket>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Ticket>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<Ticket>()
                .Property(p => p.Ticket_Amount)
                .IsRequired();
            modelBuilder.Entity<Ticket>()
                .Property(p => p.Validity_Date)
                .HasColumnType("datetime2")
                .IsRequired();

            modelBuilder.Entity<TicketDetail>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<TicketDetail>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<TicketDetail>()
                .Property(p => p.IsActive)
                .IsOptional();

            modelBuilder.Entity<TicketDetail_Seat>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<TicketDetail_Seat>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<TicketDetail_Seat>()
                .Property(p => p.IsActive)
                .IsOptional();


            modelBuilder.Entity<User>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<User>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<User>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<User>()
                .Property(p => p.UserName)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(p => p.Password)
                .HasMaxLength(100)
                .IsRequired();


            modelBuilder.Entity<Role>()
                .Property(p => p.Id)
                .HasColumnOrder(0);
            modelBuilder.Entity<Role>()
                .HasKey(c => c.Id)
                .Property(p => p.AddedDate)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Role>()
                .Property(p => p.IsActive)
                .IsOptional();
            modelBuilder.Entity<Role>()
                .Property(p => p.RoleName)
                .HasMaxLength(100)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
