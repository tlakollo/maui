﻿using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Graphics;
using AAttribute = Android.Resource.Attribute;
using AColor = Android.Graphics.Color;

namespace Microsoft.Maui
{
	public static class CheckBoxExtensions
	{
		static readonly int[][] CheckedStates = new int[][]
		{
			new int[] { AAttribute.StateEnabled, AAttribute.StateChecked },
			new int[] { AAttribute.StateEnabled, -AAttribute.StateChecked },
			new int[] { -AAttribute.StateEnabled, AAttribute.StateChecked },
			new int[] { -AAttribute.StateEnabled, -AAttribute.StatePressed },
		};

		public static void UpdateBackground(this AppCompatCheckBox nativeCheckBox, ICheckBox check)
		{
			IBrush background = check.Background;

			if (Brush.IsNullOrEmpty(background))
				nativeCheckBox.SetBackgroundColor(AColor.Transparent);
			else
				nativeCheckBox.UpdateBackground(background);
		}

		public static void UpdateIsChecked(this AppCompatCheckBox nativeCheckBox, ICheckBox check)
		{
			nativeCheckBox.Checked = check.IsChecked;
		}
	}
}