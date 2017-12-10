/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-09-28
 * Time: 06:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GuitarConcert
{
	/// <summary>
	/// Description of SettingsSingleton.
	/// </summary>
	public sealed class SettingsSingleton
	{
		private static readonly SettingsSingleton instance = new SettingsSingleton();
		private const string settingsPath = "settings.ini";
		
		public Dictionary<string, string> option = new Dictionary<string, string>();
		
		public static SettingsSingleton Instance {
			get {
				return instance;
			}
		}
		
		private SettingsSingleton()
		{
			try {
				option = IniFile.ReadAllOptions(settingsPath);
			}
			catch(Exception exception) {
				MessageBox.Show("Cannot find the settings.ini file in application directory or this file is broken. " +
				                "Please restore this file or reinstall app to fix this problem.",
				                "Fatal error",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				
				Logger.ToFile(exception);
				Environment.Exit(1);
			}
		}
		
	}
}
