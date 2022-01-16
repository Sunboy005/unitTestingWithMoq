using System.Collections.Generic;

namespace TestDrivenDesign
{
    public class stringCalculator
    {
        public int AddStrings(string strSeparatedWithComma)
        {
            var strSplit = new List<string>();
            var result = 0;

            if (strSeparatedWithComma == "")
            {
                strSplit.Add("0");
            }
            else
            {
                var strSplitted = strSeparatedWithComma.Split(',');
                foreach (var item in strSplitted)
                {
                    strSplit.Add(item);
                }
            }
            for (int i = 0; i < strSplit.Count; i++)
            {
                result += int.Parse(strSplit[i]);
            }

            return result;
        }
    }
}
