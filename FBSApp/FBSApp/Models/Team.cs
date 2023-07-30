﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FBSApp.Models
{
    public class Team : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public Stadium Stadium { get; set; }
        public long StadiumId { get; set; }
    }
}
