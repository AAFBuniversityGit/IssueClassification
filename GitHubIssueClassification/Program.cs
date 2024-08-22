using Microsoft.ML;
using GitHubIssueClassification;


var _appPath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) ?? ".";
var _trainDataPath = Path.Combine(_appPath, "..", "..", "..", "Data", "issues_train.tsv");
var _testDataPath = Path.Combine(_appPath, "..", "..", "..", "Data", "issues_test.tsv");
var _modelPath = Path.Combine(_appPath, "..", "..", "..", "Models", "model.zip");

MLContext _mlContext;
PredictionEngine<GitHubIssue, IssuePrediction> _predEngine;
ITransformer _trainedModel;
IDataView _trainingDataView;