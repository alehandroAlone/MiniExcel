

namespace DutzkiExcel2
{
    class SpreadSheet
    {
        public Cell[,] sheet;
        public string[] sheetHeader;

        public SpreadSheet(int rows, int columns)
        {
            this.sheet = new Cell[rows, columns];
            this.sheetHeader = new string[columns];

            char[] columnLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < columns; i++)
            {
                this.sheetHeader[i] = columnLetters[i].ToString().Trim();
            }
        }
    }


}
