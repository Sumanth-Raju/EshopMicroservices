using AutoMapper;
using BuildingBlocks.CQRS;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Products.CreateProduct
{
    public class CreateProductRequest : ICommand<CreateProductResult>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Category { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }

        // Parameterized constructor
        public CreateProductRequest(Guid id, string name, string description, List<string> category, string imageFile, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            ImageFile = imageFile;
            Price = price;
        }

        // Parameterless constructor (optional)
        public CreateProductRequest()
        {
            Category = new List<string>();
        }
    }
    public class CreateProductResponse
    {
        public Guid Id { get; set; }
        public CreateProductResponse(Guid id)
        {
            Id = id;
        }
        public CreateProductResponse() { }

    }
    public class CreateProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISender _sender;

        public CreateProductController(IMapper mapper, ISender sender)
        {
            _mapper = mapper;
            _sender = sender;
        }

        [HttpPost, Route("/product")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            var command = _mapper.Map<CreateProductCommand>(request);
            var result = await _sender.Send(command);
            
            var response = _mapper.Map<CreateProductResponse>(result);
            return Ok($"product created {response.Id}");
        }
    }
}
