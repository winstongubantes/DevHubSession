﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SampleApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //XAMARIN APP SETTING OF STARTING PAGE
			MainPage = new NavigationPage(new SampleApp.LoginPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
