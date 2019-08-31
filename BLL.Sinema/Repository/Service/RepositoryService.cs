using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository.Service
{
    public class RepositoryService
    {
        private readonly CustomerRepository customerRepository;
        private readonly HallRepository hallRepository;
        private readonly MovieRepository movieRepository;
        private readonly SeanceRepository seanceRepository;
        private readonly SeatRepository seatRepository;
        private readonly TicketRepository ticketRepository;
        private readonly TicketSeatRepository ticketSeatRepository;
        private readonly UserRepository userRepository;
        private readonly RoleRepository roleRepository;
        public RepositoryService()
        {
            customerRepository = new CustomerRepository();
            hallRepository = new HallRepository();
            movieRepository = new MovieRepository();
            seanceRepository = new SeanceRepository();
            seatRepository = new SeatRepository();
            ticketRepository = new TicketRepository();
            ticketSeatRepository = new TicketSeatRepository();
            userRepository = new UserRepository();
            roleRepository = new RoleRepository();
        }
        public CustomerRepository Customer => customerRepository;
        public HallRepository Hall => hallRepository;
        public MovieRepository Movie => movieRepository;
        public SeanceRepository Seance => seanceRepository;
        public SeatRepository Seat => seatRepository;
        public TicketRepository Ticket => ticketRepository;
        public TicketSeatRepository TicketSeat => ticketSeatRepository;
        public UserRepository User => userRepository;
        public RoleRepository Role => roleRepository;
    }
}
