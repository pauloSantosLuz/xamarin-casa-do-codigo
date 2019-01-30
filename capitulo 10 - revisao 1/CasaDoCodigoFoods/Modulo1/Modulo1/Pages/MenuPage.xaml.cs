﻿using Modulo1.Dal;
using Modulo1.Pages.Clientes;
using Modulo1.Pages.Configuracao;
using Modulo1.Pages.Entregadores;
using Modulo1.Pages.Garcons;
using Modulo1.Pages.Graficos;
using Modulo1.Pages.ItensCardapio;
using Modulo1.Pages.Pedidos;
using Modulo1.Pages.TiposItensCardapio;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modulo1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void GarconsOnClicked(object sender, EventArgs args)
        {
            ConfiguracaoDAL dal = new ConfiguracaoDAL();
            if (dal.GetConfiguracao() == null)
            {
                await DisplayAlert("Erro", "Dispositivo sem configuração", "Ok");
            }
            else
            {
                await Navigation.PushAsync(new GarconsPage());
            }
        }

        private async void EntregadoresOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EntregadoresPage());
        }

        private async void TiposItensCardapioOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TiposItensCardapioPage());
        }

        private async void ItensCardapioOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ItensCardapioPage());
        }

        private async void ConfiguracoesOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConfiguracoesPage());
        }

        private async void ClientesOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ClientesListPage());
        }

        private async void PedidosOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PedidosPage());
        }

        private async void GraficosOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GraficoDeBarrasDePedidosPorDiaPage());
        }
    }
}