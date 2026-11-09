// // W1D3
// // CLASS TASK 1

// int a = Convert.ToInt32(Console.ReadLine());
// PrintFrom(a);
// void  PrintFrom(int a)
// {
//     for(int i=a; i>0; i--)
//     {
//         Console.Write($"{i} ");
//     }
// }

// // CLASS TASK 2

// int a =Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(a,b,c,d);
// Console.WriteLine(sum);

// int Sum(int a, int b, int c, int d)
// {
//     return a+b+c+d;
// }

// // CLASS TASK 3

// int a = Convert.ToInt32(Console.ReadLine());
// int res = Reverse(a);

// Console.WriteLine(res);

// int Reverse(int a)
// {
//     int rev = 0;
//     for(int i =a; i>0; i /= 10)
//     {
//         rev = rev *10;
//         rev+=i%10;
//     }
//     return rev;
// }

// // CLASS 4

// using System.ComponentModel;

// int a  = Convert.ToInt32(Console.ReadLine());
// PrintStars(a);

// void PrintStars(int a)
// {
//     for(int i=0; i<a; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// // CLASS TASK 5

// int a = Convert.ToInt32(Console.ReadLine());
// printStar (a);

// void printStar(int size)
// {
//     for(int i = 0; i<size; i++)
//     {
//         printStar(size);
//     }
    // void printStar(int b)
    // {
    //     for(int i=0; i<b; i++)
    //     {
    //         Console.Write("*");
    //     }
    //     Console.WriteLine();
    // }
// }

// // CLASS TASK 6

// using System.Data;

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

//  PrintRectangle(a,b);

// void  PrintRectangle(int a, int b)
// {
//     for(int i=0; i<b; i++)
//     {
//         PrintRectangle(a);
//     }
//         void PrintRectangle(int b)
//     {
//         for(int i=0; i<b; i++)
//         {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }

// // CLASS TASK 7

// int a = Convert.ToInt32(Console.ReadLine());

//  PrintRectangle(a);

//  void  PrintRectangle(int a)
// {
//     for(int i=1; i<=a; i++)
//     {
//          PrintStar(i);
//     }
// }
// void PrintStar(int b)
//     {
//         for(int i=0; i<b; i++)
//         {
//             Console.Write("*");
//         }
//      Console.WriteLine();
// }

// // CLASS TASK 8
// int a = Convert.ToInt32(Console.ReadLine());

// PrintRightTriangle(a);

// void PrintRightTriangle(int a)
// {
//     for (int i = 1; i <= a; i++)
//     {
//         PrintSpaces(a - i); 
//         PrintStars(i);
//     }
// }

// void PrintSpaces(int c)
// {
//     for (int i = 0; i < c; i++)
//     {
//         Console.Write(" ");
//     }
// }

// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// // CLASS TASK 9



// // CLASS TASK 10

// // HOME TASK 1

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Even:{EvenCount(a)}");
// Console.WriteLine($"Odd:{OddCount(a)}");
// Console.WriteLine($"Digit:{DigitCount(a)}");
// Console.WriteLine($"Sum:{SumDigit(a)}");

// int EvenCount(int a)
// {
//     int cnt = 0;
//     for (int i = a; i > 0; i /= 10)
//     {
//         int di = i % 10;
//         if (di% 2 == 0)
//         {
//             cnt++;
//         }
//     }
//     return cnt;
// }

// int OddCount(int a)
// {
//     int cnt = 0;
//     for (int i = a; i > 0; i /= 10)
//     {
//         int di = i % 10;
//         if (di % 2 != 0)
//         {
//             cnt++;
//         }
//     }
//     return cnt;
// }

// int DigitCount(int a)
// {
//     int cnt = 0;
//     for (int i = a; i > 0; i /= 10)
//     {
//         cnt++;
//     }
//     return cnt;
// }

// int SumDigit(int a)
// {
//     int sum = 0;
//     for (int i = a; i > 0; i /= 10)
//     {
//         sum += i % 10;
//     }
//     return sum;
// }

// // HOME TASK 2

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Add:{Add(a, b)}");
// Console.WriteLine($"Subtract:{Subtract(a, b)}");
// Console.WriteLine($"Multiply:{Multiply(a, b)}");
// Console.WriteLine($"Division:{Division(a, b)}");

// int Add(int a, int b)
// {
//     return a + b;
// }

// int Subtract(int a, int b)
// {
//     return a - b;
// }

// int Multiply(int a, int b)
// {
//     return a * b;
// }

// int Division(int a, int b)
// {
//     return a / b;
// }

// // HOME TASK 3

// int a = Convert.ToInt32(Console.ReadLine());

// int min = Min(a);
// int max = Max(a);

// System.Console.WriteLine($"{min} + {max} = {min+max}");

// int Min(int a)
// {
//     int minn = int.MaxValue;
//     for(int i = a; i>0; i /= 10)
//     {
//         int ver = i%10;
//         if(ver < minn)
//         {
//             minn = ver;
//         }
//     }
//     return minn;
// }
// int Max(int a)
// {
//     int maxx = int.MinValue;
//     for(int i = a; i>0; i /= 10)
//     {
//         int ver = i%10;
//         if(ver > maxx)
//         {
//             maxx = ver;
//         }
//     }
//     return maxx;
// }

// // HOME TASK 4

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Pow(x, y));

// int Pow(int x, int y)
// {
//     return (int)Math.Pow(x, y);
// }

// // HOME TASK 5

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// Swap(ref x, ref y);
// Console.WriteLine($"x = {x}");
// Console.WriteLine($"y = {y}");

// void Swap(ref int a, ref int b)
// {
//     int temp = a;
//     a = b;       
//     b = temp;     
// }

// // HOME TASKE 6

// int a = Convert.ToInt32(Console.ReadLine());
// Divisors(a);

// int Divisors(int a)
// {
//     for (int i = 1; i <= a; i++)
//     {
//         if (a % i == 0)
//         {
//             Console.Write($"{i} ");
//         }
//     }
//     return 0;
// }

// // HOME TASK 7

// int [] arr = new int[] {1,2,3};
// insdi(arr, 5);

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }

// void insdi(int[] a, int v)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] += v;
//     }
// }

// // РЩЬУ ЕФЫЛ 8

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Min(a,b,c,d));

// int Min(int a, int b, int c, int d)
// {
//     int minn = a;
//     if(b<minn) minn = b;
//     if(c<minn) minn = c;
//     if(d<minn) minn = d;

//     return minn;
// }

// // HOME TASK 9

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Min(a,b));
// int Min(int a, int b)
// {
//     if(a < b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// // HOME TASK 10

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Min(a,b));
// int Min(int a, int b)
// {
//     if(a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }