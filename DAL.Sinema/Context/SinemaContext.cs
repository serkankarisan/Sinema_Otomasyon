using Entities.Sinema;
using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Sinema.Context
{
    public class SinemaContext:DbContext
    {
        public SinemaContext():base("SinemaConnStr")
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
                .HasRequired(td=>td.Ticket)
                .WithMany(t=>t.TicketDetails)
                .HasForeignKey(td=>td.TicketId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Seance>()
                .HasRequired(s=>s.Movie)
                .WithMany(m=>m.Seances)
                .HasForeignKey(s=>s.MovieId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Seance>()
                .HasRequired(s => s.Hall)
                .WithMany(h => h.Seances)
                .HasForeignKey(s => s.HallId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Seat>()
                .HasRequired(s=>s.Hall)
                .WithMany(s=>s.Seats)
                .HasForeignKey(s=>s.HallId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<TicketDetail_Seat>()
                .HasRequired(tds=>tds.TicketDetail)
                .WithMany(td=>td.TicketDetail_Seats)
                .HasForeignKey(tds=>tds.TicketDetailId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<TicketDetail_Seat>()
                .HasRequired(tds=>tds.Seat)
                .WithMany(s=>s.TicketDetail_Seats)
                .HasForeignKey(tds=>tds.SeatId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<EntityBase>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<EntityBase>()
                .Property(p => p.AddedDate)
                .HasColumnOrder(1)
                .HasColumnType("datetime2")
                .HasColumnAnnotation("DefaultValue", DateTime.Now)
                .IsOptional();
            modelBuilder.Entity<EntityBase>()
                .Property(p => p.IsActive)
                .HasColumnAnnotation("DefaultValue", true)
                .IsOptional();


            base.OnModelCreating(modelBuilder);
        }
    }
}
