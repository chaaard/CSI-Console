﻿using CSI.Application.DTOs;
using CSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI.Application.Interfaces
{
    public interface IAnalyticsService
    {
        Task SalesAnalytics(AnalyticsParamsDto analyticsParam);
    }
}
