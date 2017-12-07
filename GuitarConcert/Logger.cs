/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-01
 * Time: 20:31
 * 
 */
using System;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Logger.
	/// </summary>
	public class Logger
	{
		private static string logFile = ".log";
		
		public static void ToFile(Exception exception)
		{
			System.IO.File.AppendAllLines(logFile, new string[] {
				"----------------------------------------------------------------",
				DateTime.Now.ToString() +":"+ DateTime.Now.Millisecond.ToString(),
				exception.Message,
				"HResult: " + exception.HResult.ToString(),
				exception.StackTrace,
				"",});
		}
		
		public static void ToFile(string message)
		{
			System.IO.File.AppendAllLines(logFile, new string[] {
				"----------------------------------------------------------------",
				DateTime.Now.ToString() +":"+ DateTime.Now.Millisecond.ToString(),
				message,
				"",});
		}
		
		private Logger()
		{
		}
	}
}
