﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UnitConverterDemo
{
    public class TemperatureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return value;
            if (value == null)
            {
                return null;
            }
            double _value = Double.Parse(value.ToString());

            if (parameter.Equals("F"))
            {
                return ((_value - 1) *1.8)+ 33.8;
            }
            else if (parameter.Equals("K"))
            {
                return (_value - 1) + 274.15;
            }
            else if (parameter.Equals("RA"))
            {
                return ((_value - 1) * 1.8) + 493.47;
            }
            else
            {
                return Decimal.Parse(value.ToString());
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return value;
            if (value == null)
            {
                return null;
            }
            double _value = Double.Parse(value.ToString());

            if (parameter.Equals("F"))
            {
                return (_value - 33.8) / 1.8 + 1;
            }
            else if (parameter.Equals("K"))
            {
                return (_value - 274.15) + 1 ;
            }
            else if (parameter.Equals("RA"))
            {
                return (_value - 493.47) / 1.8 + 1;
            }
            else
            {
                return Decimal.Parse(value.ToString());
            }
        }
    }
}