namespace StackTests
{
    internal class Stack
    {
        internal bool isEmpty = true;
        internal List<int> valeurs = new List<int>();

        internal bool IsEmpty()
        {
            if (this.valeurs.Count == 0)
                return true;
            else
                return false;
        }

        internal void Pop()
        {
            if (valeurs.Count == 0)
                throw new UnderflowException();
            else
                valeurs.RemoveAt(valeurs.Count - 1);
        }

        internal void Push(int v)
        {
            this.valeurs.Add(v);
        }

        internal class UnderflowException : Exception
        {
        }
    }
}