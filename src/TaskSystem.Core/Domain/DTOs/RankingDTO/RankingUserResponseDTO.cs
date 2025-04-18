﻿using TaskSystem.Core.Domain.DTOs.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Core.Domain.DTOs.RankingDTO
{
    public record RankingUserResponseDTO : UserScoreDTO
    {
        public int Position { get; set; }
        public int Score { get; set; }
        public int CompletedTasks { get; set; }

    }
}
