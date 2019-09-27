
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Spoj.Solver.UnitTests.Solutions._2___Chieftain
{
    [TestClass]
    public sealed class ABSYSTests : SolutionTestsBase
    {
        public override string SolutionSource => Solver.Solutions.ABSYS;

        public override IReadOnlyList<string> TestInputs => new[]
        {
@"6

23 + 47 = machula

3247 + 5machula2 = 3749

machula13 + 75425 = 77038

235978 + 213626 = 2634246machula346346347

1machula2 + 3 = 4

2 + machula = 7
"
        };

        public override IReadOnlyList<string> TestOutputs => new[]
        {
@"23 + 47 = 70
3247 + 502 = 3749
1613 + 75425 = 77038
235978 + 213626 = 449604
1 + 3 = 4
2 + 5 = 7
"
        };

        [TestMethod]
        public void ABSYS() => TestSolution();
    }
}