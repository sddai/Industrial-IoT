namespace Microsoft.Azure.IIoT.Diagnostics.Debug.Default {
    using System;
    using System.Diagnostics;
    using System.IO.Compression;
    using Serilog;

    /// <summary>
    /// Capture the Trace logs from OPC Foundation stack and redirect them into Serilog
    /// </summary>
    public class OpcUaTraceListener : TraceListener {
        //private readonly ILogger _logger;

        /// <inheritdoc />
        public override string Name { get; set; } = "OpcUaTraceListener";

        ///// <summary>
        ///// Constructor to create Trace listener that redirect into Serilog Debug
        ///// </summary>
        ///// <param name="logger"></param>
        //public OpcUaTraceListener(ILogger logger) {
        //    //_logger = logger ?? throw new ArgumentNullException(nameof(logger));
        //}

        /// <inheritdoc />
        public override void Write(string message) {
            //TODO change log level
            //_logger.Information(message);
            Console.Out.WriteAsync(message);
        }

        /// <inheritdoc />
        public override void Write(object o) {
           Write(o.ToString());
        }

        /// <inheritdoc />
        public override void Write(object o, string category) {
            Write(o); //category not supported
        }

        /// <inheritdoc />
        public override void Write(string message, string category) {
            Write(message); //category not supported
        }

        /// <inheritdoc />
        public override void WriteLine(string message) {
            //TODO change log level
            //_logger.Information(message);
            Console.Out.WriteLineAsync(message);
        }

        /// <inheritdoc />
        public override void WriteLine(object o) {
            WriteLine(o.ToString());
        }

        /// <inheritdoc />
        public override void WriteLine(object o, string category) {
            WriteLine(o); //category not supported
        }

        /// <inheritdoc />
        public override void WriteLine(string message, string category) {
            WriteLine(message); //category not supported
        }

        /// <inheritdoc />
        public override int GetHashCode() {
            return Name.GetHashCode();
        }
    }
}
