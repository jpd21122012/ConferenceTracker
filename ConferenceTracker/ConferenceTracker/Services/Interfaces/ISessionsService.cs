﻿using ConferenceTracker.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConferenceTracker.Services.Interfaces
{
    public interface ISessionsService
    {
        Task<IEnumerable<Session>> GetAllSessions();
    }
}