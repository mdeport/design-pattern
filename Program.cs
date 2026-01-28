class Program
{
    static void Main()
    {
        //Client commande1 = new ClientComptant();
        //commande1.NouvelleCommande(); 

        //Client commande2 = new ClientCredit();
        //commande2.NouvelleCommande();

        //var query = new Builder().Select("nom", "age")
        //    .From("Utilisateurs")
        //    .where("age > 18", "pays = 'France'")
        //    .In("'actif'", "en attente'")
        //    .Or("role = 'admin'", "role = 'modérateur'")
        //    .orderBy("nom")
        //    .Top(10);

        //Console.WriteLine(query.Build());

        //var insertQuery = new Builder().Insert("Utilisateurs", new Dictionary<string, object>
        //{
        //    { "nom", "'Dupont'" },
        //    { "age", 30 },
        //    { "pays", "'France'" }
        //});

        //Console.WriteLine(insertQuery.Build());

        //IDocumentFactory partFactory = new ParticulierDocumentFactory();
        //var ribP = partFactory.CreateRIB(123);
        //var attP = partFactory.CreateAttestation(123);
        //System.Console.WriteLine(ribP.GenerateRIB());
        //System.Console.WriteLine(attP.GenerateAttestation());

        //IDocumentFactory proFactory = new ProfessionnelDocumentFactory("12345678900000");
        //var ribPro = proFactory.CreateRIB(456);
        //var attPro = proFactory.CreateAttestation(456);
        //System.Console.WriteLine(ribPro.GenerateRIB());
        //System.Console.WriteLine(attPro.GenerateAttestation());

        //var habPrototype = new ContratHabitation(); 
        //var autoPrototype = new ContratAuto();
        //var viePrototype = new ContratVie();

        //Contrat contrat1 = habPrototype.Clone();
        //contrat1.NomClient = "Dupont";
        //contrat1.DateDebut = DateTime.Today;
        //contrat1.Montant = 120000m;
        //contrat1.Annexes.Add("Inventaire mobilier");
        //PrintContrat(contrat1);

        //Contrat contrat2 = autoPrototype.Clone();
        //contrat2.NomClient = "Martin";
        //contrat2.DateDebut = DateTime.Today.AddDays(7);
        //contrat2.Montant = 20000m;
        //contrat2.Annexes.Add("Annexe options : assistance 24/7");
        //PrintContrat(contrat2);

        //Contrat contrat3 = viePrototype.Clone();
        //contrat3.NomClient = "Durand";
        //contrat3.DateDebut = DateTime.Today;
        //contrat3.Montant = 50000m;
        //contrat3.Annexes.Add("Option rente majorée");
        //rintContrat(contrat3);


        //new Notification(new NotificationEmail("Commande")).Envoyer("Votre commande a été passée avec succès.");
        //new Notification(new NotificationSMS("Livraison")).Envoyer("Votre colis est en route.");
        //new Notification(new NotificationPush("Support")).Envoyer("Votre ticket de support a été mis à jour.");

        //IPaymentService service = new InternalPaymentService();
        //ProcessOrder(service, 99.99m);

        //IPaymentService adapter = new Adapter();
        //ProcessOrder(adapter, 149.99m);

        var msg1 = new Message { Content = "Hello World" };
        Console.WriteLine(msg1.Process());

        var msg2 = new CompressedAndEncryptedMessage { Content = "Secret data" };
        Console.WriteLine(msg2.Process());

        var msg3 = new CompressedEncryptedAndSignedMessage { Content = "Very important" };
        Console.WriteLine(msg3.Process());
    }

    static void ProcessOrder(IPaymentService paymentService, decimal total)
    {
        bool success = paymentService.ProcessPayment(total, "EUR");
        if (success)
        {
            Console.WriteLine("Commande traitée avec succès");
        }
    }

    static void PrintContrat(Contrat c)
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Type : {c.GetType().Name}");
        Console.WriteLine($"Client : {c.NomClient}");
        Console.WriteLine($"Date début : {c.DateDebut:d}");
        Console.WriteLine($"Montant : {c.Montant}");
        Console.WriteLine("Clauses standard :");
        foreach (var clause in c.ClausesStandard)
            Console.WriteLine($" - {clause}");
        Console.WriteLine("Annexes :");
        foreach (var annexe in c.Annexes)
            Console.WriteLine($" - {annexe}");
        Console.WriteLine("-------------------------------------------------");
    }
}