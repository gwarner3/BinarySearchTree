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
        private int userResponse;

        public BinarySearchTree()
        {
            root = null;
        }
        public void RunOptionSelected(int optionSelected)
        {
            //Console.Clear();            
            switch (optionSelected)
            {
                case 1:
                    AddNodes();
                    break;
                case 2:
                    SearchNodes();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    UserMenu.SelectionMenu();
                    break;
            }
        }
        private void AddNodes()
        {
            userResponse = UserMenu.GetNodeToAdd();
            //code to add node

        }
        private void SearchNodes()
        {
            userResponse = UserMenu.GetSearchResponse();
            //code to search nodes
        }
        public void StartTree()
        {
            userResponse = UserMenu.SelectionMenu();
            RunOptionSelected(userResponse);
            Console.ReadLine();

        }
    }
}
