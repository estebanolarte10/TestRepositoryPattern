using System;

public class NegativeScoreException : Exception
{
    public NegativeScoreException()
    {
    }

    public NegativeScoreException(string message) : base(message)
    {
    }

    public NegativeScoreException(string message, Exception inner) : base(message, inner)
    {
    }
}
