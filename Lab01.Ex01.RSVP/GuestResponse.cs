using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace Lab01.Ex01.RSVP
{
    
    public class GuestResponse
    {
        public int GuestResponseIdId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        public DateTime Rdata { get; set; }

        public GuestResponse() { }
        public GuestResponse(string name, string email, string phone, bool? willattend)
        { 
            Name = name;
            Email = email;
            Phone = phone;
            WillAttend = willattend;
            Rdata = DateTime.Now;
        }

    }
    
}