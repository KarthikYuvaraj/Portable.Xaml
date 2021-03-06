﻿#if !NETSTANDARD
using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Collections.Generic;

namespace Portable.Xaml.ComponentModel
{
	public class UInt16Converter : BaseNumberConverter
	{
		internal override Type NumberType { get { return typeof(UInt16); } }

		internal override object FromString (string value, int fromBase)
		{
			return UInt16.Parse (value, CultureInfo.InvariantCulture);
		}

		internal override object FromString (string value, NumberFormatInfo formatInfo)
		{
			return UInt16.Parse (value, formatInfo);
		}
	}

}
#endif