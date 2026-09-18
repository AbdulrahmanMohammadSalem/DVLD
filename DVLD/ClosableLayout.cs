using DVLD.Interfaces;
using System;
using System.Windows.Forms;

namespace DVLD {
    public class ClosableLayout : UserControl {
        public event Action<bool> CloseRequested;
        public event Action ForceExit;
        public event Action<DVLD_Business.Permissions> ActiveUserPermissionsChanged;

        protected virtual void OnCloseRequested(bool showBackground) => CloseRequested?.Invoke(showBackground);

        protected virtual void OnForceExit() => ForceExit?.Invoke();
        protected virtual void OnActiveUserPermissionsChanged(DVLD_Business.Permissions newValues) => ActiveUserPermissionsChanged?.Invoke(newValues);
    }
}
