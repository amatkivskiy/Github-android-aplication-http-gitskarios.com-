using System;
using System.Reactive.Concurrency;

namespace Domain.UseCases
{
	public interface IUseCaseWithArgument<out TReturn, in TArgument>
	{
		IScheduler SubscribeOn { get;}
		IScheduler ObserveOn { get;}
		void Execute(IObserver<TReturn> subscriber, TArgument arg);
		void UnSunscribe();
	}
}