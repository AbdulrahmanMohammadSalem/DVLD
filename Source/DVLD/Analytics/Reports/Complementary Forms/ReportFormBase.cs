using Salem.Controls;
using System;

namespace DVLD.Analytics.Reports.Complementary_Forms {
    public class ReportFormBase : SalForm {
        internal event Action<int> PersonSaved;
        internal event Action ForceExit;

        protected virtual void OnPersonSaved(int personID) => PersonSaved?.Invoke(personID);

        protected virtual void OnForceExit() => ForceExit?.Invoke();
    }
}
