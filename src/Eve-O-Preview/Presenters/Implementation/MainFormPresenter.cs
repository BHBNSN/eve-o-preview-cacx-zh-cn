using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Drawing;
using EveOPreview.Configuration;
using EveOPreview.Mediator.Messages;
using EveOPreview.View;
using MediatR;

namespace EveOPreview.Presenters
{
	public class MainFormPresenter : Presenter<IMainFormView>, IMainFormPresenter
	{
		#region Private constants
		private const string FORUM_URL = @"https://forum.eveonline.com/t/4202";
		#endregion

		#region Private fields
		private readonly IMediator _mediator;
		private readonly IThumbnailConfiguration _configuration;
		private readonly IConfigurationStorage _configurationStorage;
		private readonly IDictionary<string, IThumbnailDescription> _descriptionsCache;
		private bool _suppressSizeNotifications;

		private bool _exitApplication;
		private bool _isLoadingUi;
		private int _currentGroup = 1;
		#endregion

		public MainFormPresenter(IApplicationController controller, IMainFormView view, IMediator mediator, IThumbnailConfiguration configuration, IConfigurationStorage configurationStorage)
			: base(controller, view)
		{
			this._mediator = mediator;
			this._configuration = configuration;
			this._configurationStorage = configurationStorage;

			this._descriptionsCache = new Dictionary<string, IThumbnailDescription>();

			this._suppressSizeNotifications = false;
			this._exitApplication = false;

			this.View.FormActivated = this.Activate;
			this.View.FormMinimized = this.Minimize;
			this.View.FormCloseRequested = this.Close;
			this.View.ApplicationSettingsChanged = this.SaveApplicationSettings;
			this.View.ThumbnailsSizeChanged = this.UpdateThumbnailsSize;
			this.View.ThumbnailStateChanged = this.UpdateThumbnailState;
			this.View.DocumentationLinkActivated = this.OpenDocumentationLink;
			this.View.ApplicationExitRequested = this.ExitApplication;

			this.View.IconName = this._configuration.IconName;
		}

		private void Activate()
		{
			this._suppressSizeNotifications = true;
			this.LoadApplicationSettings();
			this.View.SetDocumentationUrl(MainFormPresenter.FORUM_URL);
			this.View.SetVersionInfo(this.GetApplicationVersion());
			if (this._configuration.MinimizeToTray)
			{
				this.View.Minimize();
			}

			this._mediator.Send(new StartService());
			this._suppressSizeNotifications = false;
		}

		private void Minimize()
		{
			if (!this._configuration.MinimizeToTray)
			{
				return;
			}

			this.View.Hide();
		}

		private void Close(ViewCloseRequest request)
		{
			if (this._exitApplication || !this.View.MinimizeToTray)
			{
				this._mediator.Send(new StopService()).Wait();

				this._configurationStorage.Save();
				request.Allow = true;
				return;
			}

			request.Allow = false;
			this.View.Minimize();
		}

		private async void UpdateThumbnailsSize()
		{
			if (!this._suppressSizeNotifications)
			{
				this.SaveApplicationSettings();
				await this._mediator.Publish(new ThumbnailConfiguredSizeUpdated());
			}
		}

		private void LoadApplicationSettings()
		{
			this._configurationStorage.Load();
			this._isLoadingUi = true;
			this.View.BeginUpdateUI();

			this.View.MinimizeToTray = this._configuration.MinimizeToTray;

			this.View.ThumbnailOpacity = this._configuration.ThumbnailOpacity;

			this.View.EnableClientLayoutTracking = this._configuration.EnableClientLayoutTracking;
			this.View.HideActiveClientThumbnail = this._configuration.HideActiveClientThumbnail;
			this.View.MinimizeInactiveClients = this._configuration.MinimizeInactiveClients;
			this.View.WindowsAnimationStyle = ViewAnimationStyleConverter.Convert(this._configuration.WindowsAnimationStyle);
			this.View.ShowThumbnailsAlwaysOnTop = this._configuration.ShowThumbnailsAlwaysOnTop;
			this.View.HideThumbnailsOnLostFocus = this._configuration.HideThumbnailsOnLostFocus;
			this.View.EnablePerClientThumbnailLayouts = this._configuration.EnablePerClientThumbnailLayouts;

			this.View.SetThumbnailSizeLimitations(this._configuration.ThumbnailMinimumSize, this._configuration.ThumbnailMaximumSize);
			this.View.ThumbnailSize = this._configuration.ThumbnailSize;

			this.View.EnableThumbnailZoom = this._configuration.ThumbnailZoomEnabled;
			this.View.ThumbnailZoomFactor = this._configuration.ThumbnailZoomFactor;
			this.View.ThumbnailZoomAnchor = ViewZoomAnchorConverter.Convert(this._configuration.ThumbnailZoomAnchor);
			this.View.OverlayLabelAnchor = ViewZoomAnchorConverter.Convert(this._configuration.OverlayLabelAnchor);

			this.View.ShowThumbnailOverlays = this._configuration.ShowThumbnailOverlays;
			this.View.ShowThumbnailFrames = this._configuration.ShowThumbnailFrames;
			this.View.LockThumbnailLocation = this._configuration.LockThumbnailLocation;
			this.View.ThumbnailSnapToGrid = this._configuration.ThumbnailSnapToGrid;
			this.View.ThumbnailSnapToGridSizeX = this._configuration.ThumbnailSnapToGridSizeX;
			this.View.ThumbnailSnapToGridSizeY = this._configuration.ThumbnailSnapToGridSizeY;
			this.View.EnableActiveClientHighlight = this._configuration.EnableActiveClientHighlight;
			this.View.ActiveClientHighlightColor = this._configuration.ActiveClientHighlightColor;

			this.View.OverlayLabelColor = this._configuration.OverlayLabelColor;
			this.View.OverlayLabelSize = this._configuration.OverlayLabelSize;

			this.View.IconName = this._configuration.IconName;

			// Hotkeys tab: populate clients and default group
			var clients = this._configuration.GetAllKnownClients();
			this.View.SetAvailableClients(clients);
			this._currentGroup = 1;
			this.View.SelectedCycleGroup = this._currentGroup;
			this.LoadGroupToView(this._currentGroup);

			// Wire group changed handler
			this.View.SelectedCycleGroupChanged = this.OnSelectedCycleGroupChanged;
			this.View.EndUpdateUI();
			this._isLoadingUi = false;
		}

		private void OnSelectedCycleGroupChanged()
		{
			if (this._isLoadingUi) return;
			// Save current group's UI to config, then load new group's config into UI
			this.SaveGroupFromView(this._currentGroup);
			this._currentGroup = this.View.SelectedCycleGroup;
			this.View.BeginUpdateUI();
			this.LoadGroupToView(this._currentGroup);
			this.View.EndUpdateUI();
			this._configurationStorage.Save();
		}

		private void LoadGroupToView(int group)
		{
			// Set forward/backward hotkeys CSV
			var fwd = GetForwardHotkeys(group) ?? new List<string>();
			var bwd = GetBackwardHotkeys(group) ?? new List<string>();
			this.View.CycleGroupForwardHotkeysText = string.Join(",", fwd);
			this.View.CycleGroupBackwardHotkeysText = string.Join(",", bwd);
			// Set clients order
			var orderDict = GetClientsOrder(group) ?? new Dictionary<string, int>();
			var ordered = orderDict.OrderBy(kv => kv.Value).Select(kv => kv.Key).ToList();
			this.View.SetSelectedClientsForCurrentGroup(ordered);
		}

		private void SaveGroupFromView(int group)
		{
			// Save forward/backward hotkeys
			var fwdCsv = this.View.CycleGroupForwardHotkeysText ?? string.Empty;
			var bwdCsv = this.View.CycleGroupBackwardHotkeysText ?? string.Empty;
			SetForwardHotkeys(group, ParseCsv(fwdCsv));
			SetBackwardHotkeys(group, ParseCsv(bwdCsv));
			// Save clients order (only selected/checked ones, in current order)
			var selected = this.View.GetSelectedClientsForCurrentGroup() ?? new List<string>();
			var dict = new Dictionary<string, int>();
			for (int i = 0; i < selected.Count; i++)
			{
				dict[selected[i]] = i + 1;
			}
			SetClientsOrder(group, dict);
		}

		private static List<string> ParseCsv(string csv)
		{
			var list = new List<string>();
			if (!string.IsNullOrWhiteSpace(csv))
			{
				foreach (var part in csv.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					var s = part.Trim();
					if (!string.IsNullOrEmpty(s)) list.Add(s);
				}
			}
			return list;
		}

		private List<string> GetForwardHotkeys(int g) => g switch
		{
			1 => this._configuration.CycleGroup1ForwardHotkeys,
			2 => this._configuration.CycleGroup2ForwardHotkeys,
			3 => this._configuration.CycleGroup3ForwardHotkeys,
			4 => this._configuration.CycleGroup4ForwardHotkeys,
			5 => this._configuration.CycleGroup5ForwardHotkeys,
			_ => this._configuration.CycleGroup1ForwardHotkeys,
		};
		private List<string> GetBackwardHotkeys(int g) => g switch
		{
			1 => this._configuration.CycleGroup1BackwardHotkeys,
			2 => this._configuration.CycleGroup2BackwardHotkeys,
			3 => this._configuration.CycleGroup3BackwardHotkeys,
			4 => this._configuration.CycleGroup4BackwardHotkeys,
			5 => this._configuration.CycleGroup5BackwardHotkeys,
			_ => this._configuration.CycleGroup1BackwardHotkeys,
		};
		private Dictionary<string, int> GetClientsOrder(int g) => g switch
		{
			1 => this._configuration.CycleGroup1ClientsOrder,
			2 => this._configuration.CycleGroup2ClientsOrder,
			3 => this._configuration.CycleGroup3ClientsOrder,
			4 => this._configuration.CycleGroup4ClientsOrder,
			5 => this._configuration.CycleGroup5ClientsOrder,
			_ => this._configuration.CycleGroup1ClientsOrder,
		};
		private void SetForwardHotkeys(int g, List<string> v)
		{
			switch (g)
			{
				case 1: this._configuration.CycleGroup1ForwardHotkeys = v; break;
				case 2: this._configuration.CycleGroup2ForwardHotkeys = v; break;
				case 3: this._configuration.CycleGroup3ForwardHotkeys = v; break;
				case 4: this._configuration.CycleGroup4ForwardHotkeys = v; break;
				case 5: this._configuration.CycleGroup5ForwardHotkeys = v; break;
			}
		}
		private void SetBackwardHotkeys(int g, List<string> v)
		{
			switch (g)
			{
				case 1: this._configuration.CycleGroup1BackwardHotkeys = v; break;
				case 2: this._configuration.CycleGroup2BackwardHotkeys = v; break;
				case 3: this._configuration.CycleGroup3BackwardHotkeys = v; break;
				case 4: this._configuration.CycleGroup4BackwardHotkeys = v; break;
				case 5: this._configuration.CycleGroup5BackwardHotkeys = v; break;
			}
		}
		private void SetClientsOrder(int g, Dictionary<string, int> v)
		{
			switch (g)
			{
				case 1: this._configuration.CycleGroup1ClientsOrder = v; break;
				case 2: this._configuration.CycleGroup2ClientsOrder = v; break;
				case 3: this._configuration.CycleGroup3ClientsOrder = v; break;
				case 4: this._configuration.CycleGroup4ClientsOrder = v; break;
				case 5: this._configuration.CycleGroup5ClientsOrder = v; break;
			}
		}

		private async void SaveApplicationSettings()
		{
			if (this._isLoadingUi) return;
			this._configuration.MinimizeToTray = this.View.MinimizeToTray;

			this._configuration.ThumbnailOpacity = (float)this.View.ThumbnailOpacity;

			this._configuration.EnableClientLayoutTracking = this.View.EnableClientLayoutTracking;
			this._configuration.HideActiveClientThumbnail = this.View.HideActiveClientThumbnail;
			this._configuration.MinimizeInactiveClients = this.View.MinimizeInactiveClients;
			this._configuration.WindowsAnimationStyle = ViewAnimationStyleConverter.Convert(this.View.WindowsAnimationStyle);
			this._configuration.ShowThumbnailsAlwaysOnTop = this.View.ShowThumbnailsAlwaysOnTop;
			this._configuration.HideThumbnailsOnLostFocus = this.View.HideThumbnailsOnLostFocus;
			this._configuration.EnablePerClientThumbnailLayouts = this.View.EnablePerClientThumbnailLayouts;

			this._configuration.ThumbnailSize = this.View.ThumbnailSize;

			this._configuration.ThumbnailZoomEnabled = this.View.EnableThumbnailZoom;
			this._configuration.ThumbnailZoomFactor = this.View.ThumbnailZoomFactor;
			this._configuration.ThumbnailZoomAnchor = ViewZoomAnchorConverter.Convert(this.View.ThumbnailZoomAnchor);
			this._configuration.OverlayLabelAnchor = ViewZoomAnchorConverter.Convert(this.View.OverlayLabelAnchor);

			this._configuration.ShowThumbnailOverlays = this.View.ShowThumbnailOverlays;
			if (this._configuration.ShowThumbnailFrames != this.View.ShowThumbnailFrames)
			{
				this._configuration.ShowThumbnailFrames = this.View.ShowThumbnailFrames;
				await this._mediator.Publish(new ThumbnailFrameSettingsUpdated());
			}

			this._configuration.LockThumbnailLocation = this.View.LockThumbnailLocation;
			this._configuration.ThumbnailSnapToGrid = this.View.ThumbnailSnapToGrid;
			this._configuration.ThumbnailSnapToGridSizeX = this.View.ThumbnailSnapToGridSizeX;
			this._configuration.ThumbnailSnapToGridSizeY = this.View.ThumbnailSnapToGridSizeY;

			this._configuration.EnableActiveClientHighlight = this.View.EnableActiveClientHighlight;
			this._configuration.ActiveClientHighlightColor = this.View.ActiveClientHighlightColor;

			this._configuration.OverlayLabelColor = this.View.OverlayLabelColor;
			this._configuration.OverlayLabelSize = this.View.OverlayLabelSize;

			this._configuration.IconName = this.View.IconName;

			// Save current group's hotkeys and clients order
			this.SaveGroupFromView(this._currentGroup);

			this._configurationStorage.Save();

			this.View.RefreshZoomSettings();

			await this._mediator.Send(new SaveConfiguration());
		}


		public void AddThumbnails(IList<string> thumbnailTitles)
		{
			IList<IThumbnailDescription> descriptions = new List<IThumbnailDescription>(thumbnailTitles.Count);

			lock (this._descriptionsCache)
			{
				foreach (string title in thumbnailTitles)
				{
					IThumbnailDescription description = this.CreateThumbnailDescription(title);
					this._descriptionsCache[title] = description;

					descriptions.Add(description);
				}
			}

			this.View.AddThumbnails(descriptions);
		}

		public void RemoveThumbnails(IList<string> thumbnailTitles)
		{
			IList<IThumbnailDescription> descriptions = new List<IThumbnailDescription>(thumbnailTitles.Count);

			lock (this._descriptionsCache)
			{
				foreach (string title in thumbnailTitles)
				{
					if (!this._descriptionsCache.TryGetValue(title, out IThumbnailDescription description))
					{
						continue;
					}

					this._descriptionsCache.Remove(title);
					descriptions.Add(description);
				}
			}

			this.View.RemoveThumbnails(descriptions);
		}

		private IThumbnailDescription CreateThumbnailDescription(string title)
		{
			bool isDisabled = this._configuration.IsThumbnailDisabled(title);
			return new ThumbnailDescription(title, isDisabled);
		}

		private async void UpdateThumbnailState(String title)
		{
			if (this._descriptionsCache.TryGetValue(title, out IThumbnailDescription description))
			{
				this._configuration.ToggleThumbnail(title, description.IsDisabled);
			}

			await this._mediator.Send(new SaveConfiguration());
		}

		public void UpdateThumbnailSize(Size size)
		{
			this._suppressSizeNotifications = true;
			this.View.ThumbnailSize = size;
			this._suppressSizeNotifications = false;
		}

		private void OpenDocumentationLink()
		{
			// funtimes
			// https://brockallen.com/2016/09/24/process-start-for-urls-on-net-core/
			// https://github.com/dotnet/runtime/issues/17938

			// TODO Move out to a separate service / presenter / message handler
#if LINUX
			Process.Start("xdg-open", new Uri(MainFormPresenter.FORUM_URL).AbsoluteUri);
#else
			ProcessStartInfo processStartInfo = new ProcessStartInfo(new Uri(MainFormPresenter.FORUM_URL).AbsoluteUri);
			processStartInfo.UseShellExecute = true;
			Process.Start(processStartInfo);
#endif
		}

		private string GetApplicationVersion()
		{
			Version version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
			string target = "Windows";
#if LINUX
  target = "Linux";
#endif
			return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision} {target}";
		}

		private void ExitApplication()
		{
			this._exitApplication = true;
			this.View.Close();
		}
	}
}