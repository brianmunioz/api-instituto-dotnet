using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MasterNet.Application.Core;
public class PagedList<T>
{
    public PagedList
    (
        List<T> items,
        int count,
        int pageNumber,
        int pageSize
    )
    {
        CurrentPage=pageNumber;
        TotalPages = (int)Math.Ceiling(count/(double)pageSize);
        PageSize = pageSize;
        TotalCount = count;
        Items = items;

    }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set;}
    public int PageSize { get; set; }
    public int TotalCount {get; set;}
    public List<T> Items { get; set; } = new List<T>();
    public static async Task<PagedList<T>> CreateAsync
    (
        IQueryable<T> source,//Representa la consulta
        int pageNumber,
        int pageSize
    )
    {
        var count = await source.CountAsync(); //cantidad de records en bdd
        var items = await source
                            .Skip((pageNumber-1)*pageSize)
                            .Take(pageSize)
                            .ToListAsync();
    return new PagedList<T>(items,count,pageNumber,pageSize);
    }
}