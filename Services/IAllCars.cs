using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using shop.Entities;
using shop.Models;

namespace shop.Services
{
    public interface IAllCars
    {
        Task<bool> ExistAsync(Guid id);
        Task<Car> GetCar(Guid id);
        Task<List<Car>> GetAll();
        Task<(bool IsSuccess, Exception Exception)> InsertAsync(Car car);
        Task<(bool IsSuccess, Exception Exception)> UpdateAsync(Car car);
        Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
    }
}