using MediatR;
using Microsoft.AspNetCore.Http;

namespace ETicaretAPI.Application.Features.Commands.ProductImageFiles.UploadProductImageFile
{
    public class UploadProductImageFileCommandRequest : IRequest<UploadProductImageFileCommandResponse>
    {
        public string id { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
