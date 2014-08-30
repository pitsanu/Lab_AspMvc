using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Movies.Models.Checkers
{
    public abstract class Checker
    {
        protected Checker NextChecker;
        public abstract bool IsValid();

    }
}