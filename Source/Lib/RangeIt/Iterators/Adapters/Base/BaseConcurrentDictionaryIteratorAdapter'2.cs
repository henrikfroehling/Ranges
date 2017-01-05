﻿namespace RangeIt.Iterators.Adapters.Base
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    internal abstract class BaseConcurrentDictionaryIteratorAdapter<T, U> : IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        protected ConcurrentDictionary<T, U> _dictionary;
        protected KeyValuePair<T, U> _current;
        protected int _index;
        protected bool _isEnd;

        internal BaseConcurrentDictionaryIteratorAdapter(ConcurrentDictionary<T, U> dictionary, bool isEnd = false)
        {
            if (dictionary == null)
                throw new ArgumentNullException(nameof(dictionary));

            _dictionary = dictionary;
            _current = default(KeyValuePair<T, U>);
            _isEnd = isEnd;
            _index = -1;
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid => !IsEndIterator && Index >= 0 && Index < _dictionary.Count;

        public bool Previous()
        {
            var count = _dictionary.Count;

            if (count == 0)
                return false;

            if (_index == 0)
            {
                _isEnd = false;
                _index = -1;
                _current = default(KeyValuePair<T, U>);
                return false;
            }

            if (_isEnd)
                _index = count;

            if (_index >= 1)
            {
                _isEnd = false;
                --_index;
                _current = _dictionary.ElementAt(_index);
                return true;
            }

            return false;
        }

        public bool Next()
        {
            var count = _dictionary.Count;

            if (_isEnd || count == 0)
                return false;

            if (_index == count - 1)
            {
                _index = count;
                _isEnd = true;
                _current = default(KeyValuePair<T, U>);
                return false;
            }

            if (_index < count - 1)
            {
                _index++;
                _current = _dictionary.ElementAt(_index);
                return true;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _dictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}