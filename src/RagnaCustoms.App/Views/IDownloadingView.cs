﻿using RagnaCustoms.Presenters;

namespace RagnaCustoms.Views
{
    public interface IDownloadingView : IView
    {
        DownloadingPresenter Presenter { set; }
        int DownloadPercent { get; set; }

        void ShowSuccessMessage(string message, string title);
    }
}
