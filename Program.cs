using System.Text;


// See https://aka.ms/new-console-template for more information

if (args.Length!=1)
{
    Console.WriteLine("somente um parâmetro");
    Environment.Exit(0);
    
}
string caminho = args[0];

var linhas =File.ReadLines(caminho);
StringBuilder saida = new();
saida.AppendLine("StringBuilder sbJson = new();");
foreach(var linha in linhas)
{
    string convertido = Microsoft.CodeAnalysis.CSharp.SymbolDisplay.FormatPrimitive(linha,true, true);
    saida.AppendLine("sbJson.AppendLine("+convertido+");");
}
TextCopy.ClipboardService.SetText(saida.ToString());
Console.WriteLine(saida.ToString());