using System;
using System.Collections.Generic;
using System.Drawing;

namespace EveOPreview.View
{
	/// <summary>
	/// Main view interface
	/// Presenter uses it to access GUI properties
	/// </summary>
	public interface IMainFormView : IView
	{
		bool MinimizeToTray { get; set; }

		double ThumbnailOpacity { get; set; }

		bool EnableClientLayoutTracking { get; set; }
		bool HideActiveClientThumbnail { get; set; }
		bool MinimizeInactiveClients { get; set; }
		ViewAnimationStyle WindowsAnimationStyle { get; set; }
		bool ShowThumbnailsAlwaysOnTop { get; set; }
		bool HideThumbnailsOnLostFocus { get; set; }
		bool EnablePerClientThumbnailLayouts { get; set; }

		Size ThumbnailSize { get; set; }

		bool EnableThumbnailZoom { get; set; }
		int ThumbnailZoomFactor { get; set; }
		ViewZoomAnchor ThumbnailZoomAnchor { get; set; }
		ViewZoomAnchor OverlayLabelAnchor { get; set; }

		bool ShowThumbnailOverlays { get; set; }
		bool ShowThumbnailFrames { get; set; }

		bool LockThumbnailLocation { get; set; }
		bool ThumbnailSnapToGrid { get; set; }
		int ThumbnailSnapToGridSizeX { get; set; }
		int ThumbnailSnapToGridSizeY { get; set; }

		bool EnableActiveClientHighlight { get; set; }
		Color ActiveClientHighlightColor { get; set; }
		Color OverlayLabelColor { get; set; }
		int OverlayLabelSize { get; set; }

		string IconName { get; set; }

		// Hotkeys UI support
		int SelectedCycleGroup { get; set; } // 1..5
		string CycleGroupForwardHotkeysText { get; set; }
		string CycleGroupBackwardHotkeysText { get; set; }

		/// <summary>
		/// Set full list of available client titles to show in the clients editor.
		/// </summary>
		void SetAvailableClients(IList<string> clients);

		/// <summary>
		/// Get selected clients (in order) for current SelectedCycleGroup from the UI.
		/// </summary>
		IList<string> GetSelectedClientsForCurrentGroup();

		/// <summary>
		/// Set selected clients (in order) for current SelectedCycleGroup in the UI.
		/// </summary>
		void SetSelectedClientsForCurrentGroup(IList<string> orderedClients);
		void SetDocumentationUrl(string url);
		void SetVersionInfo(string version);
		void SetThumbnailSizeLimitations(Size minimumSize, Size maximumSize);

		void Minimize();

		void AddThumbnails(IList<IThumbnailDescription> thumbnails);
		void RemoveThumbnails(IList<IThumbnailDescription> thumbnails);
		void RefreshZoomSettings();

		Action ApplicationExitRequested { get; set; }
		Action FormActivated { get; set; }
		Action FormMinimized { get; set; }
		Action<ViewCloseRequest> FormCloseRequested { get; set; }
		Action ApplicationSettingsChanged { get; set; }
		Action ThumbnailsSizeChanged { get; set; }
		Action<string> ThumbnailStateChanged { get; set; }
		Action DocumentationLinkActivated { get; set; }

		/// <summary>
		/// Raised when the user changes the selected cycle group in the Hotkeys tab.
		/// Presenter should save current group's UI to config and load the new group's settings into the view.
		/// </summary>
		Action SelectedCycleGroupChanged { get; set; }

		/// <summary>
		/// Suppress UI events while presenter is populating controls.
		/// </summary>
		void BeginUpdateUI();
		void EndUpdateUI();
	}
}