namespace JWLimited.Cryptography.Nodes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public DateTime CreationTime { get; }
        public DateTime LastAccessTime { get; private set; }
        public int AccessCount { get; private set; }

        public Node(T value)
        {
            Value = value;
            CreationTime = DateTime.Now;
            LastAccessTime = CreationTime;
            AccessCount = 0;
        }

        public void UpdateAccessInfo()
        {
            LastAccessTime = DateTime.Now;
            AccessCount++;
        }

        public override string ToString()
        {
            return $"Value: {Value}, Created: {CreationTime}, Last Accessed: {LastAccessTime}, Access Count: {AccessCount}";
        }
    }

}