using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace MMtoInchconverter
{
    public class InchtoMM : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the InchtoMM class.
        /// </summary>
        public InchtoMM()
          : base("InchtoMM", "IM",
              "ConvertsInchtoMM",
              "MMtoInchconverter", "Utility")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Inch", "I", "Input values in Inches", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Millimeters", "MM", "Output values in millimeters", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            double I = 0.0;

            if (DA.GetData(0, ref I))
                return;

            double Millimeters = I * 25.4;
            DA.SetData(0,Millimeters);
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
            get { return new Guid("F0F0C7B4-1D4D-46B3-BD36E-BE7E4EF663F4"); }
        }
    }
}