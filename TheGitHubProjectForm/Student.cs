using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TheGitHubProjectForm
{
    [Serializable]
    public struct Student
    {

        public string surName;
        public string firstName;
        public string gender;
        public DateTime dateOfBirth;
        public string mathematicsMark;
        public string physicsMark;
        public string informaticsMark;
        public string scholarship;
        public int Age;



    }
}
