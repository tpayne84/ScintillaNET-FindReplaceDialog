using ScintillaNET;

namespace ScintillaNET_FindReplaceDialog
{
    public class ToolStripIncrementalSearcher : ToolStripControlHostEx
    {
        #region Properties

        public Scintilla Scintilla
        {
            get { return Searcher.Scintilla; }
            set { Searcher.Scintilla = value; }
        }


        public IncrementalSearcher Searcher
        {
            get { return Control as IncrementalSearcher; }
        }

        #endregion Properties


        #region Constructors

        public ToolStripIncrementalSearcher(Scintilla scintilla) : base(new IncrementalSearcher(true))
        {
            this.Scintilla = scintilla;
        }

        public ToolStripIncrementalSearcher() : base(new IncrementalSearcher(true))
        {
        }

        #endregion Constructors
    }
}
