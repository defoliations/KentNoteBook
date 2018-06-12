﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KentNoteBook.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace KentNoteBook.Service
{
	public class Program
	{
		public static void Main(string[] args) {
			var host = BuildWebHost(args);

			using ( var serviceScope = host.Services.GetService<IServiceScopeFactory>().CreateScope() ) {
				var context = serviceScope.ServiceProvider.GetRequiredService<KentNoteBookDbContext>();
				context.Database.Migrate();
			}

			host.Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}
