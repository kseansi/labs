using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab_1
{
    public class Menu : Form
    {
        public Menu()
        {
            
        }

    }
    class TestMenu 
    {
        [STAThread]
        static void Main()
        {
            Menu menuForCheck = new Menu();
            Console.WriteLine(menuForCheck.IsInitialized);

        }
    }
}
