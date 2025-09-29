using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld.Apps
{
    [App(icon: Icons.Box)]
    public class HelloWorldPage : ViewBase
    {
        public override object? Build()
        {
            return "HelloWorld";
        }
    }
}
