using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vamos registrar um compromisso");

        Console.Write("Digite a data do compromisso (dd/MM/aaaa): ");
        var dataDigitada = Console.ReadLine();

        DateTime dataCompromisso;

        while (!DateTime.TryParseExact(dataDigitada,
                "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out dataCompromisso))
        {
            Console.WriteLine("DATA INVÁLIDA.\nDigite a data do compromisso (dd/MM/aaaa): ");
            dataDigitada = Console.ReadLine();
        }

        Console.Write("Digite a hora do compromisso (HH:mm): ");
        var horaDigitada = Console.ReadLine();

        DateTime horaTemp;
        TimeSpan horaCompromisso;

        while (!DateTime.TryParseExact(horaDigitada,
                "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out horaTemp))
        {
            Console.WriteLine("HORA INVÁLIDA.\nDigite a hora do compromisso (HH:mm): ");
            horaDigitada = Console.ReadLine();
        }

        horaCompromisso = horaTemp.TimeOfDay;

        Console.Write("Digite a DESCRIÇÃO para o compromisso: ");
        var descricao = Console.ReadLine();

        Console.Write("Digite o LOCAL para o compromisso: ");
        var local = Console.ReadLine();

        DateTime dataEHoraParaCompromisso = dataCompromisso.Add(horaCompromisso);

        Console.WriteLine("\n--- Detalhes do Compromisso ---");
        Console.WriteLine("Data: " + dataCompromisso.ToString("dd/MM/yyyy"));
        Console.WriteLine("Hora: " + horaCompromisso.ToString(@"hh\:mm"));
        Console.WriteLine("Descrição: " + descricao);
        Console.WriteLine("Local: " + local);
        Console.WriteLine("Data e Hora Final: " + dataEHoraParaCompromisso.ToString("dd/MM/yyyy HH:mm"));
    }
}