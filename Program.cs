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

        IDocumentFactory partFactory = new ParticulierDocumentFactory();
        var ribP = partFactory.CreateRIB(123);
        var attP = partFactory.CreateAttestation(123);
        System.Console.WriteLine(ribP.GenerateRIB());
        System.Console.WriteLine(attP.GenerateAttestation());

        IDocumentFactory proFactory = new ProfessionnelDocumentFactory("12345678900000");
        var ribPro = proFactory.CreateRIB(456);
        var attPro = proFactory.CreateAttestation(456);
        System.Console.WriteLine(ribPro.GenerateRIB());
        System.Console.WriteLine(attPro.GenerateAttestation());
    }
}