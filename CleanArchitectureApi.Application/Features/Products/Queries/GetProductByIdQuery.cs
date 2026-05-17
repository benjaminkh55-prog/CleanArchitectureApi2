using MediatR;
using CleanArchitectureApi.Domain.Entities;

namespace CleanArchitectureApi.Application.Features.Products.Queries;

public record GetProductByIdQuery(int Id)
    : IRequest<Product?>;
