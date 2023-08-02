using System;

public class EmptyNameException : Exception
{
    public EmptyNameException()
    {
    }

    public EmptyNameException(string message) : base(message)
    {
    }

    public EmptyNameException(string message, Exception inner) : base(message, inner)
    {
    }
}
