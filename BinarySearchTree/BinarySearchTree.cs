using System;

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
                    CheckRoot();
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
                    break;
            }
        }
        private void CheckRoot()
        {
            userResponse = UserMenu.GetNodeToAdd();
            Node addedNode = new Node(userResponse);

            if (root == null)
            {
                root = addedNode;
            }
            else
            {
                AddNode(root, addedNode);
            }            
        }
        private void AddNode(Node root, Node addedNode)
        {
            if(addedNode.info > root.info)
            {
                if (root.rightChild == null)
                {
                    root.rightChild = addedNode;
                }
                else
                {
                    AddNode(root.rightChild, addedNode);
                }
            }
            else if(addedNode.info < root.info)
            {
                if (root.leftChild == null)
                {
                    root.leftChild = addedNode;
                }
                else
                {
                    AddNode(root.leftChild, addedNode);
                }
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
