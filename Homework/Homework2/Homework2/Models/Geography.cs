using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework2.Models
{
    public class Geography
    {
        public int id  { get; set; }
        public string name { get; set; }
        public string level { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public Geography parent { get; set; }
        public Geography child { get; set; }

        public Geography ( int id, string name, string level, float longitude, float latitude, Geography parent, Geography child)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.longitude = longitude;
            this.latitude = latitude;
            this.parent = parent;
            this.child = child;
        }

        public string toString()
        {
            return this.name;
        }

        public string getHierarchy()
        {
            return this.name + this.parent.getHierarchy();
        }
    }
}