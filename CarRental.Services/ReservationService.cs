using CarRental.Data;
using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Services
{

    public class ReservationService
    {
        private readonly AppDbContext context;

        
        public Reservation GetReservationById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Reservations.Find(id);
            }
        }

        public List<Reservation> GetAllReservations()
        {
            using (var context = new AppDbContext())
            {
                return context.Reservations.ToList();
            }
        }

        public List<Reservation> GetReservationsByCustomerId(int customerId)
        {
            using (var context = new AppDbContext())
            {
                return context.Reservations.Where(r => r.CustomerId == customerId).ToList();
            }
        }

        public List<Reservation> GetReservationsByVehicleId(int vehicleId)
        {
            using (var context = new AppDbContext())
            {
                return context.Reservations.Where(r => r.VehicleId == vehicleId).ToList();
            }
        }

        public Reservation AddReservation(DateTime startDate, DateTime endDate, int vehicleId, int customerId)
        {
            using (var context = new AppDbContext())
            {
                var reservation = new Reservation
                {
                    StartDate = startDate,
                    EndDate = endDate,
                    VehicleId = vehicleId,
                    CustomerId = customerId
                };

                context.Reservations.Add(reservation);
                context.SaveChanges();

                return reservation;
            }
        }
    }
}
