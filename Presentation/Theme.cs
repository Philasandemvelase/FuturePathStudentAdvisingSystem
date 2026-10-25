using System.Drawing;
using System.Windows.Forms;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Future Path colour palette. The same values are used in every .Designer.cs file,
    /// so the Forms Designer preview matches what the running application shows.
    /// </summary>
    internal static class Theme
    {
        public static readonly Color BrandRed = Color.FromArgb(218, 30, 40);
        public static readonly Color ButtonRed = Color.FromArgb(196, 18, 32);
        public static readonly Color Ink = Color.FromArgb(33, 33, 33);
        public static readonly Color Muted = Color.FromArgb(102, 102, 102);
        public static readonly Color Page = Color.FromArgb(244, 244, 244);
        public static readonly Color Nav = Color.FromArgb(232, 232, 232);
        public static readonly Color NavActive = Color.FromArgb(253, 226, 228);
        public static readonly Color Border = Color.FromArgb(204, 204, 204);

        public static readonly Color InfoBack = Color.FromArgb(232, 240, 251);
        public static readonly Color InfoText = Color.FromArgb(31, 78, 140);
        public static readonly Color ErrorBack = Color.FromArgb(253, 232, 234);
        public static readonly Color ErrorText = Color.FromArgb(164, 22, 26);
        public static readonly Color SuccessBack = Color.FromArgb(232, 245, 233);
        public static readonly Color SuccessText = Color.FromArgb(27, 94, 32);
        public static readonly Color WarningBack = Color.FromArgb(255, 244, 214);
        public static readonly Color WarningText = Color.FromArgb(122, 82, 0);

        public static readonly Font NavFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font NavFontActive = new Font("Segoe UI", 9F, FontStyle.Bold);

        /// <summary>Creates one sidebar button. Built in code because the sidebar changes per role.</summary>
        public static Button CreateNavButton(string text)
        {
            Button button = new Button();
            button.Text = text;
            button.Width = 188;
            button.Height = 34;
            button.Margin = new Padding(0, 0, 0, 6);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.White;
            button.ForeColor = Ink;
            button.Font = NavFont;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(8, 0, 0, 0);
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
            button.FlatAppearance.BorderColor = Border;
            return button;
        }

        /// <summary>Highlights the sidebar button of the open screen.</summary>
        public static void SetNavActive(Button button, bool active)
        {
            if (active)
            {
                button.BackColor = NavActive;
                button.Font = NavFontActive;
                button.FlatAppearance.BorderColor = BrandRed;
            }
            else
            {
                button.BackColor = Color.White;
                button.Font = NavFont;
                button.FlatAppearance.BorderColor = Border;
            }
        }
    }
}
