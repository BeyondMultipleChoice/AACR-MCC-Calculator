using System;
using System.Collections.Generic;
using System.Text;


//Class with constructor that calculate Matthews Correlation Coefficient.   
//Programmer: Marisol Mercado Santiago (marisolvsh@gmail.com)
//Automated Analysis of Constructed Response Research Group

//Acknowledgements: 
//This material is based upon work supported by the National Science Foundation(Grants 1323162 and 1347740). 
//Any opinions, findings and conclusions or recommendations expressed in this material are those of the author(s) and do not necessarily reflect the views of the supporting agencies.

class CalculateMCC
    {
        private double result;

        public CalculateMCC(double tp, double tn, double fp, double fn)
        {
            double num;
            double denom; 

            num = (tp * tn) - (fp * fn);
            denom = (tp + fp)
                    * (tp + fn)
                    * (tn + fp)
                    * (tn + fn);

            //Show a negative number if needed
            if (denom < 0)
            {
                denom = Math.Sqrt(Math.Abs(denom)) * -1;
            }
            else
            {
                denom = Math.Sqrt(denom);
            }

            result = num / denom;

        }

        //Call this function to retrieve the result
        public double GetMCCResult()
        {
            return result;
        }
    }

