﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MockAssessment7.Models
{
    public class PlayerClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public PlayerClass(int id, string name, string type)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
        }

        private List<PlayerClass> playerClassList = new List<PlayerClass>();

        
    }
}
