﻿using System.Collections.Generic;
using TAP2018_19.AuctionSite.Interfaces;

namespace TAP2019_20_Project
{
    public class User : IUser
    {
        public IEnumerable<IAuction> WonAuctions()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public string Username { get; }
    }
}