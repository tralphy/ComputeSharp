// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that an output will not be null even if the corresponding type allows it.
/// Specifies that an input argument was not null when the call returns.
/// </summary>
/// <remarks>Internal copy from the BCL attribute.</remarks>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, Inherited = false)]
internal sealed class NotNullAttribute : Attribute
{
}