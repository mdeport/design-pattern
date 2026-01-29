## Exercice 1

1.1 Le design pattern est le singleton. Parce qu'il va garantir qu'une seul instance, tout en fournissant un point d'accès global à cette instance.

1.2 
![alt text](<Uml 1.png>)

1.3
```Csharp
public sealed class Configuration
{
    private static readonly System.Lazy<Configuration> _instance =
        new System.Lazy<Configuration>(() => new Configuration());

    public static Configuration Instance => _instance.Value;

    public string ConnectionString { get; set; }
    public string Langue { get; set; }
    public string ZoneHoraire { get; set; }

    private Configuration()
    {
        ConnectionString = "";
        Langue = "";
        ZoneHoraire = "";
    }
}
```

1.4 

Les avantages sont :
- Garantit une seule instance
- Fournit un point d'accès global

Les inconvénients sont :

- Difficile à tester
- Violation potentielle de SRP


## Exercice 2

2.1 le pattern utilisé est la Factory method.

2.2 

Les participants du pattern sont : 
- IVehicle : abstrait
- Car, Motorcycle, Truck : concrets enfant de IVehicle
- VehicleFactory : Créateur abstrait
- CarFactory, MotorcycleFactory, TruckFactory : Créateurs concrets

2.3 

La méthode `OrderVehicle()` est une methode qui va définir comment vont se dérouler les étapes de la création du véhicule. C'est une méthode template.

2.4 

les differences fondamentales entre factory method et abstract factory sont que avec factory method on va utiliser l'heritage pour créer des methods alors que avec abstract factory on va utiliser la composition pour créer des objets. On préférera factory method lorsque l'on veut laisser la responsabilité de la création d'objet à des sous-classes, et abstract factory lorsque l'on veut créer des familles d'objets liés sans spécifier leurs classes concrètes.

## Exercice 3

3.1
1. Les décorateurs devraient hériter d'une interface ou d'une classe abstraite par exemple, `ICoffee`, plutôt que de la classe concrète `Coffee`.
2. Chaque décorateur remplace complètement la description et le coût, ce qui empêche l'addition des coûts et descriptions des décorateurs précédents.
3. L'utilisation actuelle ne permet pas de combiner plusieurs décorateurs, car chaque décorateur ne peut être appliqué qu'une seule fois.

3.2
```Csharp
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

public class Coffee : ICoffee
{
    public virtual string GetDescription() => "Café simple";
    public virtual double GetCost() => 2.0;
}

public class MilkDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public MilkDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public string GetDescription() => $"{_coffee.GetDescription()}, Lait";
    public double GetCost() => _coffee.GetCost() + 0.5;
}

public class SugarDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public SugarDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public string GetDescription() => $"{_coffee.GetDescription()}, Sucre";
    public double GetCost() => _coffee.GetCost() + 0.2;
}

public class CaramelDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public CaramelDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public string GetDescription() => $"{_coffee.GetDescription()}, Caramel";
    public double GetCost() => _coffee.GetCost() + 0.8;
}
```

## Exercice 4 


4.1 

Les violations des principes SOLID dans ce code sont :
- La maintenabilité du code est dificile car a chaque car a chaque ajout d'une nouvelle condition dans le if else, on va devoir modifier la classe NotificationService.

- Ici la classe créer et envoie les notifications ce qui n'est pas un principe SOLID car une classe doit avoir une seul responsabilité.

4.2 

Le pattern qui convient le mieux a cette siguation est le pattern stratégie. Car il va permettre de définir une famille d'algorithmes, de les encapsuler chacun dans une classe séparée.


4.3 
```Csharp
public interface INotificationStrategy
{
    void SendNotification(string message);
}

public class EmailNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Envoi d'un email : {message}");
    }
}

public class SMSNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Envoi d'un SMS : {message}");
    }
}

public class PushNotificationStrategy : INotificationStrategy
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Envoi d'une notification push : {message}");
    }
}

public class NotificationService
{
    private readonly INotificationStrategy _notificationStrategy;

    public NotificationService(INotificationStrategy notificationStrategy)
    {
        _notificationStrategy = notificationStrategy;
    }

    public void SendNotification(string message)
    {
        _notificationStrategy.SendNotification(message);
    }
}
```

## Exercice 5

5.1 

Le pattern utilisé est le composite.

5.2

- `IComponent` : Définit l'interface commune aux elements de la composition, permettant de traiter les objets individuels et les compositions de manière uniforme.
- `Leaf` : Représente un objet feuille dans la composition, qui ne contient aucun autre element. Et qui va effectuer les opérations définies dans l'interface IComponent.
- `Composite` : Représente un objet qui va contenir des enfants et leur déleguer les opérations définies dans l'interface IComponent.

5.3

Un exemple concret serait la gestion d'une structure organisationnelle dans une entreprise, où chaque département peut contenir des employés ou d'autres départements, formant ainsi une hiérarchie hiérarchique.

5.4 

je ne sais pas