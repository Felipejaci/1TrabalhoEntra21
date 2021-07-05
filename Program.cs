using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felipe_A._Jacinto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva seus códigos Aqui ;)
            // Nome : Felipe Andrei Jacinto


            // Inicia o Codigo

            // gera os vetores do estoque
            int[][] esto01 = new int[6][];
            int[][] esto02 = new int[6][];
            int[][] esto03 = new int[6][];
            int[][] esto04 = new int[6][];
            for (int i = 0; i < esto01.Length; i++)
            {
                esto01[i] = new int[6];
                esto02[i] = new int[6];
                esto03[i] = new int[6];
                esto04[i] = new int[6];
            }

            // parte 1)
            //preenche a matriz usando uma função uma função -----------------------------------------------------------------
            int nume = 1;
                preencheEstoque(nume, esto01);

                nume = 2;
                preencheEstoque(nume, esto02);

                nume = 3;
                preencheEstoque(nume, esto03);

                nume = 4;
                preencheEstoque(nume, esto04);
            //todas matizes preenchidas ------------------------------------------------------------------------e

            Console.WriteLine();
            Console.WriteLine("                                          |       Importa Joeslei      |");
            Console.WriteLine("                                          |      onde o produto vai    |");
            Console.WriteLine("                                          |       voando ate você      |");
            Console.WriteLine();


            // for que mostra os dias
            for (int dia = 0; dia < 6; dia++)
            {
                Console.WriteLine((dia+1) +"° dia");
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("recebe carga:");
                Console.WriteLine();

                //parte 2)
                //define as listas 
                List<string> carga1 = new List<string>();
                List<string> carga2 = new List<string>();
                List<string> carga3 = new List<string>();

                //mostra quantas cargas chegaram, preenche as listas e mostra na tela as cargas
                int quantCarga = Geradores.Qtd();
                Console.WriteLine("chegaram " + quantCarga + " cargas");
                Console.WriteLine();

                for (int i = 0; i < quantCarga; i++)
                {
                    //olha quantas cargas chegaram
                    if (i == 0)
                    {
                        carga1 = Geradores.GeraEntrada();
                        mostraList(carga1);
                        //distribui as cargas em seus devidos estoques
                        for (int j = 0; j < carga1.Count; j++)
                        {
                            if (carga1[j] == "1")
                            {
                                int nu = 1;
                                procuraMatriz(esto01,nu);
                            }
                            else if (carga1[j] == "2")
                            {
                                int nu = 2;
                                procuraMatriz(esto02, nu);
                            }
                            else if (carga1[j] == "3")
                            {
                                int nu = 3;
                                procuraMatriz(esto03, nu);
                            }
                            else
                            {
                                int nu = 4;
                                procuraMatriz(esto04, nu);
                            }
                        }
                    }
                    else if (i == 1)
                    {
                        carga2 = Geradores.GeraEntrada();
                        mostraList(carga2);
                        for (int j = 0; j < carga2.Count; j++)
                        {
                            if (carga2[j] == "1")
                            {
                                int nu = 1;
                                procuraMatriz(esto01, nu);
                            }
                            else if (carga2[j] == "2")
                            {
                                int nu = 2;
                                procuraMatriz(esto02, nu);
                            }
                            else if (carga2[j] == "3")
                            {
                                int nu = 3;
                                procuraMatriz(esto03, nu);
                            }
                            else
                            {
                                int nu = 4;
                                procuraMatriz(esto04, nu);
                            }
                        }
                    }
                    else
                    {
                        carga3 = Geradores.GeraEntrada();
                        mostraList(carga3);
                        for (int j = 0; j < carga3.Count; j++)
                        {
                            if (carga3[j] == "1")
                            {
                                int nu = 1;
                                procuraMatriz(esto01, nu);
                            }
                            else if (carga3[j] == "2")
                            {
                                int nu = 2;
                                procuraMatriz(esto02, nu);
                            }
                            else if (carga3[j] == "3")
                            {
                                int nu = 3;
                                procuraMatriz(esto03, nu);
                            }
                            else
                            {
                                int nu = 4;
                                procuraMatriz(esto04, nu);
                            }
                        }
                    }
                    Console.WriteLine();
                }

                //mostra a matriz
                mostraMatriz(esto01);
                Console.WriteLine();
                mostraMatriz(esto02);
                Console.WriteLine();
                mostraMatriz(esto03);
                Console.WriteLine();
                mostraMatriz(esto04);

                Console.WriteLine();
                Console.WriteLine("precione *ENTER* para continuar");
                Console.ReadLine();

                //mostra quantas ordens de serviço chegaram
                int quantServi = Geradores.Qtd();
                Console.WriteLine();
                Console.WriteLine("chegaram " + quantServi + " pedidos");
                Console.WriteLine();

                //cria o vetor para receber a ordem de serviço
                char[] VetorChar;               
                string[] str = new string[quantServi];

                //repete quantas ordens de serviço rescebida
                for (int i = 0; i < quantServi; i++)
                {
                    str[i] = Geradores.OrdemDeServico();
                    Console.WriteLine(str[i]);
                    //try para não dar OutOfRangeExeception
                    try
                    {
                        VetorChar = str[i].ToCharArray(0, 10);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        try
                        {
                            VetorChar = str[i].ToCharArray(0, 8);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            VetorChar = str[i].ToCharArray(0, 6);
                        }
                    }

                    //transforma o vetor de char em inteiro
                    int[] vetorInt = new int[VetorChar.Length];
                    for (int k = 0; k < VetorChar.Length; k++)
                    {
                        if (VetorChar[k] == '1')
                        {
                            vetorInt[k] = 1;
                        }
                        else if (VetorChar[k] == '2')
                        {
                            vetorInt[k] = 2;
                        }
                        else if (VetorChar[k] == '3')
                        {
                            vetorInt[k] = 3;
                        }
                        else if (VetorChar[k] == '4')
                        {
                            vetorInt[k] = 4;
                        }
                    }

                    //percorre o vetor
                    for (int j = 0; j < vetorInt.Length; j++)
                    {
                        //se o vetor tiver um 1 ele entra
                        if (vetorInt[j] == 1)
                        {
                            int nu1 = 1;
                            procuraMatrizOrdemServico(esto01, nu1);
                        }
                        else if (vetorInt[j] == 2)
                        {
                            int nu1 = 2;
                            procuraMatrizOrdemServico(esto02, nu1);
                        }
                        else if (vetorInt[j] == 3)
                        {
                            int nu1 = 3;
                            procuraMatrizOrdemServico(esto03, nu1);
                        }
                        else
                        {
                            int nu1 = 4;
                            procuraMatrizOrdemServico(esto04, nu1);
                        }
                    }
                }

                //mostra a matriz
                mostraMatriz(esto01);
                Console.WriteLine();
                mostraMatriz(esto02);
                Console.WriteLine();
                mostraMatriz(esto03);
                Console.WriteLine();
                mostraMatriz(esto04);


                Console.ReadLine();

            }                                

        }
        public static int[][] preencheEstoque(int nume, int[][] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                if (i == 0 || i == 1 || i == 2)
                {
                    for (int j = 0; j < matriz[i].Length; j++)
                    {
                        matriz[i][j]  = nume;
                    }
                }
                else
                {
                    for (int j = 0; j < matriz[i].Length; j++)
                    {
                        matriz[i][j] = 0;
                    }
                }
            }
            return matriz;
        }
        public static int[][] mostraMatriz(int[][] matriz) //olha eu sai que parece impossivel de perceber mas esta função mostra a matriz :)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j] + " |");
                }
                Console.WriteLine();
            }
            return matriz;
        }
        public static void mostraList(List<string> list )
        {
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public static int[][] procuraMatriz(int[][] matriz, int nume)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] == 0)
                    {
                        matriz[i][j] = nume;
                        if (i == 5 && j == 5)
                        {
                            matriz[i][j] = 0;
                        }
                        i = 20;
                        break;
                    }
                }
            }
            return matriz;
        }
        public static int[][] procuraMatrizOrdemServico(int[][] matriz, int nume2)
        {
            for (int i = 5; i > -1; i--)
            {
                for (int j = 5; j > -1; j--)
                {
                    if (matriz[i][j] == nume2)
                    {
                        matriz[i][j] = 0;
                        i = -20;
                        break;
                    }
                }
            }
            return matriz;
        }

    }
}
