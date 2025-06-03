using FlowCheck.Domain.Interfaces;
using FlowCheck.InfraData.Repository;
using JJ.Net.CrossData.CrossData;
using JJ.Net.CrossData.DTO;
using JJ.Net.CrossData.Enumerador;
using JJ.Net.CrossData.Extensao;
using JJ.Net.CrossData.Interfaces;
using JJ.Net.Data;
using JJ.Net.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowCheck.Application
{
    public static class Bootstrap
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Iniciar()
        {
            try
            {
                var services = new ServiceCollection();

                services.AddCrossData(config =>
                {
                    config.TipoBanco = TipoBancoDados.SQLite;
                    config.NomeAplicacao = "FlowCheck";
                });

                RegistrarServicos(services);

                ServiceProvider = services.BuildServiceProvider();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private static void RegistrarServicos(IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork>(provider =>
            {
                var config = provider.GetRequiredService<IConfiguracaoBancoDados>();
                return new UnitOfWork(config.ConexaoAtiva);
            });

            services.AddSingleton<IAnotacaoRepository, AnotacaoRepository>();
        }
    }
}
