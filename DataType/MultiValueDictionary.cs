using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataType
{
    public interface IMultiValueDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        void Add(TKey key, TValue value);

        bool Remove(TKey key, TValue value);

        bool Clear(TKey key);
    }

    public class MultiValueDictionary<TKey, TValue> : IMultiValueDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, List<TValue>> _multiValueDictionary = new Dictionary<TKey, List<TValue>>();

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _multiValueDictionary.SelectMany(m => m.Value.Select(v => new KeyValuePair<TKey, TValue>( m.Key, v))).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(TKey key, TValue value)
        {
            if (_multiValueDictionary.ContainsKey(key))
            {
                _multiValueDictionary[key].Add(value);
            }
            else
            {
                _multiValueDictionary.Add(key, new List<TValue> {value});
            }
        }

        public bool Remove(TKey key, TValue value)
        {
            if (_multiValueDictionary.ContainsKey(key))
            {
                try
                {
                    var match = _multiValueDictionary[key].First(v => v == null);

                    _multiValueDictionary[key].Remove(match);

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public bool Clear(TKey key)
        {
            if (_multiValueDictionary.ContainsKey(key))
            {
                _multiValueDictionary.Remove(key);
            }

            return false;
        }
    }
}
