namespace DutzkiExcel2
{
    class TxtFile
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        public string FilePath { get; set; }

        public TxtFile(string filepath)
        {
            this.FilePath = filepath;
        }

        public TxtFile GetDimensions()
        {
            FileStream stream = File.OpenRead(this.FilePath);
            StreamReader read = new StreamReader(stream);

            string? tempString = "";
            int loopLength = 0;
            this.Columns = 1;
            this.Rows = 1;
            while ((tempString = read.ReadLine()) != null)
            {
                string[] tempArr = SplitLine(tempString);

                loopLength = tempArr.Length;

                if (loopLength > this.Columns)
                {
                    this.Columns = loopLength;
                }
                else
                {
                    loopLength = this.Columns;
                }
                this.Rows++;
            }
            return this;
        }

        public TxtFile PrintResult()
        {
            Console.WriteLine("Rows {0} - Columns {1} ", this.Rows, this.Columns);
            return this;
        }

        private static string[] SplitLine(string line)
        {
            string[] splitLine = line.Split(',');
            return splitLine;
        }

        public int GetCol()
        {
            return this.Columns;
        }

        public int GetRow()
        {
            return this.Rows;
        }
    }

}
