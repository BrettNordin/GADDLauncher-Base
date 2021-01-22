using System;

namespace GL.Steam
{
    [Serializable]
    public class SteamWorkshopException : Exception
    {
        public SteamWorkshopException()
        {
        }

        public SteamWorkshopException(string message) : base(message)
        {
        }

        public SteamWorkshopException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}