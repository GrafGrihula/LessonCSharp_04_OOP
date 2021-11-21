using System;
using System.Collections.Generic;
using System.Text;

namespace DescriptionBuilding
{
    abstract class Creator
    {
        List<string> creators = new List<string>();
        public abstract IBuild FactoryMethod();

        public Creator()
        {

        }

        public void CreateBuild()
        {
            // Вызываем фабричный метод, чтобы получить объект-продукт.
            var product = FactoryMethod();
            // Далее, работаем с этим продуктом.
            var result = "Creator: \r\n" + product.Operation();
            creators.Add(result);
            foreach (string build in creators)
            {
                Console.WriteLine(build);
            }
        }
    }
}
