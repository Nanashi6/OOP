using System;

namespace LibForLab6
{
    public struct Ticket
    {
        public DateTime date;
        public Place place;

        public Ticket(DateTime date, Place place)
        {
            this.date = date;
            this.place = place;
        }

    }
}
