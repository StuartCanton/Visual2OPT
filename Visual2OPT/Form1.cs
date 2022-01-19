using SharedLibrary.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Visual2OPT.TestGraphAlgorithms;

namespace Visual2OPT
{
    public partial class Form1 : Form
    {
        private CostMatrix _cm;

        private SolidBrush redBrush = new SolidBrush(Color.DarkRed);
        private Pen redPen = new Pen(Color.DarkRed);
        private Font labelFont = new Font(FontFamily.GenericMonospace, 12);

        private List<Point> Data = new List<Point>();
        private readonly GraphFactory _graphFactory;
        private Graph _graph;

        Node[] Nodes; //problem
        Edge[] Edges; //solution


        private readonly Random _random;

        
        public Form1()
        {
            AllocConsole();
            _random = new Random(55);

            //set up the problem
            NodeFactory _nodeFactory = new NodeFactory(_random);
            Nodes = _nodeFactory.GetNodes(5);



            _graphFactory = new GraphFactory(_random);
            _graph = _graphFactory.GetGraph(Nodes.Length);

            Debug.WriteLine($"Number of edges:{_graph.Edges.Count}");
            //_matrix = _matrixFactory.GetMatrixWithRandomCosts(Nodes);           
            //CostMatrix _cm = new(Nodes,_random);
            //MinimumSpanningTree MST = new(_graph);
           
            //int[,] tree = MST.GetMSTFromEdges(_graph.Edges.ToArray());

            //Edges = _graph.Edges.ToArray();
            Edges = _graph.MST();

            //foreach (var item in tree)
            //{
            //    if (_matrix.IsAdjacent(item))
            //        item.isVisible = true;
            //}

            InitializeComponent();
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            label1.Text = _graph.Edges.ToArray().EdgeArrayToString();
            label2.Text = Edges.ToArray().EdgeArrayToString();

            //Data.Add(new Point(20, 20));
            //Data.Add(new Point(30, 20));
            //Data.Add(new Point(20, 30));
            //Data.Clear();

            //Nodes = _cm.Nodes.ToList();

            //TestHungarian2 TH = new(_random);
            var TVC = new TestVertexCover();



            foreach (var item in Nodes)
            {
                Data.Add(item.Location);
                //Nodes.Add(item);
            }

            listBox1.Items.Clear();
            //listBox2.Items.Add(cm.DisplayCosts);
            //label1.Text = _matrix.CostToString(Nodes);
            //label2.Text = _matrix.AdjacencyToString(Nodes);
           // label3.Text = MST.LastQueue;
            listBox1.Items.AddRange(Nodes.Select(x => x.Name).ToArray());
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e)
        {



        }
      
        private Point Midpoint(Point A, Point B)
        {
            return new Point() { X = (A.X + B.X) / 2, Y = (A.Y + B.Y) / 2 };
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;
            //DrawGrid(g, pictureBox1, 66, 14);

            //Data.Select(e1 => e1.Map(dimGraph, dimDisplay))
            Data.Select(p => new Rectangle(p, new Size(10, 10)))
                .ToList()
                .ForEach(r => g.FillEllipse(redBrush, r))
                ;

            //_cm.Nodes
            //    .ToList()
            //    .ForEach(p => g.DrawString(p.Name, labelFont, redBrush, Point.Add(p.Location,new Size(-5,-5))));

            foreach (var item in Nodes)
            {
                g.DrawString(item.Name, labelFont, redBrush, Point.Add(item.Location,new Size(5,5)));
            }

            foreach (var item in Edges)
            {
                if (item.isVisible)
                {
                    var colourPen = new Pen(item.Colour);
                    var colourBrush = new SolidBrush(item.Colour);
                    var Start = Nodes[item.Start].Location;
                    var End = Nodes[item.End].Location;
                    var Mid = Midpoint(Start, End);
                    string label = Nodes[item.Start].Name + Nodes[item.End].Name + item.Distance.ToString();

                    g.DrawLine(colourPen, Nodes[item.Start].Location, Nodes[item.End].Location);
                    //g.DrawString("oo", labelFont, colourBrush, new Point(5, 5));
                    g.DrawString(label, labelFont, colourBrush, Point.Add(Mid, new Size(1, 1)));
                }

            }


            //var res = Data.LinearRegression()
            //                .Select(e1 => e1.Map(dimGraph, dimDisplay))
            //                .ToList();
            //g.DrawLine(redPen, res[0].X, res[0].Y, res[1].X, res[1].Y);
            //g.DrawLine(redPen, Data[0].X, Data[0].Y, Data[1].X, Data[1].Y);
            //g.DrawString("A")


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // PictureBox.MousePosition.X
            //Console.WriteLine("Clicked x:{0},y{1}", PictureBox.MousePosition.X, PictureBox.MousePosition.Y);
            Debug.Print("Clicked x:{0},y{1}", PictureBox.MousePosition.X, PictureBox.MousePosition.Y);
            //Console.WriteLine("obj:{0}", sender);


        }
        private void DrawGrid(Graphics g, PictureBox pb, int cols, int rows)
        {
            var gr = pb.CreateGraphics();
            var width = pb.Width;
            var height = pb.Height;
            var cellWidth = width / cols;
            var cellHeight = height / rows;

            for (int y = 0; y < height; y += cellHeight) g.DrawLine(redPen, 0, y, width, y);
            for (int x = 0; x < width; x += cellWidth) g.DrawLine(redPen, x, 0, x, height);
        }
    }
}