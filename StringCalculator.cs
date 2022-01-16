using System;
using System.Collections.Generic;

namespace TestDrivenDesign
{
    public class StringCalculator
    {
        public int AddStrings(string strSeparatedWithComma)
        {
            var strSplit = new List<string>();
            var result = 0;

            if (strSeparatedWithComma != "")
            {
                
                var strSplitted = strSeparatedWithComma.Split(',');
                foreach (var item in strSplitted)
                {
                    strSplit.Add(item);
                }
            }
            else
            {
                return 0;
            }
            foreach (var item in strSplit)
            {
                result += int.Parse(item);
            }

            return result;
        }
    }
}
