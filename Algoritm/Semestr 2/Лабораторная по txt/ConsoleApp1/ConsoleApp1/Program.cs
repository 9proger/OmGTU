using System;
using System.IO;
class HelloWorld
{
    static void Main()
    {
        string line1;
        string line2;
        int lin1;
        int lin2;
        try
        {
            StreamReader sr1 = new StreamReader("File1.txt");
            StreamReader sr2 = new StreamReader("File2.txt");
            StreamWriter fin = new StreamWriter("End.txt");
            line1 = sr1.ReadLine();
            line2 = sr2.ReadLine();
            lin1 = Convert.ToInt32(line1);
            lin2 = Convert.ToInt32(line2);
            while (line1 != null || line2 != null)
            {
                if (lin1 <= lin2 & line1!=null & line2!=null)
                {
                    fin.WriteLine(lin1);
                    line1 = sr1.ReadLine();
                    lin1 = Convert.ToInt32(line1);
                }
                if (lin1 > lin2 & line1 != null & line2 != null)
                {
                    fin.WriteLine(lin2);
                    line2 = sr2.ReadLine();
                    lin2 = Convert.ToInt32(line2);
                }
                if (line1 == null)
                {
                    fin.WriteLine(lin2);
                    line2 = sr2.ReadLine();
                    lin2 = Convert.ToInt32(line2);
                }
                if (line2 == null)
                {
                    fin.WriteLine(lin1);  
                    line1 = sr1.ReadLine();
                    lin1 = Convert.ToInt32(line1);
                    Console.WriteLine(lin1);
                }
            }
            sr1.Close();
            sr2.Close();
            fin.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
