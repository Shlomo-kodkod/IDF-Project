using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public interface IMilitaryOrganization
    {
        int yearOfConstruction {  get; }
        string chiefOfStaff { get; }
        List<object> strikeOptionList { get; }

        void AddStrikOption(object strikeOption);

        void RemoveStrikOption(object strikeOption);
    }
}
