using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace VisitorBenchmark
{
    public class Tests
    {
        /*
         * I have put each test case in a seperate class.
         * I did this to eliminate the risk of poluting the results with the presence of other solutions.
         * For example, I noticed that for some reason,
         * depending on the number of virtual functions in the Unit class,
         * performance could vary significantly.
         * I didn't want to use generic classes either since I don't know how they are implemented in C#.
         * However, that is something I wish to investigate in the future.
         */

        [GlobalSetup]
        public void GlobalSetup()
        {
            TestCases.IfElseIf04Classes.Init();
            TestCases.IfElseIf08Classes.Init();
            TestCases.IfElseIf16Classes.Init();

            TestCases.VirtualCall04Classes.Init();
            TestCases.VirtualCall08Classes.Init();
            TestCases.VirtualCall16Classes.Init();

            TestCases.Visitor04Classes.Init();
            TestCases.Visitor08Classes.Init();
            TestCases.Visitor16Classes.Init();

            TestCases.PatternSwitch04Classes.Init();
            TestCases.PatternSwitch08Classes.Init();
            TestCases.PatternSwitch16Classes.Init();

            TestCases.DynamicCast04Classes.Init();
            TestCases.DynamicCast08Classes.Init();
            TestCases.DynamicCast16Classes.Init();

            TestCases.VirtualSwitch04Classes.Init();
            TestCases.VirtualSwitch08Classes.Init();
            TestCases.VirtualSwitch16Classes.Init();

            TestCases.NoVirtualSwitch04Classes.Init();
            TestCases.NoVirtualSwitch08Classes.Init();
            TestCases.NoVirtualSwitch16Classes.Init();

            TestCases.VirtualJumpTable04Classes.Init();
            TestCases.VirtualJumpTable08Classes.Init();
            TestCases.VirtualJumpTable16Classes.Init();

            TestCases.NoVirtualJumpTable04Classes.Init();
            TestCases.NoVirtualJumpTable08Classes.Init();
            TestCases.NoVirtualJumpTable16Classes.Init();
        }

#region IfElseIf
        [Benchmark]
        public void TestIfElseIf04Classes()
        {
            TestCases.IfElseIf04Classes.Test();
        }

        [Benchmark]
        public void TestIfElseIf08Classes()
        {
            TestCases.IfElseIf08Classes.Test();
        }

        [Benchmark]
        public void TestIfElseIf16Classes()
        {
            TestCases.IfElseIf16Classes.Test();
        }
        #endregion

#region VirtualCall
        [Benchmark]
        public void TestVirtualCall04Classes()
        {
            TestCases.VirtualCall04Classes.Test();
        }

        [Benchmark]
        public void TestVirtualCall08Classes()
        {
            TestCases.VirtualCall08Classes.Test();
        }

        [Benchmark]
        public void TestVirtualCall16Classes()
        {
            TestCases.VirtualCall16Classes.Test();
        }
        #endregion

#region Visitor
        [Benchmark]
        public void TestVisitor04Classes()
        {
            TestCases.Visitor04Classes.Test();
        }

        [Benchmark]
        public void TestVisitor08Classes()
        {
            TestCases.Visitor08Classes.Test();
        }

        [Benchmark]
        public void TestVisitor16Classes()
        {
            TestCases.Visitor16Classes.Test();
        }
        #endregion

#region PatternSwitch
        [Benchmark]
        public void TestPatternSwitch04Classes()
        {
            TestCases.PatternSwitch04Classes.Test();
        }

        [Benchmark]
        public void TestPatternSwitch08Classes()
        {
            TestCases.PatternSwitch08Classes.Test();
        }

        [Benchmark]
        public void TestPatternSwitch16Classes()
        {
            TestCases.PatternSwitch16Classes.Test();
        }
        #endregion

#region DynamicCast
        [Benchmark]
        public void TestDynamicCast04Classes()
        {
            TestCases.DynamicCast04Classes.Test();
        }

        [Benchmark]
        public void TestDynamicCast08Classes()
        {
            TestCases.DynamicCast08Classes.Test();
        }

        [Benchmark]
        public void TestDynamicCast16Classes()
        {
            TestCases.DynamicCast16Classes.Test();
        }
        #endregion

#region VirtualSwitch
        [Benchmark]
        public void TestVirtualSwitch04Classes()
        {
            TestCases.VirtualSwitch04Classes.Test();
        }

        [Benchmark]
        public void TestVirtualSwitch08Classes()
        {
            TestCases.VirtualSwitch08Classes.Test();
        }

        [Benchmark]
        public void TestVirtualSwitch16Classes()
        {
            TestCases.VirtualSwitch16Classes.Test();
        }
#endregion

#region NoVirtualSwitch
        [Benchmark]
        public void TestNoVirtualSwitch04Classes()
        {
            TestCases.NoVirtualSwitch04Classes.Test();
        }

        [Benchmark]
        public void TestNoVirtualSwitch08Classes()
        {
            TestCases.NoVirtualSwitch08Classes.Test();
        }

        [Benchmark]
        public void TestNoVirtualSwitch16Classes()
        {
            TestCases.NoVirtualSwitch16Classes.Test();
        }
#endregion

#region VirtualJumpTable
        [Benchmark]
        public void TestVirtualJumpTable04Classes()
        {
            TestCases.VirtualJumpTable04Classes.Test();
        }

        [Benchmark]
        public void TestVirtualJumpTable08Classes()
        {
            TestCases.VirtualJumpTable08Classes.Test();
        }

        [Benchmark]
        public void TestVirtualJumpTable16Classes()
        {
            TestCases.VirtualJumpTable16Classes.Test();
        }
#endregion

#region NoVirtualJumpTable
        [Benchmark]
        public void TestNoVirtualJumpTable04Classes()
        {
            TestCases.NoVirtualJumpTable04Classes.Test();
        }

        [Benchmark]
        public void TestNoVirtualJumpTable08Classes()
        {
            TestCases.NoVirtualJumpTable08Classes.Test();
        }

        [Benchmark]
        public void TestNoVirtualJumpTable16Classes()
        {
            TestCases.NoVirtualJumpTable16Classes.Test();
        }
#endregion
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tests>();
        }
    }
}