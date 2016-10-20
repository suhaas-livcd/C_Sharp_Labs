using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperationsOverloading
{
    class Matrix
    {
        public int[,] Mat1 = new int[2, 2];

        public int[,] Mat2 = new int[2, 2];

        public float[,] Mat3 = new float[2, 2];

        public int[,] Matadd = new int[2, 2];
        public int[,] Matsub = new int[2, 2];
        public int[,] Matmul = new int[2, 2];
        public float[,] Matdiv = new float[2, 2];

        public static int[,] operator +(Matrix obj, int[,] Mat2)
        {
            int[,] Matx=new int[2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matx[i, j] = obj.Mat1[i,j]+Mat2[i,j];
                }
            }
            return Matx;
        }

        public static int[,] operator -(Matrix obj, int[,] Mat2)
        {
            int[,] Matx = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matx[i, j] = obj.Mat1[i, j] - Mat2[i, j];
                }
            }
            return Matx;
        }

        public static int[,] operator *(Matrix obj, int[,] Mat2)
        {
            int[,] Matx = new int[2, 2];
            int c, d, k,sum=0;

            for (c = 0; c < 2; c++)
            {
                for (d = 0; d < 2; d++)
                {
                    for (k = 0; k < 2; k++)
                    {
                        sum = sum + obj.Mat1[c,k] * obj.Mat2[k,d];
                    }

                    Matx[c,d] = sum;
                    sum = 0;
                }
            }
            return Matx;
        }

        public static float[,] operator /(Matrix obj, int x)
        {
            float[,] Matx = new float[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    obj.Mat3[i,j] = (float)obj.Mat1[i,j];
                    Matx[i, j] = obj.Mat3[i, j] / x;
                }
            }
            return Matx;
        }

        public static bool operator ==(Matrix obj, int[,] Mat2)
        {
            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (obj.Mat1[i, j] == Mat2[i, j]) { count++; }
                }
            }
            if (count == 4) { return true; } else { return false; }
        }

        public static bool operator !=(Matrix obj, int[,] Mat2)
        {
            return !(obj==Mat2);
        }

        public static implicit operator float(Matrix obj)
        {
            float f = 0;
            for(int i = 0;i< 2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    f = f + obj.Mat1[i, j];
                }
            }
            return f;
        }

        static void Main(string[] args)
        {
            Matrix matobj = new Matrix();
            matobj.Initialisation();
            matobj.SetValues(matobj.Mat1);
            matobj.SetValues(matobj.Mat2);
            Console.WriteLine("Ist Matrix is\n");
            matobj.GetValues(matobj.Mat1);
            Console.WriteLine("IInd Matrix is\n");
            matobj.GetValues(matobj.Mat2);
            matobj.Matadd = matobj + matobj.Mat2;
            Console.WriteLine("After Addition");
            matobj.GetValues(matobj.Matadd);
            matobj.Matadd = matobj - matobj.Mat2;
            Console.WriteLine("After Subtraction");
            matobj.GetValues(matobj.Matadd);
            matobj.Matadd = matobj * matobj.Mat2;
            Console.WriteLine("After Multiplication");
            matobj.GetValues(matobj.Matadd);
            matobj.Matdiv = matobj / 2;
            Console.WriteLine("After Division by 2");
            matobj.GetValues(matobj.Matdiv);
            bool check = matobj == matobj.Mat2;
            Console.WriteLine("After Checking Equality:");
            if (check) { Console.WriteLine("Matrices are equal"); } else { Console.WriteLine("Matrices are not equal"); }
            float f = matobj;
            Console.WriteLine("The sum of matrix elements" + f);
            Console.WriteLine("________________________________");
        }

        public void Initialisation()
        {
            Console.WriteLine("\n*___*___*___*___*___***__Welcome to the Matrix Multiplication Program__***___*___*___*___*___*\n\n");
            Console.WriteLine("\t\t\t\t2*2 Matrix Operations");
            Console.WriteLine("\t\t\t__________________________________\n");
        }

        public void SetValues(int[,] Mat3)
        {
            Console.WriteLine("Enter the First Matrix Values?\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter the [{0}][{1}]",i,j);
                    Mat3[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("________________________________");
        }

        public void GetValues(int[,] array) {
            for (int x = 0; x < array.GetLength(0); x += 1)
            {
                for (int y = 0; y < array.GetLength(1); y += 1)
                {
                    Console.Write(array[x, y]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________");
        }

        public void GetValues(float[,] array)
        {
            for (int x = 0; x < array.GetLength(0); x += 1)
            {
                for (int y = 0; y < array.GetLength(1); y += 1)
                {
                    Console.Write(array[x, y] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________");
        }
         
    }
}
