using System;
using System.Collections.Generic;
using System.Linq;

namespace BoostrapQualityClassifier{
    class Bootstrapper
    {
        internal (int[] trainingSet, int []testSet) GetBootstrappedValues(int[] randomValuesArray)
        {

            int arraySize = randomValuesArray.Length;


            var trainingSetCollection = GetRandomIndexesSet(arraySize);

            var testSetCollection = GetTestSet(randomValuesArray, trainingSetCollection);

            var trainingSet = ToRandomizedArray(trainingSetCollection);
            var testSet = ToRandomizedArray(testSetCollection);

            return (trainingSet, testSet);
        }

        private static int[] ToRandomizedArray(IEnumerable<int> collectionToRandomize)
        {
            return collectionToRandomize.OrderBy(x => Guid.NewGuid()).ToArray();
        }

        private static IEnumerable<int> GetTestSet(int[] randomValuesArray, IEnumerable<int> trainingSet)
        {
            return randomValuesArray.Intersect(trainingSet);
        }

        private IEnumerable<int> GetRandomIndexesSet(int arraySize)
        {
            Random randomGenerator = new Random();
            HashSet<int> randomIndexSet = new HashSet<int>();
            for (int i = 0; i < arraySize; i++)
            {
                int randomIndexValue = randomGenerator.Next(0, arraySize);
                randomIndexSet.Add(randomIndexValue);
            }
            return randomIndexSet;
        }
    }
}