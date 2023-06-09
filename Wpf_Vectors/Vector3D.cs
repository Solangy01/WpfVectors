﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Wpf_Vectors
{
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string? ToString()
        {
            return $"{X}; {Y}; {Z}";
        }

        public static Vector3D Parse(string text)
        {
            double[] coords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries) // разделяем строку на массив
                                    .Select(coord => double.Parse(coord)).ToArray(); // и преобразуем его в массив double 

            return new Vector3D(coords[0], coords[1], coords[2]);
        }


        // Переопределение оператора +
        // Суммирование
        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Разность
        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D((a.X - b.X), (a.Y - b.Y), (a.Z - b.Z));
        }

        // Скалярное произведение
        public static double operator &(Vector3D a, Vector3D b)
        {
            return a.X*b.X + a.Y*b.Y + a.Z*b.Z;
        }

        // Вычисление длины
        public double Length()
        {
            return Math.Sqrt(X*X + Y*Y + Z*Z);
        }
    }
}
