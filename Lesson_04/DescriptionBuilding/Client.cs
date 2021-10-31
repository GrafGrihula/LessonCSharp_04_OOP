using System;

namespace DescriptionBuilding
{
    class Client
    {
        public Client()
        {
        }

        public void Main()
        {
            Console.WriteLine("App: Запущено с ConcreteCreatorA.");
            ClientCode(new ConcreteCreatorA());
            ClientCode(new ConcreteCreatorA());

            Console.WriteLine("");

            Console.WriteLine("App: Запущено с ConcreteCreatorB.");
            ClientCode(new ConcreteCreatorB());
        }

        public void ClientCode(Creator creator)
        {

            // ...
            //Console.WriteLine("Client: Я не знаю о классе Creator," +
            //    "но это все еще работает.\n");
            Console.WriteLine();
            creator.CreateBuild();
            // ...
        }
    }
}