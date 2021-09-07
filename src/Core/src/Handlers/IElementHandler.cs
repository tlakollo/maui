﻿namespace Microsoft.Maui
{
	public interface IElementHandler
	{
		void SetMauiContext(IMauiContext mauiContext);

		void SetVirtualView(IElement view);

		void UpdateValue(string property);

		void Invoke(string command, object? args = null);

		void DisconnectHandler();

		void ConnectHandler(object nativeView);

		object? NativeView { get; }

		IElement? VirtualView { get; }

		IMauiContext? MauiContext { get; }
	}
}