using app_csharpBTS.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_csharpBTS.Manager
{
    class StaffManager : DataManager
    {
        public staff AddStaff(staff staff)
        {
            Context.staff.Add(staff);
            if (Context.SaveChanges() > 0)
                return staff;
            return null;
        }
        public bool RemoveStaff(staff staff)
        {
            if (staff != null)
            {
                Context.staff.Remove(staff);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool RemoveStaff(int idStaff)
        {
            staff staff = FindStaffID(idStaff);
            if (staff == null)
                return false;
            return RemoveStaff(staff);
        }
        public bool EditStaff(staff staff)
        {
            Context.Entry(staff).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }
        public staff FindStaffID(int idStaff)
        {
            return Context.staff.Find(idStaff);
        }
        public staff FindStaffName(string Username)
            => Context.staff.FirstOrDefault(staff => staff.Username == Username);
        public List<staff> GetStaff()
            => Context.staff.ToList();
    }
}
