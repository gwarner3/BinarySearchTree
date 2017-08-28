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
        private bool continueSearch;// = true;

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
            continueSearch = true;
            userResponse = UserMenu.GetNodeToAdd();
            Node addedNode = new Node(userResponse);

            if (root == null)
            {
                root = addedNode;
            }
            else if (addedNode.info > root.info)
            {
                //check if right node is empty
                Console.ReadLine();
            }
            else if (addedNode.info < root.info)
            {
                Node tempRoot = root;
                CheckLeftChild(tempRoot, addedNode);
            }
        }
        private void CheckLeftChild(Node tempRoot, Node addedNode)
        {
        }
        private void FindNextLeftNode(Node leftChild, Node addedNode)
        {
        }
        private void CheckRightChild(Node root)
        {
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
