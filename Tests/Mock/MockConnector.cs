using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using EasyBot.Framework.Abstractions;

namespace Tests.Mock
{
    internal class MockConnector<TModel> : IConnector<TModel>
    {
        private readonly List<TModel> activities;

        public ReadOnlyCollection<TModel> Messages => activities.AsReadOnly();

        public MockConnector()
        {
            activities = new List<TModel>();
        }

        public async Task<string> SendActivity(TModel activity)
        {
            activities.Add(activity);

            return Guid.NewGuid().ToString();
        }


    }
}