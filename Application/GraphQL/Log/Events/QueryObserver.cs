using System.IO;
using System.Text;
using HotChocolate.Execution;
using Microsoft.Extensions.DiagnosticAdapter;
using Microsoft.Extensions.Logging;

namespace Application.GraphQL.Log.Events
{
    public class QueryObserver : ObserverBase
    {
        private readonly ILogger<QueryObserver> _logger;
        private bool ShouldLog = true;
        public QueryObserver(ILogger<QueryObserver> logger)
        {
            _logger = logger;
        }

        [DiagnosticName("HotChocolate.Execution.Query")]
        public void OnQuery(IQueryContext context)
        {
            return;
            // This method is used to enable start/stop events for query.
        }

        [DiagnosticName("HotChocolate.Execution.Query.Start")]
        public void BeginQueryExecute(IQueryContext context)
        {
            //TODO: Add check for variables. Case: query variables(like $id) are not parsed automatically.
            ShouldLog = !context.Request.Query.ToString().Contains("query IntrospectionQuery");
            if (ShouldLog)
                _logger.LogWarning(context.Request.Query.ToString());
        }

        [DiagnosticName("HotChocolate.Execution.Query.Stop")]
        public void EndQueryExecute(IQueryContext context)
        {
            if (!ShouldLog)
                return;
            using (var stream = new MemoryStream())
            {
                var resultSerializer = new JsonQueryResultSerializer();
                resultSerializer.SerializeAsync(
                    (IReadOnlyQueryResult)context.Result,
                    stream).Wait();
                if (Encoding.UTF8.GetString(stream.ToArray()).Contains("String type is most often used by GraphQL to represent free-form human-readable text"))
                    return;
                _logger.LogInformation("\n" +
                    Encoding.UTF8.GetString(stream.ToArray()));
            }
            ShouldLog = false;
        }
    }
}
