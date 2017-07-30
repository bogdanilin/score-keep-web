﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeepWeb.Models
{
    public class Member
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

        public DateTime JoinedOn { get; set; }


        public User User { get; set; }

        public Group Group { get; set; }

        
    }
}
