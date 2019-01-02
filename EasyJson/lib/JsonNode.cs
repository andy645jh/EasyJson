using System;
using System.Collections.Generic;

namespace ManageJson.lib
{
    public class JsonNode
    {
        private string _key;
        private JsonObj _val;
        private string _valString;     

        public JsonNode()
        {
            
        }

        public void setKey(string k)
        {
            _key = k;
        }

        public void setVal(string v)
        {
            _valString = v;
        }

        public void setVal(JsonObj v)
        {
            _val = v;
        }

        public string getKey()
        {
            return _key;
        }               

        /*public override string ToString()
        {
            if(_key == null)
            {
                if (_val.GetType() == typeof(string))
                {
                    return '"' + _val.ToString() +'"';
                }
                else if (_val.GetType() == typeof(int) || _val.GetType() == typeof(float))
                {
                    return _val.ToString();
                }else if(_val.GetType() == typeof(bool))
                {
                    return _val.ToString();
                }
                else
                {
                    return _val.ToString();
                }
            }
            else
            {
                return '"' + _key + '"' + ":" + _val.ToString();
            }
            
        }*/
    }
}