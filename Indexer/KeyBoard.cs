using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class KeyBoard
    {
        private List<Key> keys { get; set; }
        public Key this[int code]
        {
            get
            {
             return keys.Where(x => x.KeyCode == code).FirstOrDefault();
            }
            set
            {
                var KeyIndex = keys.FindIndex(x => x.KeyCode == code);
                keys[KeyIndex] = value;
            }
        }
        public Key this[char symbol]
        {
            get
            {
                return keys.Where(x => x.KeySymbol == symbol).FirstOrDefault();
            }
            set
            {
                var KeyIndex = keys.FindIndex(x => x.KeySymbol == symbol);
                keys[KeyIndex] = value;
            }
        }
    }
}
