// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Runtime.CompilerServices
{
    using JetBrains.Annotations;

    /// <summary>
    ///     Aggregates caller information provided by the compiler. See <see cref="CallerFilePathAttribute" />,
    ///     <see cref="CallerMemberNameAttribute" />, <see cref="CallerLineNumberAttribute" />.
    /// </summary>
    [PublicAPI]
    public struct CallerInfo : IEquatable<CallerInfo>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CallerInfo" /> struct.
        /// </summary>
        /// <param name="filePath">The caller file path.</param>
        /// <param name="memberName">The caller member name.</param>
        /// <param name="lineNumber">The caller line number.</param>
        public CallerInfo(string? filePath, string? memberName, int? lineNumber)
        {
            FilePath = filePath;
            MemberName = memberName;
            LineNumber = lineNumber == 0 ? null : lineNumber;
        }

        /// <summary>
        ///     The caller file path.
        /// </summary>
        public string? FilePath { get; }

        /// <summary>
        ///     The caller member name.
        /// </summary>
        public string? MemberName { get; }

        /// <summary>
        ///     The caller line number.
        /// </summary>
        public int? LineNumber { get; }

        /// <inheritdoc />
        public bool Equals(CallerInfo other)
        {
            return FilePath == other.FilePath && MemberName == other.MemberName && LineNumber == other.LineNumber;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is CallerInfo other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Combine(FilePath, MemberName, LineNumber);
        }

#pragma warning disable 1591
#pragma warning disable SA1201 // Elements should appear in the correct order
        public static bool operator ==(CallerInfo left, CallerInfo right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CallerInfo left, CallerInfo right)
        {
            return !left.Equals(right);
        }
#pragma warning restore 1591
#pragma warning restore SA1201 // Elements should appear in the correct order
    }
}
