using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.Tests.AdWords
{
	public class TestConfig
	{
		private static TestConfig _instance;
		private static object _lock = new object();
		public static TestConfig GetFromConfigFile()
		{
			if (_instance == null)
			{
				lock (_lock)
				{
					if (_instance == null)
					{
						var builder = new ConfigurationBuilder();
						builder.SetBasePath(Directory.GetCurrentDirectory());
						builder.AddJsonFile("appsettings.json");
						IConfigurationRoot root = builder.Build();
						string testConfigDir = root["testConfigDir"];
						_instance = new TestConfig(testConfigDir);
					}
				}
			}
			return _instance;
		}

		private string _dir;
		private string _path;

		private TestConfig(string dir)
		{
			var builder = new ConfigurationBuilder();
			builder.SetBasePath(dir);
			builder.AddJsonFile("test-config.json");
			var root = builder.Build();
			root.Bind(this);
			_dir = dir.TrimEnd('\\', '/');
			_dir = _dir + Path.DirectorySeparatorChar;
			_path = _dir + "test-config.json";
		}

		public OAuth2ConfigSection Oauth2 { get; set; }
		public AdWordsConfigSection AdWords { get; set; }

		public void Save()
		{
			var jsonSettings = new JsonSerializerSettings();
			jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
			jsonSettings.Formatting = Formatting.Indented;
			var jsonContent = JsonConvert.SerializeObject(this, jsonSettings);
			File.WriteAllText(_path, jsonContent);
		}

		public class OAuth2ConfigSection
		{
			public string CredentialJsonPath { get; set; }
			public string RefreshToken { get; set; }
			public string AccessToken { get; set; }
			public string IssuedTime { get; set; }
			public int ExpiresIn { get; set; }
		}

		public string GetFilePath(string relativePath)
		{
			return _dir + relativePath;
		}

		public class AdWordsConfigSection
		{
			public string ManagerCustomerId { get; set; }
			public string ClientCustomerId { get; set; }
			public string DeveloperToken { get; set; }
			public long CampaignId { get; set; }
		}
	}
}
