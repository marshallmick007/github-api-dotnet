﻿using GitHub.API;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.APIIntegrationTests
{
    public abstract class IntegrationTest
    {
        protected APIClient APIClient { get; private set; }

        protected IntegrationTest()
        {
            this.APIClient = this.CreateClient();
            this.Setup();
        }

        protected abstract APIClient CreateClient();
        protected virtual void Setup() { }
    }

    public abstract class BasicAuthIntegrationTest : IntegrationTest
    {
        private static readonly string USERNAME = ConfigurationManager.AppSettings["GITHUB_API_USERNAME"];
        private static readonly string PASSWORD = ConfigurationManager.AppSettings["GITHUB_API_PASSWORD"];

        protected override APIClient CreateClient()
        {
            return new APIClient(USERNAME, PASSWORD);
        }
    }
}
