using DutzkiExcel2;
using Application = DutzkiExcel2.Application;

    TxtFile txt = new TxtFile("C:\\Users\\User\\Desktop\\New Text Document.txt").GetDimensions().PrintResult();
    SpreadSheet sheet = new SpreadSheet(txt.GetRow(), txt.GetCol());
    Application aapp = new Application(ref sheet, txt.FilePath);

    Console.WriteLine();
