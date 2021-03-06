﻿namespace Iterator.Performance.Tests
{
    using BenchmarkDotNet.Running;
    using Const;
    using NotConst;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Array<T>
            BenchmarkRunner.Run<Array_1_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<Array_1_ConstIterator_Vs_Enumerator_Tests>();

            // List<T>
            BenchmarkRunner.Run<List_1_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<List_1_ConstIterator_Vs_Enumerator_Tests>();

            // Collection<T>
            BenchmarkRunner.Run<Collection_1_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<Collection_1_ConstIterator_Vs_Enumerator_Tests>();

            // ReadOnlyCollection<T>
            BenchmarkRunner.Run<ReadOnlyCollection_1_ConstIterator_Vs_Enumerator_Tests>();

            // Array<KeyValuePair<T, U>>
            BenchmarkRunner.Run<Array_2_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<Array_2_ConstIterator_Vs_Enumerator_Tests>();

            // Dictionary<T, U>>
            BenchmarkRunner.Run<Dictionary_2_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<Dictionary_2_ConstIterator_Vs_Enumerator_Tests>();

            // ConcurrentDictionary<T, U>>
            BenchmarkRunner.Run<ConcurrentDictionary_2_Iterator_Vs_Enumerator_Tests>();
            BenchmarkRunner.Run<ConcurrentDictionary_2_ConstIterator_Vs_Enumerator_Tests>();

            // ReadOnlyDictionary<T, U>>
            BenchmarkRunner.Run<ReadOnlyDictionary_2_ConstIterator_Vs_Enumerator_Tests>();
        }
    }
}
