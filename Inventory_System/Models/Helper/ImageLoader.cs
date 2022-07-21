using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Inventory_System.Model
{
    public static class ImageLoader
    {
        public   static string imagePath = "";
        public static string fileDeletePath;
        /// <summary>
        /// Load picture images
        /// </summary>
        /// <returns></returns>
        public static string Load()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "@C://Pictures";
            fileDialog.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|PNG|*.png";
            fileDialog.FilterIndex = 1;
            fileDialog.Title = "Select Image";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return imagePath = fileDialog.FileName;
            }
            else
            {
                return imagePath;
            }

        }
        /// <summary>
        /// Load any file
        /// </summary>
        /// <returns></returns>
        public static string LoadFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); 
            fileDialog.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|PNG|*.png|PDF|*.pdf";
            fileDialog.FilterIndex = 1;
            fileDialog.Title = "Select File";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return imagePath = fileDialog.FileName;
            }
            else
            {
                return imagePath;
            }

        } 
        /// <summary>
        /// Get staff images
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MemoryStream GetStaff(string staffid)
        {
            try
            {
                MemoryStream ms = null;
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                using (SqlConnection mycon = myConHelper.GetConnection())
                {

                    SqlCommand myComand = mycon.CreateCommand();
                    myComand.Connection = mycon;
                    myComand.Parameters.Clear();
                    myComand.Parameters.AddWithValue("@staffid", staffid);
                    myComand.CommandType = CommandType.StoredProcedure;
                    myComand.CommandText = "sp_staff_passport";
                    SqlDataAdapter da = new SqlDataAdapter(myComand);

                    DataTable dt = new DataTable();
                    da.Fill(dt); 
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow Rec in dt.Rows)
                        {
                            if (Rec[0] != null)
                            {
                                byte[] pic = (byte[])Rec[0];
                                ms = new MemoryStream(pic);
                            }
                        }

                    }
                }

                return ms;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        
        }
}