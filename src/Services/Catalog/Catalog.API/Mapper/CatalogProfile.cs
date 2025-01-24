using AutoMapper;
using Catalog.API.Products.CreateProduct;


namespace BuildingBlocks.Mapper
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile() {

            CreateMap<CreateProductRequest, CreateProductCommand>().ReverseMap();
            CreateMap<CreateProductResult, CreateProductResponse>().ReverseMap();
        }
    }
}
