using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02
{
    class RegistroDeCompras
    {
        // Definição dos atributos da classe
        private DateTime data;
        private string produto;
        private decimal valor;

        // Lista para armazenar as compras
        private List<RegistroDeCompras> compras;

        // Construtor da classe
        public RegistroDeCompras(DateTime data, string produto, decimal valor)
        {
            this.data = data;
            this.produto = produto;
            this.valor = valor;
            this.compras = new List<RegistroDeCompras>();
        }

        // Método para adicionar uma compra à lista
        public void AdicionarCompra(DateTime data, string produto, decimal valor)
        {
            compras.Add(new RegistroDeCompras(data, produto, valor));
        }

        // Método para listar todas as compras registradas
        public void ListarCompras()
        {
            foreach (var compra in compras)
            {
                Console.WriteLine($"Data: {compra.data}, Produto: {compra.produto}, Valor: {compra.valor}");
            }
        }
    }
}
