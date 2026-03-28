namespace ConsoleApp1;

class Program
{
    static List<double> brutto = new List<double>();
    static void Main(string[] args)
    {
        StreamReader sr= new StreamReader("netto.txt");
        while (!sr.EndOfStream)
        {
            double novelt_ar=Math.Round((Convert.ToDouble(int.Parse(sr.ReadLine())*1.27)), 0);
            brutto.Add(novelt_ar);
        }
        sr.Close();
        StreamWriter sw = new StreamWriter("brutto.txt");
        foreach (var item in brutto)
        {
            sw.WriteLine(item);
        }
        sw.Close();
    }
}
