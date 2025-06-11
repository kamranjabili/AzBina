using AzBina.Application.Abstracts.Repositories;
using AzBina.Domain.Entities;
using AzBina.Persistence.Contexts;

namespace AzBina.Persistence.Repositories;

public class CategoryRepository:Repository<Category>,ICategoryRepository
{
    public CategoryRepository(AzBinaDbContext context):base(context)
    { 
    }
}
