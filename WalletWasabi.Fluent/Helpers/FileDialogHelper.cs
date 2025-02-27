﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;

namespace WalletWasabi.Fluent.Helpers
{
	public static class FileDialogHelper
	{
		public static async Task<string?> ShowOpenFileDialogAsync(string title)
		{
			var ofd = CreateOpenFileDialog(title);
			return await GetDialogResult(ofd);
		}

		public static async Task<string?> ShowOpenFileDialogAsync(string title, string[] filterExtTypes)
		{
			var ofd = CreateOpenFileDialog(title);
			ofd.Filters = GenerateFilters(filterExtTypes);
			return await GetDialogResult(ofd);
		}

		private static async Task<string?> GetDialogResult(OpenFileDialog ofd)
		{
			var window = ((IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime).MainWindow;
			var selected = await ofd.ShowAsync(window);

			return selected.FirstOrDefault();
		}

		private static OpenFileDialog CreateOpenFileDialog(string title)
		{
			var ofd = new OpenFileDialog
			{
				AllowMultiple = false,
				Title = title,
			};

			SetDefaultDirectory(ofd);

			return ofd;
		}

		private static List<FileDialogFilter> GenerateFilters(string[] filterExtTypes)
		{
			var filters = new List<FileDialogFilter>();

			var generatedFilters =
				filterExtTypes
					.Where(x => x != "*")
					.Select(ext =>
						new FileDialogFilter
						{
							Name = $"{ext.ToUpper()} files",
							Extensions = new List<string> { ext }
						});

			filters.AddRange(generatedFilters);

			if (filterExtTypes.Contains("*"))
			{
				filters.Add(new FileDialogFilter()
				{
					Name = "All files",
					Extensions = new List<string> { "*" }
				});
			}

			return filters;
		}

		private static void SetDefaultDirectory(FileSystemDialog sfd)
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				sfd.Directory = Path.Combine("/media", Environment.UserName);
			}

			if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			{
				sfd.Directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			}
		}
	}
}