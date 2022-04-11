using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsForm.Helpers
{
    public static class GroupSpecialityHelper
    {
        public static string getGroupSpeciality(int? specialityId, List<StudentGroup> studentGroups)
        {
            foreach (var item in studentGroups)
            {
                if (item.SpecialityId == specialityId)
                {
                    return item.Number;
                }
            }
            return "";

        }
    }
}
