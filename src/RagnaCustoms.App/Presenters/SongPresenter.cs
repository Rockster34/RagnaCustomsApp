﻿using System.Threading.Tasks;
using RagnaCustoms.Models;
using RagnaCustoms.Services;
using RagnaCustoms.Views;

namespace RagnaCustoms.Presenters
{
    public class SongPresenter
    {
        public SongPresenter(Configuration configuration, ISongView view, IDownloadingPresenter downloadingPresenter,
            ISongProvider songProvider)
        {
            Configuration = configuration;
            View = view;
            View.Presenter = this;
            View.AutoCloseDownload = AutoCloseDownload;
            View.Overlay = Overlay;
            DownloadingPresenter = downloadingPresenter;
            SongProvider = songProvider;

        }

        protected virtual Configuration Configuration { get; }
        protected virtual ISongView View { get; }
        protected virtual IDownloadingPresenter DownloadingPresenter { get; }
        protected virtual ISongProvider SongProvider { get; }

        public virtual string ApiKey
        {
            get => Configuration.ApiKey;
            set => Configuration.ApiKey = value;
        }

        public virtual bool SendScoreAutomatically
        {
            get => Configuration.SendScoreAutomatically;
            set => Configuration.SendScoreAutomatically = value;
        }

        public virtual bool Overlay
        {
            get => Configuration.Overlay;
            set => Configuration.Overlay = value;
        } 
        public virtual string BaseFolder
        {
            get => Configuration.BaseFolder;
            set => Configuration.BaseFolder = value;
        }


        public virtual bool AutoCloseDownload
        {
            get => Configuration.AutoCloseDownload;
            set => Configuration.AutoCloseDownload = value;
        }

        public virtual bool EasyStreamRequest
        {
            get => Configuration.EasyStreamRequest;
            set => Configuration.EasyStreamRequest = value;
        }

        public string Lang
        {
            get => Configuration.Lang;
            set => Configuration.Lang = value;
        }

        public void SearchLocal(string term)
        {
        }

        public async Task SearchOnlineAsync(string term)
        {
            View.Songs = await SongProvider.SearchOnlineAsync(term);
        }

        public virtual void DownloadAsync(int songId, string songFolder= null)
        {
            DownloadingPresenter.Download(songId, Configuration.AutoCloseDownload, songFolder);
            DownloadingPresenter.ShowAsPopup();
        }

        public virtual void EnableSendScoreAutomatically()
        {
            Configuration.SendScoreAutomatically = true;
        }

        public virtual void DisableSendScoreAutomatically()
        {
            Configuration.SendScoreAutomatically = true;
        }

        public virtual string GetApiKey()
        {
            return Configuration.ApiKey;
        }

        public virtual void SetApiKey(string apiKey)
        {
            Configuration.ApiKey = apiKey;
        }

        internal async Task CompareSongsAsync()
        {
            View.Songs = await SongProvider.CompareSongsWithOnlineAsync();
        }
    }
}