﻿using System;

namespace HealthAppGCU.Models
{
    public class HealthcareActivityViewModel
    {
        public HealthcareActivityViewModel()
        {
            Date = DateTime.Now;
        }

        public string Id { get; set; }

        public DateTime? Date { get; set; }

        public int? Calories { get; set; }

        public double? WaterIntake { get; set; }

        public TimeSpan? HoursSlept { get; set; }

        public double? Weight { get; set; }
    }
}
