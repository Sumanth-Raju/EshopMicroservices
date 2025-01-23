using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public class CreateProductCommand : IRequest<CreateProductResult>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Category { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }

        // Parameterized constructor
        public CreateProductCommand(Guid id, string name, string description, List<string> category, string imageFile, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            ImageFile = imageFile;
            Price = price;
        }

        // Parameterless constructor (optional)
        public CreateProductCommand()
        {
            Category = new List<string>();
        }
    }
    public class CreateProductResult {
        public Guid Id { get; set; }
        public CreateProductResult(Guid Id)
        {
            Id = Id;
        }
        
    }

    internal class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        // how to trigger handler with the comand class add IRequest by installing mediatr
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // business logic to create a product
            throw new NotImplementedException();
        }
    }
}
