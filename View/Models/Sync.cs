using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncView.Properties;

namespace SyncView.Models
{
    class Sync
    {
        public string Conexao { get; set; }
        public string Status { get; set; }

        public string Empresa { get; set; }
        public int Atraso
        {
            get; set;
        }

        public DateTime LastUpdate { get; set; }



        public Bitmap GetBitmap
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject(Status, Resources.Culture);
            }
        }
    }
}
