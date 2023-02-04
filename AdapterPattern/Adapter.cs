using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        public Adaptee _adaptee { get; set; }

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetTargetRequest()
        {
            return $"This is '{this._adaptee.GetAdapteeRequest()}'";
        }
    }
}
