using System;
namespace ProjectDB
{
	public class Edge
	{
        public int fee { get; set; }
        public Vertex from = new Vertex();
        public Vertex to = new Vertex();
    }
}
