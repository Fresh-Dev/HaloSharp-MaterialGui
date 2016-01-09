using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HaloSharp.Model.Metadata;
using HaloSharp.Model.Stats.Common;

namespace MaterialHaloSharp
{    
    /// <summary>
    /// Class Tools.
    /// </summary>
    internal class Tools 
    {
        /// <summary>
        /// Scales an image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="maxWidth">The maximum width.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <returns>Image</returns>
        public static Bitmap ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            var newImage = new Bitmap(newWidth, newHeight);
            using (var graphics = Graphics.FromImage(newImage)) graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        /// <summary>
        /// Bitmaps from URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>System.Drawing.Bitmap.</returns>
        public static Bitmap BitmapFromUrl(string url)
        {
            Bitmap bmp = null;
            Stream mystream = null;
            HttpWebResponse wresp = null;
            try
            {
                var wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;
                wresp = (HttpWebResponse)wreq.GetResponse();
                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            finally
            {
                mystream?.Close();
                wresp?.Close();
            }
            return (bmp);
        }

        /// <summary>
        /// Gets the sprite from image.
        /// </summary>
        /// <param name="img">The Image</param>
        /// <param name="cropArea">The crop area.</param>
        /// <returns>System.Drawing.Bitmap.</returns>
        public static Bitmap GetSpriteFromImage(Bitmap img, Rectangle cropArea)
        {
            var bmp = new Bitmap(cropArea.Width, cropArea.Height);
            using (var gph = Graphics.FromImage(bmp)) { gph.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), cropArea, GraphicsUnit.Pixel); }
            return bmp;
        }
        
        /// <summary>
        /// Rectangle of Medals Sprite
        /// </summary>
        /// <param name="medal">The medal.</param>
        /// <returns>System.Drawing.Rectangle.</returns>
        public static Rectangle MedalSpriteRectangle(Medal medal)
        {
            return new Rectangle(medal.SpriteLocation.Left, medal.SpriteLocation.Top, medal.SpriteLocation.Width, medal.SpriteLocation.Height);
        }

        /// <summary>
        /// Gets the medal from medal list.
        /// </summary>
        /// <param name="MedalList">The medal list.</param>
        /// <param name="MedalId">The medal identifier.</param>
        /// <returns>HaloSharp.Model.Metadata.Medal.</returns>
        public static Medal GetMedalFromMedalList(List<Medal> MedalList, uint MedalId)
        {
            return MedalList.Find(item => item.Id == MedalId);
        }
        

    }

}
