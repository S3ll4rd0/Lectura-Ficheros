using System;
using System.IO;

public class lecturaFichero
{
    public static void Main(String[] args)
    {
        using (StreamReader sr = new StreamReader(@"F:\05.Internet\Google Drive\00.Proyectos\07.C#\Ejer4.6.1\bin\Debug\net6.0\tecleado.txt"))
        {
            string line;
            int i = 0;

            while (i < 3) 
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
                i++;
            }
            sr.Close();
        }
    }
}