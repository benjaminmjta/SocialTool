using SocialTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SocialTool.Logic
{
    public static class Calculations
    {
        public static bool BaseTaxActive { get; set; }

        public static int BaseTaxPercentage { get; set; }

        public static void CalculateTaxPool()
        {
            Double Pool = 0;
            foreach (Person P in Population.People) 
            {
                if (BaseTaxActive && (BaseTaxPercentage > 0) && (BaseTaxPercentage <= 100))
                {
                    Pool = Pool + (P.Income / (100 / BaseTaxPercentage));
                }
            }
            Population.TaxPool = Pool;
        }

        public static void CalculatePersonalIncome(string ownIncome, ref string ownGet, ref string ownTake, ref string tempnetinc)
        {
            Double Income = Double.Parse(ownIncome);
            Double Take = 0;
            if (BaseTaxActive && (BaseTaxPercentage > 0) && (BaseTaxPercentage <= 100))
            {
                Take = Income / (100 / BaseTaxPercentage);
            }
            CalculateTaxPool();
            Double Get = (Population.TaxPool + Take) / (Population.People.Count() + 1);
            ownGet = Get.ToString("0.00");
            ownTake = Take.ToString("0.00");
            tempnetinc = (Income - Take + Get).ToString("0.00");
        }
    }
}
