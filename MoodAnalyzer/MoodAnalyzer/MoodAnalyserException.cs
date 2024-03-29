﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerP
{
    public class MoodAnalyserException : Exception
    {

        public enum ExceptionType
        {
            NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}