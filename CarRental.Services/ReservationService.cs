using CarRental.Data;
using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{

    public class ReservationService
    {
        private readonly AppDbContext _context;

        public ReservationService(AppDbContext context)
        {
            _context = context;
        }

        public Reservation GetReservationById(int id)
        {
            return _context.Reservations.Find(id);
        }

        public List<Reservation> GetAllReservations()
        {
            return _context.Reservations.ToList();
        }

        public List<Reservation> GetReservationsByCustomerId(int customerId)
        {
            return _context.Reservations.Where(r => r.CustomerId == customerId).ToList();
        }

        public List<Reservation> GetReservationsByVehicleId(int vehicleId)
        {
            return _context.Reservations.Where(r => r.VehicleId == vehicleId).ToList();
        }

        public Reservation AddReservation(DateTime startDate, DateTime endDate, int vehicleId, int customerId)
        {
            var reservation = new Reservation
            {
                StartDate = startDate,
                EndDate = endDate,
                VehicleId = vehicleId,
                CustomerId = customerId
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return reservation;
        }
    }
}


