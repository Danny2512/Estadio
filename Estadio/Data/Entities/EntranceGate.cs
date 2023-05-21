﻿namespace Estadio.Data.Entities
{
    public class EntranceGate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<EntranceGateTiket> EntranceGateTiket { get; set; }
    }
}
