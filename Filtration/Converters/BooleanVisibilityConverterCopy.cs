﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Filtration.Converters
{
    internal class BooleanVisibilityConverterCopy : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? Visibility.Visible : Visibility.Hidden;
            if (value is bool && targetType == typeof (Visibility))
            {
                var val = (bool) value;
                if (val)
                {
                    return Visibility.Visible;
                }
                if (parameter is Visibility)
                {
                    return parameter;
                }
                return Visibility.Collapsed;
            }
            if (value != null)
            {
                return Visibility.Visible;
            }


            if (parameter is Visibility)
            {
                return parameter;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
