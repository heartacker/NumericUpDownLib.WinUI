namespace NumericUpDownLib.WinUI.Converters
{
    using Microsoft.UI.Xaml.Data;
    using System;
    using System.Globalization;

    /// <summary>
    /// Converts a byte number into a string that contains the number 'X' characters input.
    /// The output of this converter can be used to measure UI Air space to ensure enough
    /// space for input controls...
    /// </summary>
    public sealed class ByteToPlaceHolderStringConverter : IValueConverter
    {
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((value is double) == false)
                return null;

            byte byteVal = (byte)(double)value;

            string retString = string.Empty;
            for (int i = 0; i < byteVal; i++)
                retString += "X";

            return retString;
        }

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
