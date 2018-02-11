﻿using System;

namespace UnityRipper
{
	public static class BitConverterExtensions
	{
		public static uint ToUInt32(float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return BitConverter.ToUInt32(bytes, 0);
		}

		public static uint Reverse(uint value)
		{
			uint reverse = (value & 0x000000FF) << 24 | (value & 0x0000FF00) << 8 |
				(value & 0x00FF0000) >> 8 | (value & 0xFF000000) >> 24;
			return reverse;
		}

		public static int Reverse(int value)
		{
			unchecked
			{
				uint uvalue = (uint)value;
				uint reverse = Reverse(uvalue);
				return (int)reverse;
			}
		}
	}
}
