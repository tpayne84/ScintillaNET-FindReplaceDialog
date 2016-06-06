using System.Windows.Forms;

namespace ScintillaNET_FindReplaceDialog
{
    public class ToolStripControlHostEx : ToolStripControlHost
    {
        public ToolStripControlHostEx() : base(new Control())
        {
        }
        public ToolStripControlHostEx(Control c) : base(c)
        {
        }
    }
}
