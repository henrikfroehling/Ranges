﻿namespace RangeIt.Iterators
{
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public static class IteratorExtensions
    {
        public static Iterator Begin(this ArrayList arrayList) => new Iterator(arrayList);

        public static Iterator End(this ArrayList arrayList) => new Iterator(arrayList);

        public static Iterator Begin(this Queue queue) => new Iterator(queue);

        public static Iterator End(this Queue queue) => new Iterator(queue);

        public static Iterator Begin(this Stack stack) => new Iterator(stack);

        public static Iterator End(this Stack stack) => new Iterator(stack);

        public static Iterator Begin(this SortedList sortedList) => new Iterator(sortedList);

        public static Iterator End(this SortedList sortedList) => new Iterator(sortedList);

        public static Iterator<T> Begin<T>(this T[] items) => new Iterator<T>(items);

        public static Iterator<T> End<T>(this T[] items) => new Iterator<T>(items, true);

        public static Iterator<T> Begin<T>(this List<T> list) => new Iterator<T>(list);

        public static Iterator<T> End<T>(this List<T> list) => new Iterator<T>(list, true);

        public static Iterator<T> Begin<T>(this Collection<T> collection) => new Iterator<T>(collection);

        public static Iterator<T> End<T>(this Collection<T> collection) => new Iterator<T>(collection, true);

        public static Iterator<T> Begin<T>(this ConcurrentQueue<T> queue) => new Iterator<T>(queue);

        public static Iterator<T> End<T>(this ConcurrentQueue<T> queue) => new Iterator<T>(queue, true);

        public static Iterator<T> Begin<T>(this ConcurrentStack<T> stack) => new Iterator<T>(stack);

        public static Iterator<T> End<T>(this ConcurrentStack<T> stack) => new Iterator<T>(stack, true);

        public static Iterator<T> Begin<T>(this ConcurrentBag<T> bag) => new Iterator<T>(bag);

        public static Iterator<T> End<T>(this ConcurrentBag<T> bag) => new Iterator<T>(bag, true);

        public static Iterator<T, U> Begin<T, U>(this KeyValuePair<T, U>[] items) => new Iterator<T, U>(items);

        public static Iterator<T, U> End<T, U>(this KeyValuePair<T, U>[] items) => new Iterator<T, U>(items);

        public static Iterator<T, U> Begin<T, U>(this Dictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        public static Iterator<T, U> End<T, U>(this Dictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        public static Iterator<T, U> Begin<T, U>(this ConcurrentDictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        public static Iterator<T, U> End<T, U>(this ConcurrentDictionary<T, U> dictionary) => new Iterator<T, U>(dictionary);

        public static ConstIterator ConstBegin(this ArrayList arrayList) => new ConstIterator(arrayList);

        public static ConstIterator ConstEnd(this ArrayList arrayList) => new ConstIterator(arrayList);

        public static ConstIterator ConstBegin(this Queue queue) => new ConstIterator(queue);

        public static ConstIterator ConstEnd(this Queue queue) => new ConstIterator(queue);

        public static ConstIterator ConstBegin(this Stack stack) => new ConstIterator(stack);

        public static ConstIterator ConstEnd(this Stack stack) => new ConstIterator(stack);

        public static ConstIterator ConstBegin(this SortedList sortedList) => new ConstIterator(sortedList);

        public static ConstIterator ConstEnd(this SortedList sortedList) => new ConstIterator(sortedList);

        public static ConstIterator<T> ConstBegin<T>(this T[] items) => new ConstIterator<T>(items);

        public static ConstIterator<T> ConstEnd<T>(this T[] items) => new ConstIterator<T>(items);

        public static ConstIterator<T> ConstBegin<T>(this List<T> list) => new ConstIterator<T>(list);

        public static ConstIterator<T> ConstEnd<T>(this List<T> list) => new ConstIterator<T>(list);

        public static ConstIterator<T> ConstBegin<T>(this Collection<T> collection) => new ConstIterator<T>(collection);

        public static ConstIterator<T> ConstEnd<T>(this Collection<T> collection) => new ConstIterator<T>(collection);

        public static ConstIterator<T> ConstBegin<T>(this ReadOnlyCollection<T> collection) => new ConstIterator<T>(collection);

        public static ConstIterator<T> ConstEnd<T>(this ReadOnlyCollection<T> collection) => new ConstIterator<T>(collection);

        public static ConstIterator<T> ConstBegin<T>(this ConcurrentQueue<T> queue) => new ConstIterator<T>(queue);

        public static ConstIterator<T> ConstEnd<T>(this ConcurrentQueue<T> queue) => new ConstIterator<T>(queue);

        public static ConstIterator<T> ConstBegin<T>(this ConcurrentStack<T> stack) => new ConstIterator<T>(stack);

        public static ConstIterator<T> ConstEnd<T>(this ConcurrentStack<T> stack) => new ConstIterator<T>(stack);

        public static ConstIterator<T> ConstBegin<T>(this ConcurrentBag<T> bag) => new ConstIterator<T>(bag);

        public static ConstIterator<T> ConstEnd<T>(this ConcurrentBag<T> bag) => new ConstIterator<T>(bag);

        public static ConstIterator<T, U> ConstBegin<T, U>(this KeyValuePair<T, U>[] items) => new ConstIterator<T, U>(items);

        public static ConstIterator<T, U> ConstEnd<T, U>(this KeyValuePair<T, U>[] items) => new ConstIterator<T, U>(items);

        public static ConstIterator<T, U> ConstBegin<T, U>(this Dictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstEnd<T, U>(this Dictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstBegin<T, U>(this ReadOnlyDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstEnd<T, U>(this ReadOnlyDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstBegin<T, U>(this ConcurrentDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);

        public static ConstIterator<T, U> ConstEnd<T, U>(this ConcurrentDictionary<T, U> dictionary) => new ConstIterator<T, U>(dictionary);
    }
}
