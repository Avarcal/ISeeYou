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
using Emgu.CV.Structure;
using Emgu.CV.Util;


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

            // Wyświetlanie poszczególnych etapów -> Okienek można zakomentować
            CvInvoke.NamedWindow("Scale of gray",NamedWindowType.FreeRatio);
            CvInvoke.Imshow("Scale of gray", this.tmpMatImage);

            //Średnia jasność obrazu - bardzo nieprzydatna, bo daje nam za mało informacji
            MCvScalar meanValueOfImage = CvInvoke.Mean(this.tmpMatImage);

            Mat SobelX = new Mat();
            Mat SobelY = new Mat();
            Mat Sobels = new Mat();
            CvInvoke.Sobel(this.tmpMatImage, SobelX, tmpMatImage.Depth, 1, 0, 3);
            CvInvoke.Sobel(this.tmpMatImage, SobelY, tmpMatImage.Depth, 0, 1, 3);

            CvInvoke.BitwiseOr(SobelX,SobelY,Sobels);

            CvInvoke.NamedWindow("Sobels", NamedWindowType.FreeRatio);
            CvInvoke.Imshow("Sobels", Sobels);


            Mat SobelEqual = new Mat();
            Sobels.CopyTo(SobelEqual);
            CvInvoke.EqualizeHist(Sobels,SobelEqual);

            Mat SobelTresh = new Mat();

            // TUTAJ TA WARTOŚć JEST PODAWANA ZE SLIDERA WIEC ZAMIAST 210 PODŁADUJ SLIDER
            int TresholdForSobel = 210;

            
            CvInvoke.Erode(SobelEqual,SobelTresh,new Mat(3,3,DepthType.Cv8U, 1), new Point(-1,-1),1,BorderType.Constant,default(MCvScalar));


            CvInvoke.NamedWindow("Erode", NamedWindowType.FreeRatio);
            CvInvoke.Imshow("Erode", SobelTresh);
            CvInvoke.Threshold(SobelEqual, SobelTresh, TresholdForSobel, 255, ThresholdType.Binary);
            CvInvoke.Dilate(SobelTresh,SobelTresh,new Mat(3,3,DepthType.Cv8U,1),new Point(-1,-1),1,BorderType.Default, default(MCvScalar));
            CvInvoke.Erode(SobelTresh,SobelTresh,new Mat(3,3,DepthType.Cv8U,1),new Point(-1,-1),1,BorderType.Default, default(MCvScalar));
            CvInvoke.MedianBlur(SobelTresh,SobelTresh,5);


            CvInvoke.NamedWindow("SobelsThreshold", NamedWindowType.FreeRatio);
            CvInvoke.Imshow("SobelsThreshold", SobelTresh);

            Mat TempInput = new Mat();
            CvInvoke.CvtColor(this.tmpMatImage,TempInput,ColorConversion.BayerBg2Gray);
            CvInvoke.Threshold(TempInput, TempInput, 5, 255, ThresholdType.Binary);
            CvInvoke.Erode(TempInput,TempInput,new Mat(3,3,DepthType.Cv8U, 1),new Point(-1,-1),1,BorderType.Constant,default(MCvScalar));

            // CvInvoke.NamedWindow("TempInput", NamedWindowType.FreeRatio);
            // CvInvoke.Imshow("TempInput", TempInput);

            Mat VeinsWithouthCircle = new Mat(SobelTresh.Size,DepthType.Cv8U,1);
            SobelTresh.CopyTo(VeinsWithouthCircle,TempInput);

            CvInvoke.NamedWindow("VeinsWithouthCircle", NamedWindowType.FreeRatio);
            CvInvoke.Imshow("VeinsWithouthCircle", VeinsWithouthCircle);

            VectorOfColorPoint countours = new VectorOfColorPoint();
            VectorOfByte hierarchy = new VectorOfByte();

            //Tu się wypierdala ścierwo... wklejam Ci kod z C++ który działa 

            /*
             * vector<vector<Point>> contours;
             * vector<Vec4i> hierarchy;
             * findContours(VeinsWithoutCircle, contours, hierarchy, CV_RETR_LIST, CV_CHAIN_APPROX_SIMPLE, Point(0, 0));
             * 
             * Mat ContoursImage = Mat::zeros(Image.size(), CV_8UC3);
             * Scalar color;
             * for (int i = 0; i < contours.size(); i++)
             * {
             * color = Scalar(rand() % 255, rand() % 255, rand() % 255);
             * if (contours[i].size() > 15) {
             * drawContours(ContoursImage, contours, i, color, 1, 8, hierarchy);
             * }
             * namedWindow("ContoursImage", CV_WINDOW_NORMAL);
             * resizeWindow("ContoursImage", 669, 500);
             * imshow("ContoursImage", ContoursImage);
             *
             *  erode(SobelThresh, SobelThresh, Mat(), Point(-1, -1), 3);
             *  dilate(SobelThresh, SobelThresh, Mat());
             *  
             * 
             * 
             */
            CvInvoke.FindContours(VeinsWithouthCircle, countours, hierarchy, RetrType.List, ChainApproxMethod.ChainApproxSimple, new Point(0, 0));

            Mat DrawImage = new Mat(SobelTresh.Size, DepthType.Cv8U, 3);


            for (int i = 0; i < countours.Size; i++)
            {
                Random rnd = new Random(255);
                MCvScalar color = new MCvScalar(System.Convert.ToDouble(rnd), System.Convert.ToDouble(rnd), System.Convert.ToDouble(rnd));
                
                {
                    
                }
                CvInvoke.DrawContours(DrawImage, countours, i, color, 1, LineType.EightConnected, hierarchy);
            }


            CvInvoke.NamedWindow("DrawImage", NamedWindowType.FreeRatio);
            CvInvoke.Imshow("DrawImage", DrawImage);




        }

        private void transformateToScaleGrey()
        {
            CvInvoke.CvtColor(this.tmpMatImage,this.tmpMatImage,ColorConversion.Bgr2Gray);
        }

        
    }
}
