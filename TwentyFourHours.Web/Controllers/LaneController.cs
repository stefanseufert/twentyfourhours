﻿using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHours.Web.Controllers
{
    public class LaneController: NancyModule
    {
        public LaneController() : base("/lane")
        {

        }
    }
}
