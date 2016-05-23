using System;
namespace Lab_OP_2
{
    class TestVector
    {
        static void Main(string[] args)
        {
            int size = 4;

            Vector v1 = new Vector(size, new int[] { 0, 2, 4, 7 });
            Vector v2 = new Vector(size, new int[] { 7, 11, 1, 1 });

            Vector _product = new Vector(size);
            Vector _sum = new Vector(size);
            Vector _subtr = new Vector(size);
            Vector _angle = new Vector(size);
            
            Console.WriteLine("Вектор v1 = {0}, длина(модуль вектора) равна {1:f2}", v1, v1.CalculateLength(v1));
            Console.WriteLine("Вектор v2 = {0}, длина(модуль вектора) равна {1:f2}", v2, v2.CalculateLength(v2));

            Console.WriteLine("Произведение вектора v1 на вектор v2 равно " + _product.GetScalarProduct(v1, v2));
            Console.WriteLine("Сумма векторов:\n" + _sum.SummVectors(v1, v2));
            Console.WriteLine("Разность векторов:\n" + _subtr.SubtractVectors(v1, v2));
            Console.WriteLine("Угол между векторами равен {0:f4}", _angle.GetAngle(v1, v2));

            Console.ReadKey();
        }
    }
}

















//string _vector0 = "";
//string _vector1 = "";
//string _vector2 = "";
//string _vector3 = "";

//Random rnd = new Random();

//Vector vector0 = new Vector();
//for (int i = 0; i < size; i++)
//{
//    _vector0 += vector0[i].ToString() + " ";
//    string.Format(_vector0);
//}
//Vector vector1 = new Vector(size);
//for (int i = 0; i < size; i++)
//{
//    vector1[i] = rnd.Next(0, 9);
//    _vector1 += vector1[i].ToString() + " ";
//    string.Format(_vector1);
//}
//Vector vector2 = new Vector(size);
//for (int i = 0; i < size; i++)
//{
//    vector2[i] = rnd.Next(0, 9);
//    _vector2 += vector2[i].ToString() + " ";
//    string.Format(_vector2);
//}
//Vector vector3 = new Vector(size);
//for (int i = 0; i < size; i++)
//{
//    vector3[i] = rnd.Next(0, 9);
//    _vector3 += vector3[i].ToString() + " ";
//    string.Format(_vector3);
//}
//string strV0 = string.Format("{0}, {1}", v0[0], v0[1]);





























//        int n = int.Parse(Console.ReadLine());
//        Vector = new Vector(n);
//        Vector = new Vector(n);
//        int m = int.Parse(Console.ReadLine());
//        int[,] vectors = new int[m,n];

//        Random rnd = new Random();

//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                vectors[i, j] = rnd.Next(-6,6);
//                Console.Write("{0,3}", vectors[i,j]);
//            }
//            Console.WriteLine();
//        }

//        for (int i = 0; i < m-1; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                vec.SetVector(vectors[i+1, j], vectors[i+1, j], vectors[i+1, j]);               
//                vec1.SetVector(vectors[i, j], vectors[i, j], vectors[i, j]);
//            }
//            Console.WriteLine("Вектор №1 ({0}, {1}, {2}) Длина = {3}", vectors[i+1, 0], vectors[i+1, 1], vectors[i+1, 2], vec.GetModul());
//            Console.WriteLine("Вектор №2 ({0}, {1}, {2}) Длина = {3}", vectors[i, 0], vectors[i, 1], vectors[i, 2], vec1.GetModul());
//            Console.WriteLine("Скалярное произведение = {0}", Vector.GetSkalProiz(vec,vec1));
//            Console.WriteLine("Угол между векторами равен {0}", Vector.GetAngle(vec,vec1));
//            Console.WriteLine();
//        }

//    }
//}
