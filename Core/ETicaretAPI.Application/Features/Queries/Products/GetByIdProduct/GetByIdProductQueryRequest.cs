using MediatR;

namespace ETicaretAPI.Application.Features.Queries.Products.GetByIdProduct
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public string id { get; set; }
    }
}
