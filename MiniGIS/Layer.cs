﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGIS
{
    public class Layer
    {
        public List<MapObject> MapObjects { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public Map Map { get; set; }
        public GEORect GEOBounds { get; set; }

        public Layer()
        {
            Name = "";
            Visible = true;
            MapObjects = new List<MapObject>();
            GEOBounds = new GEORect(0.0, 0.0, 0.0, 0.0);
        }

        public void AddMapObject(MapObject mapObject)
        {
            mapObject.Layer = this;
            MapObjects.Add(mapObject);
            GEOBounds = GEORect.Union(GEOBounds, mapObject.GEOBounds);
        }

        public void InsertMapObject(int index, MapObject mapObject)
        {
            MapObjects.Insert(index, mapObject);
        }

        public void RemoveMapObject(MapObject mapObject)
        {
            MapObjects.Remove(mapObject);
        }

        public int CountMapObjects()
        {
            return MapObjects.Count;
        }

        public void Draw(PaintEventArgs e)
        {
            foreach(var mapObject in MapObjects)
            {
                mapObject.Draw(e);
            }
        }

        public void Clear()
        {
            MapObjects.Clear();
        }

        private MapObject FindObject(GEORect searchRect)
        {
            for(int i = CountMapObjects() - 1; i > 0; --i)
            {
                if(MapObjects[i].IsInside(searchRect))
                {
                    return MapObjects[i];
                }
            }
            return null;
        }
    }
}