namespace XamarinQCM.ViewModels
{
    public class QuickVM
    {
        private static QuickVM _quickVM;

        public static QuickVM GetQuick(){
            if (_quickVM == null)
                _quickVM = new QuickVM();
            return _quickVM;
        }

        public int cpt;

        QuickVM()
        {

        }
    }
}

