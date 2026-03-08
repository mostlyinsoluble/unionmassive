// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace AnalyzerRunner
{
    internal readonly struct Statistic(int numberOfNodes, int numberOfTokens, int numberOfTrivia)
    {
        public int NumberofNodes { get; } = numberOfNodes;

        public int NumberOfTokens { get; } = numberOfTokens;

        public int NumberOfTrivia { get; } = numberOfTrivia;

        public static Statistic operator +(Statistic statistic1, Statistic statistic2)
        {
            return new Statistic(
                statistic1.NumberofNodes + statistic2.NumberofNodes,
                statistic1.NumberOfTokens + statistic2.NumberOfTokens,
                statistic1.NumberOfTrivia + statistic2.NumberOfTrivia);
        }
    }
}
