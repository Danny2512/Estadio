﻿namespace Estadio.Data.Entities
{
    public class EntranceGateTiket
    {
        public Guid TicketId { get; set; }
        public Guid EntranceGateId { get; set; }
        public Tiket Tiket { get; set; }
        public EntranceGate EntranceGate { get; set; }
    }
}
