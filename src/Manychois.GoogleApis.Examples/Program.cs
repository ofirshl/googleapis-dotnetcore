using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Manychois.GoogleApis.Examples
{
	public class Program
	{
		static ILogger<Program> Logger;

		public static void Main(string[] args)
		{
			NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(
				Path.Combine(Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.ApplicationBasePath, "NLog.config"), false);
			var loggerFactory = new LoggerFactory();
			loggerFactory.AddNLog();

			Logger = loggerFactory.CreateLogger<Program>();

			try
			{
				var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());
				// avoid accidentially checking in sensitive data to the source control 
				if (args.Length > 0)
				{
					builder.AddJsonFile(args[0]);
				}
				else
				{
					builder.AddJsonFile("appsettings.json");
				}
				IConfigurationRoot programConfig = builder.Build();

				var program = new Program();
				program.RunAsync(programConfig, loggerFactory).ConfigureAwait(false).GetAwaiter().GetResult();

			}
			catch (Exception ex)
			{
				Logger.LogError("{0}: {1}{2}{3}", ex.GetType().Name, ex.Message, Environment.NewLine, ex.StackTrace);
			}
		}

		async Task RunAsync(IConfigurationRoot programConfig, ILoggerFactory loggerFactory)
		{
			// comment out the examples you want to skip
			try
			{
				/*
				var oauth2Examples = new OAuth2.AllExamples(programConfig, loggerFactory);
				await oauth2Examples.RunAsync().ConfigureAwait(false);
				*/
				
				var adWordsExamples = new AdWords.AllExamples(programConfig, loggerFactory);
				await adWordsExamples.RunAsync().ConfigureAwait(false);
				
			}
			catch (Exception ex)
			{
				Logger.LogError("{0}: {1}{2}{3}", ex.GetType().Name, ex.Message, Environment.NewLine, ex.StackTrace);
			}
		}
	}
}
