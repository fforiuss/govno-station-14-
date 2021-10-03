﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Localization;

namespace Content.Client.PDA
{
    [GenerateTypedNameReferences]
    public partial class PDAMenu : SS14Window
    {
        public Button FlashLightToggleButton => FlashLightToggleButtonProtected;
        public Button EjectIdButton => EjectIdButtonProtected;
        public Button EjectPenButton => EjectPenButtonProtected;

        public Button ActivateUplinkButton => ActivateUplinkButtonProtected;

        public RichTextLabel PdaOwnerLabel => PdaOwnerLabelProtected;
        public RichTextLabel IdInfoLabel => IdInfoLabelProtected;

        public PDAMenu()
        {
            RobustXamlLoader.Load(this);

            MasterTabContainer.SetTabTitle(0, Loc.GetString("pda-bound-user-interface-main-menu-tab-title"));
        }
    }
}