namespace CrackingCode.src.Tree.lib
{
    public class Tree<T>
    {
        public T data { get; set; }
        public Tree<T> left { get; set; }
        public Tree<T> right { get; set; }
        public Tree(T data)
        {
            this.data = data;
        }
   }


}
