using System;
using System.Linq;

namespace Morgan_and_a_String
{
    class Program
    {
        static string morganAndString(string a, string b)
        {
            char[] res=(a+b).ToCharArray();
            int k = 0;

            char[] av = a.ToCharArray();
            char[] bv = b.ToCharArray();

            int avi = 0;
            int bvi = 0;

            bool lopped = false;
            bool picka = true;

            while ((avi < av.Length) || (bvi < bv.Length))
            {

                if ((avi < av.Length) && (bvi < bv.Length))
                {
                    int i = avi;
                    int j = bvi;
                    bool picked = false;

                    while ((!picked) && ((i < av.Length) && (j < bv.Length)))
                    {
                        if (av[i] < bv[j])
                        {
                            picka = true;
                            picked = true;
                        }
                        if (av[i] > bv[j])
                        {
                            picka = false;
                            picked = true;
                        }
                        if (av[i] == bv[j])
                        {
                            if (!lopped)
                            {
                                i++;
                                j++;
                            }
                            else
                            {
                                picked = true;
                            }
                        }
                    }

                    if(lopped)
                    {
                        if()
                    }
                    if ((i == avi) && (j == bvi))
                    {
                        if (av[i] == bv[j])
                            lopped = true;
                        else
                            lopped = false;
                    }
                    else
                    {
                        lopped = true;
                    }
                }
                else
                {
                    if (avi < av.Length)
                    {
                        picka = true;
                    }
                    else if (bvi < bv.Length)
                    {
                        picka = false;
                    }
                }


                if (picka)
                {
                    res[k] = av[avi];
                    avi++;
                    k++;
                }
                else
                {
                    res[k] = bv[bvi];
                    bvi++;
                    k++;
                }
            }

            return new string(res);
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string result = morganAndString(a, b);

                Console.WriteLine("Output:");
                Console.WriteLine(result);

                Console.ReadKey();
            }
        }
    }
}
