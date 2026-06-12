namespace Bai7_Stream
{
    internal class ndir_ncopy
    {
        static void Main(string[] args)
        {

            ndir_ncopy obj = new ndir_ncopy();
            //dir
            //obj.ndir();



            //copy

            obj.ncopy();



        }

        public void ndir()
        {
            var path = "C:\\";
            var dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();

            foreach (var d in directories)
            {
                //onsole.WriteLine(d.CreationTime);
                Console.WriteLine($"{d.LastWriteTime.ToString("MM/dd/yyyy")} {d.LastWriteTimeUtc:HH:MM)} <dir>   {d.Name}");
            }

            var files = dir.GetFiles();
            foreach (var f in files)
            {
                Console.WriteLine($"{f.LastWriteTime:DD/MM/YYYY} {f.LastWriteTimeUtc:HH/MM}       {f.Length:#,####}      {f.Name}");
            }
        }


            public void ncopy()
        {
            var source = @"C:\\test bài 7\\1\\234\\test.txt";
            var dest = @"C:\\test bài 7\\1\\234\\test_copy.txt";

            var buffer = new byte[2024];
            using var instream = File.OpenRead(source);     // dùng using thì không cần close.
            using var outstream = File.OpenWrite(dest);


            int n = instream.Read(buffer, 0, buffer.Length);
            while (n > 0)
            {



                Console.WriteLine(n.ToString());

                outstream.Write(buffer, 0, n);

                n = instream.Read(buffer, 0, buffer.Length);
            }

            //instream.Close();
            //outstream.Close();
        }

        
        }
    }

