namespace CarBuilderApp
{
    internal class Engine : Part
    {
        private int qubic;

        public Engine(int qubic, decimal cost) : base(cost)
        {
            this.qubic = qubic;
        }
    }
}