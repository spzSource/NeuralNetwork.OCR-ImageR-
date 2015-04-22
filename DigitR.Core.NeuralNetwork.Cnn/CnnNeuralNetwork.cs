﻿using System;
using System.Collections.Generic;

using DigitR.Core.InputProvider;
using DigitR.Core.NeuralNetwork.Algorithms;
using DigitR.Core.NeuralNetwork.Behaviours;
using DigitR.Core.NeuralNetwork.Cnn.Primitives;
using DigitR.Core.NeuralNetwork.Primitives;

namespace DigitR.Core.NeuralNetwork.Cnn
{
    public class CnnNeuralNetwork : IMultiLayerNeuralNetwork<byte[], byte>, ITrainable<byte, byte[]>
    {
        private readonly IOutputAlgorithm<double, CnnConnection> outputAlgorithm;
        private readonly IActivationAlgorithm<double, double> activationAlgorithm;
        private readonly ITrainingAlgorithm<IMultiLayerNeuralNetwork<byte[], byte>, IInputTrainingPattern<byte, byte[]>> trainingAlgorithm;

        public CnnNeuralNetwork(
            IOutputAlgorithm<double, CnnConnection> outputAlgorithm, 
            IActivationAlgorithm<double, double> activationAlgorithm,
            ITrainingAlgorithm<IMultiLayerNeuralNetwork<byte[], byte>, IInputTrainingPattern<byte, byte[]>> trainingAlgorithm)
        {
            if (outputAlgorithm == null)
            {
                throw new ArgumentNullException("outputAlgorithm");
            }
            if (activationAlgorithm == null)
            {
                throw new ArgumentNullException("activationAlgorithm");
            }
            if (trainingAlgorithm == null)
            {
                throw new ArgumentNullException("trainingAlgorithm");
            }
            this.outputAlgorithm = outputAlgorithm;
            this.activationAlgorithm = activationAlgorithm;
            this.trainingAlgorithm = trainingAlgorithm;
        }

        /// <summary>
        /// All layers.
        /// </summary>
        public ILayer<object>[] Layers
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Provides a determination logic according to input pattern 
        /// and current state of this instance of neuran network.
        /// </summary>
        /// <param name="inputPattern">The input pattern for determine.</param>
        /// <returns>The result successful flag.</returns>
        public byte Process(IInputPattern<byte[]> inputPattern)
        {
            throw new NotImplementedException();
        }

        public void ProcessTraining(IEnumerable<IInputTrainingPattern<byte, byte[]>> patterns)
        {
            trainingAlgorithm.ProcessTraining(this, patterns);
        }
    }
}
