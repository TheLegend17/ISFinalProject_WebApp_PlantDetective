using DocumentFormat.OpenXml.Vml;
using ISFinalProjectPlantDetective.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using System.Drawing;
using System.Net;


namespace ISFinalProjectPlantDetective.Controllers
{
    public class DisplayInformationController : Controller
    {
        public IActionResult Index(string imageBytes)
        {
            MachineLearningService machineLearningService = new MachineLearningService();
            var model = new InformationModel();
            byte[] byteArray = ConvertStringToByteArray(imageBytes);
            var res = machineLearningService.PredictImageLabel(byteArray);
            model = res;
                
            /*string outputFilePath = "path/to/output/image.png"; // Output file path for the converted image
            try
            {
                // Create a MemoryStream from the byte array
                using (MemoryStream memoryStream = new MemoryStream(byteArray))
                {
                    // Convert the byte array to an Image object
                    ImageConverter imageConverter = new ImageConverter();
                    System.Drawing.Image image = (Image)imageConverter.ConvertFrom(ImageData);

                    // Save the image to the output file
                    image.Save(outputFilePath);
                }

                Console.WriteLine("Image conversion completed successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/

            return View(model);
        }

        private byte[] ConvertStringToByteArray(string input)
        {
            // Convert the string to byte array
            string[] byteValues = input.Split(',');
            byte[] byteArray = new byte[byteValues.Length];

            for (int i = 0; i < byteValues.Length; i++)
            {
                byteArray[i] = Convert.ToByte(byteValues[i]);
            }

            return byteArray;
        }
    }
}
