using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree2
{
    class BinaryTree
    {
        public Node root;
        public int Size = 0;

        public BinaryTree(int firstElement)
        {
            root = new(firstElement);
            Size++;
        }

        public void Add(int element)
        {
            Node newElement = new(element);
            Node placeHolder = root;

            do {
                if(newElement.Value > placeHolder.Value)
                {
                    placeHolder = placeHolder.right;
                }
                else
                {
                    placeHolder = placeHolder.left;
                }
            }
            while (placeHolder == null);

            placeHolder.Value = newElement.Value;
        }
        public void RemoveElement(int element)
        {
            Node remove = new(element);
            Node guide = root;

            do
            {
                if (remove.Value > guide.Value)
                {
                    guide = guide.right;
                }
                else if (remove.Value < guide.Value)
                {
                    guide = guide.left;
                }
                else if (guide == null)
                {
                    Console.WriteLine("Elemento encontrado.");
                }
            }
            while (guide.Value != remove.Value);

            if (guide.Value == remove.Value)
            {




            }

        }



        public void AddElement(int element)
        {
            Node newElement = new(element);
            Node placeHolder = root;

            if(newElement.Value > placeHolder.Value)
            {
                
                if(placeHolder.right == null)
                {
                    placeHolder.right = newElement;
                    Size++;
                }
                else
                {
                    placeHolder = placeHolder.right;
                    PlaceElement(placeHolder.Value, newElement.Value);
                }
            }
            else
            {
                if (placeHolder.left == null)
                {
                    placeHolder.left = newElement;
                    Size++;
                }
                else
                {
                    placeHolder = placeHolder.left;
                    PlaceElement(placeHolder.Value, newElement.Value);
                }
            }

        }
        private void PlaceElement(int position, int element) 
        {
            Node newElement = new(element);
            Node placeHolder = new(position);

            if (newElement.Value > placeHolder.Value)
            {
                if(placeHolder.right == null)
                {
                    placeHolder.right = newElement;
                    Size++;
                }
                else
                {
                    placeHolder = placeHolder.right;
                    PlaceElement(placeHolder.Value, newElement.Value);
                }

            }
            else
            {
                if (placeHolder.left == null)
                {
                    placeHolder.left = newElement;
                    Size++;
                }
                else
                {
                    placeHolder = placeHolder.left;
                    PlaceElement(placeHolder.Value, newElement.Value);
                }
            }

        }

        

    }
}
