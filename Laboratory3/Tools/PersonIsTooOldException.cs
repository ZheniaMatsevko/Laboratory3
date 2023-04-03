﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory3.Tools
{
    class PersonIsTooOldException: Exception
    {
        public PersonIsTooOldException() { }
        public PersonIsTooOldException(DateTime date) : base(String.Format("Person is too old while date is: {0}", date.ToShortDateString()))
        {

        }
    }
}
