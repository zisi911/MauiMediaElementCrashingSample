﻿namespace MauiMediaElementCrashingSample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
	}
}
