using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// TODO: Figure out a function  that is able to draw any pixel in a canvas
        /// TODO: Learn about Pen, Brush, 
        /// </summary>
        public Form1()
        {
            InitializeComponent();



            
            // Default panel size
            this.Width = 1065;
            this.Height = 618;

            m_bitmap = new Bitmap(m_pb.Width, m_pb.Height);
            g_graphics = Graphics.FromImage(m_bitmap);
            g_graphics.Clear(Color.White);
            m_pb.Image = m_bitmap;
        }

        /// <summary>
        /// We can use to set the bitmap size to a very small file size suitable for the pixel art 
        /// 
        /// TODO: Implement tools using Enums 
        /// 
        /// </summary>

        Bitmap m_bitmap;
        Graphics g_graphics;
        bool paint_a = false;
        Point px, py;
        Pen npen = new Pen(Color.Black,20);
        

        // represents an intiger value for the selected tool
        int current_tool_selected;

        private void m_pb_Click(object sender, EventArgs e)
        {
            // Must be null here
        }

        #region Mouse events

        /// <summary>
        /// Note: "e" is an event argument for mouse pointer
        /// </summary>

        private void m_pb_MouseDown(object sender, MouseEventArgs e)
        {
            paint_a = true;
            py = e.Location;

        }
        private void m_pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint_a)
            {
                if (current_tool_selected == 1)
                {
                    px = e.Location;
                    g_graphics.DrawLine(npen, px,py);
                    py = px;
                }
            }
            m_pb.Refresh();
        }
        private void m_pb_MouseUp(object sender, MouseEventArgs e)
        {
            paint_a = false;
        }
        #endregion



        #region Button  Controls
        private void Paint_btn_Click(object sender, EventArgs e)
        {
            current_tool_selected = 1;
        }
        #endregion





    }
}
