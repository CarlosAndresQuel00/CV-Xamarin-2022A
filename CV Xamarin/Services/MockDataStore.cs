using CV_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_Xamarin.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Edad", Description="21 años" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dirección", Description="Quito Sur, Quito" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Teléfono móvil", Description="0996989414" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Correo electrónico", Description="carlos.quel@epn.edu.ec" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Experiencia", Description="CNT - Quito" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Referencia", Description="Santiago - Pichincha gerencia Bancaria" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}