using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider
{
    public class DbProviderMock : IDisposable
    {
        private string _dbConnection;
        private bool _disposed = false;

        public DbProviderMock(string name = null)
        {
            _dbConnection = "OPEN";
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose (bool dispose)
        {
            if (_disposed) return;

            if (!dispose) Console.WriteLine("Developer didn't invoke Dispose()");

            _dbConnection = "CLOSE";
            Console.WriteLine($"Dispose() [destructor) invoked by GC at {DateTime.Now:hh:mm:ss:ms}. Status do {_dbConnection}");

            _disposed = true;

            GC.SuppressFinalize(this);
        }

        ~DbProviderMock()
        {
            if (!_disposed) Dispose(false);

            Console.WriteLine($"Finalize() [destructor) invoked by GC at {DateTime.Now:hh:mm:ss:ms}. Status do {_dbConnection}");
        }
    }
}
