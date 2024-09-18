namespace Design_Patterns.Abstract_Factory_Desgin_Pattern
{
    public class AsusManufacturer : Company
    {
        public override Gpu createGpu()
        {
            return new AsusGpu();
        }

        public override Monitor createMonitor()
        {
            return new AsusMonitor();
        }
    }
}
