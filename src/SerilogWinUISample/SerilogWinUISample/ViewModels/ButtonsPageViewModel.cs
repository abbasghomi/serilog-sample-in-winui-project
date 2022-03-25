using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.WinUI.Notifications;
using LoggerProject;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace SerilogWinUISample.ViewModels
{
    public partial class ButtonsPageViewModel : ObservableRecipient
    {
        private readonly ILoggerService _loggerService = Ioc.Default.GetRequiredService<ILoggerService>();

        public ButtonsPageViewModel()
        {
        }

        [ICommand]
        public async Task InformationLogAsync()
        {
            _loggerService.Log(LoggerProject.Enums.LogLevel.Information, "My Button Clicked");
            SendNotification("Logged a Information level log!");
        }

        [ICommand]
        public async Task WarningLogAsync()
        {
            _loggerService.Log(LoggerProject.Enums.LogLevel.Warning, "My Button Clicked");
            SendNotification("Logged a Warning level log!");
        }

        [ICommand]
        public async Task ErrorLogAsync()
        {
            _loggerService.Log(LoggerProject.Enums.LogLevel.Error, "My Button Clicked");
            SendNotification("Logged a Error level log!");
        }

        [ICommand]
        public async Task FatalLogAsync()
        {
            _loggerService.Log(LoggerProject.Enums.LogLevel.Fatal, "My Button Clicked");
            SendNotification("Logged a Fatal level log!");
        }

        [ICommand]
        private async Task OpenLogFolderAsync()
        {
            await OpenLogFolder();
        }

        private async Task OpenLogFolder()
        {
            if (Directory.Exists(_loggerService.GetLogFolderPath()))
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "explorer.exe";
                startInfo.Arguments = _loggerService.GetLogFolderPath();
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void SendNotification(string message)
        {
            new ToastContentBuilder()
              .SetToastScenario(ToastScenario.Default)
              .AddText(message)
              .AddButton(new ToastButton()
                  .SetDismissActivation())
              .Show();
        }
    }
}
