﻿using System;

namespace MyFootballRestApi.Models
{
    public class Player : EntityBase<Player>
    {
        public string UserId { get; set; }
        public Position Position { get; set; }
        public byte[] Avatar { get; set; }
        public PhysicalStats PhysicalStats { get; set; }
        public bool HasTrained { get; set; }
        public int TeamId { get; set; }

        // if has teamId
        public int Number { get; set; }

        // if has teamId
        public bool IsCaptain { get; set; }
    }
}
