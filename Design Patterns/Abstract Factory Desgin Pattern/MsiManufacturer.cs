namespace Design_Patterns.Abstract_Factory_Desgin_Pattern
{
    public class MsiManufacturer : Company
    {
        public override Gpu createGpu()
        {
            return new MsiGpu();
        }

        public override Monitor createMonitor()
        {
            return new MsiMonitor();
        }
    }
}
