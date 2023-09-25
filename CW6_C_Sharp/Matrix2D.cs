using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW6_C_Sharp
{
    internal class Matrix2D
    {
        private int[,] _array;

        public Matrix2D(int[,] array) 
        {
            _array = array;
        }
        public Matrix2D(int column, int row) 
        {
            _array = new int[column, row];
        }
        public void SetRandomNumbers(int min, int max) 
        {
            Random rand = new Random();
            for(int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    _array[i, j] = rand.Next(min, max);
                }
            }
        }

        public int this[int firstIndex, int secondIndex]
        {
            get
            {
                if ((firstIndex >= 0 && firstIndex < _array.GetLength(0)) && (secondIndex >= 0 && secondIndex < _array.GetLength(1)))
                    return _array[firstIndex, secondIndex];
                throw new ArgumentException("Error / Not correct index");
            }
            set
            {
                if ((firstIndex >= 0 && firstIndex < _array.GetLength(0)) && (secondIndex >= 0 && secondIndex < _array.GetLength(1)))
                    {
                    _array[firstIndex, secondIndex] = value;
                }
                else
                {
                    throw new ArgumentException("Error / Not correct index");
                }
            }
        }
        int[,] GetMatrix2D() 
        {
            return _array;
        }
        public static Matrix2D operator+(Matrix2D a, Matrix2D b)
        {
            if (a._array.GetLength(0) != b._array.GetLength(0))
                throw new ArgumentException("Error / Not correct index");
            else if (a._array.GetLength(1) != b._array.GetLength(1))
                throw new ArgumentException("Error / Not correct index");

            Matrix2D newMatrix = new Matrix2D(a._array.GetLength(0), a._array.GetLength(1));
            for(int i = 0; i < newMatrix.GetMatrix2D().GetLength(0); i++)
            {
                for(int j = 0; j < newMatrix.GetMatrix2D().GetLength(1); j++)
                {
                    newMatrix._array[i, j] = a._array[i, j] + b._array[i, j];
                }
            }
            return newMatrix;
        }

        public static bool operator ==(Matrix2D a, Matrix2D b)
        {
            int sumA = 0, sumB = 0;
            for (int i = 0; i  < a._array.GetLength(0); i++)
            {
                for(int j = 0; j  < a._array.GetLength(1); j++)
                {
                    sumA += a._array[i, j];
                }
            }
            for (int i = 0; i < b._array.GetLength(0); i++)
            {
                for (int j = 0; j < b._array.GetLength(1); j++)
                {
                    sumB += b._array[i, j];
                }
            }
            if (sumA == sumB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Matrix2D a, Matrix2D b)
        {
            int sumA = 0, sumB = 0;
            for (int i = 0; i < a._array.GetLength(0); i++)
            {
                for (int j = 0; j < a._array.GetLength(1); j++)
                {
                    sumA += a._array[i, j];
                }
            }
            for (int i = 0; i < b._array.GetLength(0); i++)
            {
                for (int j = 0; j < b._array.GetLength(1); j++)
                {
                    sumB += b._array[i, j];
                }
            }
            if (sumA != sumB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Matrix2D a, Matrix2D b)
        {
            int sumA = 0, sumB = 0;
            for (int i = 0; i < a._array.GetLength(0); i++)
            {
                for (int j = 0; j < a._array.GetLength(1); j++)
                {
                    sumA += a._array[i, j];
                }
            }
            for (int i = 0; i < b._array.GetLength(0); i++)
            {
                for (int j = 0; j < b._array.GetLength(1); j++)
                {
                    sumB += b._array[i, j];
                }
            }
            if (sumA > sumB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Matrix2D a, Matrix2D b)
        {
            int sumA = 0, sumB = 0;
            for (int i = 0; i < a._array.GetLength(0); i++)
            {
                for (int j = 0; j < a._array.GetLength(1); j++)
                {
                    sumA += a._array[i, j];
                }
            }
            for (int i = 0; i < b._array.GetLength(0); i++)
            {
                for (int j = 0; j < b._array.GetLength(1); j++)
                {
                    sumB += b._array[i, j];
                }
            }
            if (sumA < sumB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for(int j = 0 ; j < _array.GetLength(1); j++)
                {
                    sb.Append(this[i,j]);
                    if (i < _array.GetLength(0) - 1)
                        sb.Append(' ');
                }
                sb.Append('\n');
            }
            return $"Array: {sb.ToString()}";
        }
    }
}
