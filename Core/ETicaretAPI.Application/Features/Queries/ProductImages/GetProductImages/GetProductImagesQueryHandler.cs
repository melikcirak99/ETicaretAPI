using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Application.Features.Queries.ProductImages.GetProductImages
{
    public class GetProductImagesQueryHandler : IRequestHandler<GetProductImagesQueryRequest, GetProductImagesQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        public IConfiguration _configuration { get; }

        public GetProductImagesQueryHandler(IProductReadRepository productReadRepository, IConfiguration configuration)
        {
            _productReadRepository = productReadRepository;
            _configuration = configuration;
        }

        public async Task<GetProductImagesQueryResponse> Handle(GetProductImagesQueryRequest request, CancellationToken cancellationToken)
        {
            Product? product = await _productReadRepository
               .Table
               .Include(x => x.ProductImageFiles)
               .FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));
            return new()
            {
                Paths = product?.ProductImageFiles.Select(p => $"{_configuration["BaseStorageUrl"]}/{p.Path}").ToList()
            };
        }
    }
}
