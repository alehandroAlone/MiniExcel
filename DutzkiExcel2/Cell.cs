namespace DutzkiExcel2
{
    public class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string? ColLetter { get; set; }

        public string? Address { get; set; }

        public string? Value { get; set; }
        public string? DataType { get; set; }
        public void SetDataType()
        {
            this.DataType = this.Value;
        }
    }

    class CellBuilder : Cell
    {
        private readonly Cell emptyCell = new();

        public static CellBuilder Empty() => new();

        public CellBuilder SetFields(Action<Cell> cell)
        {
            cell(emptyCell);
            return this;
        }

        public Cell Build()
        {
            return this.emptyCell;
        }


    }
}
