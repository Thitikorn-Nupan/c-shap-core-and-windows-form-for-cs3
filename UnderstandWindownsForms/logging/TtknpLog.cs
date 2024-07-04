using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandWindownsForms.logging
{
    internal class TtknpLog
    {
        public ILoggerFactory iLoggerFactory;

        public TtknpLog()
        {
            iLoggerFactory = LoggerFactory.Create(
                builder => builder
                    // add console as logging target
                    .AddConsole()
                    // add debug output as logging target
                    // set minimum level to log
                    .SetMinimumLevel(LogLevel.Debug)
            );

        }
    }
}
