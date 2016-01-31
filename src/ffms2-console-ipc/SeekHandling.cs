using System;

namespace ffms2.console.ipc
{
    /// <summary>
    /// Control how seeking is handled
    /// </summary>
    [Serializable]
    public enum SeekHandling
    {
        /// <summary>
        /// Linear access without rewind
        /// </summary>
        /// <remarks>
        /// <para>In FFMS2, the equivalent is <c>FFMS_SEEK_LINEAR_NO_RW</c>.</para>
        /// <para>Will throw an error if each successive requested frame number isn't bigger than the last one.</para>
        /// <para>Only intended for opening images but might work on well with some obscure video format.</para>
        /// </remarks>
        LinearNoRewind = -1,
        /// <summary>
        /// Linear access
        /// </summary>
        /// <remarks>
        /// <para>In FFMS2, the equivalent is <c>FFMS_SEEK_LINEAR</c>.</para>
        /// <para>If you request frame n without having requested frames 0 to n-1 in order first, all frames from 0 to n will have to be decoded before n can be delivered.</para>
        /// <para>The definition of slow, but should make some formats "usable".</para>
        /// </remarks>
        Linear = 0,
        /// <summary>
        /// Safe normal
        /// </summary>
        /// <remarks>
        /// <para>In FFMS2, the equivalent is <c>FFMS_SEEK_NORMAL</c>.</para>
        /// <para>Bases seeking decisions on the keyframe positions reported by libavformat.</para>
        /// </remarks>
        Normal = 1,
        /// <summary>
        /// Unsafe normal
        /// </summary>
        /// <remarks>
        /// <para>In FFMS2, the equivalent is <c>FFMS_SEEK_UNSAFE</c>.</para>
        /// <para>Same as <see cref="Normal" /> but no error will be thrown if the exact destination has to be guessed.</para>
        /// </remarks>
        Unsafe = 2,
        /// <summary>
        /// Aggressive
        /// </summary>
        /// <remarks>
        /// <para>In FFMS2, the equivalent is <c>FFMS_SEEK_AGGRESSIVE</c>.</para>
        /// <para>Seeks in the forward direction even if no closer keyframe is known to exist.</para>
        /// <para>Only useful for testing and containers where libavformat doesn't report keyframes properly.</para>
        /// </remarks>
        Aggressive = 3
    }
}