﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErucaCRM.Domain;
namespace ErucaCRM.Business.Interfaces
{
   public interface ITimeZoneBusiness
    {
        List<TimeZoneModal> GetTimeZones();
    }
}
