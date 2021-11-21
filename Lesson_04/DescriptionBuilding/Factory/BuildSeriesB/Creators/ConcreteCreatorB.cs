namespace DescriptionBuilding
{
    class ConcreteCreatorB : Creator
    {
        public override IBuild FactoryMethod()
        {
            return new ConcreteBuildB1();
        }
    }
}