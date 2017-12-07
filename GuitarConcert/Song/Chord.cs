/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-04
 * Time: 17:25
 * 
 */
using System;
using System.Drawing;
using System.Xml;
using System.IO;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Chord.
	/// </summary>
	public class Chord
	{	
		private int E4;
		private int B3;
		private int G3;
		private int D3;
		private int A2;
		private int E2;
		
		public string Name;
		
		public Chord(string fileName)
		{
			this.Load(fileName);
		}
		
		public Chord()
		{
			RestoreDefault();
		}
		
		public void Load(string chordName)
		{
			try {
				XmlDocument doc = new XmlDocument();
				doc.LoadXml(File.ReadAllText(String.Format("{0}/{1}.{2}",
						SettingsSingleton.Instance.option["chordsDirectory"],
						chordName,
						SettingsSingleton.Instance.option["chordDiagramExtension"])));
				
				this.Name = doc.GetElementsByTagName("chord")[0].Attributes[0].Value;
				
				this.E4 = int.Parse(doc.GetElementsByTagName("e4")[0].InnerText);
				this.B3 = int.Parse(doc.GetElementsByTagName("b3")[0].InnerText);
				this.G3 = int.Parse(doc.GetElementsByTagName("g3")[0].InnerText);
				this.D3 = int.Parse(doc.GetElementsByTagName("d3")[0].InnerText);
				this.A2 = int.Parse(doc.GetElementsByTagName("a2")[0].InnerText);
				this.E2 = int.Parse(doc.GetElementsByTagName("e2")[0].InnerText);
			}
			catch(Exception exception) {
				RestoreDefault();
				Logger.ToFile(exception);
			}
		}
		
		public Bitmap CreateBitmap()
		{
			Bitmap bmp = new Bitmap(300, 150);
			Graphics graphics = Graphics.FromImage(bmp);
			Pen blackPen = new Pen(Color.Black);
			
			// TODO Draw chord diagram
			
			graphics.DrawString(this.Name, new Font(SettingsSingleton.Instance.option["fontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))), Brushes.Black, 0, 0);
			
			return bmp;
		}
		
		private void RestoreDefault()
		{
			this.Name = "Em11";
			this.E4 = 0;
			this.B3 = 0;
			this.G3 = 0;
			this.D3 = 0;
			this.A2 = 0;
			this.E2 = 0;
		}
	}
}
