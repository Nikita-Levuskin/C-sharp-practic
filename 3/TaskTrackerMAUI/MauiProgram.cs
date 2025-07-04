﻿using Microsoft.Extensions.Logging;
using TaskTrackerMAUI.ViewModels;
using TaskTrackerMAUI.Views;
using TaskTrackerMAUI.Services;
using TaskTrackerMAUI.Models;
using Plugin.LocalNotification;     

namespace TaskTrackerMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("bahnschrift.ttf", "Bahnschrift");
                })
                .UseLocalNotification();     

            builder.Services.AddSingleton<IDataService, SQLiteDataService>();
            builder.Services.AddSingleton<IThemeService, ThemeService>();

            builder.Services.AddSingleton<KanbanViewModel>();
            builder.Services.AddTransient<TaskDetailViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();
            builder.Services.AddTransient<NotificationsViewModel>();
            builder.Services.AddTransient<CalendarViewModel>(); 

            builder.Services.AddSingleton<KanbanPage>();
            builder.Services.AddTransient<TaskDetailPage>();
            builder.Services.AddTransient<SettingsPage>();
            builder.Services.AddTransient<NotificationsPage>();
            builder.Services.AddTransient<CalendarPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif
            var app = builder.Build();

            var themeService = app.Services.GetRequiredService<IThemeService>();
            themeService.InitializeTheme();

            return app;
        }
    }
}