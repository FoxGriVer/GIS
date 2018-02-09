using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGIS
{
    public enum MapToolType
    {
        selectBtn,
        panBtn,
        zoominBtn,
        zoomoutBtn

    }
    
    public partial class Map : UserControl
    {

        public MapToolType mapToolType;
        public List<Layer> Layers;
    
        public double MapScale { get; set; }
        public GEOPoint MapCenter { get; set; }

        public const int shake = 5;

        public Map()
        {
            InitializeComponent();
            MapScale = 1.0;
            MapCenter = new GEOPoint();
            Layers = new List<Layer>();
            mapToolType = MapToolType.panBtn;
        }       

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            foreach(var layer in Layers)
            {
                if(layer.Visible)
                {
                    layer.Draw(e);
                }
            }
        }

        public System.Drawing.Point MapToScreen(GEOPoint mapPoint)
        {
            var screenPoint = new System.Drawing.Point();
            screenPoint.X = (int)((mapPoint.X + MapCenter.X) * MapScale + this.Width / 2 + 0.5);
            screenPoint.Y = (int)(-(mapPoint.Y + MapCenter.Y) * MapScale + this.Height / 2 + 0.5);
            return screenPoint;
        }

       public GEOPoint ScreenToMap(System.Drawing.Point screenPoint)
       {
            var mapPoint = new GEOPoint();
            mapPoint.X = (screenPoint.X - this.Width / 2) / MapScale - MapCenter.X;
            mapPoint.Y = -(screenPoint.Y - this.Height / 2) / MapScale - MapCenter.Y;
            return mapPoint;
       }

       public void AddLayer(Layer layer)
       {
            layer.Map = this;
            Layers.Add(layer);
        }

       public void InsertLayer(int index, Layer layer)
       {
            Layers.Insert(index, layer);
       }

       public void RemoveLayer(Layer layer)
       {
            Layers.Remove(layer);
       }

       public int CountLayers()
       {
            return Layers.Count;
       }


        public bool isMouseDown = false;
        public System.Drawing.Point MouseDownPosition;
        private System.Drawing.Point point1;
        private System.Drawing.Point point2;

        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            switch(mapToolType)
            {
                case MapToolType.panBtn:
                    {
                        isMouseDown = true;
                        MouseDownPosition = e.Location;
                        break;
                    }
                case MapToolType.selectBtn: break;

                case MapToolType.zoominBtn:
                    {            
                        isMouseDown = true;
                        point1 = e.Location;

                        Refresh();
                        break;
                    }
                case MapToolType.zoomoutBtn:
                    {
                        GEOPoint zoomGeoPoint = ScreenToMap(e.Location);
                        MapCenter.X = -zoomGeoPoint.X;
                        MapCenter.Y = -zoomGeoPoint.Y;
                        MapScale *= 0.8 ;
                        Refresh();
                        break;
                    }
            }
        }

        private void Map_MouseMove(object sender, MouseEventArgs e) 
        {
            double dx;
            double dy;
            switch (mapToolType)
            {
                case MapToolType.panBtn:
                    {
                        if (isMouseDown == true)
                        {
                            dx = MouseDownPosition.X - e.Location.X;
                            dy = MouseDownPosition.Y - e.Location.Y;
                            MapCenter.X = MapCenter.X - dx/MapScale; 
                            MapCenter.Y = MapCenter.Y + dy/MapScale;
                           
                            Refresh();
                            MouseDownPosition = e.Location;
                        }
                        break;                    
                    }
                case MapToolType.selectBtn:
                    {
                        
                        
                        break;
                    }
                case MapToolType.zoominBtn:
                    {
                        if(isMouseDown == true)
                        {
                            Graphics g = this.CreateGraphics();
                            Pen blackPen = new Pen(Color.Black, 1);

                            point2 = e.Location;
                            Refresh();

                           
                            if (point1.X > point2.X && point1.Y > point2.Y)
                            {

                                g.DrawRectangle(blackPen, new Rectangle(point2.X,  point2.Y, point1.X - point2.X, point1.Y - point2.Y));
                            }
                            else if (point1.Y > point2.Y && point1.X < point2.X)
                            {

                                g.DrawRectangle(blackPen, new Rectangle(point1.X, point2.Y, Math.Abs(point2.X - point1.X), Math.Abs(point2.Y - point1.Y)));
                            }
                            else if (point1.X > point2.X && point1.Y < point2.Y)
                            {
                                g.DrawRectangle(blackPen, new Rectangle(point2.X, point1.Y, Math.Abs(point2.X - point1.X), Math.Abs(point2.Y - point1.Y)));
                            }
                            else g.DrawRectangle(blackPen, new Rectangle(point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y));
                        }
                        break;
                    }
                case MapToolType.zoomoutBtn: break;
            }
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            
            switch (mapToolType)
            {
                case MapToolType.panBtn:
                    {
                        isMouseDown = false;
                        break;
                    }
                case MapToolType.selectBtn: break;
                case MapToolType.zoominBtn:
                    {
                        GEOPoint zoomGeoPoint = ScreenToMap(e.Location);
                        MapCenter.X = -zoomGeoPoint.X;
                        MapCenter.Y = -zoomGeoPoint.Y;
                        MapScale *= 1.2;

                        isMouseDown = false;
                        Refresh();
                        //toDo photo
                        break;
                    }
                case MapToolType.zoomoutBtn: break;
            }
        }
    }
}
 