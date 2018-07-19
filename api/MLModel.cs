using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Models;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace api
{
    public class MLModel
    {
        private PredictionModel<MinstDigit, MinstPrediction> _model;
        public MLModel()
        {
            var pipeline = new LearningPipeline();
            string dataPath = "./train.csv";
            pipeline.Add(new TextLoader(dataPath).CreateFrom<MinstDigit>(separator: ',', useHeader: true));
            pipeline.Add(new ColumnConcatenator("Features", MinstDigit.GetColumnNames()));
            pipeline.Add(new StochasticDualCoordinateAscentClassifier());
            _model = pipeline.Train<MinstDigit, MinstPrediction>();

            
        }

        private void Evaluate()
        {
            var loader = new TextLoader("./mnist_test.csv").CreateFrom<MinstDigit>(separator: ',', useHeader: true);
            var evaluator = new ClassificationEvaluator();
            var evaluation = evaluator.Evaluate(_model, loader);
        }

        public MinstPrediction Predict(MinstDigit digit)
        {
            return _model.Predict(digit);
        }
    }
}
