/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-14
 * Time: 18:36
 * 
 */
using System;
using System.IO;
using System.IO.Compression;

namespace GuitarConcert
{
	/// <summary>
	/// Description of GcFile.
	/// </summary>
	public class GcFile
	{
		// TODO add support to multiple files in archive
		public GcFile()
		{
		}
		
		public static void Compress(DirectoryInfo directorySelected)
        {
			//string directoryPath = @"C:\Users\gladius882\Desktop\Git\GuitarConcert\GuitarConcert\bin\Debug";
            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) & 
                       FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(directorySelected.FullName + ".gz"))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, 
                               CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);

                            }
                        }
//                        FileInfo info = new FileInfo(directoryPath + "\\" + fileToCompress.Name + ".gz");
//                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
//                        fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
                    }

                }
            }
        }
		
		public static void Decompress(FileInfo fileToDecompress)
        {
			// FIXME InvalidDataException
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress, true))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
            }
        }
	}
}
