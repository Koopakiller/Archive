﻿using GalaSoft.MvvmLight;

namespace Koopakiller.Apps.MultiDimensionalMindManager.ViewModel
{
    public class HamburgerMenuItemViewModel:ViewModelBase
    {
        public string Header { get; set; }

        public ViewModelBase ViewModel { get; set; }

        public string Glyph { get; set; }
    }
}
