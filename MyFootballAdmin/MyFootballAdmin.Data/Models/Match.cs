﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFootballAdmin.Data.Models
{
    public class Match:EntityBase<Match>
    {       
        public DateTime MatchDateTime { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public int GoalClub1 { get; set; }
        public int GoalClub2 { get; set; }
        public List<MatchEventBase> Events { get; set; }
        public Guid StadiumId { get; set; }
        public Guid RefereeId { get; set; }
        public Match()
        {
            Events = new List<MatchEventBase>();
        }
        public override string ToString()
        {
            return Team1.Name + " " + GoalClub1.ToString() + " " + GoalClub2.ToString() + " " + Team2.Name + " " + MatchDateTime.ToShortDateString() + MatchDateTime.DayOfWeek;
        }
    }
}
