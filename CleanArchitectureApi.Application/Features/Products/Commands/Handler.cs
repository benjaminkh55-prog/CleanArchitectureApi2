using MediatR;
using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Domain.Entities;

namespace CleanArchitectureApi.Application.Features.Products.Commands;

public class CreateProductHandler
    : IRequestHandler<CreateProductCommand, int>
{
    private readonly IRepository<Product> _repository;

    public CreateProductHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(
        CreateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        await _repository.AddAsync(product);

        return product.Id;
    }
}
