using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        int opc;
        do
        {
            // ====== CONFIGURAR TELA COM FUNDO AZUL ======
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            // Preenche todo o background com azul
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            // ====== JANELA PRINCIPAL ======
            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Cyan, ConsoleColor.Black, "*** M e n u   P r i n c i p a l ***");

            // ====== JANELA COM OPÇÕES ======
            DesenhaJanelaComFundo(10, 8, 60, 16, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[1] Menu Vetores");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 10);
            Console.Write("[2] Joguinho Adivinha Número");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 11);
            Console.Write("[3] Tabuada");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 12);
            Console.Write("[4] Média Aritmética");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 13);
            Console.Write("[5] Sorteia Nome");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 14);
            Console.Write("[6] Fim");
            Thread.Sleep(200);

            // ====== JANELA DE ENTRADA ======
            DesenhaJanelaComFundo(10, 17, 60, 20, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 18);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Digite sua opção: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            if (!int.TryParse(Console.ReadLine(), out opc))
            {
                opc = 0;
            }

            switch (opc)
            {
                case 1:
                    MenuVetores();
                    break;
                case 2:
                    Adivinha();
                    break;
                case 3:
                    Tabuada();
                    break;
                case 4:
                    MediaAritmetica();
                    break;
                case 5:
                    SorteiaName();
                    break;
                case 6:
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < Console.WindowHeight; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.Write(new string(' ', Console.WindowWidth));
                    }

                    DesenhaJanelaComFundo(10, 10, 60, 14, ConsoleColor.Red, ConsoleColor.Black, "");
                    Console.SetCursorPosition(15, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Programa Encerrado com sucesso!");
                    Console.SetCursorPosition(0, 15);
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.SetCursorPosition(12, 19);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Inválida!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                    break;
            }

        } while (opc != 6);
    }

    // ====== FUNÇÃO PARA DESENHAR JANELA COM FUNDO PREENCHIDO ======
    static void DesenhaJanelaComFundo(int x, int y, int largura, int altura,
                                       ConsoleColor corBorda, ConsoleColor corFundo, string titulo)
    {
        Console.ForegroundColor = corBorda;
        Console.BackgroundColor = corFundo;

        // Linha superior
        Console.SetCursorPosition(x, y);
        Console.Write("╔" + new string('═', largura - 2) + "╗");

        // Linhas do meio com preenchimento
        for (int i = y + 1; i < altura; i++)
        {
            Console.SetCursorPosition(x, i);
            Console.Write("║" + new string(' ', largura - 2) + "║");
        }

        // Linha inferior
        Console.SetCursorPosition(x, altura);
        Console.Write("╚" + new string('═', largura - 2) + "╝");

        // Escreve o título se fornecido
        if (!string.IsNullOrEmpty(titulo))
        {
            Console.SetCursorPosition(x + 2, y + 1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = corFundo;
            Console.Write(titulo);
        }

        Console.ForegroundColor = ConsoleColor.White;
    }

    static void MenuVetores()
    {
        int opc2;
        do
        {
            // ====== CONFIGURAR TELA COM FUNDO VERMELHO ======
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            // Preenche todo o background com vermelho
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            // ====== JANELA PRINCIPAL ======
            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** M E N U   V E T O R E S ***");

            // ====== JANELA COM OPÇÕES ======
            DesenhaJanelaComFundo(10, 8, 60, 16, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[1] Analisa Números");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 10);
            Console.Write("[2] Consulta Dia/Mês");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 11);
            Console.Write("[3] Sigla ou Nome de Estado");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 12);
            Console.Write("[4] Número por Extenso");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 13);
            Console.Write("[5] Sorteia Nome");
            Thread.Sleep(200);

            Console.SetCursorPosition(12, 14);
            Console.Write("[6] Encerrar");
            Thread.Sleep(200);

            // ====== JANELA DE ENTRADA ======
            DesenhaJanelaComFundo(10, 17, 60, 20, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 18);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite sua opção: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;

            if (!int.TryParse(Console.ReadLine(), out opc2))
            {
                opc2 = 0;
            }

            switch (opc2)
            {
                case 1:
                    AnalisaNumeros();
                    break;
                case 2:
                    ConsultaDiaMes();
                    break;
                case 3:
                    SiglaEstado();
                    break;
                case 4:
                    NumeroPorExtenso();
                    break;
                case 5:
                    SorteiaNameVetores();
                    break;
                case 6:
                    break;
                default:
                    Console.SetCursorPosition(12, 19);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Inválida!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                    break;
            }

        } while (opc2 != 6);
    }

    static void AnalisaNumeros()
    {
        int[] n = new int[10];
        int par = 0, impar = 0, soma = 0, maior = 0, menor = 0, posicao = 0, posicao2 = 0, media = 0;
        char continuar = 'S';

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** A N A L I S A   N Ú M E R O S ***");

            par = 0;
            impar = 0;
            soma = 0;
            maior = 0;
            menor = 0;
            posicao = 1;
            posicao2 = 1;
            media = 0;

            DesenhaJanelaComFundo(5, 7, 70, 19, ConsoleColor.Yellow, ConsoleColor.Black, "");

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(7, 8 + i);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Informe o {i + 1}º número desejado: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Magenta;

                if (!int.TryParse(Console.ReadLine(), out n[i]))
                {
                    n[i] = 0;
                }

                if (n[i] % 2 != 0)
                {
                    impar++;
                }
                else
                {
                    par++;
                }

                soma = soma + n[i];

                if (i == 0)
                {
                    maior = n[i];
                    menor = n[i];
                    posicao = i + 1;
                    posicao2 = i + 1;
                }
                else
                {
                    if (n[i] > maior)
                    {
                        maior = n[i];
                        posicao = i + 1;
                    }
                    if (n[i] < menor)
                    {
                        menor = n[i];
                        posicao2 = i + 1;
                    }
                }
            }

            media = soma / 10;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Cyan, ConsoleColor.Black, "*** R E S U L T A D O   D A   A N Á L I S E ***");

            DesenhaJanelaComFundo(10, 7, 60, 16, ConsoleColor.Cyan, ConsoleColor.Black, "");

            Console.SetCursorPosition(12, 8);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"✓ Números pares: {par}");
            Console.SetCursorPosition(12, 9);
            Console.WriteLine($"✓ Números ímpares: {impar}");

            Console.SetCursorPosition(12, 11);
            Console.WriteLine($"✓ Maior: {maior} (posição {posicao}ª)");
            Console.SetCursorPosition(12, 12);
            Console.WriteLine($"✓ Menor: {menor} (posição {posicao2}ª)");

            Console.SetCursorPosition(12, 14);
            Console.WriteLine($"✓ Somatória: {soma}");
            Console.SetCursorPosition(12, 15);
            Console.WriteLine($"✓ Média: {media}");

            DesenhaJanelaComFundo(10, 17, 60, 20, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 18);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }

    static void ConsultaDiaMes()
    {
        string[] dia = { "", "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
        string[] mes = { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        string opcao;
        int numero;

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Cyan, ConsoleColor.Black, "*** C O N S U L T A   D I A / M Ê S ***");

            DesenhaJanelaComFundo(10, 8, 60, 14, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("O que quer consultar (Dia, Mês ou Sair)? ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            opcao = Console.ReadLine();

            if (opcao == "Sair" || opcao == "sair")
            {
                break;
            }

            Console.SetCursorPosition(12, 10);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Digite o número correspondente: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                numero = 0;
            }

            Console.SetCursorPosition(12, 12);
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (opcao == "Dia" || opcao == "dia")
            {
                if (numero >= 1 && numero <= 7)
                {
                    Console.WriteLine($"✓ Resultado: {dia[numero]}");
                }
                else
                {
                    Console.WriteLine("✗ Dia Inválido!");
                }
            }
            else if (opcao == "Mês" || opcao == "mes" || opcao == "mês")
            {
                if (numero >= 1 && numero <= 12)
                {
                    Console.WriteLine($"✓ Resultado: {mes[numero]}");
                }
                else
                {
                    Console.WriteLine("✗ Mês Inválido!");
                }
            }
            else
            {
                Console.WriteLine("✗ Opção inválida.");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Thread.Sleep(1500);

        } while (opcao != "Sair" && opcao != "sair");
    }

    static void SiglaEstado()
    {
        string[,] estado = new string[27, 2]
        {
            { "AC", "ACRE" },
            { "AL", "ALAGOAS" },
            { "AP", "AMAPÁ" },
            { "AM", "AMAZONAS" },
            { "BA", "BAHIA" },
            { "CE", "CEARÁ" },
            { "DF", "DISTRITO FEDERAL" },
            { "ES", "ESPÍRITO SANTO" },
            { "GO", "GOIÁS" },
            { "MA", "MARANHÃO" },
            { "MT", "MATO GROSSO" },
            { "MS", "MATO GROSSO DO SUL" },
            { "MG", "MINAS GERAIS" },
            { "PA", "PARÁ" },
            { "PB", "PARAÍBA" },
            { "PR", "PARANÁ" },
            { "PE", "PERNAMBUCO" },
            { "PI", "PIAUÍ" },
            { "RJ", "RIO DE JANEIRO" },
            { "RN", "RIO GRANDE DO NORTE" },
            { "RS", "RIO GRANDE DO SUL" },
            { "RO", "RONDÔNIA" },
            { "RR", "RORAIMA" },
            { "SC", "SANTA CATARINA" },
            { "SP", "SÃO PAULO" },
            { "SE", "SERGIPE" },
            { "TO", "TOCANTINS" }
        };

        string texto;
        bool encontrado;
        char continuar = 'S';

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** S I G L A   O U   N O M E   D E   E S T A D O ***");

            encontrado = false;
            DesenhaJanelaComFundo(10, 8, 60, 13, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Informe o estado (sigla ou nome): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            texto = Console.ReadLine().ToUpper();

            for (int i = 0; i < 27; i++)
            {
                if (texto == estado[i, 0])
                {
                    Console.SetCursorPosition(12, 11);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"✓ {estado[i, 0]} = {estado[i, 1]}");
                    encontrado = true;
                    break;
                }
                else if (texto == estado[i, 1])
                {
                    Console.SetCursorPosition(12, 11);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"✓ {estado[i, 1]} = {estado[i, 0]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.SetCursorPosition(12, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("✗ Estado não encontrado!");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Thread.Sleep(700);
            Console.SetCursorPosition(12, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }

    static void NumeroPorExtenso()
    {
        string[] unidade = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        string[] dezena = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        string[] centena = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
        int n, ne, nd, centena_num, resto;
        string extenso;
        char continuar = 'S';

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** N Ú M E R O   P O R   E X T E N S O ***");

            extenso = "";
            DesenhaJanelaComFundo(10, 8, 60, 13, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Informe um número (0 a 1000): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            if (!int.TryParse(Console.ReadLine(), out n))
            {
                n = 0;
            }

            Thread.Sleep(500);
            Console.SetCursorPosition(12, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (n < 0 || n > 1000)
            {
                Console.WriteLine("✗ Número fora da faixa!");
            }
            else if (n < 20)
            {
                extenso = unidade[n];
                Console.WriteLine($"✓ {n} = {extenso}");
            }
            else if (n < 100)
            {
                ne = n / 10;
                nd = n % 10;
                extenso = dezena[ne];
                if (nd > 0)
                {
                    extenso += " e " + unidade[nd];
                }
                Console.WriteLine($"✓ {n} = {extenso}");
            }
            else if (n == 100)
            {
                extenso = "cem";
                Console.WriteLine($"✓ {n} = {extenso}");
            }
            else if (n < 1000)
            {
                centena_num = n / 100;
                resto = n % 100;
                if (resto == 0)
                {
                    extenso = centena[centena_num];
                }
                else
                {
                    if (resto < 20)
                    {
                        extenso = centena[centena_num] + " e " + unidade[resto];
                    }
                    else
                    {
                        ne = resto / 10;
                        nd = resto % 10;
                        extenso = centena[centena_num] + " e " + dezena[ne];

                        if (nd > 0)
                        {
                            extenso += " e " + unidade[nd];
                        }
                    }
                }
                Console.WriteLine($"✓ {n} = {extenso}");
            }
            else
            {
                extenso = "mil";
                Console.WriteLine($"✓ {n} = {extenso}");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(700);
            Console.SetCursorPosition(12, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }

    static void SorteiaNameVetores()
    {
        char continuar = 'S';
        do
        {
            string[] nome = new string[5];
            string[] nome_sorteado = new string[5];
            bool[] ja_sorteado = { false, false, false, false, false };
            int n;
            HashSet<string> nomes_verificados = new HashSet<string>();

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            // ====== VALIDAÇÃO DE NOMES DUPLICADOS ======
            bool nomes_validos = false;
            while (!nomes_validos)
            {
                nomes_validos = true;
                nomes_verificados.Clear();
                DesenhaJanelaComFundo(10, 8, 60, 16, ConsoleColor.Yellow, ConsoleColor.Black, "");

                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(12, 9 + i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Informe o {i + 1}º nome: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    nome[i] = Console.ReadLine().Trim();

                    // Verifica se o nome já foi inserido
                    if (nomes_verificados.Contains(nome[i].ToLower()))
                    {
                        Console.Clear();

                        for (int j = 0; j < Console.WindowHeight; j++)
                        {
                            Console.SetCursorPosition(0, j);
                            Console.Write(new string(' ', Console.WindowWidth));
                        }

                        DesenhaJanelaComFundo(5, 10, 70, 14, ConsoleColor.Red, ConsoleColor.Black, "");
                        Console.SetCursorPosition(12, 11);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("✗ ERRO: Nomes duplicados! Digite novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(2000);
                        Console.Clear();

                        for (int j = 0; j < Console.WindowHeight; j++)
                        {
                            Console.SetCursorPosition(0, j);
                            Console.Write(new string(' ', Console.WindowWidth));
                        }

                        nomes_validos = false;
                        break;
                    }

                    nomes_verificados.Add(nome[i].ToLower());
                }
            }

            // ====== SORTEIO DOS NOMES ======
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    n = random.Next(0, 5);
                } while (ja_sorteado[n] == true);

                ja_sorteado[n] = true;
                nome_sorteado[i] = nome[n];
            }

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Cyan, ConsoleColor.Black, "*** R E S U L T A D O   D O   S O R T E I O ***");

            DesenhaJanelaComFundo(10, 8, 60, 15, ConsoleColor.Cyan, ConsoleColor.Black, "");

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(12, 9 + i);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"★ {i + 1}º - {nome_sorteado[i]}");
                Thread.Sleep(400);
            }
            Thread.Sleep(500);

            DesenhaJanelaComFundo(10, 16, 60, 19, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 17);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }

    static void Adivinha()
    {
        char continuar = 'S';

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Cyan, ConsoleColor.Black, "*** J O G U I N H O   A D I V I N H A   N Ú M E R O ***");

            int numero = random.Next(1, 101);
            int tentativa = 0;
            int palpite = 0;

            DesenhaJanelaComFundo(10, 8, 60, 18, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Adivinhe um número de 1 a 100!");
            Console.WriteLine();

            while (palpite != numero)
            {
                tentativa++;
                Console.SetCursorPosition(12, 10 + tentativa);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Tentativa {tentativa}: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                if (!int.TryParse(Console.ReadLine(), out palpite))
                {
                    palpite = 0;
                }

                Console.SetCursorPosition(12, 11 + tentativa);
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (palpite < numero)
                    Console.WriteLine("O número é MAIOR!");
                else if (palpite > numero)
                    Console.WriteLine("O número é MENOR!");
                else
                    Console.WriteLine($"PARABÉNS! Você acertou em {tentativa} tentativa(s)!");

                if (tentativa >= 10)
                {
                    Console.SetCursorPosition(12, 12 + tentativa);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Fim de jogo! O número era {numero}");
                    break;
                }
            }

            DesenhaJanelaComFundo(10, 19, 60, 22, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 20);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }

    static void Tabuada()
    {
        char continuar = 'S';

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** T A B U A D A ***");

            DesenhaJanelaComFundo(10, 8, 60, 12, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite um número (1-10): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                numero = 0;
            }

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, $"*** T A B U A D A   D O   {numero} ***");

            if (numero >= 1 && numero <= 10)
            {
                DesenhaJanelaComFundo(15, 8, 50, 20, ConsoleColor.Yellow, ConsoleColor.Black, "");

                for (int i = 1; i <= 10; i++)
                {
                    Console.SetCursorPosition(17, 8 + i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
            else
            {
                DesenhaJanelaComFundo(15, 10, 50, 14, ConsoleColor.Red, ConsoleColor.Black, "");
                Console.SetCursorPosition(17, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número fora do intervalo!");
            }

            DesenhaJanelaComFundo(10, 21, 60, 24, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 22);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }

    static void MediaAritmetica()
    {
        char continuar = 'S';

        do
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** M É D I A   A R I T M É T I C A ***");

            DesenhaJanelaComFundo(10, 8, 60, 12, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Quantas notas deseja calcular? ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            if (!int.TryParse(Console.ReadLine(), out int qtd) || qtd <= 0)
            {
                qtd = 0;
            }

            double[] notas = new double[qtd];
            double soma = 0;

            if (qtd > 0)
            {
                DesenhaJanelaComFundo(10, 13, 60, 13 + qtd + 2, ConsoleColor.Yellow, ConsoleColor.Black, "");

                for (int i = 0; i < qtd; i++)
                {
                    Console.SetCursorPosition(12, 14 + i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Nota {i + 1}: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    if (!double.TryParse(Console.ReadLine(), out notas[i]))
                    {
                        notas[i] = 0;
                    }

                    soma += notas[i];
                }

                double media = soma / qtd;

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write(new string(' ', Console.WindowWidth));
                }

                DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** R E S U L T A D O ***");

                DesenhaJanelaComFundo(10, 8, 60, 14, ConsoleColor.Yellow, ConsoleColor.Black, "");

                Console.SetCursorPosition(12, 9);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"✓ Média: {media:F2}");

                Console.SetCursorPosition(12, 11);
                if (media >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("✓ Situação: APROVADO!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("✗ Situação: REPROVADO!");
                }
            }
            else
            {
                DesenhaJanelaComFundo(10, 10, 60, 14, ConsoleColor.Red, ConsoleColor.Black, "");
                Console.SetCursorPosition(12, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Quantidade de notas inválida!");
            }

            DesenhaJanelaComFundo(10, 15, 60, 18, ConsoleColor.Yellow, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 16);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }

    static void SorteiaName()
    {
        char continuar = 'S';
        do
        {
            string[] nome = new string[5];
            string[] nome_sorteado = new string[5];
            bool[] ja_sorteado = { false, false, false, false, false };
            int n;
            HashSet<string> nomes_verificados = new HashSet<string>();

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** S O R T E I A   N O M E ***");

            // ====== VALIDAÇÃO DE NOMES DUPLICADOS ======
            bool nomes_validos = false;
            while (!nomes_validos)
            {
                nomes_validos = true;
                nomes_verificados.Clear();
                DesenhaJanelaComFundo(10, 8, 60, 16, ConsoleColor.Yellow, ConsoleColor.Black, "");

                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(12, 9 + i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Informe o {i + 1}º nome: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    nome[i] = Console.ReadLine().Trim();

                    // Verifica se o nome já foi inserido
                    if (nomes_verificados.Contains(nome[i].ToLower()))
                    {
                        Console.Clear();

                        for (int j = 0; j < Console.WindowHeight; j++)
                        {
                            Console.SetCursorPosition(0, j);
                            Console.Write(new string(' ', Console.WindowWidth));
                        }

                        DesenhaJanelaComFundo(5, 10, 70, 14, ConsoleColor.Red, ConsoleColor.Black, "");
                        Console.SetCursorPosition(12, 11);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("✗ ERRO: Nomes duplicados! Digite novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(2000);
                        Console.Clear();

                        for (int j = 0; j < Console.WindowHeight; j++)
                        {
                            Console.SetCursorPosition(0, j);
                            Console.Write(new string(' ', Console.WindowWidth));
                        }

                        DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Yellow, ConsoleColor.Black, "*** S O R T E I A   N O M E ***");

                        nomes_validos = false;
                        break;
                    }

                    nomes_verificados.Add(nome[i].ToLower());
                }
            }

            // ====== SORTEIO DOS NOMES ======
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    n = random.Next(0, 5);
                } while (ja_sorteado[n] == true);

                ja_sorteado[n] = true;
                nome_sorteado[i] = nome[n];
            }

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            DesenhaJanelaComFundo(5, 2, 70, 5, ConsoleColor.Cyan, ConsoleColor.Black, "*** R E S U L T A D O   D O   S O R T E I O ***");

            DesenhaJanelaComFundo(10, 8, 60, 15, ConsoleColor.Cyan, ConsoleColor.Black, "");

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(12, 9 + i);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"★ {i + 1}º - {nome_sorteado[i]}");
                Thread.Sleep(400);
            }
            Thread.Sleep(500);

            DesenhaJanelaComFundo(10, 16, 60, 19, ConsoleColor.Cyan, ConsoleColor.Black, "");
            Console.SetCursorPosition(12, 17);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Deseja continuar? (S/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            continuar = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (continuar == 'S' || continuar == 's');
    }
}
