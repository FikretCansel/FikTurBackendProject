﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class TourOrder:IEntity
    {
        public int Id { get; set; }
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int PacketId { get; set; }
    }
}
