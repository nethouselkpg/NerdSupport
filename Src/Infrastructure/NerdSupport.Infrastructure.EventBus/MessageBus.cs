using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Infrastructure.Bus
{
    public class MessageBus : IMessageBus
    {
        private readonly ISubscriptionService _subscriptionService;

        public MessageBus(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        public void Publish<T>(T eventMessage)
        {
            var subscriptions = _subscriptionService.GetSubscriptions<T>();
            subscriptions.ToList().ForEach(x => PublishToConsumer(x, eventMessage));
        }

        private static void PublishToConsumer<T>(IConsumer<T> x, T eventMessage)
        {
            try
            {
                x.Handle(eventMessage);
            }
            catch (Exception e)
            {
                //log and handle internally
            }
            finally
            {
                var instance = x as IDisposable;
                if (instance != null)
                {
                    instance.Dispose();
                }
            }
        }
    }
}
