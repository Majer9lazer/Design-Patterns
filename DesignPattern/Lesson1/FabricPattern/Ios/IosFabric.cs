namespace DesignPattern.Ios
{
    class IosFabric : Fabric
    {
        public Developer GetDeveloper()
        {
            return new IosDeveloper();
        }
    }
}
