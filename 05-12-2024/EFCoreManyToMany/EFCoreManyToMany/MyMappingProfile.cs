using AutoMapper;


namespace EFCoreManyToMany
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile()
        {
           CreateMap<Database.Book, ViewModels.BookDto>()
            .ForMember(x=>x.AuthorName,x=>x.MapFrom(y=>y.Author.AuthorName))
           .ReverseMap();
            // CreateMap<ViewModels.BookDto, Database.Book>();
           CreateMap<Database.Author, ViewModels.AuthorDto>()
            .ReverseMap();
           CreateMap<Database.Category, ViewModels.CategoryDto>()
            .ReverseMap();

        }

    }
}
