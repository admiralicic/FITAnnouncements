using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FITAnnouncements.Data.EF.DAL;
using FITAnnouncements.Data.EF.BLL;

namespace FITAnnouncements.Admin
{
    public static class Session
    {
        public static User LoggedInUser  { get; set; }
    }
}
