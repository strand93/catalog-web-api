using CatalogWebApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogWebApi.Repositories
{
    public interface IItemsRepository
    {
        //GET
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        //POST
        Task CreateItemAsync(Item item);
        //PUT
        Task UpdateItemAsync(Item item);
        //DELETE
        Task DeleteItemAsync(Guid id);
    }
}