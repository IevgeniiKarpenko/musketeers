using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var compressor = new Compressor();
            bool validated = compressor.ValidateCmdArgs(args);

            if(validated)
            { 
                compressor.DoAction();
            }
            else
            {
                Console.WriteLine("Invalid command line arguments");
            }
        }

    }

    public class Compressor
    {
        public string Source { get; set; }
        public string Output { get; set; }
        private CompressionMode Operation;

        public bool Compress()
        {
            try
            {
                const int chunkSize = 128; // read the file by chunks of 1KB
                using (var file = File.OpenRead(Source))
                {
                    int bytesRead;
                    var buffer = new byte[chunkSize];
                    while ((bytesRead = file.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        using (FileStream sourceStream = new FileStream(Output, FileMode.Append))
                        using (GZipStream zipStream = new GZipStream(sourceStream, Operation, false))
                        {
                            zipStream.Write(buffer, 0, bytesRead);
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Decompress()
        {
            try
            {
                using (FileStream targetStream = new FileStream(Output, FileMode.Create))
                using (FileStream sourceStream = new FileStream(Source, FileMode.Open))
                using (GZipStream zipStream = new GZipStream(sourceStream, Operation))
                {
                    zipStream.CopyTo(targetStream);
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DoAction()
        {
            if (!File.Exists(Source))
                return false;

            if(Operation == CompressionMode.Decompress)
            {
                return Decompress();
            }
            else
            {
                return Compress();
            }

        }

        public bool ValidateCmdArgs(string[] param)
        {
            if (param.Any(p => string.IsNullOrEmpty(p)))
                return false;

            switch (param[0])
            {
                case "compress":
                    Operation = CompressionMode.Compress;
                    break;
                case "decompress":
                    Operation = CompressionMode.Decompress;
                    break;
                default:
                    return false;
            }

            if (param[2]?.IndexOfAny(Path.GetInvalidPathChars()) == -1)
            {
                Output = param[2];
            }

            if (File.Exists(param[1]))
            {
                Source = param[1];
                return true;
            }

            return false;
        }
    }
}
