
using ISFinalProjectPlantDetective.Models;
using System.Runtime.Intrinsics.X86;
using Tensorflow.Keras.Engine;

namespace ISFinalProjectPlantDetective
{
    public class MachineLearningService
    {
        public InformationModel PredictImageLabel(byte[] imageBytes)
        { 
            MLModel.ModelInput sampleData = new MLModel.ModelInput()
            {
                ImageSource = imageBytes,
            };
            var result = MLModel.Predict(sampleData);
            var res = result.PredictedLabel;
            Console.WriteLine(res);
            Console.WriteLine(res);
            ListOfInformation list = new ListOfInformation();
            var info = list.GetInformationByName(res);
            return info;
        }
    }
}
