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
		
		public void Load(string fileName)
		{
			try {
				XmlDocument doc = new XmlDocument();
				doc.LoadXml(File.ReadAllText(PathGenerator.ChordDiagramPath(fileName)));
				
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
			Bitmap bmp = new Bitmap(300, 200);
			Graphics graphics = Graphics.FromImage(bmp);
			Pen blackPen = new Pen(Color.Black);
			
			graphics.DrawString(this.Name, new Font(SettingsSingleton.Instance.option["fontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))), Brushes.Black, 125, 0);
			graphics.DrawRectangle(new Pen(Color.Black), 0, 30, 290, 125);
			
			for(int y=48; y<150; y+=18)
			{
				graphics.DrawLine(new Pen(Color.Chocolate), 0, y, 290, y);
			}
			
			for(int x=72; x<290; x+=73)
			{
				graphics.DrawLine(new Pen(Color.DarkKhaki), x, 30, x, 155);
			}
			
			graphics.FillEllipse(new SolidBrush(Color.Blue), E4==0? -4:(E4-1)*72+36-5, 30+(18*1)-5, 10, 10);
			graphics.FillEllipse(new SolidBrush(Color.Blue), B3==0? -4:(B3-1)*72+36-5, 30+(18*2)-5, 10, 10);
			graphics.FillEllipse(new SolidBrush(Color.Blue), G3==0? -4:(G3-1)*72+36-5, 30+(18*3)-5, 10, 10);
			graphics.FillEllipse(new SolidBrush(Color.Blue), D3==0? -4:(D3-1)*72+36-5, 30+(18*4)-5, 10, 10);
			graphics.FillEllipse(new SolidBrush(Color.Blue), A2==0? -4:(A2-1)*72+36-5, 30+(18*5)-5, 10, 10);
			graphics.FillEllipse(new SolidBrush(Color.Blue), E2==0? -4:(E2-1)*72+36-5, 30+(18*6)-5, 10, 10);
			
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
