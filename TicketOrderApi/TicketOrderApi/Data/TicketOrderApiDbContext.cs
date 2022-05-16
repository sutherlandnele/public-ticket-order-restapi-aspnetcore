﻿using TicketOrderApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketOrderApi.Data
{
    public class TicketOrderApiDbContext : DbContext
    {
        public TicketOrderApiDbContext(DbContextOptions<TicketOrderApiDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }    
    }
}