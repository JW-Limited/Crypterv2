using Newtonsoft.Json;

namespace JWLimited.Cryptography.Nodes
{

    public sealed class NodeManager<T>
    {
        private Node<T> head;
        private Action<Exception> errorHandler;
        private readonly object dataLock = new object();    

        public static NodeManager<T> Create(Action<Exception> _errorHandler)
        {
            ArgumentNullException.ThrowIfNull(_errorHandler);

            var nodeMng = new NodeManager<T>();
            nodeMng.errorHandler = _errorHandler;
            return nodeMng;
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                current.Previous = head;
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                Node<T> current = head;
                while (current != null)
                {
                    writer.WriteLine(current.Value);
                    current = current.Next;
                }
            }
        }

        public async Task<byte> SaveToSeparateFiles(string folderPath, Func<Node<T>, string> fileNameSelector)
        {
            lock(dataLock)
            {
                return _SaveToSeparateFiles(folderPath, fileNameSelector);
            }
        }

        public class CurrentNodeData
        {
            public int Index { get; set; }
            public int NextIndex { get; set; }
            public T Value { get; set; }
        }


        private byte _SaveToSeparateFiles(string folderPath, Func<Node<T>, string> fileNameSelector)
        {
            try
            {
                Node<T> current = head;
                int index = 0;

                while (current != null)
                {
                    string fileName = Path.Combine(folderPath, fileNameSelector(current));

                    CurrentNodeData nodeData = new CurrentNodeData()
                    {
                        Value = current.Value,
                        Index = index,
                        NextIndex = index + 1
                    };

                    string json = JsonConvert.SerializeObject(nodeData);

                    File.WriteAllText(fileName, json);

                    current = current.Next;
                    index++;
                }

                return 1;
            }
            catch(Exception  ex)
            {
                errorHandler?.Invoke(ex);
            }

            return 0;
            
        }

        public async Task<List<CurrentNodeData>> LoadFromSeparateFiles(string folderPath)
        {
            lock (dataLock)
            {
                return _LoadFromSeparateFiles(folderPath);
            }
        }

        private List<CurrentNodeData> _LoadFromSeparateFiles(string folderPath)
        {
            List<CurrentNodeData> nodes = new List<CurrentNodeData>();

            try
            {
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    string json = File.ReadAllText(file);
                    nodes.Add(JsonConvert.DeserializeObject<CurrentNodeData>(json));
                }
                nodes = nodes.OrderBy(x => x.Index).ToList();
                head = null;
                foreach (CurrentNodeData node in nodes)
                {
                    Add(node.Value);
                }

                return nodes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void LoadFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Add((T)Convert.ChangeType(line, typeof(T)));
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}