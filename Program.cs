using System;

namespace BoostrapQualityClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils utils = new Utils();
            var randomValuesArray = utils.GetRandomArray(0, 255, 100);
            Console.WriteLine($"Array to bootstrap {string.Join(",", randomValuesArray)}");

            Bootstrapper bootstrapper = new Bootstrapper();
            var (trainingSet, testSet) = bootstrapper.GetBootstrappedValues(randomValuesArray);

            Console.WriteLine($"Training set {string.Join(",", trainingSet)}");
            Console.WriteLine($"Test set {string.Join(",", testSet)}");

            Console.WriteLine($"Training set size: {trainingSet.Length}");
            Console.WriteLine($"Test set size: {testSet.Length}");
        }
     
    }
    
}
