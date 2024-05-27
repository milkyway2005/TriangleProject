using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLibrary
{
    public class CheckTriangleType
    {
        public Triangle myTr { get; set; }
        public List<double> Sides;

        public CheckTriangleType(Triangle triangle)
        {
            myTr = triangle;
            Sides = new List<double>() { myTr.A, myTr.B, myTr.C};
            Sides.Sort();
        }

        public bool IsTriangleExists()
        {
            if(myTr.A >= myTr.B + myTr.C || myTr.B >= myTr.A + myTr.C || myTr.C >= myTr.B + myTr.A)
            {
                return false;
            }
            return true;
        }

        public string CheckTriangleSideType()
        {
            if(myTr.A == myTr.B && myTr.A == myTr.C)
            {
                return "Равносторонний";
            }
            if(myTr.A == myTr.B || myTr.A == myTr.C || myTr.B == myTr.C)
            {
                return "Равнобедренный";
            }
            return "Разносторонний";
        }

        public string CheckTriangleCornerType()
        {
            if(Math.Pow(Sides[2], 2) == Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2))
            {
                return "Прямоугольный";
            }
            if(Math.Pow(Sides[2], 2) < Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2))
            {
                return "Остроугольный";
            }
            return "Тупоугольный";
        }

        public override string ToString()
        {
            if (!IsTriangleExists())
            {
                return "Не треугольник";
            }
            return (CheckTriangleSideType() + "\n" + CheckTriangleCornerType());
        }
    }
}
