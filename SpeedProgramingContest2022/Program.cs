class Program
{
    private static DateTime d;
    private static string fp = "";
    private static int lv = 100000000;
    private static int l = 1;
    private static int k = 10;
    private static int x = 0;
    private static int t = 0;
    private static int m = 0;

    static void Main(string[] args)
    {
        d = DateTime.Now;
        int c = new DirectoryInfo(Environment.CurrentDirectory).GetFiles().Where(a => a.Name.StartsWith("result")).Count();
        fp = $"result{c + 1}.txt";
        File.AppendAllText(fp, $"Start program! - Limit value {lv}{Environment.NewLine}");
        for (int i = 0; i <= lv; i++)
        {
            me(i);
        }
        Console.WriteLine("End");
        Console.ReadLine();
    }

    private static void me(int @in)
    {
        l = 1;
        k = 10;
        x = 0;
        m = 0;
        t = @in;

        while (@in >= k)
        {
            l++;
            k = k * 10;
        }
        int[] i = new int[l];
        while (k >= 1)
        {
            if (t >= k)
            {
                i[x] = (t / k);
                x++;
            }
            t = t % k;
            k = k / 10;
        }

        for (int n = 0; n < i.Length; n++)
        {
            m += P(i[n], l);
        }

        if (@in == m)
        {
            TimeSpan el = DateTime.Now - d;
            string msg = m + ": Ellapsed: " + el;
            Console.WriteLine(msg);
            File.AppendAllText(fp, msg + Environment.NewLine);
        }
    }

    private static int P(int @in, int l)
    {
        int a = @in;
        for (int i = 1; i < l; i++) @in = @in * a;
        return @in;
    }
}