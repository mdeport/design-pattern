public abstract class StrategieNotification
{
    public abstract void Envoyer(string message);
}

public class NotificationEmail : StrategieNotification
{
    private string contexte;

    public NotificationEmail(string contexte)
    {
        this.contexte = contexte;
    }

    public override void Envoyer(string message)
    {
        Console.WriteLine($"Email - {contexte}: {message}");
    }
}

public class NotificationSMS : StrategieNotification
{
    private string contexte;

    public NotificationSMS(string contexte)
    {
        this.contexte = contexte;
    }

    public override void Envoyer(string message)
    {
        Console.WriteLine($"SMS - {contexte}: {message}");
    }
}

public class NotificationPush : StrategieNotification
{
    private string contexte;

    public NotificationPush(string contexte)
    {
        this.contexte = contexte;
    }

    public override void Envoyer(string message)
    {
        Console.WriteLine($"Push - {contexte}: {message}");
    }
}

public class Notification
{
    private StrategieNotification strategie;

    public Notification(StrategieNotification strategie)
    {
        this.strategie = strategie;
    }

    public void Envoyer(string message)
    {
        strategie.Envoyer(message);
    }
}