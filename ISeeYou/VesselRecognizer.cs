using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.CvEnum;


namespace ISeeYou
{
    class VesselRecognizer
    {
        private Mat tmpMatImage;

        public VesselRecognizer(String newImage)
        {

            try
            {
                this.tmpMatImage = CvInvoke.Imread(newImage);
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }

         public void recognizeVessel()
        {
            this.transformateToScaleGrey();
            CvInvoke.Imshow("Scale of gray", this.tmpMatImage);
        }

        private void transformateToScaleGrey()
        {
            CvInvoke.CvtColor(this.tmpMatImage,this.tmpMatImage,ColorConversion.Bgr2Gray);
        }

        
    }
}
