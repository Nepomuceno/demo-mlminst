using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Models;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace api
{
    public class MLModel
    {
        private PredictionModel<MinstDigit, MinstPrediction> _model;
        public MLModel()
        {
            var pipeline = new LearningPipeline();

            string dataPath = "./mnist_train.csv";

            pipeline.Add(new TextLoader(dataPath).CreateFrom<MinstDigit>(separator: ',', useHeader: true));

            pipeline.Add(new ColumnConcatenator("Features", MinstDigit.GetColumnNames()));

            pipeline.Add(new StochasticDualCoordinateAscentClassifier());


            _model = pipeline.Train<MinstDigit, MinstPrediction>();

            

            this.Evaluate();
            //this.Export();

        }

        private void Evaluate()
        {
            var loader = new TextLoader("./mnist_test.csv").CreateFrom<MinstDigit>(separator: ',', useHeader: true);
            var evaluator = new ClassificationEvaluator();
            var evaluation = evaluator.Evaluate(_model, loader);
            Console.WriteLine(JsonConvert.SerializeObject(evaluation,Formatting.Indented));
        }

        public MinstPrediction Predict(MinstDigit digit)
        {
            return _model.Predict(digit);
        }

        private void Export()
        {
            var onnxPath = "./SaveModelToOnnxTest.onnx";
            var onnxAsJsonPath = "./SaveModelToOnnxTest.json";

            OnnxConverter converter = new OnnxConverter()
            {
                InputsToDrop = new[] { "Label" },
                OutputsToDrop = new[] { "Label", "Features" },
                Onnx = onnxPath,
                Json = onnxAsJsonPath,
                Domain = "com.mydomain"
            };

            converter.Convert(_model);

            // Strip the version.
            var fileText = File.ReadAllText(onnxAsJsonPath);
            fileText = Regex.Replace(fileText, "\"producerVersion\": \"([^\"]+)\"", "\"producerVersion\": \"##VERSION##\"");
            File.WriteAllText(onnxAsJsonPath, fileText);
        }
    }
}
