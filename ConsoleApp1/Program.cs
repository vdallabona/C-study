namespace introCSharp{
    public class Program{
        static void Main(string[] args){
            int op;

            do{
                Console.WriteLine("Digite o número do Programa que deseja rodar");
                Console.WriteLine("\n [1] Exercício 8");
                Console.WriteLine("\n [2] Exercício 9");
                Console.WriteLine("\n [3] Exercício 18");
                Console.WriteLine("\n [4] Exercício 26");
                Console.WriteLine("\n [5] Exercício 24");
                Console.WriteLine("\n [6] Desafio dos *");
                Console.WriteLine("\n [7] Sair");
                op = Convert.ToInt32(Console.ReadLine());
                
                switch (op){  
                    case 1:{
                        Operacoes.Exercicio1();
                        break;
                    }
                    case 2:{
                        Operacoes.Exercicio2();
                        break;
                    }
                    case 3:{
                        Operacoes.Exercicio3();
                        break;
                    }
                    case 4:{
                        Operacoes.Exercicio4();
                        break;
                    }
                    case 5:{
                        Operacoes.Exercicio5();
                        break;
                    }
                    case 6:{
                        Operacoes.Exercicio6();
                        break;
                    }
                }
            }while(op != 7);
        }
    }
}