public class Tree<T>
{
    public List<Tree<T>> Childs { get; set; } = new List<Tree<T>>();

    public T Value { get; set; }

    public Tree(T item) => this.Value = item;

    public bool AddChild(Tree<T> add)
    {
        if (add is null) return false;
        this.Childs.Add(add);
        return true;
    }

}


public class BinarianTree<T>
{
    public bool HaveChild => (this.HaveRigthChild || this.HaveLeftChild);
    public BinarianTree<T> LeftChild { get; set; }

    public bool HaveLeftChild => !(this.LeftChild is null);

    public BinarianTree<T> RigthChild { get; set; }

    public bool HaveRigthChild => !(this.RigthChild is null);

    public T Value { get; set; }


    public BinarianTree(T item) => this.Value = item;

    //False left   true: rigth
    public bool AddChild(BinarianTree<T> child, bool side)
    {
        if (side)
        {
            this.RigthChild = child;
            return true;
        }
        this.LeftChild = child;
        return true;
    }
}



public static class Recorridos
{
    public static IEnumerable<Tree<T>> PreOrden<T>(Tree<T> root)
    {
        yield return root;

        foreach (var child in root.Childs)
        {
            foreach (var item in PreOrden(child))
            {
                yield return item;
            }

        }
    }


    public static IEnumerable<Tree<T>> PosOrden<T>(Tree<T> root)
    {
        foreach (var child in root.Childs)
        {
            foreach (var item in PosOrden(child))
            {
                yield return item;
            }

        }

        yield return root;
    }

    public static IEnumerable<BinarianTree<T>> InOrden<T>(BinarianTree<T> root)
    {
        if (root.HaveLeftChild)
        {

            foreach (var item in InOrden(root.LeftChild))
            {
                yield return item;
            }
        }

        yield return root;


        if (root.HaveRigthChild)
        {
            foreach (var item in InOrden(root.RigthChild))
            {
                yield return item;
            }
        }

    }


}