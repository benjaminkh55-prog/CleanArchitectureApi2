using MediatR;
using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Domain.Entities;

namespace CleanArchitectureApi.Application.Features.Products.Queries;

public class GetProductByIdHandler
    : IRequestHandler<GetProductByIdQuery, Product?>
{
    private readonly IRepository<Product> _repository;

    public GetProductByIdHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<Product?> Handle(
        GetProductByIdQuery request,
        CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}
