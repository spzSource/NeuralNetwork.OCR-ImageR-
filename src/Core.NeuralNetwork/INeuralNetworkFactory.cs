﻿using System.Collections.Generic;

using DigitR.Core.NeuralNetwork.Primitives;

namespace DigitR.Core.NeuralNetwork
{
    /// <summary>
    /// Provides a specific neural network building.
    /// </summary>
    public interface INeuralNetworkFactory<TData>
    {
        /// <summary>
        /// Performs building specific neural network instance.
        /// </summary>
        /// <returns>The instance of specific neural network.</returns>
        INeuralNetwork<TData[]> Create(IReadOnlyCollection<ILayer<INeuron<TData>>> layers);
    }
}