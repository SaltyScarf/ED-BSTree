using System;

namespace LAB_5_ADST
{
    class Program
    {
        static void Main()
        {
            BSTree<int> test = new BSTree<int>();

            test.BST_Insert(100, 50);
            test.BST_Insert(200, 40);
            test.BST_Insert(300, 70);
            test.BST_Insert(400, 60);
            test.BST_Insert(500, 80);
        }
    }
}
