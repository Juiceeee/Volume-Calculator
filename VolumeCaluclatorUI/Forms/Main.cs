#region Namespace

using System;
using System.Windows.Forms;

using VolumeCalculatorUI.Primitives;
using VolumeCalculatorUI.Properties;

#endregion

namespace VolumeCalculatorUI.Forms
{
    /// <summary>The <see cref="Main"/> class.</summary>
    public partial class Main : Form
    {
        #region Constructors and Destructors

        /// <summary>Initializes a new instance of the <see cref="Main"/> class.</summary>
        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>Handles the Click event of the BTN_Calculate control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BTN_Calculate_Click(object sender, EventArgs e)
        {
            CalculateVolume();
        }

        /// <summary>Calculates the volume.</summary>
        private void CalculateVolume()
        {
            // Create a separate class to hold the dimensions and do the calculation.
            Dimensions dimensions = new Dimensions(Convert.ToInt32(NUD_Height.Value), Convert.ToInt32(NUD_Width.Value));

            // Retrieves the volume value
            var volume = dimensions.Volume;

            // Output the volume as string in the text box
            TB_Result.Text = volume.ToString();
        }

        /// <summary>Loads the settings.</summary>
        private void LoadSettings()
        {
            NUD_Height.Value = Settings.Default.Height;
            NUD_Width.Value = Settings.Default.Width;
        }

        /// <summary>Handles the FormClosing event of the Main control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>Handles the Load event of the Main control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            //Load custom user settings.
            LoadSettings();
        }

        /// <summary>Saves the settings.</summary>
        private void SaveSettings()
        {
            // Saves the user specific values to settings
            Settings.Default.Height = Convert.ToInt32(NUD_Height.Value);
            Settings.Default.Width = Convert.ToInt32(NUD_Width.Value);
            Settings.Default.Save();
        }

        #endregion
    }
}