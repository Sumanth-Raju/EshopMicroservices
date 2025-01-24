using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
    public class CreateProductCommand : ICommand<CreateProductResult>
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
        public CreateProductResult(Guid id)
        {
            Id = id;
        }
        public CreateProductResult() { }

    }

    internal class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        // how to trigger handler?  with the comand class add IRequest by installing mediatr
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // business logic to create a product

            // create product entity from command object

            // save it to database

            //return create product result

            var product = new Product
            {
                Name = command.Name,
                Description = command.Description,
                Category = command.Category,
                ImageFile = command.ImageFile,
                Price = command.Price

            };
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
