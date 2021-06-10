namespace LAB_5_ADST
{
    public class BSTNode<T>
    {
        public T Value;
        public int Key;
        
        public BSTNode<T> LeftChild { get; set; }
        public BSTNode<T> RightChild { get; set; }

        public BSTNode(T value, int key)
        {
            Value = value;
            Key = key;
        }
    }
}