// using Microsoft.Toolkit.Uwp.Notifications;
using CommunityToolkit.WinUI.Notifications;

new ToastContentBuilder()
    .AddText("Tjena Berra!")
    .AddButton(new ToastButton()
            .SetDismissActivation())
    .Show();