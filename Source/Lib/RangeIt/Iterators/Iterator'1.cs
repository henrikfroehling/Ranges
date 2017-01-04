﻿namespace RangeIt.Iterators
{
    using Detail.NotConst;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct Iterator<T> : IIterator<T>
    {
        private IIterator<T> _iteratorHelper;

        public Iterator(T[] items)
        {
            _iteratorHelper = new ArrayIterator<T>(items);
        }

        internal Iterator(T[] items, bool isEnd)
        {
            _iteratorHelper = new ArrayIterator<T>(items, isEnd);
        }

        public Iterator(List<T> list)
        {
            _iteratorHelper = new ListIterator<T>(list);
        }

        internal Iterator(List<T> list, bool isEnd)
        {
            _iteratorHelper = new ListIterator<T>(list, isEnd);
        }

        public Iterator(Collection<T> collection)
        {
            _iteratorHelper = new CollectionIterator<T>(collection);
        }

        internal Iterator(Collection<T> collection, bool isEnd)
        {
            _iteratorHelper = new CollectionIterator<T>(collection, isEnd);
        }

        public Iterator(ConcurrentStack<T> stack)
        {
            _iteratorHelper = new ConcurrentStackIterator<T>(stack);
        }

        internal Iterator(ConcurrentStack<T> stack, bool isEnd)
        {
            _iteratorHelper = new ConcurrentStackIterator<T>(stack, isEnd);
        }

        public Iterator(ConcurrentBag<T> bag)
        {
            _iteratorHelper = new ConcurrentBagIterator<T>(bag);
        }

        internal Iterator(ConcurrentBag<T> bag, bool isEnd)
        {
            _iteratorHelper = new ConcurrentBagIterator<T>(bag, isEnd);
        }

        public T Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool IsValid => _iteratorHelper.IsValid;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() => Current?.ToString();

        public static Iterator<T> operator --(Iterator<T> it)
        {
            it.Previous();
            return it;
        }

        public static Iterator<T> operator ++(Iterator<T> it)
        {
            it.Next();
            return it;
        }

        public static implicit operator bool(Iterator<T> it) => it.IsValid;

        public static explicit operator T(Iterator<T> it) => it.Current;
    }
}
