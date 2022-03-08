using System;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato[] contato = new Contato[5];
            int opc, cont = 0;

            void Inserir()
            {     
                    Console.Clear();
                    Console.WriteLine("\t\tAdicionando Novo Contato\n");
                    Console.Write("\tDigite o Nome: ");
                    string nome = Console.ReadLine().ToLower();
                    Console.Write("\tDigite o Telefone: ");
                    float telefone = float.Parse(Console.ReadLine());
                    Console.Write("\tDigite a Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("\tInforme o Sexo: ");
                    char sexo = char.Parse(Console.ReadLine());

                    contato[cont] = new Contato(nome, telefone, idade, sexo);
                    
                    Console.ReadKey();
                    Console.Clear();
                
            }

            void Imprimir()
            {
                Console.Clear();
                Console.WriteLine("\t\tImprimindo Contato");
                if (cont == 0)
                {
                    Console.WriteLine("\n\tNenhum Contato Registrado");
                }
                else
                {
                    for (int i = 0; i < cont; i++)
                    {
                        Console.WriteLine(contato[i].ToString());
                    }
                }
                Console.ReadKey();
                Console.Clear();


            }

            void Ordenar()
            {
                for (int i = 0; i < cont; i++)
                {
                    
                    for (int j = 0; j < cont; j++)
                    {
                        string will = contato[i].Nome;
                        string ana = contato[j].Nome;
                        Contato aux;

                        if (cont == 1)
                        {
                            break;
                        }
                        else
                        {
                            //int valor = nome1.CompareTo(nome2);

                            if (ana.CompareTo(will) == 1)
                            {
                                aux = contato[i];
                                contato[i] = contato[j];
                                contato[j] = aux;
                               
                            }
                            else
                            {

                            }

                            //Console.WriteLine(valor);
                            
                        }
                    }
                  

                }
            }

            void Remover()
            {
                Console.Clear();
                Console.WriteLine("\t\tRemovendo Contato\n");
                if (cont == 0)
                {
                    Console.WriteLine("\tNenhum Contato Registrado");
                }
                else
                {
                    Console.Write("\tNome do Contato: ");
                    string remove = Console.ReadLine();
                    bool check = false;
                    for (int i = 0; i < cont; i++)
                    {
                        if (remove == contato[i].Nome)
                        {
                            Console.WriteLine($"\n\tContato {contato[i].Nome} Removido...");
                            contato[i] = null;
                            cont--;
                            check = true;
                        }

                        if (check == false)
                        {
                            Console.WriteLine("\tEsse contato não existe");
                        }
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }

            void Seach()
            {
                Console.Clear();
                Console.WriteLine("\t\tBusca de Contato\n");
                if (cont == 0)
                {
                    Console.WriteLine("\tNenhum Contato Adicionado");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Write("Buscar: ");
                    string busca = Console.ReadLine().ToLower();
                    bool check = false;
                    for (int i = 0; i < cont; i++)
                    {
                        if (busca == contato[i].Nome)
                        {
                            Console.WriteLine(contato[i].ToString());
                            check = true;
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    if (check == false)
                    {
                        Console.WriteLine("\nNenhum Contato Encontrado!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }

            do
            {
                opc = Menu();

                switch (opc)
                {
                    case 1:
                        if (cont == 5)
                        {
                            Console.WriteLine("Lista está cheia");
                            break;
                        }
                        Inserir();
                        cont++;
                        Ordenar();
                        break;

                    case 2:
                        /*Remover();*/
                        bool check = false;
                        if (cont == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tRemover Contato\n");
                            Console.WriteLine("\tNenhum Contato!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tRemover Contato\n");
                            Console.Write("\tRemover: ");
                            string remove = Console.ReadLine().ToLower();

                            for (int i = 0; i < cont; i++)
                            {
                                if (remove == contato[i].Nome)
                                {
                                    Console.WriteLine($"Contato: {contato[i].Nome} removido...");
                                    contato[i] = null;
                                    cont--;
                                    Console.ReadKey();
                                    Console.Clear();
                                    check = true;
                                }
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                if (contato[i] == null)
                                {
                                    contato[i] = contato[i + 1];
                                    contato[i+1] = null;
                                }
                            }
                            if (check == false)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\tRemover Contato\n");
                                Console.WriteLine("\tNenhum Contato Encontrado!!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;

                    case 3:
                        Ordenar();
                        Imprimir();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\t\tQuantidade\n");
                        Console.WriteLine($"\tQuantidade de contatos: {cont}");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Seach();
                        break;
                }


            } while (opc != 6);
        }
        public static int Menu()
        {
            int opc;
            Console.WriteLine("\tMenu Prinpcial");
            Console.WriteLine("\n\t[1] - Adicionar Novo Contato" +
                                "\n\t[2] - Remover Contato" +
                                "\n\t[3] - Mostrar Todos os Contatos" +
                                "\n\t[4] - Mostrar Quantidade de Contatos" +
                                "\n\t[5] - Buscar Contatos" +
                                "\n\t[6] - Fechar");
            Console.Write("\tOpção: ");
            opc = int.Parse(Console.ReadLine());
            return (opc);
        }

    }
}
