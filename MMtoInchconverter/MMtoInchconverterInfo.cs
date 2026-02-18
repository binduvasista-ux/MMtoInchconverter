using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace MMtoInchconverter
{
    public class MMtoInchconverterInfo : GH_AssemblyInfo
    {
        public override string Name => "MMtoInchconverter";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("e6d46004-5079-472b-b4fc-b07eccfcbd21");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";

        //Return a string representing the version.  This returns the same version as the assembly.
        public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
    }
}