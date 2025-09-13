namespace Lab_6_1_
{
    internal class Triada
    {
        int a;
        int b;
        int c;

        public Triada(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triada()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }
        public virtual void PlusOne()
        {
            a++;
            b++;
            c++;
        }
        public override string ToString()
        {
            return ($"A: {a}, B: {b}, C: {c}");
        }
        public override bool Equals(object? obj)
        {
            if (obj is Triada)
            {
                Triada other = (Triada)obj;
                return a == other.a && b == other.b && c == other.c;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }

    }
}
