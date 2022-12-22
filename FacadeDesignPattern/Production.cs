namespace FacadeDesignPattern
{
    internal class Production
    {
        Machine machine = new();
        Worker worker = new();
        Material material = new();

        public bool StartProduction()
        {
            if (!machine.IsRunning() && worker.hasCapacity && material.isMaterialAvailable())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
