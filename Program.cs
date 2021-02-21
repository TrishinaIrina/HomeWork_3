using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2(5, 6);
            //IsPalindrom();
            //CountWords();
            //Task5();
            //IdenticalChar();
            //Task7();
            //CountNumbersInString();
            //task9();
            //CountWord();
            //ToUpper();
            //AdditionalTask1_8();
            AdditionalTask9_10();

        }
        // не знаю пока как в с# сделать метод шаблонным
        public static void InitUserDoubleArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
        }

        public static void InitRandomIntArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }

        public static void InitRandomDoubleBivariateArray(double[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
                }
            }
        }

        public static void InitRandomIntBivariateArray(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }

        public static void PrintDoubleArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(' ');
            }
            Console.WriteLine("");
        }

        public static void PrintIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(' ');
            }
            Console.WriteLine("");
        }

        public static void PrintDoubleBivariateArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine("");
            }
        }

        public static double SumArray(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static double ProductArray(double[] array)
        {
            double product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        public static double SumBivariateArray(double[,] array)
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }

        public static double ProductBivariateArray(double[,] array)
        {
            double product = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    product *= array[i, j];
                }
            }
            return product;
        }

        public static double SumEvenElementArray(double[] array)  // взяла четных по порядку, а не по индексу
        {
            double sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }

        public static double SumOddColumnBivariateArray(double[,] array)   // взяла нечетных по порядку, а не по индексу
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j += 2)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }


        /*1.Объявить одномерный (5 элементов ) массив с именем A и двумерный массив (3 строки, 4 столбца)
         * дробных чисел с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, 
         * а двумерный массив В случайными числами с помощью циклов. 
         * Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. 
         * Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, 
         * общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.*/

        private static void Task1()
        {
            double[] A = new double[5];
            InitUserDoubleArray(A);
            double[,] B = new double[3, 4];
            InitRandomDoubleBivariateArray(B);
            Console.WriteLine("Одномерный массив с инициалицированными пользователем значениями: ");
            PrintDoubleArray(A);
            Console.WriteLine("Двумерный  массив с рандомными значениями: ");
            PrintDoubleBivariateArray(B);
            double joint;
            double max = -10000000.0;
            double min = 10000000.0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.GetLength(0); j++)
                {
                    for (int k = 0; k < B.GetLength(1); k++)
                    {
                        if (A[i] == B[j, k])
                        {
                            joint = A[i];
                            if (joint > max)
                                max = joint;
                            if (joint < min)
                                min = joint;
                        }
                    }
                }
            }
            if (max > -10000000.0)
                Console.WriteLine("Наибольшее общее число из двух массивов: " + max);
            else
                Console.WriteLine("Нет общих для данных двух массивов значений");
            if (min < 10000000.0)
                Console.WriteLine("Наименьшее общее число из двух массивов: " + max);
            else
                Console.WriteLine("Нет общих для данных двух массивов значений");
            double sum = SumArray(A) + SumBivariateArray(B);
            Console.WriteLine("Сумма элементов двух массивов: " + sum);
            double product = ProductArray(A) * ProductBivariateArray(B);
            Console.WriteLine("Произведение всех элементов двух массивов: " + product);
            Console.WriteLine("Сумма четных элементов одномерного массива: " + SumEvenElementArray(A));
            Console.WriteLine("Сумма нечетных столбцов двумерного массива: " + SumOddColumnBivariateArray(B));
        }

        //2.Даны 2 массива размерности M и N соответственно. 
        //Необходимо переписать в третий массив общие элементы первых двух массивов без повторений. 
        private static void Task2(int M, int N)
        {
            int k = 0;
            int[] array1 = new int[M];
            int[] array2 = new int[N];
            InitRandomIntArray(array1);
            PrintIntArray(array1);
            InitRandomIntArray(array2);
            PrintIntArray(array2);
            int[] array3 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        bool b = true;
                        for (int d = 0; d <= k; d++)
                        {
                            if (array1[i] == array3[d])
                            {
                                b = false;
                                break;
                            }
                        }
                        if (b)
                            array3[k++] = array1[i];
                    }
                }
            }
            Console.WriteLine("Общие элементы обоих массивов: ");
            PrintIntArray(array3);
        }

        //3.Пользователь вводит строку. Проверить, является ли эта строка палиндромом. 
        //Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
        public static void IsPalindrom()
        {
            string str = Console.ReadLine();
            string reversStr = null;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversStr += str[i];
            }
            if (str == reversStr)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
        }

        //4.Подсчитать количество слов во введенном предложении.
        public static void CountWords()
        {
            int count = 0;
            string str = Console.ReadLine();
            str = str.Trim(' ');
            string[] arrayStr = str.Split(' ');
            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(arrayStr[i]))
                    count++;
            }
            Console.WriteLine("Количество слов в предложении: " + count);
        }

        //5.Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
        //Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.

        public static void Task5()
        {
            int[,] array2 = new int[5, 5];
            int[] array1 = new int[25];
            InitRandomIntBivariateArray(array2);
            int min = 100;
            int indexMin = 0;
            int max = -100;
            int indexMax = 0;
            int sum = 0;
            int index = 0;
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array1[index++] = array2[i, j];
                }
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                    indexMax = i;
                }
                if (array1[i] < min)
                {
                    min = array1[i];
                    indexMin = i;
                }
            }
            int start = indexMin < indexMax ? (indexMin + 1) : (indexMax + 1);
            int end = indexMin > indexMax ? indexMin : indexMax;
            for (int i = start; i < end; i++)
            {
                sum += array1[i];
            }
            Console.WriteLine("Сумма элементов между максимальным и минимальным: " + sum);
        }

        //6.Дан текст. Найти наибольшее количество идущих подряд одинаковых символов
        public static void IdenticalChar()
        {
            int count = 1;
            int max = 1;
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    count++;
                }
                else
                    count = 1;
                if (count > max)
                    max = count;
            }
            Console.WriteLine(max);
        }

        //7.Написать программу: Во введённой строке символов, содержащий прописные буквы
        //русского алфавита, подсчитать количество различных (без повторений) букв

        public static void Task7()
        {
            string str = Console.ReadLine();
            string buf = str;
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[j] == str[i])
                    {
                        buf = str.Remove(j, 1);
                        str = buf;
                        j--;
                    }
                }
            }
            Console.WriteLine("Количество символов без повторений: " + str.Length);
        }


        //8.	Составить программу, которая подсчитывает, сколько содержится цифр в строке длиной 20 символов.
        private static void CountNumbersInString()
        {
            string str = Console.ReadLine();
            int buf;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (int.TryParse(str[i].ToString(), out buf))
                    count++;
            }
            Console.WriteLine("Количество цифр содержащихся в строке: " + count);
        }

        //9.	Дан текст, состоящий из 20 букв. Проверить, можно ли из заданной последовательности
        //символов составить Ваше имя и напечатать его. В противном случае напечатать текст “Нет имени”.

        private static void task9()
        {
            string name = "ira";
            string anyText = Console.ReadLine();
            string result = null;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < anyText.Length; j++)
                {
                    if (name[i] == anyText[j])
                    {
                        result += name[i];
                        break;
                    }
                }
            }
            if (name == result)
                Console.WriteLine(name);
            else
                Console.WriteLine("Нет имени");
        }

        //10.	Дана строка символов длиной не более 255 символов. 
        //Группы символов, разделенные пробелами и не содержащие пробелов внутри себя, будем 
        //называть словами. Найти количество слов, у которых первый и последний символы совпадают между собой.
        private static void CountWord()
        {
            string str = Console.ReadLine();
            int count = 0;
            str.Trim(' ');
            string[] array = str.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < 2) continue;
                int last = array[i].Length - 1;
                if (array[i][0] == array[i][last])
                    count++;
            }
            Console.WriteLine(count);
        }

        //11.	Написать программу, в которой по малой русской букве выводится соответствующая большая.
        private static void ToUpper()
        {
            string letter = Console.ReadLine();
            string a = letter.ToUpper();
            Console.WriteLine(a);
        }



        public static void AdditionalTask1_8()
        {
            //Вывести элементы числового массива, которые больше, чем элементы, стоящие перед ними.
            int[] array = new int[15];
            InitRandomIntArray(array);
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                    Console.WriteLine(array[i]);
            }

            //Все элементы массива поделить на значение наибольшего элемента этого массива.
            double[] newArray = new double[15];
            InitRandomIntArray(array);
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = Convert.ToDouble(array[i]) / Convert.ToDouble(max);
            }
            PrintDoubleArray(newArray);

            //Найти номер и значение первого положительного элемента массива.

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    Console.WriteLine(array[i]);
                break;
            }

            //Дан массив, содержащий положительные и отрицательные числа. 

            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i] * -1;
            }

            //В массиве найти минимальный и максимальный элементы, поменять их местами.
            //В одномерном массиве найти минимальный и максимальный элементы. Вычислить их разность.
            //Найти сумму тех элементов массива, которые одновременно имеют четные и отрицательные значения.
            //В массиве найти минимальное значение среди элементов с нечетными индексами.

            int minimum = array[0];
            int maximum = array[0];
            int indexMin = 0;
            int indexMax = 0;
            int sum = 0;
            int minOdd = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                    indexMax = i;
                }
                if (array[i] < minimum)
                {
                    minimum = array[i];
                    indexMin = i;
                }

                if (array[i] < 0 && array[i] % 2 == 0)
                    sum += array[i];

                if (array[i] < minOdd || i % 2 != 0)
                    minOdd = array[i];
            }
            array[indexMax] = minimum;
            array[indexMin] = maximum;
            Console.WriteLine(maximum - minimum);
        }

        public static void AdditionalTask9_10()
        {
            int[] array = new int[15];
            InitRandomIntArray(array);
            Console.WriteLine("Сгенерированные элементы массива: ");
            PrintIntArray(array);

            //Дан одномерный массив. Найти среднее арифметическое его элементов. 
            //Вывести на экран только те элементы массива, которые больше найденного среднего арифметического.
            int summa = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summa += array[i];
            }
            int arithmeticMean = summa / array.Length;
            Console.WriteLine("Элементы больше среднего арифметического: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > arithmeticMean)
                {
                    Console.WriteLine(array[i]);
                }
            }
            /*Найти элементы массива, которые сильно отклоняются от среднего значения (элементов массива).
             "Отклонение" будет вычисляться как процент разности между элементом и средним значением к среднему значению. 
            Например, если очередной элемент равен 10, а среднее значение массива равно 5, то (10-5)/5 = 1 (100%). 
            Т.е. значение элемента превышает среднее значение на 100%.
            Пусть в данной задаче ищутся элементы, разница со средним значением которых превышает 50%.*/
            Console.WriteLine("Элементы с разницей от среднего арифметического 50%: ");
            for (int i = 0; i < array.Length; i++)
            {
                double deviation = (Convert.ToDouble(array[i]) - Convert.ToDouble(arithmeticMean)) / (Convert.ToDouble(arithmeticMean));
                if (deviation > 0.5)
                {
                    Console.WriteLine(array[i]);
                }
            }

            /*В однородном массиве, состоящем из N вещественных элементов, найти максимальный по модулю элемент массива.*/
            int maxModul = Math.Abs(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > maxModul)
                    maxModul = Math.Abs(array[i]);
            }
            Console.WriteLine("Максимальное по модулю значение: " + maxModul);

            /*Получить среднее арифметическое всех чётных элементов массива, стоящих на нечётных местах.*/
            summa = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && i % 2 == 0)
                {
                    summa += array[i];
                }
            }
            Console.WriteLine("Среднее арифметическое всех чётных элементов массива, стоящих на нечётных местах: " + summa / array.Length);

            //Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
            int K = 7;
            int sumBeforeK = 0;
            int sumAfterK = 0;
            for (int i = 0; i <= K; i++)
            {
                sumBeforeK += array[i];
            }
            for (int i = K + 1; i < array.Length; i++)
            {
                sumBeforeK += array[i];
            }
            if (sumBeforeK > sumAfterK)
                Console.WriteLine("Cумма до 7 элемента больше суммы чисел после 7 элемента");
            else if (sumBeforeK < sumAfterK)
                Console.WriteLine("Cумма после 7 элемента больше суммы чисел до него");
            else
                Console.WriteLine("Суммы чисел до и после седьмого элемента равны");

            //Найти сумму и произведение элементов одномерного числового массива.
            summa = 0;
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                summa += array[i];
                product *= array[i];
            }
        }






    }
}
