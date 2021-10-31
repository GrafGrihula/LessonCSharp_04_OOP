using System.Collections.Generic;

namespace DescriptionBuilding
{
    class ConcreteCreatorA : Creator
    {

        public override IBuild FactoryMethod()
        {
            return new ConcreteBuildA1();
        }

    }
}