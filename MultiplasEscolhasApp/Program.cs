using System;

namespace MultiplasEscolhasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double peso;
            double altura;
            double resultado;
            double salarioAtual;
            double salarioMinimo;
            double raioEsfera;
            double volumeEsfera;
            double n1;
            double n2;
            double n3;
            double notaRec;
            double notaExame;
            double notaFinal;
            string nomeAnimal;
            string tipoAnimal;
            bool validacao = true;
            Program program = new Program();

            Console.WriteLine("Olá, seja bem vindo! Escolha uma das opções para interagir!");

            do
            {
                Console.WriteLine("(1) Calcular IMC");
                Console.WriteLine("(2) Calcular quantidade salário mínimo");
                Console.WriteLine("(3) Calcular volume de uma esfera");
                Console.WriteLine("(4) Calcular média notas escolares");
                Console.WriteLine("(6) Verificar animais");
                Console.WriteLine("(7) Sair");

                Console.WriteLine("Digite a sua opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do seu peso:");
                        peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a sua altura:");
                        altura = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Imc(peso, altura);
                        Console.WriteLine("O resultado do seu IMC é {0}", resultado);
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor do seu salário:");
                        salarioAtual = Convert.ToDouble(Console.ReadLine());

                        salarioMinimo = 1192.40;

                        resultado = program.ConversaoSalarioMinimo(salarioAtual, salarioMinimo);
                        Console.WriteLine("O seu salário equivale a {0} salários mínimos", resultado);

                        break;

                    case 3:
                        Console.WriteLine("Digite o valor do raio da esfera:");
                        raioEsfera = Convert.ToDouble(Console.ReadLine());

                        volumeEsfera = program.CalcularVolume(raioEsfera);
                        Console.WriteLine("O volume da esfera é {0}", volumeEsfera);

                        break;

                    case 4:
                        Console.WriteLine("Digite a nota final do 1º bimestre:");
                        n1= Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a nota final do 2º bimestre:");
                        n2= Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a nota final do 3º bimestre:");
                        n3= Convert.ToDouble(Console.ReadLine());

                        notaFinal = program.MediaFinal(n1, n2, n3);

                        if (notaFinal >= 7)
                        {
                            Console.WriteLine("Parabéns, você foi aprovado, sua nota final foi ${notaFinal}", notaFinal);
                        }
                        else {
                            Console.WriteLine("Você foi REPROVADO, sua nota final foi ${notaFinal}, recomendamos que faça a porva de recuperação!", notaFinal);

                            Console.WriteLine("Digite a nota da prova de recuperação");
                            notaRec = Convert.ToDouble(Console.ReadLine());

                            notaExame = program.MediaRec(notaRec, notaFinal);

                            if(notaExame >= 5)
                            {
                                Console.WriteLine("Parabéns, você foi aprovado, sua nota final foi ${notaExame}", notaExame);
                            } 
                            else {
                                Console.WriteLine("Você foi REPROVADO, sua nota da recuperação foi ${notaExame}!", notaExame);
                            }
                        }
      
                        break;

                    case 5:
                        Console.WriteLine("Digite o nome do seu animal de estimação:");
                        nomeAnimal = Console.ReadLine();

                        Console.WriteLine("Digite o tipo do seu animal de estimação:");
                        tipoAnimal = Console.ReadLine();

                        Cachorro animalNovo = new Cachorro(nomeAnimal, tipoAnimal);
                        Gato animalNovo2 = new Gato(nomeAnimal, tipoAnimal);
                        Peixe animalNovo3 = new Peixe(nomeAnimal, tipoAnimal);

                        animalNovo.verificarTipoAnimal(tipoAnimal);
                        animalNovo2.verificarTipoAnimal(tipoAnimal);
                        animalNovo3.verificarTipoAnimal(tipoAnimal);

                        Console.WriteLine("O nome do seu animal de estimação é {0} e ele é do tipo {1}", animalNovo.getNome(), animalNovo.getTipo());

                        break;

                    case 6:
                        validacao = false;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);
        }
        public double Imc(double peso, double altura)
        {
            double resultadoImc;
            resultadoImc = Math.Round((peso / (altura * altura)));

            if (resultadoImc < 20)
            {
                Console.WriteLine("Você está abaixo do peso!");
                return resultadoImc;
            } else if (resultadoImc <= 20 || resultadoImc < 25)
            {
                Console.WriteLine("Você está com peso ideal");
                return resultadoImc;
            } else
            {
                Console.WriteLine("Você está acima do peso.");
                return resultadoImc;
            }
        }
        public double ConversaoSalarioMinimo(double salarioAtual, double salarioMinimo)
        {
            return Math.Round((salarioAtual / salarioMinimo), 2);
        }

        public double CalcularVolume( double raioEsfera)
        {
            double volume;
            double pi = 3.14;

            volume = Math.Round((4.0 / 3.0) * pi * (Math.Pow(raioEsfera, 3)), 2);
            return volume;
        }

        public double MediaFinal(double n1,double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        public double MediaRec(double n4, double notaFinal)
        {
            double notaRec = (n4 + notaFinal) / 2;

            return notaRec;
        }


    }
}
