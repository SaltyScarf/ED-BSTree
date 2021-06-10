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
    }
}