using System;

namespace BUS
{
    public static class UtilitiesBUS
    {
        public static string ArrayToString(string[] array, int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1) str += array[i] + ";";
                else str += array[i];
            }
            return str;
        }

        public static void ShowForm(string v)
        {
            throw new NotImplementedException();
        }

        public static string LaySTT(int v)
        {
            throw new NotImplementedException();
        }
    }
}
