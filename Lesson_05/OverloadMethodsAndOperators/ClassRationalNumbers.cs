using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodsAndOperators
{
    // Класс рациональных чисел
    class ClassRationalNumbers
    {
        private int numerator;      // поле - Числитель
        private int denominator;    // поле - Знаменатель

        // ctor класса
        public ClassRationalNumbers(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Свойство поля numerator
        public int Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        // Свойство поля denominator
        public int Denominator
        {
            get { return this.denominator; }
            set { this.denominator = value; }
        }

        // Определение оператора "+"
        public static ClassRationalNumbers operator +(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return new ClassRationalNumbers(
                n.numerator + d.numerator,
                n.denominator + d.denominator);
        }

        // Определение оператора "-"
        public static ClassRationalNumbers operator -(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return new ClassRationalNumbers(
                n.numerator - d.numerator,
                n.denominator - d.denominator);
        }

        // Определение оператора "*"
        public static ClassRationalNumbers operator *(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return new ClassRationalNumbers(
                n.numerator * d.numerator, 
                n.denominator * d.denominator);
        }

        // Определение оператора "/"
        public static ClassRationalNumbers operator /(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return new ClassRationalNumbers(
                n.numerator / d.numerator,
                n.denominator / d.denominator);
        }

        // Определение оператора "%"
        public static ClassRationalNumbers operator %(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return new ClassRationalNumbers(
                n.numerator % d.numerator,
                n.denominator % d.denominator);
        }

        // Определение оператора равенства "=="
        public static bool operator ==(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return (n.numerator == d.numerator
                && n.denominator == d.denominator);
        }

        // Определение оператора неравенства "!="
        public static bool operator !=(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return (n.numerator != d.numerator
                || n.denominator != d.denominator);
        }

        // Переопределение оператора Equals()
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        // Переопределение оператора GetHashCode()
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        // Определение оператора "++"
        public static ClassRationalNumbers operator ++(ClassRationalNumbers n)
        {
            n.numerator++;
            n.denominator++;

            return n;
        }

        // Определение оператора "--"
        public static ClassRationalNumbers operator --(ClassRationalNumbers n)
        {
            n.numerator--;
            n.denominator--;

            return n;
        }

        // Определение оператора отрицания "-("
        public static ClassRationalNumbers operator -(ClassRationalNumbers n)
        {
            return new ClassRationalNumbers(-n.numerator, -n.denominator);
        }

        // Определение оператора сравнения ">"
        public static bool operator >(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return (n.numerator > d.numerator);
        }

        // Определение оператора сравнения "<"
        public static bool operator <(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return (n.numerator < d.numerator);
        }

        // Определение оператора сравнения ">="
        public static bool operator >=(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return (n.numerator >= d.numerator);
        }

        // Определение оператора сравнения "<="
        public static bool operator <=(ClassRationalNumbers n, ClassRationalNumbers d)
        {
            return (n.numerator <= d.numerator);
        }

        // Определение оператора неявного преобразования ClassRationalNumbers в double
        public static implicit operator double(ClassRationalNumbers n)
        {
            return n.numerator;
        }

        // Определение оператора неявного преобразования ClassRationalNumbers в float
        public static implicit operator float(ClassRationalNumbers n)
        {
            return n.numerator;
        }

        // Определение оператора неявного преобразования ClassRationalNumbers в int
        public static implicit operator int(ClassRationalNumbers n)
        {
            return n.numerator;
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}
