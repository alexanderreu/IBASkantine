namespace IBAS_kantine.Model;
using Azure;
using Azure.Data.Tables;

public class MenuItem : ITableEntity
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public string KoldeRet { get; set; }
    public string VarmeRet { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}