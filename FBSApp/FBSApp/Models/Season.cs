﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Season : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Year { get; set; }
        public League League { get; set; }
        public long LeagueId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Match> Matches { get; set; }
    }
}
