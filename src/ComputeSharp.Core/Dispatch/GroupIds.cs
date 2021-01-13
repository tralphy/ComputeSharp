﻿using ComputeSharp.Exceptions;

namespace ComputeSharp
{
    /// <summary>
    /// A <see langword="class"/> that indicates the ids of a given GPU thread running a compute shader within aa dispatch group.
    /// </summary>
    public static class GroupIds
    {
        /// <summary>
        /// Gets the flattened index of the current thread with respect to the dispatch group.
        /// </summary>
        public static int Index => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(Index)}");

        /// <summary>
        /// Gets the X id of the current thread with respect to the dispatch group.
        /// </summary>
        public static int X => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(X)}");

        /// <summary>
        /// Gets the Y id of the current thread with respect to the dispatch group.
        /// </summary>
        public static int Y => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(Y)}");

        /// <summary>
        /// Gets the Z id of the current thread with respect to the dispatch group.
        /// </summary>
        public static int Z => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(Z)}");

        /// <summary>
        /// Gets an <see cref="Int2"/> value with the <see cref="X"/> value for all components.
        /// </summary>
        public static Int2 XX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XX)}");

        /// <summary>
        /// Gets or sets an <see cref="Int2"/> value with the <see cref="X"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int2 XY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XY)}");

        /// <summary>
        /// Gets or sets an <see cref="Int2"/> value with the <see cref="X"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int2 XZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XZ)}");

        /// <summary>
        /// Gets or sets an <see cref="Int2"/> value with the <see cref="Y"/> and <see cref="X"/> values.
        /// </summary>
        public static Int2 YX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YX)}");

        /// <summary>
        /// Gets an <see cref="Int2"/> value with the <see cref="Y"/> value for all components.
        /// </summary>
        public static Int2 YY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YY)}");

        /// <summary>
        /// Gets or sets an <see cref="Int2"/> value with the <see cref="Y"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int2 YZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YZ)}");

        /// <summary>
        /// Gets or sets an <see cref="Int2"/> value with the <see cref="Z"/> and <see cref="X"/> values.
        /// </summary>
        public static Int2 ZX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZX)}");

        /// <summary>
        /// Gets or sets an <see cref="Int2"/> value with the <see cref="Z"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int2 ZY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZY)}");

        /// <summary>
        /// Gets an <see cref="Int2"/> value with the <see cref="Z"/> value for all components.
        /// </summary>
        public static Int2 ZZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZZ)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="X"/> value for all components.
        /// </summary>
        public static Int3 XXX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XXX)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="X"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 XXY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XXY)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="X"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 XXZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XXZ)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="Y"/> and <see cref="X"/> values.
        /// </summary>
        public static Int3 XYX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XYX)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="Y"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 XYY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XYY)}");

        /// <summary>
        /// Gets or sets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="Y"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 XYZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XYZ)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="Z"/> and <see cref="X"/> values.
        /// </summary>
        public static Int3 XZX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XZX)}");

        /// <summary>
        /// Gets or sets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="Z"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 XZY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XZY)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="X"/>, <see cref="Z"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 XZZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(XZZ)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="X"/> and <see cref="X"/> values.
        /// </summary>
        public static Int3 YXX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YXX)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="X"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 YXY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YXY)}");

        /// <summary>
        /// Gets or sets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="X"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 YXZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YXZ)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="Y"/> and <see cref="X"/> values.
        /// </summary>
        public static Int3 YYX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YYX)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Y"/> value for all components.
        /// </summary>
        public static Int3 YYY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YYY)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="Y"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 YYZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YYZ)}");

        /// <summary>
        /// Gets or sets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="Z"/> and <see cref="X"/> values.
        /// </summary>
        public static Int3 YZX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YZX)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="Z"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 YZY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YZY)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Y"/>, <see cref="Z"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 YZZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(YZZ)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="Z"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 ZXX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZXX)}");

        /// <summary>
        /// Gets or sets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="X"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 ZXY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZXY)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="X"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 ZXZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZXZ)}");

        /// <summary>
        /// Gets or sets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="Y"/> and <see cref="X"/> values.
        /// </summary>
        public static Int3 ZYX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZYX)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="Y"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 ZYY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZYY)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="Y"/> and <see cref="Z"/> values.
        /// </summary>
        public static Int3 ZYZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZYZ)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="Z"/> and <see cref="X"/> values.
        /// </summary>
        public static Int3 ZZX => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZZX)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Z"/>, <see cref="Z"/> and <see cref="Y"/> values.
        /// </summary>
        public static Int3 ZZY => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZZY)}");

        /// <summary>
        /// Gets an <see cref="Int3"/> value with the <see cref="Z"/> value for all components.
        /// </summary>
        public static Int3 ZZZ => throw new InvalidExecutionContextException($"{nameof(GroupIds)}.{nameof(ZZZ)}");
    }
}
