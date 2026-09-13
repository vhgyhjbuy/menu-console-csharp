using System;
using static System.Console;

class Program
{
    static void Main()
    {
        int opc = 0;

        do
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Blue;
            Clear();
            for (int i = 0; i < 25; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', 80));
            }
            janela(0, 0, 79, 2, 'd', ConsoleColor.Blue, ConsoleColor.Cyan);
            SetCursorPosition(25, 1);
            Write("*** M e n u   P r i n c i p a l***");
            SetCursorPosition(0, 2);

            janela(24, 4, 52, 10, 's', ConsoleColor.Blue, ConsoleColor.Cyan);
            SetCursorPosition(25, 5);
            Write("[1] Menu_Vetores");
            SetCursorPosition(25, 6);
            Write("[2] Joguinho Adivinha Número");
            SetCursorPosition(25, 7);
            Write("[3] Tabuada");
            SetCursorPosition(25, 8);
            Write("[4] Média Aritmética");
            SetCursorPosition(25, 9);
            Write("[5] Fim");

            janela(0, 19, 79, 21, 's', ConsoleColor.Blue, ConsoleColor.Cyan);

            janela(24, 12, 51, 14, 'd', ConsoleColor.Blue, ConsoleColor.Cyan);
            SetCursorPosition(25, 13);
            Write("Digite sua opção: ");
            opc = Convert.ToInt16(ReadLine());

            switch (opc)
            {
                case 1:
                    Menu_Vetores();
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
                    break;
                default:
                    SetCursorPosition(25, 20);
                    Write("[ *** Opção Inválida *** ]");
                    Thread.Sleep(2000);
                    break;
            }

        } while (opc != 5);
    }

    static void Menu_Vetores()
    {
        int opc2 = 0;

        do
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Red;
            Clear();

            for (int i = 0; i < 25; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', 80));
            }
            janela(0, 0, 79, 2, 'd', ConsoleColor.Red, ConsoleColor.Yellow);
            SetCursorPosition(25, 1);
            Write("*** M E N U   V E T O R E S ***");
            SetCursorPosition(0, 2);

            janela(24, 4, 55, 10, 's', ConsoleColor.Red, ConsoleColor.Yellow);
            SetCursorPosition(25, 5);
            Write("[1] Analisa Números");
            SetCursorPosition(25, 6);
            Write("[2] Consulta Dia/Mês");
            SetCursorPosition(25, 7);
            Write("[3] Sigla ou Nome de Estado");
            SetCursorPosition(25, 8);
            Write("[4] Número por Extenso");
            SetCursorPosition(25, 9);
            Write("[5] Sorteia Nome");
            SetCursorPosition(25, 10);
            Write("[6] Encerrar");

            janela(24, 12, 51, 14, 'd', ConsoleColor.Red, ConsoleColor.Yellow);
            SetCursorPosition(25, 13);
            Write("Digite sua opção: ");
            opc2 = Convert.ToInt16(ReadLine());

            switch (opc2)
            {
                case 1:
                    AnalisaNumeros();
                    break;
                case 2:
                    ConsultaDiaMes();
                    break;
                case 3:
                    ConsultaEstado();
                    break;
                case 4:
                    NumeroPorExtenso();
                    break;
                case 5:
                    SorteiaNome();
                    break;
                case 6:
                    break;
                default:
                    SetCursorPosition(25, 20);
                    Write("[ *** Opção Inválida *** ]");
                    Thread.Sleep(2000);
                    break;
            }
        } while (opc2 != 6);
    }

    static void AnalisaNumeros()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.Red;
        Clear();
        janela(0, 0, 79, 2, 'd', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(20, 1);
        Write("*** A N A L I S A   N Ú M E R O S ***");

        int[] numeros = new int[10];
        int maior = int.MinValue, menor = int.MaxValue;
        double media = 0;

        janela(5, 4, 75, 16, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 5);
        Write("Digite 10 números:");

        for (int i = 0; i < 10; i++)
        {
            SetCursorPosition(10, 7 + i);
            Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(ReadLine());
            media += numeros[i];

            if (numeros[i] > maior) maior = numeros[i];
            if (numeros[i] < menor) menor = numeros[i];
        }

        media /= 10;

        janela(5, 18, 75, 24, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 19);
        Write($"Maior número: {maior}");
        SetCursorPosition(10, 20);
        Write($"Menor número: {menor}");
        SetCursorPosition(10, 21);
        Write($"Média: {media:F2}");
        SetCursorPosition(10, 22);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static void ConsultaDiaMes()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.Red;
        Clear();
        janela(0, 0, 79, 2, 'd', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(20, 1);
        Write("*** C O N S U L T A   D I A / M Ê S ***");

        string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
        string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                           "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

        janela(5, 4, 75, 8, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 5);
        Write("Digite um número de 1 a 7 para o dia da semana: ");
        int dia = Convert.ToInt32(ReadLine()) - 1;

        SetCursorPosition(10, 6);
        Write("Digite um número de 1 a 12 para o mês: ");
        int mes = Convert.ToInt32(ReadLine()) - 1;

        janela(5, 10, 75, 14, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 11);
        if (dia >= 0 && dia < 7 && mes >= 0 && mes < 12)
        {
            Write($"Dia: {dias[dia]} | Mês: {meses[mes]}");
        }
        else
        {
            Write("Dados inválidos!");
        }
        SetCursorPosition(10, 12);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static void ConsultaEstado()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.Red;
        Clear();
        janela(0, 0, 79, 2, 'd', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(15, 1);
        Write("*** S I G L A   O U   N O M E   D E   E S T A D O ***");

        string[] siglas = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
        string[] estados = { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" };

        janela(5, 4, 75, 8, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 5);
        Write("Digite a sigla ou nome do estado: ");
        string entrada = ReadLine().ToUpper();

        janela(5, 10, 75, 14, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 11);
        bool encontrado = false;

        for (int i = 0; i < siglas.Length; i++)
        {
            if (siglas[i] == entrada || estados[i].ToUpper() == entrada)
            {
                Write($"Estado: {estados[i]} | Sigla: {siglas[i]}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Write("Estado não encontrado!");

        SetCursorPosition(10, 12);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static void NumeroPorExtenso()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.Red;
        Clear();
        janela(0, 0, 79, 2, 'd', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(18, 1);
        Write("*** N Ú M E R O   P O R   E X T E N S O ***");

        string[] numeros = { "Zero", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };

        janela(5, 4, 75, 8, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 5);
        Write("Digite um número de 0 a 9: ");
        int num = Convert.ToInt32(ReadLine());

        janela(5, 10, 75, 14, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 11);
        if (num >= 0 && num <= 9)
            Write($"Número: {numeros[num]}");
        else
            Write("Número fora do intervalo!");

        SetCursorPosition(10, 12);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static void SorteiaNome()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.Red;
        Clear();
        janela(0, 0, 79, 2, 'd', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(25, 1);
        Write("*** S O R T E I A   N O M E ***");

        string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo", "Fernanda", "Gabriel", "Helena", "Igor", "Júlia" };

        janela(5, 4, 75, 14, 's', ConsoleColor.Red, ConsoleColor.Yellow);
        SetCursorPosition(10, 8);
        Random rand = new Random();
        int sorteado = rand.Next(0, nomes.Length);
        Write($"Nome sorteado: {nomes[sorteado]}");
        SetCursorPosition(10, 10);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static void Adivinha()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.Green;
        Clear();
        for (int i = 0; i < 25; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write(new string(' ', 80));
        }
        janela(0, 0, 79, 2, 'd', ConsoleColor.Green, ConsoleColor.Cyan);
        SetCursorPosition(18, 1);
        Write("*** J O G U I N H O   A D I V I N H A   N Ú M E R O ***");

        Random rand = new Random();
        int numero = rand.Next(1, 101);
        int tentativa = 0;
        int palpite = 0;

        janela(10, 4, 70, 18, 's', ConsoleColor.Green, ConsoleColor.Cyan);
        SetCursorPosition(15, 5);
        Write("Adivinhe um número de 1 a 100!");

        while (palpite != numero)
        {
            tentativa++;
            SetCursorPosition(15, 7 + tentativa);
            Write($"Tentativa {tentativa}: ");
            palpite = Convert.ToInt32(ReadLine());

            SetCursorPosition(15, 8 + tentativa);
            if (palpite < numero)
                Write("Número é MAIOR!");
            else if (palpite > numero)
                Write("Número é MENOR!");
            else
                Write($"PARABÉNS! Você acertou em {tentativa} tentativa(s)!");

            if (tentativa >= 10)
            {
                SetCursorPosition(15, 19);
                Write($"Fim de jogo! O número era {numero}");
                break;
            }
        }

        SetCursorPosition(15, 21);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static void Tabuada()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.Magenta;
        Clear();
        for (int i = 0; i < 25; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write(new string(' ', 80));
        }
        janela(0, 0, 79, 2, 'd', ConsoleColor.Magenta, ConsoleColor.White);
        SetCursorPosition(30, 1);
        Write("*** T A B U A D A ***");

        janela(10, 4, 70, 8, 's', ConsoleColor.Magenta, ConsoleColor.White);
        SetCursorPosition(15, 5);
        Write("Digite um número para ver a tabuada (1-10): ");
        int num = Convert.ToInt32(ReadLine());

        janela(10, 10, 70, 24, 's', ConsoleColor.Magenta, ConsoleColor.White);
        if (num >= 1 && num <= 10)
        {
            SetCursorPosition(15, 11);
            Write($"Tabuada do {num}:");
            for (int i = 1; i <= 10; i++)
            {
                SetCursorPosition(15, 11 + i);
                Write($"{num} x {i} = {num * i}");
            }
        }
        else
        {
            SetCursorPosition(15, 12);
            Write("Número fora do intervalo!");
        }

        SetCursorPosition(15, 22);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static void MediaAritmetica()
    {
        ForegroundColor = ConsoleColor.White;
        BackgroundColor = ConsoleColor.DarkYellow;
        Clear();
        for (int i = 0; i < 25; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write(new string(' ', 80));
        }
        janela(0, 0, 79, 2, 'd', ConsoleColor.Yellow, ConsoleColor.DarkYellow);
        SetCursorPosition(22, 1);
        Write("*** M É D I A   A R I T M É T I C A ***");

        janela(10, 4, 70, 8, 's', ConsoleColor.Yellow, ConsoleColor.DarkYellow);
        SetCursorPosition(15, 5);
        Write("Quantas notas deseja calcular? ");
        int qtd = Convert.ToInt32(ReadLine());

        janela(10, 10, 70, 10 + qtd + 4, 's', ConsoleColor.Yellow, ConsoleColor.DarkYellow);
        double[] notas = new double[qtd];
        double soma = 0;

        for (int i = 0; i < qtd; i++)
        {
            SetCursorPosition(15, 11 + i);
            Write($"Nota {i + 1}: ");
            notas[i] = Convert.ToDouble(ReadLine());
            soma += notas[i];
        }

        double media = soma / qtd;

        SetCursorPosition(15, 11 + qtd + 1);
        Write($"Média: {media:F2}");
        SetCursorPosition(15, 11 + qtd + 2);
        if (media >= 7)
            Write("Situação: APROVADO!");
        else
            Write("Situação: REPROVADO!");

        SetCursorPosition(15, 11 + qtd + 3);
        Write("Pressione qualquer tecla para continuar...");
        ReadKey();
    }

    static bool Continua()
    {
        SetCursorPosition(25, 20);
        Write("Deseja continuar? (S/N): ");
        string resposta = ReadLine().ToUpper();
        return resposta == "S";
    }

    static void janela(int C1, int L1, int C2, int L2, char borda, ConsoleColor corF, ConsoleColor corB)
    {
        char cse, csd, cid, cie, lh, lv;

        if (borda == 'd')
        {
            cse = '╔'; csd = '╗'; cid = '╝'; cie = '╚'; lh = '═'; lv = '║';
        }
        else if (borda == 's')
        {
            cse = '┌'; csd = '┐'; cid = '┘'; cie = '└'; lh = '─'; lv = '│';
        }
        else
        {
            cse = csd = cid = cie = lh = lv = ' ';
        }

        ConsoleColor corFOriginal = Console.ForegroundColor;
        ConsoleColor corBOriginal = Console.BackgroundColor;
        
        Console.ForegroundColor = corF;
        Console.BackgroundColor = corB;

        for (int x = L1; x <= L2; x++)
        {
            Console.SetCursorPosition(C1, x);
            Console.Write(new string(' ', C2 - C1 + 1));
        }

        for (int x = L1; x <= L2; x++)
        {
            Console.SetCursorPosition(C1, x); Console.Write(lv);
            Console.SetCursorPosition(C2, x); Console.Write(lv);
        }

        Console.SetCursorPosition(C1, L1);
        Console.Write(new string(lh, C2 - C1 + 1));
        Console.SetCursorPosition(C1, L2);
        Console.Write(new string(lh, C2 - C1 + 1));

        Console.SetCursorPosition(C1, L1); Console.Write(cse);
        Console.SetCursorPosition(C2, L1); Console.Write(csd);
        Console.SetCursorPosition(C1, L2); Console.Write(cie);
        Console.SetCursorPosition(C2, L2); Console.Write(cid);

        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.DarkGray;

        for (int l = L1 + 1; l <= L2 + 1; l++)
        {
            Console.SetCursorPosition(C2 + 1, l);
            Console.Write(' ');
        }

        Console.SetCursorPosition(C1 + 1, L2 + 1);
        Console.Write(new string(' ', (C2 - C1)));

        Console.ForegroundColor = corFOriginal;
        Console.BackgroundColor = corBOriginal;
    }
}
