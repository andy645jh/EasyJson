using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageJson.lib
{
    public class JsonObj
    {
        private List<JsonNode> _list;

        public JsonObj()
        {
            _list = new List<JsonNode>();
        }

        public void AddProperty(JsonNode p)
        {
            _list.Add(p);
        }

        public int count()
        {
            return _list.Count;
        }
    }
}
