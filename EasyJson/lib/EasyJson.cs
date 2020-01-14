using System;

namespace ManageJson.lib
{
    public class EasyJson
    {
        private int _index;
        private string _cadena;

        public JsonObj ParseToJsonObj(string json)
        {
            
            JsonObj jsonObj = new JsonObj();
            _cadena = json.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
            Console.WriteLine("Inicial: " + _cadena.Length);
            Console.WriteLine(json);

            _index = 0;            
            var character = json[_index];           
            createObj(jsonObj);
            
            Console.WriteLine("Cantidad: "+jsonObj.count());
            Console.WriteLine("Index: " + _cadena[_index].ToString());
            return jsonObj;
        }

        private JsonObj createObj(JsonObj json)
        {
            string val = _cadena[_index].ToString();
            if (_cadena[_index].CompareTo('{') == 0)
            {
                _index++;
                breakEmpty();
                json.AddProperty(createNode());

                while (_cadena[_index].CompareTo(',') == 0)
                {
                    _index++;
                    json.AddProperty(createNode());
                }

                breakEmpty();
                val = _cadena[_index-1].ToString();
                if (_cadena[_index].CompareTo('}') == 0)
                {
                    Console.WriteLine("Cantidad Fin: " + json.count());
                    return json;
                }
                else
                {
                    Console.WriteLine("Hay mal formacion del Json");
                    return null;
                }
                
            }
            else
            {
                Console.WriteLine("Hay mal formacion del Json");
                return null;
            }

            
        }

        private JsonNode createNode()
        {            
            JsonNode node = new JsonNode();

            breakEmpty();

            if (_cadena[_index].CompareTo('"') == 0)
            {
                node.setKey(createString());
            }

            breakEmpty();

            if (_cadena[_index].CompareTo(':') == 0)
            {
                _index++;
                breakEmpty();

                if (_cadena[_index].CompareTo('"') == 0)
                {                    
                    node.setVal(createString());
                }
                else if (_cadena[_index].CompareTo('{') == 0)
                {
                    JsonObj jsonChild = new JsonObj();
                    node.setVal(createObj(jsonChild));                   
                }
            }
            else
            {
                Console.WriteLine("Se ha encontrado un caracter extraño: " + _cadena[_index]);
            }

            _index++;
            breakEmpty();            
            Console.WriteLine("Nodo: "+_cadena[_index]);
            return node;
        }

        private string createString()
        {
            var keyName = "";
            _index++;

            while (_cadena[_index].CompareTo('"')!=0)
            {
                keyName += _cadena[_index].ToString();
                _index++;
            }
                        
            _index++;
            breakEmpty();
           
            Console.WriteLine("Cadena String: " + keyName);
            return keyName;
        }

        private void breakEmpty()
        {
            string val = _cadena[_index].ToString();
            while (_cadena[_index].CompareTo(' ') == 0)
            {                
                _index++;
                if (_cadena.Length <= _index)
                {
                    _index--;
                    break;
                }
            }
        }
    }
}
