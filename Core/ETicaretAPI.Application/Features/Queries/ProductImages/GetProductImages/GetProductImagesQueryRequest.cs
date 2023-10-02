using MediatR;

namespace ETicaretAPI.Application.Features.Queries.ProductImages.GetProductImages
{
    public class GetProductImagesQueryRequest : IRequest<GetProductImagesQueryResponse>
    {
        public string id { get; set; }
    }
}
