//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.demo\",\"Name\":\"DemoRun\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs\",\"Position\":{\"Item1\":5,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.demo\",\"Name\":\"DemoRun\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.demo\",\"Name\":\"Set\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs\",\"Position\":{\"Item1\":128,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.demo\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs\",\"Position\":{\"Item1\":130,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.demo
{
    [SourceLocation("C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs", OperationFunctor.Body, 8, 129)]
    public partial class DemoRun : Operation<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, ICallable
    {
        public DemoRun(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "DemoRun";
        String ICallable.FullName => "Quantum.demo.DemoRun";
        public static OperationInfo<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Info => new OperationInfo<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>(typeof(DemoRun));
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumPrimitiveM
        {
            get;
            set;
        }

        public override Func<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Body => (__in__) =>
        {
#line 10 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0000 = 0L;
#line 11 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0001 = 0L;
#line 12 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0010 = 0L;
#line 13 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0011 = 0L;
#line 14 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0100 = 0L;
#line 15 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0101 = 0L;
#line 16 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0110 = 0L;
#line 17 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num0111 = 0L;
#line 18 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1000 = 0L;
#line 19 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1001 = 0L;
#line 20 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1010 = 0L;
#line 21 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1011 = 0L;
#line 22 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1100 = 0L;
#line 23 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1101 = 0L;
#line 24 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1110 = 0L;
#line 25 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var num1111 = 0L;
#line hidden
            {
#line 27 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                var qubits = Allocate.Apply(4L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 29 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                    foreach (var test in new QRange(1L, 10000L))
#line hidden
                    {
#line 31 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        Set.Apply((Result.Zero, qubits[0L]));
#line 32 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        Set.Apply((Result.Zero, qubits[1L]));
#line 33 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        Set.Apply((Result.Zero, qubits[2L]));
#line 34 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        Set.Apply((Result.Zero, qubits[3L]));
#line 92 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        var res0 = MicrosoftQuantumPrimitiveM.Apply(qubits[0L]);
#line 93 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        var res1 = MicrosoftQuantumPrimitiveM.Apply(qubits[1L]);
#line 94 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        var res2 = MicrosoftQuantumPrimitiveM.Apply(qubits[2L]);
#line 95 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        var res3 = MicrosoftQuantumPrimitiveM.Apply(qubits[3L]);
#line 97 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 97 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0000 = (num0000 + 1L);
                        }

#line 98 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 98 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0001 = (num0001 + 1L);
                        }

#line 99 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 99 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0010 = (num0010 + 1L);
                        }

#line 100 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 100 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0011 = (num0011 + 1L);
                        }

#line 101 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 101 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0100 = (num0100 + 1L);
                        }

#line 102 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 102 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0101 = (num0101 + 1L);
                        }

#line 103 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 103 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0110 = (num0110 + 1L);
                        }

#line 104 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 104 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num0111 = (num0111 + 1L);
                        }

#line 105 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 105 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1000 = (num1000 + 1L);
                        }

#line 106 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 106 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1001 = (num1001 + 1L);
                        }

#line 107 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 107 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1010 = (num1010 + 1L);
                        }

#line 108 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 108 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1011 = (num1011 + 1L);
                        }

#line 109 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 109 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1100 = (num1100 + 1L);
                        }

#line 110 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 110 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1101 = (num1101 + 1L);
                        }

#line 111 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 111 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1110 = (num1110 + 1L);
                        }

#line 112 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 112 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                            num1111 = (num1111 + 1L);
                        }
                    }

#line 116 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                    Set.Apply((Result.Zero, qubits[0L]));
#line 117 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                    Set.Apply((Result.Zero, qubits[1L]));
#line 118 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                    Set.Apply((Result.Zero, qubits[2L]));
#line 119 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                    Set.Apply((Result.Zero, qubits[3L]));
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(qubits);
                    }
                }
            }

#line 123 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            return (num0000, num0001, num0010, num0011, num0100, num0101, num0110, num0111, num1000, num1001, num1010, num1011, num1100, num1101, num1110, num1111);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
            this.MicrosoftQuantumPrimitiveM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__)
        {
            return __m__.Run<DemoRun, QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>(QVoid.Instance);
        }
    }

    [SourceLocation("C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs", OperationFunctor.Body, 131, -1)]
    public partial class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.demo.Set";
        public static OperationInfo<(Result,Qubit), QVoid> Info => new OperationInfo<(Result,Qubit), QVoid>(typeof(Set));
        protected ICallable<Qubit, Result> MicrosoftQuantumPrimitiveM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 133 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            var current = MicrosoftQuantumPrimitiveM.Apply(q1);
#line 134 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
            if ((desired != current))
            {
#line 136 "C:/Users/Mate/Desktop/nudli/demo/demo/Program.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }
}