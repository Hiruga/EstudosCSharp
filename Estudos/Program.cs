using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* Operações de Bitwise
             << Dobrar
             >> Metade             
             Vídeo: https://www.youtube.com/watch?v=Br1M23Qphmw&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=11
            int num = 10;

            num = num >> 1;

            Console.WriteLine(num);
            */

            /* Enumeradores (Enum)
            
            Vídeo: https://www.youtube.com/watch?v=kj_-Brm4DDI&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=12

            enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta,Sábado}; (Dentro da Classe, em cima do Static void Main)

            DiasSemana ds = (DiasSemana)3;

            int DS = (int)DiasSemana.Sexta;

            Console.WriteLine(ds);
            Console.WriteLine(DS); 

            Praticamente cria um tipo de variável novo com os valores limitados por você mesmo.

             */

            /* Typecast (Conversões) 
           Vídeo: https://www.youtube.com/watch?v=ucGefp2i4As&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=13
            float n1 = 10.5f;
            int n2 = (int)n1;

            int vInt = 10;
            long vLong = vInt;
            short vShort = (short)vInt;

            Console.WriteLine(n2);
            Console.WriteLine(vLong);
            Console.WriteLine(vShort);

             */

            /* Comando condicional If
             Vídeo: https://www.youtube.com/watch?v=m_0y_k-sCcI&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=14
             Vídeo 2: https://www.youtube.com/watch?v=Ojm98Gg1rVw

            int n1, n2, n3, n4, res;
            n1 = n2 = n3 = n4 = res = 0;
            string result;

            Console.Write("Envie a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Envie a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Envie a terceira nota: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Envie a quarta nota: ");
            n4 = int.Parse(Console.ReadLine());

            res = n1 + n2 + n3 + n4;
            if (res < 40){
                result = "Reprovado";
            }else if(res < 60){
                result = "Recuperação";
            }else{
                result = "Aprovado";
            }
            Console.WriteLine("Nota: {0} - Resultado: {1}", res, result);
             
             */

            /* If de novo
             
            int a = 10;
            int b = 20;
            int c = 2;

            if (a > b)
            {
                Console.WriteLine("É verdade");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou ElseIf");
            }
            else
            {
                Console.WriteLine("É mentira!");
            }
             
             */

            /* Switch e Goto (é o "inicio")
            int tempo = 0;
            char escolha;

            inicio:
            Console.Clear();

            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus");
            escolha = char.Parse(Console.ReadLine());


            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }
            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponível.");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
            }

            Console.Write("\nCalcular outro transporte? [s/n]: ");
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' ||  escolha == 'S') {
                goto inicio;
            }else{
                Console.WriteLine("Fim do programa.");
                Console.ReadKey();
                Console.Clear();
            }
             */

            /* For
             
            for (int num = 0; num<10; num++) //num = num+1 num+=1 num++
            {
                Console.WriteLine("Sussus Amogus");
            }
            */

            /* Teste de mesa For

            int x, y;

            y = 10;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                y = y + i;
                Console.WriteLine(y);
            }
            */

            /* While 

            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Fim do loop");
            */


            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadKey();


        }
    }
}
