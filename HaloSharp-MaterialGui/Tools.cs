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
using Tulpep.NotificationWindow;

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


        /// <summary>
        /// Gets the weapon from weapon list.
        /// </summary>
        /// <param name="WeaponList">The weapon list.</param>
        /// <param name="WeaponId">The weapon identifier.</param>
        /// <returns>HaloSharp.Model.Metadata.Weapon.</returns>
        public static Weapon GetWeaponFromWeaponList(List<Weapon> WeaponList, uint WeaponId)
        {
            return WeaponList.Find(item => item.Id == WeaponId);
        }

        /// <summary>
        /// Writes the given object instance to a binary file.
        /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
        /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the XML file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the XML file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object to read from the XML.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        public static void ShowNotification(string HeaderText, string BodyText)
        {
            var popupNotifier = new PopupNotifier
            {
                TitleText = HeaderText,
                TitleFont = new Font("Roboto", 14F, System.Drawing.FontStyle.Bold),
                ContentText = BodyText,
                BodyColor = Color.FromArgb(30, 30, 30),
                TitleColor = Color.LightGray,
                ContentColor = Color.LightGray,
                Image = Tools.ScaleImage(Properties.Resources.Unbenannt_1,64,64),
                ShowGrip = false
            };
            popupNotifier.AnimationDuration = 2000;
            popupNotifier.Popup();
        }

        /// <summary>
        /// Checks if a given file exists.
        /// </summary>
        /// <param name="Filename">The filename to check for existance.</param>
        /// <param name="CaseSensitive">Whether or not the search should be case-sensitive.</param>
        /// <returns>True if the given file exists, false if it does not.</returns>
        public static bool FileExists(string Filename, bool CaseSensitive=true)
        {
            // first, check if this file exists not counting cast
            bool FileExists = File.Exists(Filename);

            // if they don't care about case, just return what we already know
            if (!CaseSensitive)
            {
                return FileExists;
            }

            // if this file didn't exist, just return now
            if (!FileExists)
            {
                return false;
            }

            // to check the case, we're going to get a file list from the directory to compare against
            FileInfo Info = new FileInfo(Filename);
            FileInfo[] Files = Info.Directory.GetFiles(Filename, SearchOption.TopDirectoryOnly);

            // since we specified the filename as a pattern, we should have gotten exactly that one file returned
            System.Diagnostics.Debug.Assert(Files.Length == 1);

            // check to make sure the one filename received matches the entered filename, case-sensitively
            return (Filename == Files[0].Name);
        }
    }

}
