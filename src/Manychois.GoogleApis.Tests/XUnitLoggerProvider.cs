using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Manychois.GoogleApis.Tests
{
	public class XunitLoggerProvider : ILoggerProvider
	{
		private readonly ITestOutputHelper _output;

		public XunitLoggerProvider(ITestOutputHelper output)
		{
			_output = output;
		}

		public ILogger CreateLogger(string categoryName)
		{
			return new XunitLogger(categoryName, _output);
		}

		public void Dispose() { }

		private class XunitLogger : ILogger
		{
			private readonly string _name;
			private readonly ITestOutputHelper _output;

			public XunitLogger(string name, ITestOutputHelper output)
			{
				_name = name;
				_output = output;
			}
			public IDisposable BeginScope<TState>(TState state)
			{
				return new XunitScope<TState>(state);
			}

			public bool IsEnabled(LogLevel logLevel)
			{
				return true;
			}

			public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
			{
				string message = formatter(state, exception);
				message = $"[{logLevel}] [{_name}] {message}";
				_output.WriteLine(message);
			}
		}

		private class XunitScope<TState> : IDisposable
		{
			public XunitScope(TState state)
			{
				State = state;
			}
			public TState State { get; }
			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}
	}

	public static class XunitLoggerExtensions
	{
		public static ILoggerFactory AddXunitLog(this ILoggerFactory factory, ITestOutputHelper output)
		{
			factory.AddProvider(new XunitLoggerProvider(output));
			return factory;
		}
	}
}
