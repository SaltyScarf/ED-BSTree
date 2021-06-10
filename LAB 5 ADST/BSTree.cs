using System;

namespace LAB_5_ADST
{
    public class BSTree<T>
    {
        public BSTNode<T> Root { get; set; }

        public int _count;
        
        public int Count
        {
            get => _count;
        }

        public bool BST_Insert(T value, int key)
        {
            if (Root == null)
            {
                Root = new BSTNode<T>(value, key);
            }
            else
            {
                BSTNode<T> currentParent = Root;

                while (true)
                {
                    if (key > currentParent.Key)
                    {
                        if (currentParent.RightChild != null)
                        {
                            currentParent = currentParent.RightChild;
                        }
                        else
                        {
                            currentParent.RightChild = new BSTNode<T>(value, key);

                            break;
                        }
                    }
                    else if (key < currentParent.Key)
                    {
                        if (currentParent.LeftChild != null)
                        {
                            currentParent = currentParent.LeftChild;
                        }
                        else
                        {
                            currentParent.LeftChild = new BSTNode<T>(value, key);
                            
                            break;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            _count++;
            
            return true;
        }

        public void CopyTo(BSTree<T> tree2)
        {
            if (Root != null)
            {
                tree2.Root = new BSTNode<T>(Root.Value, Root.Key);

                FillInorder(Root, tree2.Root);
            }
        }
        
        private void FillInorder(BSTNode<T> root1, BSTNode<T> root2)
        {
            if (root1.LeftChild != null)
            {
                FillInorder(root1.LeftChild, root2.LeftChild = new BSTNode<T>(default, 0));
            }
            
            root2.Value = root1.Value;
            root2.Key = root1.Key;
            
            if (root1.RightChild != null)
            {
                FillInorder(root1.RightChild, root2.RightChild = new BSTNode<T>(default, 0));
            }
        }

        public void PrintPreorder()
        {
            PrintPreorder(Root);
        }
        
        public void PrintInorder()
        {
            PrintInorder(Root);
        }
        
        private void PrintPreorder(BSTNode<T> parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Key + " ");
                PrintPreorder(parent.LeftChild);
                PrintPreorder(parent.RightChild);
            }
        }
        
        private void PrintInorder(BSTNode<T> parent)
        {
            if (parent != null)
            {
                PrintInorder(parent.LeftChild);
                Console.Write(parent.Key + " ");
                PrintInorder(parent.RightChild);
            }
        }
    }
}