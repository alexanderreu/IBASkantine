using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Azure.Data.Tables;
using IBAS_kantine.Model;

namespace IBAS_kantine.Pages;

public class IndexModel : PageModel
{
    private readonly TableClient _tableClient;
    public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

    public IndexModel()
    {
        var connectionString = "DefaultEndpointsProtocol=https;AccountName=ibaskantinemenu1;AccountKey=QzQqUXfpXLrXd9fpl9qeXE1NNkQPGoRx9/Fe8kc5f9horQQCyvHqxQondneAFctV/c4gRg2Mz0US+AStbonYzA==;EndpointSuffix=core.windows.net";
        var tableName = "ibaskantinemenu";
        _tableClient = new TableClient(connectionString, tableName);
        
        _tableClient.CreateIfNotExists();
    }

    public void OnGet()
    {
        var items = _tableClient.Query<MenuItem>().ToList();
        MenuItems = items;
    }
}