namespace VolumeCalculatorUI.Utilities
{
    /// <summary>The <see cref="MathUtilities"/> class.</summary>
    public static class MathUtilities
    {
        #region Public Methods and Operators

        /// <summary>Calculates the volume.</summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        /// <returns>The <see cref="System.Int32"/> value.</returns>
        public static int CalculateVolume(int height, int width)
        {
            // Calculates the volume using width and height.
            int volume = width * height;

            // Returns the value as an int after doing the math
            return volume;
        }

        #endregion
    }
}