﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Domain.Enums.Status;

namespace TaskSystem.core.Domain.DTOs.ChallengeDTO
{
    public record ChallengeCreateDTO
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationDays { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}
