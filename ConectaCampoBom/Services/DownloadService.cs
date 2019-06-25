using ConectaCampoBom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConectaCampoBom.Services
{
    public class DownloadService
    {
        public ObservableCollection<DownloadModel> Downloads { get; private set; }

        public DownloadService()
        {
            Downloads = new ObservableCollection<DownloadModel>();
        }

        public DownloadService(List<DownloadModel> lista)
        {
            Downloads = new ObservableCollection<DownloadModel>();
            lista.ForEach(e =>
            {
                Downloads.Add(e);
            });
        }
    }
}
