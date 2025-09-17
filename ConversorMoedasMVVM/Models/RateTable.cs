// Na Model, estará toda a tabelab de cambio fictícia + regras de conversãp das moedas.
namespace ConversorMoedasMVVM.Models
{
    public class RateTable
    {
        //Dicionário com as taxas de câmbio para as moedas suportadas.
        private readonly Dictionary<string, decimal> _toBRL = new()
        {
            ["BRL"] = 1.00m, // Real Brasileiro
            ["USD"] = 5.60m, // Dólar Americano
            ["EUR"] = 6.10m, // Euro
        };
        // Propriedade para leitura externa do dicionário de taxas de câmbio.
        public IReadOnlyDictionary<string, decimal> ToBRL => _toBRL;
        public IEnumerable<string> GetCurrencies() => _toBRL.Keys.OrderBy(k => k);
        // Método para converter um valor de uma moeda para outra.
        // IEnumerable: permite retonar uma coleção de elementos.
        // string: indica que a coleção contém elementos do tipo string
        // GetCurrencies(): é o nome do método que que retonar a coleção de strings
        // _toBRL.Keys : acessa as chaves do dicionário
        // OrderBy(k => k): ordena as chaves em ordem alfabética.

        public bool Supports(string code) => _toBRL.ContainsKey(code);
        // Verifica se a moeda é suportada, retornando true ou false.

        // Método principal de conversão de moedas
        public decimal Convert(decimal amount, string from, string to)
        {
            if (!Supports(from) || !Supports(from)) return 0m;
            // Retorna 0 se a moeda de origem ou destino não for suportada.
            if (from == to) return amount;
            // Retorna o valor original se as moedas forem iguais.
            
            var brl = amount * _toBRL[from];
            // Converte o valor para BRL (Real) como moeda intermediária.
            return brl / _toBRL[to];
        }


    }
}
