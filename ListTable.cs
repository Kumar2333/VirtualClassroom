using System.Collections.Generic;

public class ListTable
{
    public List<Table> Tables = new List<Table>();

    public void AddTable(Table table)
    {
        Tables.Add(table);
    }
}