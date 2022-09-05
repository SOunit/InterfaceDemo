using System;

namespace InterfaceDemo
{
    internal class Ticket : IEquatable<Ticket>
    {
        public int DurationHours { get; set; }

        public Ticket(int durationHours)
        {
            DurationHours = durationHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationHours == other.DurationHours;
        }
    }
}
