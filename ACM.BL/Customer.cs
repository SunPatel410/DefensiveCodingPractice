using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;

namespace ACM.BL
{/// <summary>
/// Manages a single customer
/// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email address is null");
            }

            if (op.Success)
            {
                var isValidFormat = true;

                //Code here that validates the format of the email using reg ex
                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email is not in the correct format");
                }
            }

            if (op.Success)
            {
                var isRealDomain = true;

                //Code here that confirms whether domain exists
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email address does not include a valid domain");
                }
            }

            return op;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            //Fail Fast technique(Guard Clauses)
            //check for not null or white space
            if (string.IsNullOrEmpty(goalSteps))
                throw new ArgumentException("Goal steps must be entered", nameof(goalSteps));

            if (string.IsNullOrEmpty(actualSteps))
                throw new ArgumentException("Actual steps must be entered", nameof(actualSteps));

            decimal goalStepCount = 0;
            //check if it is parsed to a decimal value
            if (!decimal.TryParse(goalSteps, out goalStepCount))
                throw new ArgumentException("Goal must be numeric");

            decimal actualStepCount = 0;
            if(!decimal.TryParse(actualSteps, out actualStepCount))
                throw new ArgumentException("Actual must be numeric", nameof(actualSteps));

            //call the overload method
            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        //method overloading
        public  decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0)
                throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round((actualStepCount / goalStepCount)* 100,2);
        }
    }
}
