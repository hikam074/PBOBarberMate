using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBOBarberMate.View
{
    public class OutsideClickListener : IMessageFilter
    {
        private Control _popupControl;
        private Action _onOutsideClick;

        public OutsideClickListener(Control popupControl, Action onOutsideClick)
        {
            _popupControl = popupControl;
            _onOutsideClick = onOutsideClick;
        }

        public bool PreFilterMessage(ref Message m)
        {
            // WM_LBUTTONDOWN = 0x0201 (left mouse button down)
            // WM_RBUTTONDOWN = 0x0204 (right mouse button down)
            // WM_MBUTTONDOWN = 0x0207 (middle mouse button down)
            const int WM_LBUTTONDOWN = 0x0201;
            const int WM_RBUTTONDOWN = 0x0204;
            const int WM_MBUTTONDOWN = 0x0207;

            if (m.Msg == WM_LBUTTONDOWN || m.Msg == WM_RBUTTONDOWN || m.Msg == WM_MBUTTONDOWN)
            {
                // Get the mouse position in screen coordinates
                Point mousePos = Cursor.Position;

                // Check if the click is outside the popup control
                if (_popupControl != null && _popupControl.Visible)
                {
                    Rectangle popupScreenBounds = _popupControl.RectangleToScreen(_popupControl.ClientRectangle);

                    // If the click is outside the popup's bounds AND not on the button that opened it
                    // (assuming btnProfil is the button that opens the gbxShowProfile)
                    // We need a way to pass the "opener" button reference if necessary.
                    // For now, let's just check against the popup itself.
                    if (!popupScreenBounds.Contains(mousePos))
                    {
                        // Check if the click target is within the popup's children.
                        // This prevents clicks on controls *inside* the popup from closing it.
                        Control clickedControl = Control.FromHandle(m.HWnd);
                        if (clickedControl == null || (!popupScreenBounds.Contains(mousePos) && !IsChildOf(clickedControl, _popupControl)))
                        {
                            _onOutsideClick?.Invoke();
                            return true; // Consume the message so it doesn't get processed by other controls
                        }
                    }
                }
            }
            return false; // Allow other messages to be processed normally
        }

        private bool IsChildOf(Control child, Control parent)
        {
            Control current = child;
            while (current != null)
            {
                if (current == parent)
                {
                    return true;
                }
                current = current.Parent;
            }
            return false;
        }
    }
}