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
                    keepGoing = false;
                    break;
                default:
                    Console.WriteLine($"You typed {userResponse}. Please select 1, 2, or 3. Press ENTER to continue.");
                    Console.ReadLine();
                    UserMenu.SelectionMenu();
                    break;
            }
        }
        private void AddNodes()
        {
            userResponse = UserMenu.GetNodeToAdd();
            Node addedNode = new Node(userResponse);
            if (root == null)
            {
                root = addedNode;
            }
            else if (addedNode.info > root.info)
            {
                //does the current root have a right child
                Console.ReadLine();
            }
            else if (addedNode.info < root.info)
            {
                //does the current root have a left child                
                CheckLeftChild(root, addedNode);
            }
        }
        private void CheckLeftChild(Node root, Node addedNode)
        {
            if (root.leftChild == null)
            {
                root.leftChild = addedNode;
            }
            else
            {
                CheckRightChild(root);
            }
            {
                root.leftChild = new Node(userResponse);
            }
        }

        private void CheckRightChild(Node root)
        {
            Node temp = root;
            if (root.rightChild != null)
            {
                //something is on the right, move down a level
            }
            else
            {
                root.leftChild = new Node(userResponse);
            }
        }


        private void SearchNodes()
        {
            userResponse = UserMenu.GetSearchResponse();
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
