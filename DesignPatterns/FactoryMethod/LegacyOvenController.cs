namespace FactoryMethod
{
    public class LegacyOvenController : OvenController
    {
        // Factory method implementation => create and return a new SerialConnection obj
        protected override IDeviceConnection CreateConnection() => new SerialConnection();
    }
}