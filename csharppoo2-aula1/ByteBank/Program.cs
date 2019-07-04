using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CalculaBonificacao();
            UsarSistema();
            
            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor carlos = new Diretor("981.981.290..70");
            carlos.Nome = "Carlos";
            carlos.Senha = "123";

            GerenteDeConta patricia = new GerenteDeConta("167.382.345-93");
            patricia.Nome = "Patricia";
            patricia.Senha = "124";

            Designer tiago = new Designer("863.362.748-10");
            tiago.Nome = "Tiago";

            ParceiroComercial parceiro = new ParceiroComercial();

            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            //sistemaInterno.Logar(pedro, "dsdsd");
            sistemaInterno.Logar(carlos, "123");
            sistemaInterno.Logar(patricia, "124");

        }

        public static void CalculaBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();


            Diretor carlos = new Diretor("981.981.290..70");
            carlos.Nome = "Carlos";

            Designer tiago = new Designer("863.362.748-10");
            tiago.Nome = "Tiago";

            GerenteDeConta patricia = new GerenteDeConta("167.382.345-93");
            patricia.Nome = "Patricia";

            Auxiliar lucas = new Auxiliar("874.492.901-65");
            lucas.Nome = "Lucas";

            gerenciadorBonificacao.Registrar(carlos);
            gerenciadorBonificacao.Registrar(tiago);
            gerenciadorBonificacao.Registrar(patricia);
            gerenciadorBonificacao.Registrar(lucas);

            Console.WriteLine("TOtal de bonificações no mês:" + gerenciadorBonificacao.GetTotalBonificacao());




        }
    }
}
