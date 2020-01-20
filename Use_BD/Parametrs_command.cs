using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project
{
     class Parametrs_command
     {
        public  string paramName { get; set; }
        public object paramValue { get; set; }
        public SqlDbType paramType { get; set; }

        public   Parametrs_command(string paramName, object pramValue,SqlDbType paramType = SqlDbType.NVarChar)
        {
            this.paramName = paramName;
            this.paramValue = pramValue;
            this.paramType = paramType;
        }
        public Parametrs_command(string paramName,SqlDbType paramType)
        {
            this.paramName = paramName;
            this.paramType = paramType;
        }
     }
}
