using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_mvc.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        // caminho da pasta e do arquiv .csv

        private const string PATH = "Banco/Produto .CSV";


        public Produto()
        {
            // criar a logica para gerar a pasta e o arquivo
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho já existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho já existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                produtos.Add(p);
            }

            return produtos;
        }

        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }


    }
}