using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpFloatMulDivBench
{
    class Program
    {
        private static List<Int64> smallIntList = new List<Int64>();
        private static List<Int64> bigIntList = new List<Int64>();
        private static List<Double> smallDoubleList = new List<Double>();
        private static List<Double> bigDoubleList = new List<Double>();

        private static void Init()
        {
            smallIntList.Add(158);
            smallIntList.Add(21);
            smallIntList.Add(7813);
            smallIntList.Add(632);
            smallIntList.Add(87);
            smallIntList.Add(14);
            smallIntList.Add(751);
            smallIntList.Add(201);
            smallIntList.Add(79);
            smallIntList.Add(26);

            smallDoubleList.Add(158.0);
            smallDoubleList.Add(21.0);
            smallDoubleList.Add(7813.0);
            smallDoubleList.Add(632.0);
            smallDoubleList.Add(87.0);
            smallDoubleList.Add(14.0);
            smallDoubleList.Add(751.0);
            smallDoubleList.Add(201.0);
            smallDoubleList.Add(79.0);
            smallDoubleList.Add(26.0);

            bigIntList.Add(158862);
            bigIntList.Add(78213);
            bigIntList.Add(425763);
            bigIntList.Add(412489);
            bigIntList.Add(852362);
            bigIntList.Add(23546);
            bigIntList.Add(145823);
            bigIntList.Add(352689);
            bigIntList.Add(558721);

            bigDoubleList.Add(158862.0);
            bigDoubleList.Add(78213.0);
            bigDoubleList.Add(425763.0);
            bigDoubleList.Add(412489.0);
            bigDoubleList.Add(852362.0);
            bigDoubleList.Add(23546.0);
            bigDoubleList.Add(145823.0);
            bigDoubleList.Add(352689.0);
            bigDoubleList.Add(558721.0);
        }

        static void DisplayElapseTime(string title, TimeSpan ts)
        {
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:000}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine(title + elapsedTime);
        }
        static double MulBigDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigDoubleList.Count; ++i)
                {
                    for (int j = 0; j < bigDoubleList.Count; ++j)
                    {
                        result = bigDoubleList[i] * bigDoubleList[j];
                    }
                }
            }

            stopWatch.Stop();
            DisplayElapseTime("MulBigDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 MulBigInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigIntList.Count; ++i)
                {
                    for (int j = 0; j < bigIntList.Count; ++j)
                    {
                        result = bigIntList[i] * bigIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("MulBigInt RunTime:", stopWatch.Elapsed);

            return result;
        }
        static double DivBigDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigDoubleList.Count; ++i)
                {
                    for (int j = 0; j < bigDoubleList.Count; ++j)
                    {
                        result = bigDoubleList[i] / bigDoubleList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("DivBigDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 DivBigInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigIntList.Count; ++i)
                {
                    for (int j = 0; j < bigIntList.Count; ++j)
                    {
                        result = bigIntList[i] / bigIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("DivBigInt RunTime:", stopWatch.Elapsed);

            return result;
        }
        static double MulSmallDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallDoubleList.Count; ++i)
                {
                    for (int j = 0; j < smallDoubleList.Count; ++j)
                    {
                        result = smallDoubleList[i] * smallDoubleList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("MulSmallDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 MulSmallInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallIntList.Count; ++i)
                {
                    for (int j = 0; j < smallIntList.Count; ++j)
                    {
                        result = smallIntList[i] * smallIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("MulSmallInt RunTime:", stopWatch.Elapsed);

            return result;
        }
        static double DivSmallDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallDoubleList.Count; ++i)
                {
                    for (int j = 0; j < smallDoubleList.Count; ++j)
                    {
                        result = smallDoubleList[i] / smallDoubleList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("DivSmallDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 DivSmallInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallIntList.Count; ++i)
                {
                    for (int j = 0; j < smallIntList.Count; ++j)
                    {
                        result = smallIntList[i] / smallIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("DivSmallInt RunTime:", stopWatch.Elapsed);

            return result;
        }
        static double AddBigDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigDoubleList.Count; ++i)
                {
                    for (int j = 0; j < bigDoubleList.Count; ++j)
                    {
                        result = bigDoubleList[i] + bigDoubleList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("AddBigDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 AddBigInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigIntList.Count; ++i)
                {
                    for (int j = 0; j < bigIntList.Count; ++j)
                    {
                        result = bigIntList[i] + bigIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("AddBigInt RunTime:", stopWatch.Elapsed);

            return result;
        }
        static double SubBigDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigDoubleList.Count; ++i)
                {
                    for (int j = 0; j < bigDoubleList.Count; ++j)
                    {
                        result = bigDoubleList[i] - bigDoubleList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("SubBigDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 SubBigInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < bigIntList.Count; ++i)
                {
                    for (int j = 0; j < bigIntList.Count; ++j)
                    {
                        result = bigIntList[i] - bigIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("SubBigInt RunTime:", stopWatch.Elapsed);

            return result;
        }
        static double AddSmallDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallDoubleList.Count; ++i)
                {
                    for (int j = 0; j < smallDoubleList.Count; ++j)
                    {
                        result = smallDoubleList[i] + smallDoubleList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("AddSmallDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 AddSmallInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallIntList.Count; ++i)
                {
                    for (int j = 0; j < smallIntList.Count; ++j)
                    {
                        result = smallIntList[i] + smallIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("AddSmallInt RunTime:", stopWatch.Elapsed);

            return result;
        }
        static double SubSmallDouble(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double result = 0.0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallDoubleList.Count; ++i)
                {
                    for (int j = 0; j < smallDoubleList.Count; ++j)
                    {
                        result = smallDoubleList[i] - smallDoubleList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("SubSmallDouble RunTime:", stopWatch.Elapsed);

            return result;
        }
        static Int64 SubSmallInt(int loop)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Int64 result = 0;
            for (int k = 0; k < loop; ++k)
            {
                for (int i = 0; i < smallIntList.Count; ++i)
                {
                    for (int j = 0; j < smallIntList.Count; ++j)
                    {
                        result = smallIntList[i] - smallIntList[j];
                    }
                }
            }
            stopWatch.Stop();
            DisplayElapseTime("SubSmallInt RunTime:", stopWatch.Elapsed);

            return result;
        }

        static void Main(string[] args)
        {
            Init();
            int loop = 1000000;
            Console.WriteLine("Multiplication and Division Benchmark");
            Console.WriteLine("=====================================");
            MulBigDouble(loop);
            MulBigInt(loop);
            DivBigDouble(loop);
            DivBigInt(loop);
            MulSmallDouble(loop);
            MulSmallInt(loop);
            DivSmallDouble(loop);
            DivSmallInt(loop);
            Console.WriteLine("\nAddition and Subtraction Benchmark");
            Console.WriteLine("==================================");
            AddBigDouble(loop);
            AddBigInt(loop);
            SubBigDouble(loop);
            SubBigInt(loop);
            AddSmallDouble(loop);
            AddSmallInt(loop);
            SubSmallDouble(loop);
            SubSmallInt(loop);
        }
    }
    }
