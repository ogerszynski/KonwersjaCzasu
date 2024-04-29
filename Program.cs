using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę sekund:"); // pytanie o liczbę seukund
        int seconds = int.Parse(Console.ReadLine());

        if (seconds >= 0 && seconds <= 359999) //max wartość
        {
            string formattedTime = Konwertuj(seconds); // inicj funkcji
            Console.WriteLine("Czas w formacie HH:MM:SS: " + formattedTime); // zwraca czas albo:
        }
        else
        {
            Console.WriteLine("Nieprawidłowa liczba sekund. Podaj wartość od 0 do 359999."); //błąd
        }
    }

    static string Konwertuj(int seconds) //def funkcji
    {
        int hours = seconds / 3600;
        int remainingSeconds = seconds % 3600;
        int minutes = remainingSeconds / 60;
        int remainingMinutes = remainingSeconds % 60;
        int remainingSecondsFinal = remainingMinutes;

        // format
        string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, remainingSecondsFinal);
        return formattedTime; //zwraca wynik
    }
}
