

namespace DatingProgram.Forms
{
    internal static class FormsCommunicationChannel
    {
        public static MainWindow MainW
        {
            get
            {
                return mainW;
            }
            set
            {
                if (mainW != null)
                    mainW.profileMovedToArchive -= OnProfileMovedToArchive;
                
                mainW = value;

                if (value != null)
                    mainW.profileMovedToArchive += OnProfileMovedToArchive;
            }
        }
        public static ArchiveWindow ArchiveW
        {
            get
            {
                return archiveW;
            }
            set
            {
                if (archiveW != null)
                    archiveW.profileRemoved -= OnProfileMovedFromArchive;

                archiveW = value;

                if (value != null)
                    archiveW.profileRemoved += OnProfileMovedFromArchive;
            }
        }
        private static MainWindow mainW;
        private static ArchiveWindow archiveW;

        private static void OnProfileMovedToArchive() 
        {
            archiveW?.UpdateTable();
        }
        
        private static void OnProfileMovedFromArchive() 
        {
            mainW?.UpdateTable();
        }
    }
}
