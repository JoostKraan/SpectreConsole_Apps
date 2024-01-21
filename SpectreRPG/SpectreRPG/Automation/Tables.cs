using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;


namespace SpectreRPG.Automation
{
    public class Tables
    {
        public static string CreateStatTable(string Column1, string Column2,string row1, string row2,string row3,string row4, string row5,string row6,string row7,string row8,string row9,string row10)
        {
            var table = new Table();
            table.Alignment(Justify.Right);
            table.AddColumn(Column1);
            table.AddColumn(Column2);
            table.AddRow(row1,row2);
            table.AddRow(row3,row4);
            table.AddRow(row5,row6);
            table.AddRow(row7, row8);
            table.AddRow(row9, row10);
            table.Alignment = Justify.Left;
            table.Border = TableBorder.Ascii2;
            table.Alignment(Justify.Center);
            AnsiConsole.Write(table);
            return row1;
            
        }

        public static string CreateAttackTable(string sex)
        {
            var table = new Table();
            return sex;
        }
    
    }
}
