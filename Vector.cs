using System;
namespace Lab_OP_2
{
    class Vector
    {
        private int[] _vectArray;
        private int _size;

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _size)
                    return _vectArray[index];
                else return 0;
            }
            set
            {
                if (index >= 0 && index < _size) 
                _vectArray[index] = value;
            }
        }

        public int Size
        {
            get { return _size; }
            set
            {
                if (value > 0)
                {
                    _size = value;
                }
                else
                {
                    value = 1;
                }
            }
        }

        public int [] SetVectArray
        { set { _vectArray = value; } }

        public Vector(int n, int[] v)
        {
            _size = n;
            _vectArray = new int [Size];
     
            for (int i = 0; i < Size; i++)
                this[i] = v[i];
        }

        public Vector(int n) : this(n, new int[n])
        {
        }

        public Vector() : this(1, new int[1])
        {
        }

        public override string ToString()
        {
            string vValue = "";
            for (int i = 0; i < _size; i++)
            {
                vValue += _vectArray[i].ToString() + " ";
            }
            return string.Format("( {0})", vValue);
        }

        public Vector SummVectors(Vector v1, Vector v2)
        {
            Vector vSum = new Vector(v1._size);

            if (v1._size != v2._size)
                throw new ArgumentException("Размерности векторов не совпадают! Нельзя произвести сложение...");
            else
            {
                for (int i = 0; i < vSum._size; i = i + 1)
                    vSum[i] = v1[i] + v2[i];
            }
            return vSum;
        }

        public Vector SubtractVectors(Vector v1, Vector v2)
        {
            Vector vSubtr = new Vector(v1._size);
            if (v1._size != v2._size)
                throw new ArgumentException("Размерности векторов не совпадают! Нельзя произвести вычитание...");
            else
            {
                for (int i = 0; i < vSubtr._size; i = i + 1)
                    vSubtr[i] = v1[i] - v2[i];
                return vSubtr;
            }
        }

        public static void IncrementVector(Vector v)
        {
            for (int i = 0; i < v._size; i++)
            {
                int _vv = v[i];
                _vv++;
            }
        }

        public void DecrementVector(Vector v)
        {
            for (int i = 0; i <_size; i++)
            {
                int _vv = v[i];
                _vv--;
            }
        }

        public int GetScalarProduct(Vector v1, Vector v2)
        {
            if (v1._size != v2._size)
                throw new ArgumentException("Размерности векторов не совпадают! Нельзя вычислить произведение...");
            else
            {
                int sp = 0;
                for (int i = 0; i < v1._size; i++)
                    sp += v1[i] * v2[i];
                return sp;
            }
        }

        public double CalculateLength(Vector v)
        {
            double length = 0;
           

            for (int i = 0; i <_size; i++)
                length += Math.Pow(v[i], 2);
            length = Math.Sqrt(length);

            return length;
        }

        public double GetAngle(Vector v1, Vector v2)
        {
            if (v1._size != v2._size)
                throw new ArgumentException("Размерности векторов не совпадают! Нельзя вычислить значение угла...");
            else
            {
                double angle = GetScalarProduct(v1, v2) / CalculateLength(v1) / CalculateLength(v2);
                return angle;
            }
        }
    }
}
            