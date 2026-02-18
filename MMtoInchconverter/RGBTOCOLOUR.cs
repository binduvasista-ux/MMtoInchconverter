using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using System.Drawing;

namespace MMtoInchconverter
{
    public class RGBTOCOLOUR : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the RGBTOCOLOUR class.
        /// </summary>
        public RGBTOCOLOUR()
          : base("RGBTOCOLOUR", "RGB->Clr",
              "Converts RGB values to colour",
              "MMtoInchconverter", "Display")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddIntegerParameter("R1", "R", "Provide value for Red (0-255)", GH_ParamAccess.item, 255);
            pManager.AddIntegerParameter("G1", "G", "Provide value for Green (0-255)", GH_ParamAccess.item, 255);
            pManager.AddIntegerParameter("B", "B", "Provide value for Blue (0-255)", GH_ParamAccess.item, 255);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddColourParameter("Colour", "C", "Resulting color", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int r = 0;
            int g = 0;
            int b = 0;

            if (!DA.GetData(0, ref r)) return;
            if (!DA.GetData(1, ref g)) return;
            if (DA.GetData(2, ref b)) return;

            //Clam values
            r = Clamp255(r);
            g = Clamp255(g);
            b = Clamp255(b);

            Color color = Color.FromArgb(r, g, b);

            DA.SetData(0, color);
        }

        private int Clamp255 (int values)
        {
            if (values < 0) return 0;
            if (values > 255) return 255;
            return values;
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("01ACF488-FE50-4844-8822-A785D9DA1406"); }
        }
    }
}