using AutoMapper;
using IFSPStore.App.Cadastros;
using IFSPStore.App.Models;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.BaseRepository;
using IFSPStore.Repository.Context;
using IFSPStore.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        // Classe static: Classe que não ser instanciada
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de Dados
            // Configuração do Banco na Injeção de Dependência
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");

            // Lista de Serviços
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            }
            );
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();

            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();

            #endregion

            #region Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();

            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cidade, Cidade>();
                config.CreateMap<Grupo, Grupo>();
                config.CreateMap<Produto, Produto>();
                config.CreateMap<Usuario, Usuario>();
                config.CreateMap<Cidade, CidadeModel>()

                .ForMember(c => c.NomeEstado, c => c.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                config.CreateMap<Cliente, ClienteModel>()
                .ForMember(c => c.Cidade, c => c.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                .ForMember(c => c.IdCidade, c => c.MapFrom(x => x.Cidade!.Id));

            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
