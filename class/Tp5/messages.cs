// Approche problématique avec explosion de classes
public class Message
{
    public string Content { get; set; }

    public string Process()
    {
        return Content;
    }
}

public class CompressedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[COMPRESSED: {Content}]";
    }
}

public class EncryptedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[ENCRYPTED: {Content}]";
    }
}

public class CompressedAndEncryptedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[ENCRYPTED: [COMPRESSED: {Content}]]";
    }
}

public class SignedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[SIGNED: {Content}]";
    }
}

public class CompressedAndSignedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[SIGNED: [COMPRESSED: {Content}]]";
    }
}

public class LoggedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[LOGGED: {Content}]";
    }
}

public class EncryptedAndSignedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[SIGNED: [ENCRYPTED: {Content}]]";
    }
}

public class CompressedEncryptedAndSignedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[SIGNED: [ENCRYPTED: [COMPRESSED: {Content}]]]";
    }
}

public class CompressedAndLoggedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[LOGGED: [COMPRESSED: {Content}]]";
    }
}

public class EncryptedAndLoggedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[LOGGED: [ENCRYPTED: {Content}]]";
    }
}