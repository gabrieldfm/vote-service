﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting.Application.Interfaces.Repositories;

public interface IVotingRepository
{
    Task CreateVotingAsync();
}
