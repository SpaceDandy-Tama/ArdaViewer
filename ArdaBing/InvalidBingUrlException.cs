﻿using System;

namespace ArdaBing
{
    [Serializable]
    class InvalidBingUrlException : Exception
    {
        public InvalidBingUrlException() { }

        public InvalidBingUrlException(string url) : base(String.Format("Invalid Bing Url: {0}", url))
        {

        }
    }
}
