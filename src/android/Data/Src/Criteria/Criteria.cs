using Domain.Creterias;

namespace Data
{
    public class CriteriaImpl : ICriteria
    {
        public string SearchTerm { get; private set; }

        class Builder
        {
            private string term = string.Empty;

            public Builder WithTerm(string searchTerm)
            {
                this.term = searchTerm;
                return this;
            }

            public ICriteria Build()
            {
                return new CriteriaImpl
                {
                    SearchTerm = this.term
                };
            }
        }
    }
}

