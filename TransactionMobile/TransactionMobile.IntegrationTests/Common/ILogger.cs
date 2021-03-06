﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionMobile.IntegrationTests.Common
{
    public interface ILogger
    {
        void LogInformation(String message);

        void LogError(Exception ex);
    }

    public class TestingLogger : ILogger
    {
        public void LogInformation(String message)
        {
            Console.WriteLine(message);
        }

        public void LogError(Exception ex)
        {
            Console.WriteLine(ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}
