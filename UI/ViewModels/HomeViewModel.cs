﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace P05_01_DI_Productos_TAPIADOR_rodrigo.UI.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title;



    public HomeViewModel()
    {
        // Inicializar propiedades
        Title = "Inicio";

    }

}