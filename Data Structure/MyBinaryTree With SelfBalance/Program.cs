using System;

namespace BinaryTree3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryT = new(158);
            binaryT.Add(217);
            binaryT.Add(94);
            binaryT.Add(82);
            binaryT.Add(10);
            binaryT.Add(53);
            binaryT.Add(29);

            binaryT.CountNodes();
            //binaryT.PrintBinaryTree();
            binaryT.Delete(29);
            binaryT.Delete(158);
            binaryT.Delete(822);
            binaryT.PrintBinaryTree();
            binaryT.CountNodes();
        }
    }
}
