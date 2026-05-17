using MediatR;
using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Domain.Entities;

namespace CleanArchitectureApi.Application.Features.Products.Queries;

public class GetAllProductsHandler
    : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IRepository<Product> _repository;

    public GetAllProductsHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<List<Product>> Handle(
        GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
