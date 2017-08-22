using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node root;
        private string userResponse;

        public BinarySearchTree()
        {
            root = null;
        }
        public void SelectionMenu()
        {
            Console.Clear();
            Console.WriteLine("Key in number for what operation you ant to perform and press Enter.\n1. Add\n2. Search\n3. Exit application");
            userResponse = Console.ReadLine();
            switch (userResponse)
            {
                case "1":
                    AddNodes();
                    break;
                case "2":
                    SearchNodes();
                    break;
                case "3":                    
                    Environment.Exit(1);
                    break;
            }            
        }
        public void AddNodes()
        {

        }
        public void SearchNodes()
        {

        }
    }
}
