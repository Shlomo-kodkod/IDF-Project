using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public abstract class MilitaryOrganization
    {
        protected abstract int yearOfConstruction { get; set;  }
        protected abstract string chiefOfStaff { get; set; }

    }
}
