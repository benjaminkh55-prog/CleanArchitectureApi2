using MediatR;

namespace CleanArchitectureApi.Application.Features.Products.Commands;

public record CreateProductCommand(
    string Name,
    decimal Price,
    int CategoryId
) : IRequest<int>;
