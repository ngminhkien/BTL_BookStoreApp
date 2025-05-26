using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Mytoys
    {
        public string GenerateNextIdFromStrings(List<string> ids, string prefix)
        {
            int maxNumber = 0;

            foreach (var id in ids)
            {
                if (id.StartsWith(prefix) && id.Length == prefix.Length + 3)
                {
                    string numberPart = id.Substring(prefix.Length, 3);
                    if (int.TryParse(numberPart, out int num))
                    {
                        if (num > maxNumber)
                            maxNumber = num;
                    }
                }
            }

            int nextNumber = maxNumber + 1;
            return $"{prefix}{nextNumber:D3}";// D3 = format 3 chữ số, vd: 001, 045
        }
        public string GenerateNextIdFromStringsV2(List<string> ids, string prefix)
        {
            int maxNumber = 0;

            foreach (var id in ids)
            {
                if (id.StartsWith(prefix) && id.Length == prefix.Length + 2)
                {
                    string numberPart = id.Substring(prefix.Length, 2);
                    if (int.TryParse(numberPart, out int num))
                    {
                        if (num > maxNumber)
                            maxNumber = num;
                    }
                }
            }

            int nextNumber = maxNumber + 1;
            return $"{prefix}{nextNumber:D2}";
        }
        //public string GenerateUniqueIdWithTimestamp(string prefix, HashSet<string> existingIds)
        //{
        //    string id;
        //    do
        //    {
        //        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        //        id = $"{prefix}{timestamp}";
        //    } while (existingIds.Contains(id)); // chống trùng

        //    return id;
        //}

        public int GenerateNextInteger(List<int> numbers, bool isEven)//false là lẻ, true là chẵn
        {
            int maxNumber = numbers.Any() ? numbers.Max() : 0;
            int nextNumber = maxNumber + 1;

            if (isEven && nextNumber % 2 != 0)
                nextNumber++; // tăng thêm để thành số chẵn
            else if (!isEven && nextNumber % 2 == 0)
                nextNumber++; // tăng thêm để thành số lẻ

            return nextNumber;
        }

        public static int FindMax(List<int> arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

    }
}
