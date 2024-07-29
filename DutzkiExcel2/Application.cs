namespace DutzkiExcel2
{
    class Application
    {
        string FilePath { get; set; }

        public Application(ref SpreadSheet sheet, string FilePath)
        {
            this.FilePath = FilePath;

            AddData(ref sheet);
        }
        public SpreadSheet AddData(ref SpreadSheet sheet)
        {
            FileStream stream = File.OpenRead(this.FilePath);
            StreamReader read = new StreamReader(stream);
            int row = 0;
            int colId = 1;
            string? tempString = "";
            while ((tempString = read.ReadLine()) != null)
            {
                string[] tempArr = SplitLine(tempString);
                for (int col = 0; col < tempArr.Length; col++)
                {
                    string colLetter = sheet.sheetHeader[col];

                    Cell cell = CellBuilder.Empty()
                    .SetFields(x => x.Row = row)
                    .SetFields(x => x.Col = col)
                    .SetFields(x => x.Value = tempArr[col])
                    .SetFields(x => x.ColLetter = colLetter + colId)
                    .SetFields(x => x.SetDataType()).Build();

                    sheet.sheet[row, col] = cell;
                }
                row++;
                colId++;
            }
            return sheet;
        }

        private static string[] SplitLine(string line)
        {
            string[] splitLine = line.Split(',');
            return splitLine;
        }
    }
}
  
