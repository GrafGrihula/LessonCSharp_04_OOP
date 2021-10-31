using ReverseRow;
using System;
using Xunit;

namespace ReverseRowTest
{
    public class ReversTest
    {
        private Revers revers;
        public ReversTest()
        {
            revers = new Revers();
        }


        [Fact]
        public void WordRevers()
        {
            var input = "�����";
            var expected = "�����";

            var result = revers.StringRevers(input);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void PhraseRevers()
        {
            var input = "��������� ����";
            var expected = "���� ���������";

            var result = revers.StringRevers(input);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void PhraseWithNumbersRevers()
        {
            var input = "��������� ���� c ������� 123 = 123";
            var expected = "321 = 321 ������� c ���� ���������";

            var result = revers.StringRevers(input);

            Assert.Equal(expected, result);
        }
    }
}
