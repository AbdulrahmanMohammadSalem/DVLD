using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.User_Controls;
using DVLD_Business;
using Salem.Drawing;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace DVLD.Analytics.Reports.Controls {
    public partial class Ctrl_DocumentExportSettings : UserControl {
        private enum SupportedPageSizes : byte {
            A0, A1, A2, A3, A4, A5, A6, B5, Letter, Legal, Ledger
        }

        public Ctrl_DocumentExportSettings() {
            InitializeComponent();

            cb_preferredFontFamily.DataSource = (GlobalFields.InstalledFontFamilies);
            buttonEdit3.BackColor = Settings.Default.SurfaceBackColor;
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) =>
            buttonEdit3.BackColor = Settings.Default.SurfaceBackColor;

        private void chk_useCustomPageSize_CheckedChanged(object sender, EventArgs e) {
            cb_pageSize.Enabled = !chk_useCustomPageSize.Checked;
            lbl_pageWidth.Enabled = lbl_pageHeight.Enabled = txt_pageWidth.Enabled = txt_pageHeight.Enabled = cb_pageWidthUnit.Enabled = cb_pageHeightUnit.Enabled = chk_useCustomPageSize.Checked;
            
            if (!chk_useCustomPageSize.Checked)
                cb_pageSize_SelectedIndexChanged(null, null);
        }

        private void btn_browseFolder_Click(object sender, EventArgs e) {
            if (vistaFolderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                errorProvider1.SetError(txt_fullPath, string.Empty);
                txt_fileName_TextChanged(null, null);
            }
        }

        private void txt_fileName_TextChanged(object sender, EventArgs e) {
            string _secondPart = txt_fileName.Text, _rowFileName;

            if (_secondPart.Length > 0) {
                if (_secondPart.EndsWith(".pdf"))
                    _rowFileName = _secondPart.Substring(0, _secondPart.Length - 4);
                else {
                    _rowFileName = _secondPart;
                    _secondPart += ".pdf";
                }

                if (_rowFileName.IndexOfAny(GlobalFields.InvalidFileNameChars) >= 0 || _rowFileName.ToUpper().In(GlobalFields.InvalidFileNames)) {
                    errorProvider1.SetError(txt_fileName, Str_CtrlDocumentExportSettings.invalidFileName);
                    return;
                }

                errorProvider1.SetError(txt_fileName, string.Empty);
            }

            txt_fullPath.Text = Path.Combine(vistaFolderBrowserDialog1.SelectedPath, _secondPart.TrimStart(' '));
            txt_fullPath.SelectionStart = txt_fullPath.TextLength;
        }

        private void txt_fileName_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar.In(GlobalFields.InvalidFileNameChars)) {
                e.Handled = true;
                toolTip1.Show(Str_CtrlDocumentExportSettings.invalidCharSet, txt_fileName, 0, -78, 3500);
            }
        }

        private void txt_fileName_Validating(object sender, CancelEventArgs e) {
            if (errorProvider1.GetError(txt_fileName).Length > 0)
                e.Cancel = true;
        }

        private void cb_pageSize_SelectedIndexChanged(object sender, EventArgs e) {
            cb_pageWidthUnit.SelectedIndex = cb_pageHeightUnit.SelectedIndex = 0;
            (float width, float height) = _GetPagePortraitDimensions((SupportedPageSizes) cb_pageSize.SelectedIndex);

            if (cb_pageOrientation.SelectedIndex == 0) //Portrait
                (txt_pageWidth.Text, txt_pageHeight.Text) = (width.ToString(), height.ToString());
            else //Landscape
                (txt_pageWidth.Text, txt_pageHeight.Text) = (height.ToString(), width.ToString());
        }

        private (float width, float height) _GetPagePortraitDimensions(SupportedPageSizes size) {
            switch (size) {
                case SupportedPageSizes.A0: return (84.1F, 118.9F);
                case SupportedPageSizes.A1: return (59.4F, 84.1F);
                case SupportedPageSizes.A2: return (42F, 59.4F);
                case SupportedPageSizes.A3: return (29.7F, 42F);
                case SupportedPageSizes.A4: return (21F, 29.7F);
                case SupportedPageSizes.A5: return (14.85F, 21F);
                case SupportedPageSizes.A6: return (10.5F, 14.85F);
                case SupportedPageSizes.B5: return (17.6F, 25F);
                case SupportedPageSizes.Letter: return (21.59F, 27.94F);
                case SupportedPageSizes.Legal: return (21.59F, 35.56F);
                case SupportedPageSizes.Ledger: return (27.94F, 43.18F);
                default: throw new ArgumentOutOfRangeException(nameof(size));
            }
        }

        private void Ctrl_DocumentExportSettings_Load(object sender, EventArgs e) {
            cb_preferredFontFamily.Text = Settings.Default.CurrentLanguage == SupportedLanguages.English ? "Segoe UI Variable Text" : "Calibri";
            cb_preferredFontFamily.SelectionLength = 0;
            cb_pageSize.SelectedIndex = 4;
        }

        private void cb_pageOrientation_SelectedIndexChanged(object sender, EventArgs e) {
            if (!chk_useCustomPageSize.Checked)
                (txt_pageWidth.Text, txt_pageHeight.Text) = (txt_pageHeight.Text, txt_pageWidth.Text); 
        }

        private void txt_pageDimension_KeyPress(object sender, KeyPressEventArgs e) => CommonEventHandlers.UnsignedDecimalInput(sender as TextBox, e);

        private void txt_pageDimension_TextChanged(object sender, EventArgs e) {
            if (!chk_useCustomPageSize.Checked)
                return;

            if (float.TryParse(txt_pageWidth.Text, out float _width) && float.TryParse(txt_pageHeight.Text, out float _height)) {
                if (cb_pageWidthUnit.SelectedIndex == 0) //cm
                    _width *= 10;
                else if (cb_pageWidthUnit.SelectedIndex == 2) //in
                    _width *= 25.4F;

                if (cb_pageHeightUnit.SelectedIndex == 0) //cm
                    _height *= 10;
                else if (cb_pageHeightUnit.SelectedIndex == 2) //in
                    _height *= 25.4F;

                cb_pageOrientation.SelectedIndex = _width > _height ? 1 : 0;
            }
        }

        private void cb_pageDimensionUnit_SelectedIndexChanged(object sender, EventArgs e) => txt_pageDimension_TextChanged(null, null);

        public bool ValidateFields() {
            bool _result = true;

            if (txt_fileName.Text == string.Empty) {
                _result = false;
                errorProvider1.SetError(txt_fileName, Str_CtrlDocumentExportSettings.youMustProvideFileName);
            } else
                errorProvider1.SetError(txt_fileName, string.Empty);

            if (vistaFolderBrowserDialog1.SelectedPath == string.Empty) {
                _result = false;
                errorProvider1.SetError(txt_fullPath, Str_CtrlDocumentExportSettings.youMustChooseFolder);
            } else
                errorProvider1.SetError(txt_fullPath, string.Empty);

            if (!float.TryParse(txt_pageWidth.Text, out _)) {
                _result = false;
                errorProvider1.SetError(txt_pageWidth, Resources.txt_enterValidDecimalValue);
            } else
                errorProvider1.SetError(txt_pageWidth, string.Empty);

            if (!float.TryParse(txt_pageHeight.Text, out _)) {
                _result = false;
                errorProvider1.SetError(txt_pageHeight, Resources.txt_enterValidDecimalValue);
            } else
                errorProvider1.SetError(txt_pageHeight, string.Empty);

            if (!float.TryParse(txt_hMargin.Text, out _)) {
                _result = false;
                errorProvider1.SetError(txt_hMargin, Resources.txt_enterValidDecimalValue);
            } else
                errorProvider1.SetError(txt_hMargin, string.Empty);

            if (!float.TryParse(txt_vMargin.Text, out _)) {
                _result = false;
                errorProvider1.SetError(txt_vMargin, Resources.txt_enterValidDecimalValue);
            } else
                errorProvider1.SetError(txt_vMargin, string.Empty);

            return _result;
        }

        public DocumentExportSettings GetExportSettings() {
            float _width = float.Parse(txt_pageWidth.Text), _height = float.Parse(txt_pageHeight.Text), _hMargin = float.Parse(txt_hMargin.Text), _vMargin = float.Parse(txt_vMargin.Text);

            if (cb_pageWidthUnit.SelectedIndex == 0) //cm
                _width *= 10;
            else if (cb_pageWidthUnit.SelectedIndex == 2) //in
                _width *= 25.4F;

            if (cb_pageHeightUnit.SelectedIndex == 0) //cm
                _height *= 10;
            else if (cb_pageHeightUnit.SelectedIndex == 2) //in
                _height *= 25.4F;

            if (cb_hMarginUnit.SelectedIndex == 0) //cm
                _hMargin *= 10;
            else if (cb_hMarginUnit.SelectedIndex == 2) //in
                _hMargin *= 25.4F;

            if (cb_vMarginUnit.SelectedIndex == 0) //cm
                _vMargin *= 10;
            else if (cb_vMarginUnit.SelectedIndex == 2) //in
                _vMargin *= 25.4F;

            return new DocumentExportSettings(txt_fullPath.Text, cb_preferredFontFamily.Text, (_width, _height), (_hMargin, _vMargin), chk_openAfterSaving.Checked, chk_includeDateTime.Checked, chk_includeDvldLogo.Checked, chk_colorful.Checked);
        }
    }
}
