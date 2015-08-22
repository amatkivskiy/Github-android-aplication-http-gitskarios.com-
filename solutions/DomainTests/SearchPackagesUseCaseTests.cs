using System.Reactive;
using Domain.Creterias;
using Domain.Repository;

namespace DomainTests
{
    using NUnit.Framework;
    using System;
    using Domain;
    using Moq;
    using System.Collections.Generic;
    using Domain.UseCases;
    using System.Reactive.Concurrency;
    using System.Reactive.Linq;

    [TestFixture]
	public class SearchPackagesUseCaseTests
	{
		Mock<INuGetPackagesRepository> repository;
		Mock<ICriteria> searchCriteria;
        Mock<IObserver<IList<NuGetPackage>>> observer;

        [Test]
        public void TestPropertMethodsCalled ()
        {
            var useCase = new SearchPackagesUseCase (Scheduler.CurrentThread, Scheduler.CurrentThread, this.repository.Object);
            useCase.Execute (this.observer.Object, this.searchCriteria.Object);

            this.observer.Verify (x => x.OnNext (It.IsAny<IList<NuGetPackage>> ()), Times.Once ());
            this.observer.Verify (x => x.OnCompleted (), Times.Once ());

            this.CheckRepositoryCalled();
        }

        [SetUp]
		public void SetUp()
		{
            this.searchCriteria = new Mock<ICriteria>();

            this.repository = new Mock<INuGetPackagesRepository>();
            this.repository.Setup(packagesRepository => packagesRepository.SearchPackages(It.IsAny<ICriteria>()))
                .Returns(Observable.Return<IList<NuGetPackage>>(new List<NuGetPackage>(0)));

            this.observer = new Mock<IObserver<IList<NuGetPackage>>>();
        }

        private void CheckRepositoryCalled()
        {
            this.repository.Verify(x => x.SearchPackages(this.searchCriteria.Object), Times.Once());
        }
	}
}

