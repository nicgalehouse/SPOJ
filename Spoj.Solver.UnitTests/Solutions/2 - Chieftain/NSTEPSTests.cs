
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Spoj.Solver.UnitTests.Solutions._2___Chieftain
{
    [TestClass]
    public sealed class NSTEPSTests : SolutionTestsBase
    {
        public override string SolutionSource => Solver.Solutions.NSTEPS;

        public override IReadOnlyList<string> TestInputs => new[]
        {
@"5
4 2
6 6
3 4
7 5
9 7
"
        };

        public override IReadOnlyList<string> TestOutputs => new[]
        {
@"6
12
No Number
11
15
"
        };

        [TestMethod]
        public void NSTEPS() => TestSolution();
    }
}