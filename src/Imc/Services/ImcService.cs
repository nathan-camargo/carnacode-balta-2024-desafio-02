namespace Imc.Services
{
    public class ImcService
    {
        public (double imc, string categoria) CalcularImcECategoria(double altura, double peso)
        {
            var imc = peso / (altura * altura);
            var categoria = DeterminarCategoria(imc);
            return (imc, categoria);
        }

        private string DeterminarCategoria(double imc)
        {
            if (imc < 18.5) return "Abaixo do peso";
            if (imc < 25) return "Peso normal";
            if (imc < 30) return "Sobrepeso";
            if (imc < 35) return "Obesidade grau I";
            if (imc < 40) return "Obesidade grau II";
            return "Obesidade grau III ou mórbida";
        }

        public string ObterExplicacao()
        {
            return "O Índice de Massa Corporal (IMC) é uma medida de gordura corporal baseada na altura e no peso que se aplica a homens e mulheres adultos. As categorias variam de 'Abaixo do peso' a 'Obesidade grau III ou mórbida'.";
        }
    }
}