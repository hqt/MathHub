using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Core.Infrastructure
{
    public interface ILogger
    {
        void Info(object source, object message);
        void Warn(object source, object message);
        void Error(object source, object message);
        void Fatal(object source, object message);
        void Debug(object source, object message);
        void EnsureInitialized();
        string SerializeException(Exception e);
    }
}
