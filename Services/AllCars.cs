using System.Linq;
using System.Net.Mime;
using System.Collections.Generic;
using shop.Models;
using shop.Data;
using System.Threading.Tasks;
using System;
using shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace shop.Services
{
    public class AllCars : IAllCars
    {
        private readonly CarsContext _context;
        private readonly ILogger<AllCars> _logger;

        public AllCars(CarsContext context, ILogger<AllCars> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistAsync(Guid id)
            => await _context.Cars.AnyAsync(i => i.Id == id);
        public async Task<List<Car>> GetAll()
                => await _context.Cars.ToListAsync();

        public async Task<Car> GetCar(Guid id)
            => await _context.Cars.FirstOrDefaultAsync(i => i.Id == id);

        public async Task<(bool IsSuccess, Exception Exception)> InsertAsync(Car car)
        {
            try
            {
                await _context.Cars.AddAsync(car);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Car created in DB. ID: {car.Id}");
                return (true, null);
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Creating Car in DB failed.\nError:{e.Message}", e);
                return (false, e);
            }
        }

        public async Task<(bool IsSuccess, Exception Exception)> UpdateAsync(Car car)
        {
            if (!await ExistAsync(car.Id))
            {
                return (false, new Exception("Not found"));
            }
            try
            {
                _context.Cars.Update(car);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Car updated in DB. ID: {car.Id}");
                return (true, null);
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Updating Car in DB failed.\nError:{e.Message}", e);
                return (false, e);
            }
        }
    }
}