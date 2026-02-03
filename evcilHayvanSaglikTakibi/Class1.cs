using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace ModernUI
{
    [ToolboxItem(true)]
    public class EllipseTool : Component
    {
        // Köşe yuvarlatmayı yapan WinAPI
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private int radius = 30;
        private Control targetControl;

        [Category("Elipse")]
        public int CornerRadius
        {
            get => radius;
            set
            {
                radius = value;
                ApplyElipse();
            }
        }

        [Category("Elipse")]
        public Control TargetControl
        {
            get => targetControl;
            set
            {
                targetControl = value;
                ApplyElipse();

                if (targetControl != null)
                    targetControl.SizeChanged += (s, e) => ApplyElipse();
            }
        }

        private void ApplyElipse()
        {
            if (targetControl == null) return;

            targetControl.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    targetControl.Width,
                    targetControl.Height,
                    radius,
                    radius
                ));
        }
    }
}
