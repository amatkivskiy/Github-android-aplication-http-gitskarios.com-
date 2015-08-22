using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace Domain.UseCases
{
    public abstract class AbstractUseCase<TReturn, TArgument> : IUseCaseWithArgument<TReturn, TArgument>
    {
        private IDisposable subscription;

        protected abstract IObservable<TReturn> CreateObservable(TArgument arg);

        public AbstractUseCase(IScheduler observeOn, IScheduler subscribeOn)
        {
            this.ObserveOn = observeOn;
            this.SubscribeOn = subscribeOn;
        }

        public void Execute(IObserver<TReturn> subscriber, TArgument arg)
        {
                        this.subscription = this.CreateObservable(arg).SubscribeOn (this.SubscribeOn).ObserveOn (this.ObserveOn).Subscribe (subscriber);
        }

        public void UnSunscribe()
        {
            if (this.subscription != null)
            {
                this.subscription.Dispose();
            }
        }

        public IScheduler SubscribeOn
        {
            get;
            private set;
        }

        public IScheduler ObserveOn
        {
            get;
            private set;
        }
    }
}