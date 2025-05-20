namespace BikeManagementSystemDesktop
{
    /// <summary>
    /// Utility class related to GUI.
    /// </summary>
    public class GuiUtils
    {
        private GuiUtils() {}

        /// <summary>
        /// Displays error dialog message.
        /// </summary>
        /// 
        /// <param name="parrent">Who owns dialog, where to center</param>
        /// <param name="msg">What to display</param>
        public static void ShowError(IWin32Window parrent,string msg)
        {
            MessageBox.Show(parrent, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Delegate used in form submitting.
        /// </summary>
        /// 
        /// <typeparam name="T">Form submit return type</typeparam>
        /// <param name="fieldValue">What to send to callback</param>
        /// 
        /// <returns>Type returned on form submit</returns>
        public delegate T SimpleFormSubmit<T>(string fieldValue);

        /// <summary>
        /// Makes images in given column scale to cell size.
        /// </summary>
        /// 
        /// <param name="table">Where to look for column</param>
        /// <param name="imageColumnIndex">Which column cells to scale</param>
        public static void FixImageScaling(DataGridView table, int imageColumnIndex)
        {
            DataGridViewImageColumn images = (DataGridViewImageColumn)table.Columns[imageColumnIndex];
            images.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
