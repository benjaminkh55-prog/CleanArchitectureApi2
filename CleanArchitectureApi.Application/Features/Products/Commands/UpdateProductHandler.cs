using MediatR;
using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Domain.Entities;

namespace CleanArchitectureApi.Application.Features.Products.Commands;

public class UpdateProductHandler
    : IRequestHandler<UpdateProductCommand, bool>
{
    private readonly IRepository<Product> _repository;

    public UpdateProductHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(
        UpdateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.Id);

        if (product == null)
            return false;

        product.Name = request.Name;
        product.Price = request.Price;
        product.CategoryId = request.CategoryId;

        await _repository.UpdateAsync(product);

        return true;
    }
}
