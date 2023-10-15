﻿using Domain.Entities;
using Core.Persistance.Repositories;

namespace Application.Services.Repositories
{
    public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
    {
    }
}
