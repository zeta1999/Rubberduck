﻿using System;
using System.Collections.Generic;
using System.Linq;
using  Rubberduck.SourceControl;

namespace Rubberduck.UI.SourceControl
{
    public class ChangesPresenter
    {
        private readonly ISourceControlProvider _provider;
        private readonly IChangesView _view;

        public ChangesPresenter(ISourceControlProvider provider, IChangesView view)
        {
            _provider = provider;
            _view = view;

            _view.Commit += OnCommit;
            _view.RefreshData += OnRefresh;
            _view.CommitMessageChanged += OnCommitMessageChanged;
            _view.SelectedActionChanged += OnSelectedActionChanged;

            Refresh();
        }

        private void OnSelectedActionChanged(object sender, EventArgs e)
        {
            _view.CommitEnabled = ShouldEnableCommit();
        }

        private void OnCommitMessageChanged(object sender, EventArgs e)
        {
            _view.CommitEnabled = ShouldEnableCommit();
        }

        private bool ShouldEnableCommit()
        {
            return !string.IsNullOrEmpty(_view.CommitMessage) && _view.CommitAction != CommitAction.Unset;
        }

        public void Refresh()
        {
            var fileStats = _provider.Status().ToList();

            _view.IncludedChanges = fileStats.Where(stat => stat.FileStatus.HasFlag(FileStatus.Modified)).ToList();
            _view.UntrackedFiles = fileStats.Where(stat => stat.FileStatus.HasFlag(FileStatus.Untracked)).ToList();
        }

        public void Commit()
        {
            _provider.Commit(_view.CommitMessage);

            if (_view.CommitAction == CommitAction.CommitAndSync)
            {
                _provider.Pull();
                _provider.Push();
            }

            if (_view.CommitAction == CommitAction.CommitAndPush)
            {
                _provider.Push();
            }
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            Refresh();
        }

        private void OnCommit(object sender, EventArgs e)
        {
            Commit();
            _view.CommitMessage = string.Empty;
            Refresh();
        }
    }
}
