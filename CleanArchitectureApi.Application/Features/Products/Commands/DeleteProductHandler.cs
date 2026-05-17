using MediatR;
using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Domain.Entities;

namespace CleanArchitectureApi.Application.Features.Products.Commands;

public class DeleteProductHandler
    : IRequestHandler<DeleteProductCommand, bool>
{
    private readonly IRepository<Product> _repository;

    public DeleteProductHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(
        DeleteProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.Id);

        if (product == null)
            return false;

        await _repository.DeleteAsync(product);

        return true;
    }
}
