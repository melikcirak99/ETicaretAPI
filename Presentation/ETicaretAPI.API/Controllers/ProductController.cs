using ETicaretAPI.Application.Features.Commands.ProductImageFiles.UploadProductImageFile;
using ETicaretAPI.Application.Features.Commands.Products.CreateProduct;
using ETicaretAPI.Application.Features.Commands.Products.DeleteProduct;
using ETicaretAPI.Application.Features.Commands.Products.UpdateProduct;
using ETicaretAPI.Application.Features.Queries.ProductImages.GetProductImages;
using ETicaretAPI.Application.Features.Queries.Products.GetAllProduct;
using ETicaretAPI.Application.Features.Queries.Products.GetByIdProduct;
using ETicaretAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        readonly IMediator _mediatr;

        public ProductController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse response = await _mediatr.Send(getAllProductQueryRequest);
            return Ok(response);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response = await _mediatr.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediatr.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse response = await _mediatr.Send(updateProductCommandRequest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest deleteProductCommandRequest)
        {
            DeleteProductCommandResponse response = await _mediatr.Send(deleteProductCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadProductImageFileCommandRequest uploadProductImageFileCommandRequest)
        {
            uploadProductImageFileCommandRequest.Files = Request.Form.Files;
            UploadProductImageFileCommandResponse response = await _mediatr.Send(uploadProductImageFileCommandRequest);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetProductImages([FromRoute] GetProductImagesQueryRequest getProductImagesQueryRequest)
        {
            GetProductImagesQueryResponse response = await _mediatr.Send(getProductImagesQueryRequest);
            return Ok(response);
        }

        //[HttpDelete("[action/{id}]")]
        //public async Task<IActionResult> DeleteProductImage(string id, string imageId)
        //{
            
        //}
    }
}
