using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace TestDrivenDesign
{
    public class StringCalculator
    {

        public int AddStrings(string strSeparatedWithComma)
        {
            try
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
            catch
            {
                return 0;
            }
        }

        public int SubtractStrings(string strSeparatedWithComma)
        {
            try
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

                for (int i = 0; i < strSplit.Count; i++)
                {
                    if (strSplit.Count == 0)
                    {
                        return -1;
                    }

                    if (i == 1)
                    {
                        result += int.Parse(strSplit[i]);
                    }
                    else
                    {
                        result -= int.Parse(strSplit[i]);
                    }

                }

                return result * -1;
            }

            catch
            {
                return 0;
            }
        }
    }
}
