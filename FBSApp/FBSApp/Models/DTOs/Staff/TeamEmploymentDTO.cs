﻿namespace FBSApp.Models.DTOs.Staff
{
    public class TeamEmploymentDTO
    {
        public long TeamId { get; set; }
        public string TeamName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TeamLogo { get; set; }
    }
}
