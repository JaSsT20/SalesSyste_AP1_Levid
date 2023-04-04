using Radzen;
public static class NotificationExtensions
{
    public static void ShowNotification(this NotificationService notificationService, string title, string message, NotificationSeverity severity)
    {
        notificationService.Notify(new NotificationMessage 
        { 
            Summary = title,
            Detail = message, 
            Severity = severity });
    }

    public static void Saved(this NotificationService notificationService)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = "¡Guardado!",
                Detail = "Se ha guardado correctamente.",
                Severity = NotificationSeverity.Success
            }
        );
    }
    public static void Success(this NotificationService notificationService, string title, string message)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = title,
                Detail = message,
                Severity = NotificationSeverity.Success
            }
        );
    }

    public static void Wrong(this NotificationService notificationService, string? message)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = "Algo ha ido mal...",
                Detail = message,
                Severity = NotificationSeverity.Error
            }
        );
    }
    public static void Wrong(this NotificationService notificationService)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = "Algo ha ido mal...",
                Detail = "Parece que esta accion no ha ido bien.",
                Severity = NotificationSeverity.Error
            }
        );
    }
    public static void DataFound(this NotificationService notificationService)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = "Todo correcto",
                Detail = "Se han cargado los datos.",
                Severity = NotificationSeverity.Info
            }
        );
    }
    public static void Info(this NotificationService notificationService, string title, string message)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = title,
                Detail = message,
                Severity = NotificationSeverity.Info
            }
        );
    }
    public static void NotFound(this NotificationService notificationService)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = "Hmm...",
                Detail = "No se han encontrado datos.",
                Severity = NotificationSeverity.Warning
            }
        );
    }
}
