using System;

public class EdadInvalidaException : Exception
{
    public EdadInvalidaException(string mensaje)
        : base(mensaje)
    {
    }
}