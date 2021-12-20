using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_visualizer {
    class Program {
        static void printDisplay(string[] strings) {
            foreach (string msg in strings) {
                Console.WriteLine(msg);
            }
        }

        static void Main(string[] args) {
            string[] display = { "Welcome to the hex visualizer.\n",

                                 "Press E to add 1, R to add 2, T to add 5, Y to add 10, U to add 100, I to add 1000,",
                                 "C to clear output, or Q to quit the application.", 

                                 "\n",};

            printDisplay(display);

            int num = 0;
            while (true) {
                Console.WriteLine("Dec: {0}\tHex: {1:x4}", num, num);
                char press = Console.ReadKey(true).KeyChar;
                switch (press) {
                    case 'e':
                        num += 1;
                        break;
                    case 'r':
                        num += 2;
                        break;
                    case 't':
                        num += 5;
                        break;
                    case 'y':
                        num += 10;
                        break;
                    case 'u':
                        num += 100;
                        break;
                    case 'i':
                        num += 1000;
                        break;
                    case 'c':
                        num = 0; // reset num
                        Console.Clear();
                        printDisplay(display);
                        break;
                    case 'q':
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
