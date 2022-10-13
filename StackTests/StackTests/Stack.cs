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

        internal int Pop()
        {
            if (valeurs.Count == 0)
                throw new UnderflowException("Immpossible de Pop sur une liste vide");
            else
            {
                var last = valeurs.Last();
                valeurs.Remove(last);
                return last;
            }
        }

        internal void Push(int v)
        {
            this.valeurs.Add(v);
        }

        internal class UnderflowException : Exception
        {
            public UnderflowException(string message) : base(message)
            {

            }
        }
    }
}