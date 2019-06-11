using System;

namespace BoostrapQualityClassifier
{
    class Utils{
        public int[] GetRandomArray(int minValue, int maxValue, int arraySize){
            Random randomGenerator = new Random();
            int[] randomValuesArray = new int[arraySize];

            for(int i = 0; i < arraySize; i++){
                int randomValue = randomGenerator.Next(minValue, maxValue);
                randomValuesArray[i] = randomValue;
            }
            return randomValuesArray;
        }
    }
}