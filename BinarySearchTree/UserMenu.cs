using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public static class UserMenu
    {
        private static int userResponse;
        public static int SelectionMenu()
        {
            Console.Clear();
            Console.WriteLine("Key in number for what operation you ant to perform and press Enter.\n1. Add\n2. Search\n3. Exit application");
            try
            {
                userResponse = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please coose from one of the options. Press ENTER to continue.");
                Console.ReadLine();
                SelectionMenu();
            }            
            return userResponse;
        }
        public static int GetNodeToAdd()
        {
            Console.Clear();
            Console.WriteLine("Key in the item to add and press enter?");
            userResponse = Convert.ToInt32(Console.ReadLine());
            return userResponse;
        }
        public static int GetSearchResponse()
        {
            Console.Clear();
            Console.WriteLine("Key in the item you want to find and press enter?");
            userResponse = Convert.ToInt32(Console.ReadLine());
            return userResponse;
        }
    }
}
