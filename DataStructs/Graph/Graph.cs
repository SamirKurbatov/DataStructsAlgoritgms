namespace DataStructs.Graph
{
    internal class Graph
    {
        private List<Edge> edges;

        private List<Vertex> vertexes;

        public int VetrexCount => vertexes.Count;

        public int EdgeCount => edges.Count;

        public Graph()
        {
            edges = new();
            vertexes = new();
        }

        public void AddVertex(Vertex vertex)
        {
            if (vertex != null)
            {
                vertexes.Add(vertex);
            }
            else
            {
                throw new ArgumentNullException(nameof(vertex)); 
            }
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            if (from == null) throw new ArgumentNullException(nameof(from));
            if (to == null) throw new ArgumentNullException(nameof(to));

            var edge = new Edge(from, to);
            edges.Add(edge);
        }

        public int[,] GetMatrix()
        {
            var matrix = new int[vertexes.Count, vertexes.Count];

            foreach (var edge in edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetNeighbors(List<Vertex> result,Vertex vertex)
        {
            foreach (var edge in edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }

        public bool Wave(Vertex start, Vertex finish)
        {
            var list = new List<Vertex>();

            list.Add(start);

            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];

                foreach (var v in GetNeighbors(list, vertex)) 
                {
                    if (list.Contains(v) == false)
                    {
                        list.Add(v);
                    }
                }
            }

            return list.Contains(finish);
        }

        public bool BypassWave(Vertex initialVertex)
        {
            var stack = new Stack<Vertex>();
            var result = new HashSet<Vertex>();
            var list = new List<Vertex>();
            stack.Push(initialVertex);

            while (stack.Count != 0)
            {
                var vertex = stack.Pop();
                result.Add(vertex);

                foreach (var v in GetNeighbors(list,vertex))
                {
                    if (result.Contains(v) == false)
                    {
                        stack.Push(v);
                    }
                }
            }

            return result.Count == VetrexCount;
        }
    }
}
