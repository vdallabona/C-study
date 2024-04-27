namespace introCSharp{
    public class Operacoes{
        public static int Exercicio1(){
            int iex1 = 0;
            int valor;
            Console.WriteLine("Digite o valor cujo a tabuada deseja saber: ");
            valor = Convert.ToInt32(Console.ReadLine());
            
            for (iex1 = 0; iex1 <= 10; iex1++)
            {
                Console.WriteLine($"{valor} vezes {iex1} é igual a: {iex1 * valor}");
            }
            return 0;
        }
        public static int Exercicio2(){
            float[] notaEx2 = new float[3];
            for (int iex2 = 0; iex2 <= 2; iex2++)
            {
                Console.WriteLine($"Digite a {iex2 + 1}º nota do aluno:");
                notaEx2[iex2] = float.Parse(Console.ReadLine());
            }
            
            float average = (notaEx2[0] + notaEx2[1] + notaEx2[2]) / 3;
            Console.WriteLine($"A média do aluno é: {average}");
            if (average >= 7){
                Console.WriteLine("Esse aluno foi aprovado.");
            }
            else if (average >= 5 && average < 7){
                Console.WriteLine("Esse aluno está de recuperação.");
            }
            else
            {
                Console.WriteLine("Esse aluno foi reprovado.");
            }
            return 0;
        }
        public static int Exercicio3(){
            
            float custoProducao = 0;
            float custoDistribuicao = 0;
            float custoImposto = 0;

            Console.WriteLine("Digite o custo de produção do carro que mostrarei qual será o custo ao consumidor.");
            custoProducao = Convert.ToInt32(Console.ReadLine());
            custoDistribuicao = custoProducao*28/100;
            custoImposto = custoProducao*45/100;
            Console.WriteLine($"O custo ao consumidor será de R$: {custoProducao + custoDistribuicao + custoImposto},00 reais.");
            return 0;
        }
        public static int Exercicio4(){
            
            float[] peso = new float[5];
            int contadorEx4 = 0;

            do{
                Console.WriteLine($"Digite quanto você pesa, pessoa número {contadorEx4+1}. \n");
                peso[contadorEx4] = Convert.ToInt32(Console.ReadLine());
                contadorEx4++;
            }while(contadorEx4 != 5);
            Console.WriteLine($"O peso médio entre as 5 pessoas é: {(peso[0]+peso[1]+peso[2]+peso[3]+peso[4])/5}.");
            return 0;
        }
        public static int Exercicio5(){
            int iex1 = 0;
            float valor;
            float[] valorFinalTabuada = new float[11];
            
            Console.WriteLine("Digite o valor cujo a tabuada deseja saber: \n");
            valor = float.Parse(Console.ReadLine());
            
            for(iex1=0;iex1<=10;iex1++){
                valorFinalTabuada[iex1] = iex1 * valor;
                Console.WriteLine($"{valor} X {iex1} = {valorFinalTabuada[iex1]}");
            }
            return 0;    
        }
        public static int Exercicio6(){
            int max = 2;
            int contador = 1;
            int iex6 = 0;
            for(int i=0;i<=max;i++){
                for(int iex60=0;iex60<=2;iex60++){
                    if (contador == 1){
                        iex6 ++;
                        for(int contiex6=1;contiex6<=iex6;contiex6++){
                            Console.Write("*");
                        }
                        Console.WriteLine("\n");
                        contador = 2;
                    }else if (contador == 2){
                        iex6 ++;
                        for(int contiex6=1;contiex6<=iex6;contiex6++){
                            Console.Write("*");
                        }
                        Console.WriteLine("\n");
                        contador = 3;
                    }else{
                        iex6 --;
                        for(int contiex6=1;contiex6<=iex6;contiex6++){
                            Console.Write("*");
                        }
                        Console.WriteLine("\n");
                        contador = 1;
                    }
                }
            }
            return 0;
        }
    }
}