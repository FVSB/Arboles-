
public static class Transform<Tin, Tout>
{



    public static Tree<Tout> Portal<Tin, Tout>(Tree<Tin> changeTree, Func<Tin, Tout> dele)
    {
        var x = Recorridos.PreOrden(changeTree);
        var quee = Transformar(x, dele);
        var root = quee.Item1.Dequeue();
        var cant = quee.Item2.Dequeue();
        return Conformar(root, cant, quee.Item1, quee.Item2);

    }

    public static (Queue<Tree<Tout>>, Queue<int>) Transformar<Tin, Tout>(IEnumerable<Tree<Tin>> Recorrido, Func<Tin, Tout> dele)
    {
        var temp = new Queue<Tree<Tout>>();
        var count = new Queue<int>();
        foreach (var item in Recorrido)
        {
            var x = new Tree<Tout>(dele(item.Value));
            temp.Enqueue(x);
            count.Enqueue(item.Childs.Count);
        }

        return (temp, count);

    }

    private static Tree<Tout> Conformar<Tout>(Tree<Tout> root, int count, Queue<Tree<Tout>> child, Queue<int> cantHijos)
    {
        if (count == 0 || child.Count == 0 || cantHijos.Count == 0) return root;

        for (int i = 0; i < count; i++)
        {
            var next = child.Dequeue();
            var cant = cantHijos.Dequeue();

            var chi = Conformar(next, cant, child, cantHijos);
            root.AddChild(chi);
        }
        return root;
    }

}