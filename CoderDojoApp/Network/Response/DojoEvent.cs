using System;

namespace CoderDojoApp.Network.Response
{
    [Serializable]
    public class DojoEvent
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public String Logo { get; set; }
        public String Icon { get; set; }
        public String TicketUrl { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public int Capacity { get; set; }
        public int Participants { get; set; }
        public DojoLocation Location { get; set; }
        public DojoOrganizer Organizer { get; set; }
        public bool Free { get; set; } = true;
        public float Price { get; set; }
        
    }

    [Serializable]
    public class DojoLocation
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public String PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Distance { get; set; }
    }

    [Serializable]
    public class DojoOrganizer
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Platform { get; set; }
    }

}