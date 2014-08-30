using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Movies.Models.Checkers
{
    public class NullChecker : Checker
    {
        private string input;
        public NullChecker(string input)
        {
            this.input = input;
        }
        

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}