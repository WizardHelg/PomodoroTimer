﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PomodoroTimer
{
    /// <summary>
    /// Настройки
    /// </summary>
    internal class Settings
    {
        public enum Name
        {
            WorkPeriod,
            SmallRelaxPeriod,
            BigRelaxPeriod,
            PomodoroAmaunt
        }

        private readonly Dictionary<Name, int> data = new()
        {
            [Name.WorkPeriod] = 25,
            [Name.SmallRelaxPeriod] = 5,
            [Name.BigRelaxPeriod] = 15,
            [Name.PomodoroAmaunt] = 4
        };

        [JsonPropertyName("workPeriod")]
        public int WorkPeriod
        {
            get => data[Name.WorkPeriod];
            set => data[Name.WorkPeriod] = value;
        }

        [JsonPropertyName("smallRelaxPeriod")]
        public int SmallRelaxPeriod
        {
            get => data[Name.SmallRelaxPeriod];
            set => data[Name.SmallRelaxPeriod] = value;
        }

        [JsonPropertyName("bigRelaxPeriod")]
        public int BigRelaxPeriod
        {
            get => data[Name.BigRelaxPeriod];
            set => data[Name.BigRelaxPeriod] = value;
        }

        [JsonPropertyName("pomodoroAmount")]
        public int PomodoroAmaunt
        {
            get => data[Name.PomodoroAmaunt];
            set => data[Name.PomodoroAmaunt] = value;
        }

        public int this[Name name]
        {
            get => data[name];
            set => data[name] = value;
        }
    }
}
