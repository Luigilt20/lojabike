namespace LojaBike
{
    class Bike
    {
        public string Modelo { get; set; } = string.Empty;
        public double bateria { get; set; }
        public double PesoCiclista { get; set; }
        public int RecargaMes {  get; set; }

        //Metodos

        public double CalcularAutonomia ()
        {
            double autonomiaBase = bateria / 15.0;
            bool pesoElevado = PesoCiclista > 90.0;
            //SE O PESO FOR ACIMA DE 90KG A BATERIA REDUZ PARA 15% DE AUTONOMIA
            return pesoElevado ? (autonomiaBase * 0.05) : autonomiaBase;
        }
        public double CalculaConsumoMensal()
        { 
            double kmPorCarga = bateria/1000.0
            return kmPorCarga * RecargaMes;
        }
        public double CalcularCustoMensal()
        { 
            const double PRECO_KWH = 0.80
            return CalculaConsumoMensal() * PRECO_KWH;
        }
        public bool ModeloEcomico()
        {
            return (CalculaConsumoMensal() < 15.0) || (CalcularAutonomia() > 40.0)
        }
    }
}