using System.Drawing;
using System.Windows.Forms;

namespace MoveCursor
{
    public sealed class Program
    {
        static void Main(string[] args)
        {
            var bounds = Screen.PrimaryScreen.Bounds;
            Cursor.Position = new Point(
                (bounds.Left + bounds.Right) / 2,
                (bounds.Top + bounds.Bottom) / 2);
        }
    }
}
