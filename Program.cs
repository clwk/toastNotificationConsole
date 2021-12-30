using CommunityToolkit.WinUI.Notifications;

new ToastContentBuilder()
    .AddText("Tjena Berra!")
    .AddButton(new ToastButton()
            .SetDismissActivation())
    .Show();