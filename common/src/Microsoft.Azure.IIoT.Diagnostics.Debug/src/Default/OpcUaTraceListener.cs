namespace Microsoft.Azure.IIoT.Diagnostics.Debug.Default {
    using System;
    using System.Diagnostics;
    using Serilog;

    /// <summary>
    /// Capture the Trace logs from OPC Foundation stack and redirect them into Serilog
    /// </summary>
    public class OpcUaTraceListener : TraceListener {
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor to create Trace listener that redirect into Serilog Debug
        /// </summary>
        /// <param name="logger"></param>
        public OpcUaTraceListener(ILogger logger) {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <inheritdoc />
        public override void Write(string message) {
            //TODO change log level
            _logger.Information(message);
        }

        /// <inheritdoc />
        public override void WriteLine(string message) {
            //TODO change log level
            _logger.Information(message);
        }

    }
}
