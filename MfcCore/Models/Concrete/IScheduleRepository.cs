﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MfcCore.Models.Concrete
{
    interface IScheduleRepository
    {
        IEnumerable<Schedule> Schedules { get; }
    }
}
