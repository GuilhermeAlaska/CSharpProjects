using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree3
{
    class BinaryTree
    {
        public Node root;
        public int NumberOfElements = 0;
        ArrayList selfBalancedArrayList = new();
        ArrayList temp = new();

        public BinaryTree(int firstValue)
        {
            root = new(firstValue);
            NumberOfElements++;
        }

        public void Add(int element)
        {
            Node newElement = new(element);
            Node elementPlace = root;
            bool elementInserted = false;

            while (!elementInserted)
            {
                if(elementPlace == null)
                {
                    root = newElement;
                    elementInserted = true;
                }
                if (newElement.Value <= elementPlace.Value)
                {
                    if (elementPlace.left == null)
                    {
                        elementPlace.left = newElement;
                        NumberOfElements++;
                        elementInserted = true;
                    }
                    else
                    {
                        elementPlace = elementPlace.left;
                    }
                }
                else if (newElement.Value > elementPlace.Value)
                {
                    if (elementPlace.right == null)
                    {
                        elementPlace.right = newElement;
                        NumberOfElements++;
                        elementInserted = true;
                    }
                    else
                    {
                        elementPlace = elementPlace.right;
                    }
                }
            }
        }
        private void AddNode(Node element)
        {

            Node elementPlace = root;
            bool elementInserted = false;

            while (!elementInserted)
            {
                if (element.Value <= elementPlace.Value)
                {
                    if (elementPlace.left == null)
                    {
                        elementPlace.left = element;
                        NumberOfElements++;
                        elementInserted = true;
                    }
                    else
                    {
                        elementPlace = elementPlace.left;
                    }
                }
                else if (element.Value > elementPlace.Value)
                {
                    if (elementPlace.right == null)
                    {
                        elementPlace.right = element;
                        NumberOfElements++;
                        elementInserted = true;
                    }
                    else
                    {
                        elementPlace = elementPlace.right;
                    }
                }
            }
        }
        public void Altura()
        {
            Console.WriteLine("A altura da árvore é: " + CountAltura(root));
        }
        private int CountAltura(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            else
            {
                int esq = CountAltura(root.left);
                int dir = CountAltura(root.right);
                if (esq > dir)
                {
                    return esq + 1;
                }
                else
                {
                    return dir + 1;
                }
            }
        }
        public void Delete(int element)
        {
            Node nodeToRemove = new(element);
            Node elementPlace = root;
            Node prevElement;
            bool elementRemoved = false;

            while (!elementRemoved)
            {
                if (nodeToRemove.Value == elementPlace.Value)
                {
                    Node newRoot;

                    if (root.left != null)
                    {
                        newRoot = root.right;
                        Node oldLeft = root.left;
                        root = newRoot;
                        AddNode(oldLeft);
                        NumberOfElements--;
                        elementRemoved = true;
                    }
                    else
                    {
                        root = root.right;
                        elementRemoved = true;
                    }
                }
                if (nodeToRemove.Value < elementPlace.Value)
                {
                    Node newLeft;

                    if (elementPlace.left == null)
                    {
                        Console.WriteLine("\nElemento não encontrado!\n");
                        break;
                    }

                    if (nodeToRemove.Value == elementPlace.left.Value)
                    {
                        prevElement = elementPlace;
                        elementPlace = elementPlace.left;

                        if (elementPlace.left == null && elementPlace.right == null)
                        {
                            elementPlace = null;
                            prevElement.left = null;
                            elementRemoved = true;
                        }
                        else if (elementPlace.right != null && elementPlace.left == null)
                        {
                            newLeft = elementPlace.right;
                            prevElement.left = newLeft;
                            elementPlace = null;
                            elementRemoved = true;
                        }
                        else if (elementPlace.left != null && elementPlace.right == null)
                        {
                            newLeft = elementPlace.left;
                            prevElement.left = newLeft;
                            elementPlace = null;
                            elementRemoved = true;
                        }
                        else                                                           
                        {
                            newLeft = elementPlace.right;
                            newLeft.left = elementPlace.left;
                            prevElement.left = newLeft;
                            elementPlace = null;
                            elementRemoved = true;
                        }
                    }
                    else 
                    {
                        elementPlace = elementPlace.left;
                    }
                }
                else    
                {
                    Node newRight;

                    if (elementPlace.right == null)
                    {
                        Console.WriteLine("\nElemento não encontrado!\n");
                        break;
                    }

                    if (nodeToRemove.Value == elementPlace.right.Value)
                    {
                        prevElement = elementPlace;
                        elementPlace = elementPlace.right;

                        if (elementPlace.left == null && elementPlace.right == null)
                        {
                            elementPlace = null;
                            prevElement.right = null;
                            elementRemoved = true;
                        }
                        else if (elementPlace.right != null && elementPlace.left == null)
                        {
                            newRight = elementPlace.right;
                            prevElement.right = newRight;
                            elementPlace = null;
                            elementRemoved = true;
                        }
                        else if (elementPlace.left != null && elementPlace.right == null)
                        {
                            newRight = elementPlace.left;
                            prevElement.right = newRight;
                            elementPlace = null;
                            elementRemoved = true;
                        }
                        else                                                           
                        {
                            newRight = elementPlace.right;
                            newRight.left = elementPlace.left;

                            prevElement.right = newRight;
                            elementPlace = null;
                            elementRemoved = true;
                        }
                    }
                    else
                    {
                        elementPlace = elementPlace.right;
                    }
                }
            }
            if (elementRemoved) { Console.WriteLine("\nElemento removido.\n"); NumberOfElements--;}
        }
        public void CountNodes()
        {
            Console.WriteLine("\nNúmero de nós: " + NumberOfElements);
        }
        public void MaxNumber()
        {
            Node maxNumber = root;
            while (maxNumber.right != null)
            {
                maxNumber = maxNumber.right;
            }
            Console.WriteLine($"\nO maior número é: {maxNumber.Value}");
        }
        public void MinNumber()
        {
            Node minNumber = root;
            while (minNumber.left != null)
            {
                minNumber = minNumber.left;
            }
            Console.WriteLine($"\nO menor número é: {minNumber.Value}");
        }
        public void PrintBinaryTree()
        {
            RecursivePrintTree(root);
        }
        private void RecursivePrintTree(Node node)
        {
            if (node == null)
            {
                node = root;
            }
            if (node.left != null)
            {
                RecursivePrintTree(node.left);
                Console.Write(" " + node.Value);
            }
            else
            {
                Console.Write(" " + node.Value);
            }
            if (node.right != null)
            {
                RecursivePrintTree(node.right);
            }
        }
        private void InsertItemsOnArrayList(Node node)
        {
            if (node == null)
            {
                node = root;
            }
            if (node.left != null)
            {
                InsertItemsOnArrayList(node.left);
                temp.Add(node.Value);
            }
            else
            {
                temp.Add(node.Value);
            }
            if (node.right != null)
            {
                InsertItemsOnArrayList(node.right);
            }
        }
        private void CreateOrdenatedArrayList()
        {
            InsertItemsOnArrayList(root);
        }
        private void InsertItemsOnSelfBalancedTree()
        {
            int middleElementIndex = temp.Count / 2;
            int index = middleElementIndex;

            selfBalancedArrayList.Add(temp[middleElementIndex]);
            BinaryTree selfBalancedTree = new(Convert.ToInt32(temp[middleElementIndex]));

            int arraySize = temp.Count;
            int indexToBeAccessed = index + 1;

            while (indexToBeAccessed <= arraySize - 1)
            {
                selfBalancedArrayList.Add(temp[indexToBeAccessed]);
                indexToBeAccessed++;
            }
            indexToBeAccessed = index - 1;
            while (indexToBeAccessed != 0)
            {
                selfBalancedArrayList.Add(temp[indexToBeAccessed]);
                indexToBeAccessed--;
            }

            foreach (int item in selfBalancedArrayList)
            {
                selfBalancedTree.Add(item);
            }
            Console.Write("Self balanced tree: ");
            RecursivePrintTree(selfBalancedTree.root);
        }
        public void CreateSelfBalancedTree()
        {
            CreateOrdenatedArrayList();
            InsertItemsOnSelfBalancedTree();
        }
    }
}
