using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace TAP2018_19.AuctionSite.Data
{
    public class Site
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Timezone { get; set; }
        public virtual int SessionExpirationInSeconds { get; set; }
        public virtual double MinimumBidIncrement { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Auction> Auctions { get; set; }
    }

    public class Auction
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime EndsOn { get; set; }
        public virtual int SellerId { get; set; }
        public virtual User Seller { get; set; }
        public virtual int CurrentWinnerId { get; set; }
        public virtual User CurrentWinner { get; set; }

    }

    public class Session
    {
        public virtual int Id { get; set; }
        public virtual DateTime ValidUntil { get; set; }
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual int SiteId { get; set; }
        public virtual Site Site { get; set; }
    }

    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual int SiteId { get; set; }
        public virtual Site Site { get; set; }
    }

    public class ASContext : DbContext
    {
        public ASContext(string connectionString) : base(connectionString) { }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
