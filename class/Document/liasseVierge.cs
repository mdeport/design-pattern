public class LiasseVierge
{
    private string document { get; set; }

    public LiasseVierge(string doc)
    {
        document = doc;
    }

    public bool EstEgal(LiasseVierge l1, LiasseVierge l2)
    {
        return l1.document == l2.document;
    }
    
    public void AfficherDocument()
    {
        System.Console.WriteLine("Document: " + document);
    }
}