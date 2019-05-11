using System;
using myMLApp.Model.DataModels;
using Microsoft.ML;

namespace myMLApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsumeModel();
        }

        public static void ConsumeModel()
        {
            MLContext mlContext = new MLContext();

            ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);
        }
    }
}