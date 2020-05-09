namespace Volume_Calculator.Utilities
{
    /// <summary>Class MathUtilities.</summary>
    public static class MathUtilities
    {
        #region Public Methods and Operators

        /// <summary>Calculates the volume.</summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>System.Int32.</returns>
        public static int CalculateVolume(int width, int height)
        {
            int volume = width * height;

            return volume;
        }

        #endregion
    }
}