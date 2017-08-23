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
        private Node leftChild;
        private Node rightChild;
        private int userResponse;
        private bool keepGoing = true;

        public BinarySearchTree()
        {
            root = null;
        }
        public void RunOptionSelected(int optionSelected)
        {
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
            if (root == null)
            {
                root = new Node(userResponse);
                return;
            }
            
            
            if (root.leftLink == null && root.info < userResponse)
            {
                leftChild = new Node(userResponse);
                root.leftLink = leftChild;
            }
            else if (root.leftLink == null && root.info > userResponse)
            {
                rightChild = new Node(userResponse);
                root.rightLink = rightChild;
            }
            //UserMenu.SelectionMenu();            
        }
        
            //else if (userResponse > root.info)
            //{
            //    Node newNode = new Node(userResponse);
            //    root.rightLink = root;
            //}
            //else if (userResponse < root.info)
            //{
            //    Node temp = new Node(userResponse);
            //    root.leftLink = temp;
            //}
        //}
        private void SearchNodes()
        {
            userResponse = UserMenu.GetSearchResponse();
            //code to search nodes
        }
        public void StartTree()
        {
            
            while (keepGoing)
            {
                userResponse = UserMenu.SelectionMenu();
                RunOptionSelected(userResponse);                
            }
            Console.ReadLine();

        }
    }
}
