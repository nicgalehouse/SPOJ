
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Spoj.Solver.UnitTests.Solutions._2___Chieftain
{
    [TestClass]
    public sealed class ARMYTests : SolutionTestsBase
    {
        public override string SolutionSource => Solver.Solutions.ARMY;

        public override IReadOnlyList<string> TestInputs => new[]
        {
@"5

1 1
1
1

3 2
1 3 2
5 5

5 4
1 2 3 4 5
1 2 3 4

1 2
2
1 1

3 4
1 2 3
1 1 1 7
"
        };

        public override IReadOnlyList<string> TestOutputs => new[]
        {
@"Godzilla
MechaGodzilla
Godzilla
Godzilla
MechaGodzilla
"
        };

        [TestMethod]
        public void ARMY() => TestSolution();
    }
}