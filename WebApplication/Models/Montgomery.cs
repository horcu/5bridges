﻿using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class Montgomery: MarylandCounties
    {
        public Montgomery()
        {

        }
        public new int GetLength()
        {
            return 15;
        }

        public new string GetCountyInfo()
        {
            return Information;
        }

        public Montgomery(int id, string name, string information, int population) : base(id, name, information, population)
        {
        }
    }
}