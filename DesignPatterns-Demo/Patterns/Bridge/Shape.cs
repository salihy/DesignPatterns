using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Bridge
{
    public abstract class Shape
    {
        protected ColorApi graphicsApi;

        protected Shape(ColorApi graphicsApi) { 
            this.graphicsApi = graphicsApi;
        }

        public abstract Task draw();
    }
}
