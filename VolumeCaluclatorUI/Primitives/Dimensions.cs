

#region Namespace

using System.Diagnostics;
using System.Text;

using VolumeCalculatorUI.Utilities;

#endregion

namespace VolumeCalculatorUI.Primitives
{
    /// <summary>The <see cref="Dimensions"/> class.</summary>
    [DebuggerDisplay("Height={Height}, Width={Width}, Volume={Volume}")]
    public class Dimensions
    {
        #region Constants

        /// <summary>The separator.</summary>
        private const string SEPARATOR = ": ";

        #endregion

        #region Constructors and Destructors

        /// <summary>Initializes a new instance of the <see cref="Dimensions"/> class.</summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        public Dimensions(int height, int width) : this()
        {
            Height = height;
            Width = width;
        }

        /// <summary>Initializes a new instance of the <see cref="Dimensions"/> class.</summary>
        public Dimensions()
        {
            Height = 0;
            Width = 0;
        }

        #endregion

        #region Properties - Public

        /// <summary>Gets or sets the height.</summary>
        /// <value>The height.</value>
        public int Height { get; set; }

        /// <summary>Gets the volume.</summary>
        /// <value>The volume.</value>
        public int Volume
        {
            get { return MathUtilities.CalculateVolume(Height, Width); }
        }

        /// <summary>Gets or sets the width.</summary>
        /// <value>The width.</value>
        public int Width { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            StringBuilder resultsBuilder = new StringBuilder();
            resultsBuilder.AppendLine(Constants.HEIGHT + SEPARATOR + Height);
            resultsBuilder.AppendLine(Constants.WIDTH + SEPARATOR + Width);
            resultsBuilder.AppendLine(Constants.VOLUME + SEPARATOR + Volume);
            return resultsBuilder.ToString();
        }

        #endregion
    }
}