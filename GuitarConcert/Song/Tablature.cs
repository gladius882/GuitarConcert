/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-08
 * Time: 19:20
 * 
 */
using System;
using System.IO;
using AlphaTab.Importer;
using AlphaTab.Model;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Tablature.
	/// </summary>
	public class Tablature
	{
		#region Properties
		
		public Score GpTablature
		{
			get
			{
				return GpTablature;
			}
			private set
			{
				GpTablature = value;
			}
		}
		
		public TextTablature TextTablature
		{
			get
			{
				return TextTablature;
			}
			private set
			{
				TextTablature = value;
			}
		}
		
		#endregion
		
		public Tablature()
		{
			// TODO Tablature constructor
		}
		
		public void LoadText(string fileName)
		{
			// TODO Tablature.LoadText(string)
		}
		
		public void LoadGp(string fileName)
		{
			this.GpTablature = ScoreLoader.LoadScoreFromBytes(File.ReadAllBytes(fileName));
		}
	}
}
