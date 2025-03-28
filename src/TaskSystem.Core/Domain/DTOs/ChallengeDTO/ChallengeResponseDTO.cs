﻿using TaskSystem.Core.Domain.Enums.Status;

namespace TaskSystem.Core.Domain.DTOs.ChallengeDTO
{
    public record ChallengeResponseDTO
    {
        public Guid Id { get; set; }
        public string ChallengeName { get; set; }
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
    }
}
