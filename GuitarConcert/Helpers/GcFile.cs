/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-14
 * Time: 18:36
 * 
 */
using System;
using System.IO;
using Ionic.Zip;

namespace GuitarConcert
{
	/// <summary>
	/// Description of GcFile.
	/// </summary>
	public class GcFile : IDisposable
	{
		private ZipFile zip;
		
		public GcFile(string fileName)
		{	
			Open(fileName);
		}
		
		public GcFile()
		{
			zip = new ZipFile();
		}
		
		public void Open(string fileName)
		{
			if(File.Exists(fileName))
				this.zip = new ZipFile(fileName);
			else
				throw new FileNotFoundException(fileName);
		}
		
		public void Extract(string path)
		{
			if(Directory.Exists(path))
				this.zip.ExtractAll(path);
			else 
				throw new DirectoryNotFoundException(path);
		}
		
		public static void Create(string[] files, string output, bool overrideFile = true)
		{
			using(ZipFile gc = new ZipFile())
			{
				foreach(string file in files)
				{
					gc.AddFile(file, ".");
				}
				
				if(output.EndsWith(".gc") == false)
				{
					output+=".gc";
				}
				
				if(File.Exists(output) && overrideFile == true)
					File.Delete(output);
				
				gc.Save(output);
			}
		}
		
		public void Dispose()
		{
			this.zip.Dispose();
		}
	}
}
