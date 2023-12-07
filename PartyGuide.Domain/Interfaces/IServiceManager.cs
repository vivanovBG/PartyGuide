﻿using PartyGuide.Domain.Models;

namespace PartyGuide.Domain.Interfaces
{
    public interface IServiceManager
    {
        Task AddNewService(ServiceModel serviceModel);
        Task<List<ServiceModel>> GetAllServicesAsync();
        Task<ServiceModel> GetServiceByIdAsync(int? id);
        Task<List<ServiceModel>> GetServiceTablesFilterAsync(string category, string title, string startPriceRange, string endPriceRange, string location);
    }
}