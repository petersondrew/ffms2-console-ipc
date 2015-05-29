namespace ffms2.console.ipc
{
    public enum FrameResizeMethod
    {
        /// <summary>
        /// Bilinear (Fast)
        /// </summary>
        BilinearFast = 0x01,

        /// <summary>
        /// Bilinear
        /// </summary>
        Bilinear = 0x02,

        /// <summary>
        /// Bicubic
        /// </summary>
        Bicubic = 0x04,

        /// <summary>
        /// X
        /// </summary>
        X = 0x08,

        /// <summary>
        /// Point
        /// </summary>
        Point = 0x10,

        /// <summary>
        /// Area
        /// </summary>
        Area = 0x20,

        /// <summary>
        /// Bicubic (Linear)
        /// </summary>
        BicubLin = 0x40,

        /// <summary>
        /// Gaussian
        /// </summary>
        Gauss = 0x80,

        /// <summary>
        /// Sinc
        /// </summary>
        Sinc = 0x100,

        /// <summary>
        /// Lanczos
        /// </summary>
        Lanczos = 0x200,

        /// <summary>
        /// Spline
        /// </summary>
        Spline = 0x400
    }
}