using System;
using System.Windows.Forms;

class Hello
{
    static int Main()
    {
        Console.WriteLine("Hello World!");
        MessageBox.Show("All Done!");
        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
        return 0;
    }
}
