using MediatR;

namespace ETicaretAPI.Application.Features.Commands.Products.DeleteProduct
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public string id { get; set; }
    }
}
