using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_JosueBenjaminCenturion
{
    public enum DesktopMaterial {
        Oak,
        Pine,
        Mahogany,
        Laminate,
        Glass
    }; 

    public class Desk
    {
        // Desk required specifications 
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINNUMOFDRAWERS = 0;
        public const int MAXNUMOFDRAWERS = 7;

        public DesktopMaterial materials;  

        public DesktopMaterial desktopMaterialProps
        {
            get { return materials; }
            set { materials = value; }
        }


        public int Depth { get; set; }
        public int Width { get; set; }
        public int Drawers { get; set; }

        public string SurfaceMaterial { get; set; }

        public Desk(int width, int depth, int drawers, string surfaceMaterial)
        {
            this.Width = width;
            this.Depth = depth;
            this.Drawers = drawers;
            this.SurfaceMaterial = surfaceMaterial;
        }



    }
}
