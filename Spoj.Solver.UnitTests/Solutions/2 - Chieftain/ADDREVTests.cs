
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Spoj.Solver.UnitTests.Solutions._2___Chieftain
{
    [TestClass]
    public sealed class ADDREVTests : SolutionTestsBase
    {
        public override string SolutionSource => Solver.Solutions.ADDREV;

        public override IReadOnlyList<string> TestInputs => new[]
        {
@"3
24 1
4358 754
305 794",
@"1
100000 25"
        };

        public override IReadOnlyList<string> TestOutputs => new[]
        {
@"34
1998
1
",
@"35
"
        };

        [TestMethod]
        public void ADDREV() => TestSolution();
    }
}