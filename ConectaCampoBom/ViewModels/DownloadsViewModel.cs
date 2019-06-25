using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class DownloadsViewModel
    {
        public IList<DownloadModel> Itens { get; private set; }

        public DownloadsViewModel()
        {
            var repo = new DownloadService();
            Itens = repo.Downloads;
        }

        public DownloadsViewModel(List<DownloadModel> lista)
        {
            var repo = new DownloadService(lista);
            Itens = repo.Downloads;
        }

        
    }
}
