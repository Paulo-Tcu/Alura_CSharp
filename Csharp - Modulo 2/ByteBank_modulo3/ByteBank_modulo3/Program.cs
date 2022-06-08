using ByteBank_modulo3.Funcionarios;

namespace ByteBank_modulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var carlos = new Funcionario(2000, "123.456.789-00");
            //carlos.Nome = "Carlos";
            //carlos.CPF = "123.456.789-00";
            //carlos.Salario = 2000;

            //Console.WriteLine(carlos.GetBonificacao());
            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            //gerenciador.Registrar(carlos);



            //Diretor roberta = new Diretor("111.111.111-00");
            //roberta.Nome = "Roberta";
            //roberta.CPF = "111.111.111-00";
            //roberta.Salario = 5000.00;

            //Aumentar salario
            //double salario = carlos.Salario;
            //carlos.AumentarSalario();
            //Console.WriteLine($"{carlos.Nome} possui salário atual de R${salario} e terá um aumento de {carlos.Salario - salario}, totalizando R${carlos.Salario}");

            //salario = roberta.Salario;
            //roberta.AumentarSalario();
            //Console.WriteLine($"{roberta.Nome} possui salário atual de R${salario} e terá um aumento de {roberta.Salario - salario}, totalizando R${roberta.Salario}");

            //Bonificação
            //Console.WriteLine($"A bonificação de {carlos.Nome} é de R${carlos.GetBonificacao()}");
            //Console.WriteLine($"A bonificação de {roberta.Nome} é de R${roberta.GetBonificacao()}");
            //gerenciador.Registrar(roberta);
            //Console.WriteLine($"Dando um total de R${gerenciador.GetTotalBonificacao()}");

            //Console.WriteLine($"Total de funcionários {Funcionario.TotalFuncionarios}"); // Chamando atrbuto de validar total de funcionário

            //-----------------------------------------------------------------------------------------------------------------------------------

            CalcularBonificacao();
            Console.WriteLine($"E aqui o total de bonificação no atributo statico de Funcionário: R${Funcionario.TotalDeBonificacao}\n" +
                $"Com uma média de R${Funcionario.TotalDeBonificacao / Funcionario.TotalFuncionarios} por funcionário(s)\n" +
                $"Total de Funcionários: {Funcionario.TotalFuncionarios}");

            Funcionario paulo = new Desenvolvedor("123.456.789");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine($"Total de bonificações do mês: R${gerenciadorBonificacao.GetTotalBonificacao()}");
        }
    }
}



