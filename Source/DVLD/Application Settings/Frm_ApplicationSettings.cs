using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Extensions;
using Salem.Controls;
using Salem.Drawing;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using DVLD.Interfaces;
using static DVLD_Business.Permissions;

namespace DVLD.Application_Settings {
    public partial class Frm_ApplicationSettings : SalForm, IEnforcePermissions {
        private float _chosenSaturation, _chosenLightness;
        private int _oldSelectedThemeIndex = -1;
        private ColorModes _selectedColorMode = ColorModes.Light;
        private Theme _selectedTheme;
        private ThemeColorPalette _selectedColorPalette;
        private bool _userChangedSelectedTheme = false;
        private readonly Font _smallItalicFont, _smallRegularFont, _bigItalicFont, _bigRegularFont;
        private string _cachedActiveThemeName;

        private string SelectedThemeText =>  $"\"{_selectedTheme.ThemeName}\" (" + (_selectedColorMode == ColorModes.Light ? cb_colorMode.Items[0] : cb_colorMode.Items[1]) + ')';

        public Frm_ApplicationSettings() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;
            
            if (GlobalFields.ToolStripRenderer.ImageMarginBackColor.IsLight()) {
                resetToolStripMenuItem.Image = Resources.Reset_Black_16;
                resetToolStripMenuItem.Tag = (byte) 1;
            } else {
                resetToolStripMenuItem.Image = Resources.Reset_White_16;
                resetToolStripMenuItem.Tag = (byte) 0;
            }

            toolTip1.ToolTipTitle = Resources.msg_notice;

             _chosenSaturation = Settings.Default.MenuStripItemBorderColor.GetSaturation();
            _chosenLightness = Settings.Default.MenuStripItemBorderColor.GetBrightness();

            cb_theme.Items.AddRange(Theme.GetAllThemeNames());

            if (GlobalFields.ActiveUserPermissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.CreateNewTheme))
                cb_theme.Items.Add(Str_FrmSettings.createNewTheme);

            _smallRegularFont = btn_baseBackColor.Font;
            _smallItalicFont = new Font(_smallRegularFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            _bigRegularFont = lbl_language.Font;
            _bigItalicFont = new Font(_bigRegularFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
        }

        private void Frm_Settings_Load(object sender, EventArgs e) {
            _selectedTheme = Theme.Find(Settings.Default.CurrentThemeID);
            _cachedActiveThemeName = _selectedTheme.ThemeName;

            lbl_colorMode.Image = Settings.Default.GetCurrentColorMode() == ColorModes.Light ? Resources.Light_32 : Resources.Dark_32;
            rb_MenuItemStyle_CheckedChanged(rb_freeValues, EventArgs.Empty);
            
            cb_language.SelectedIndex = (int) Settings.Default.CurrentLanguage;
            cb_colorMode.SelectedIndex = (int) Settings.Default.CurrentThemeColorMode;
            cb_theme.Text = _selectedTheme.ThemeName;
        }

        private void _LoadColorPaletteValues(ThemeColorPalette _palette) {
            _SetButtonColorDisplay(btn_baseBackColor, _palette.BaseBackColor);
            _SetButtonColorDisplay(btn_surfaceBackColor, _palette.SurfaceBackColor);
            _SetButtonColorDisplay(btn_baseForeColor, _palette.BaseForeColor);
            _SetButtonColorDisplay(btn_strongForeColor, _palette.StrongForeColor);
            _SetButtonColorDisplay(btn_accentForeColor, _palette.AccentForeColor);
            _SetButtonColorDisplay(btn_baseLinkColor, _palette.BaseLinkColor);
            _SetButtonColorDisplay(btn_inactiveForeColor, _palette.InactiveForeColor);
            _SetButtonColorDisplay(btn_surfaceBorderColor, _palette.SurfaceBorderColor);
            _SetButtonColorDisplay(btn_surfaceHoverColor, _palette.SurfaceHoverColor);
            _SetButtonColorDisplay(btn_inactiveTabColor, _palette.InactiveTabBackColor);
            _SetButtonColorDisplay(btn_gridHeaderCellColor, _palette.GridHeaderCellColor);
            _SetButtonColorDisplay(btn_gridHeaderHighlightColor, _palette.GridHeaderCellHighlightColor);

            trackBar1.Value = (int) _palette.MenuStripItemBorderColor.GetHue();
            btn_selectHue.Text = trackBar1.Value.ToString();

            _SetButtonColorDisplay(btn_mainMenuBackColor, _palette.MainMenuStripColor);
            _SetButtonColorDisplay(btn_menuItemHoverColor, _palette.MenuStripItemHoverBackColor);
            _SetButtonColorDisplay(btn_menuItemHoverBorderColor, _palette.MenuStripItemBorderColor);
        }

        private void btn_color_Click(object sender, EventArgs e) {
            Button _sender = sender as Button;

            colorDialog1.Color = _sender.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                if (_sender.BackColor != colorDialog1.Color) {
                    _SetButtonColorDisplay(_sender, colorDialog1.Color, true);
                    lbl_selectedTheme.Text = SelectedThemeText + '*';
                    _userChangedSelectedTheme = true;
                }
            }
        }

        private void btn_selectHue_Click(object sender, EventArgs e) {
            using (Frm_SelectHue _frmSelectHue = new Frm_SelectHue(trackBar1.Value)) {
                if (_frmSelectHue.ShowDialog() == DialogResult.OK)
                    trackBar1.Value = _frmSelectHue.SelectedValue;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            if (rb_freeValues.Checked)
                return;

            btn_selectHue.BackColor = HslColor.ToColor(255, trackBar1.Value, _chosenSaturation, _chosenLightness);
            btn_selectHue.Text = trackBar1.Value.ToString();

            if (_selectedColorMode == ColorModes.Light) {
                _SetButtonColorDisplay(btn_mainMenuBackColor, HslColor.ToColor(255, trackBar1.Value, 0.4F, 0.96F), true);
                _SetButtonColorDisplay(btn_menuItemHoverColor, HslColor.ToColor(255, trackBar1.Value, 0.73F, 0.83F), true);
                _SetButtonColorDisplay(btn_menuItemHoverBorderColor, HslColor.ToColor(255, trackBar1.Value, 1.0F, 0.42F), true);
            } else {
                _SetButtonColorDisplay(btn_mainMenuBackColor, HslColor.ToColor(255, trackBar1.Value, 0.12F, 0.05F), true);
                _SetButtonColorDisplay(btn_menuItemHoverColor, HslColor.ToColor(255, trackBar1.Value, 0.73F, 0.17F), true);
                _SetButtonColorDisplay(btn_menuItemHoverBorderColor, HslColor.ToColor(255, trackBar1.Value, 1.0F, 0.58F), true);
            }

            lbl_selectedTheme.Text = SelectedThemeText + '*';
            _userChangedSelectedTheme = true;
        }

        private void btn_apply_Click(object sender, EventArgs e) {
            if (_userChangedSelectedTheme) {
                DialogResult _dialogResult = MessageBox.Show(Str_FrmSettings.unsavedChangesExist, Resources.msg_confirm, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (_dialogResult == DialogResult.Yes) {
                    if (!_SaveChangesToSelectedTheme()) {
                        MessageBox.Show(Resources.msg_somethingWentWrongWhileSaving, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _ApplyChanges();

                    _LoadColorPaletteValues(_selectedColorPalette);
                    lbl_selectedTheme.Text = SelectedThemeText;
                    _userChangedSelectedTheme = false;
                } else if (_dialogResult == DialogResult.No)
                    _ApplyChanges();
            } else
                _ApplyChanges();
        }

        private void _ApplyChanges() {
            bool _restart = Settings.Default.CurrentLanguage != (SupportedLanguages) cb_language.SelectedIndex;

            Settings.Default.CurrentLanguage = (SupportedLanguages) cb_language.SelectedIndex;
            Settings.Default.CurrentThemeID = _selectedTheme.ThemeID;
            Settings.Default.CurrentThemeColorMode = (ColorModes) cb_colorMode.SelectedIndex;
            Settings.Default.ApplyColorPaletteSettings(_selectedColorPalette);
            Settings.Default.Save();

            if (_restart) {
                System.Windows.Forms.Application.Restart();
                return;
            }

            _cachedActiveThemeName = _selectedTheme.ThemeName;

            lbl_language.Font = lbl_colorMode.Font = lbl_theme.Font = _bigRegularFont;
            lbl_language.Text = Str_FrmSettings.language;
            lbl_colorMode.Text = Str_FrmSettings.colorMode;
            lbl_colorMode.Image = Settings.Default.GetCurrentColorMode() == ColorModes.Light ? Resources.Light_32 : Resources.Dark_32;
            lbl_theme.Text = Str_FrmSettings.theme;

            _chosenSaturation = Settings.Default.MenuStripItemBorderColor.GetSaturation();
            _chosenLightness = Settings.Default.MenuStripItemBorderColor.GetBrightness();
        }

        private void cb_theme_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_theme.SelectedIndex == _oldSelectedThemeIndex)
                return;

            if (cb_theme.SelectedIndex == cb_theme.Items.Count - 1 && GlobalFields.ActiveUserPermissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.CreateNewTheme)) {
                cb_theme.SelectedIndex = _oldSelectedThemeIndex;

                using (Frm_EnterThemeName _frmEnterThemeName = new Frm_EnterThemeName()) {
                    if (_frmEnterThemeName.ShowDialog() == DialogResult.OK)
                        _CreateNewTheme(_frmEnterThemeName.InputValue);
                }
            } else {
                _oldSelectedThemeIndex = cb_theme.SelectedIndex;
                _selectedTheme = Theme.Find(cb_theme.Text);
                _selectedColorPalette = _selectedColorMode == ColorModes.Light ? _selectedTheme.LightColorPaletteInfo : _selectedTheme.DarkColorPaletteInfo;
                ll_deleteSelectedTheme.Enabled = GlobalFields.ActiveUserPermissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.DeleteTheme) && _selectedTheme.ThemeID != Settings.Default.CurrentThemeID && _selectedTheme.ThemeID != 1;

                if (cb_theme.Text == _cachedActiveThemeName) {
                    lbl_theme.Font = _bigRegularFont;
                    lbl_theme.Text = Str_FrmSettings.theme;
                } else {
                    lbl_theme.Font = _bigItalicFont;
                    lbl_theme.Text = Str_FrmSettings.theme + '*';
                }

                _LoadColorPaletteValues(_selectedColorPalette);

                lbl_selectedTheme.Text = SelectedThemeText;
                _userChangedSelectedTheme = false;
            }
        }

        private void _CreateNewTheme(string themeName) {
            Theme _newTheme = Theme.CreateNew(themeName);

            if (_newTheme is null)
                MessageBox.Show(Resources.msg_somethingWentWrongWhileSaving, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                cb_theme.Items.Insert(cb_theme.Items.Count - 1, _newTheme.ThemeName);
                cb_theme.SelectedIndex = cb_theme.Items.Count - 2;

                MessageBox.Show(Str_FrmSettings.themeSavedSuccessfullyWithID + _newTheme.ThemeID + Environment.NewLine + Str_FrmSettings.youCanStyleNow, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rb_MenuItemStyle_CheckedChanged(object sender, EventArgs e) {
            RadioButton _sender = sender as RadioButton;

            if (!_sender.Checked)
                return;

            if (byte.Parse(_sender.Tag as string) == 0) { //Free Values
                label20.Enabled = label6.Enabled = label19.Enabled = btn_mainMenuBackColor.Enabled = btn_menuItemHoverColor.Enabled = btn_menuItemHoverBorderColor.Enabled = true;
                label21.Enabled = trackBar1.Enabled = btn_selectHue.Enabled = false;
                
                btn_selectHue.BackColor = Color.FromArgb(147, 147, 147);
            } else {
                label20.Enabled = label6.Enabled = label19.Enabled = btn_mainMenuBackColor.Enabled = btn_menuItemHoverColor.Enabled = btn_menuItemHoverBorderColor.Enabled = false;
                label21.Enabled = trackBar1.Enabled = btn_selectHue.Enabled = true;

                trackBar1_ValueChanged(trackBar1, EventArgs.Empty);
            }
        }

        private void cb_colorMode_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedColorMode = cb_colorMode.SelectedIndex == 2 ? DrawingHelpers.GetSystemTheme() : (ColorModes) cb_colorMode.SelectedIndex;
            _selectedColorPalette = _selectedColorMode == ColorModes.Light ? _selectedTheme.LightColorPaletteInfo : _selectedTheme.DarkColorPaletteInfo;

            if (cb_colorMode.SelectedIndex == (int) Settings.Default.CurrentThemeColorMode) {
                lbl_colorMode.Font = _bigRegularFont;
                lbl_colorMode.Text = Str_FrmSettings.colorMode;
            } else {
                lbl_colorMode.Font = _bigItalicFont;
                lbl_colorMode.Text = Str_FrmSettings.colorMode + '*';
            }

            _LoadColorPaletteValues(_selectedColorPalette);

            lbl_selectedTheme.Text = SelectedThemeText;
            _userChangedSelectedTheme = false;
        }

        private void ll_branchIntoNewTheme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_EnterThemeName _frmEnterThemeName = new Frm_EnterThemeName(cb_theme.Text, Str_FrmSettings.newTheme)) {
                if (_frmEnterThemeName.ShowDialog() == DialogResult.OK) {
                    Theme _newTheme = _selectedTheme.BranchIntoNewTheme(_frmEnterThemeName.InputValue);

                    if (_newTheme is null) {
                        MessageBox.Show(Str_FrmSettings.themeSaveFailed, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cb_theme.Items.Insert(cb_theme.Items.Count - 1, _newTheme.ThemeName);
                    cb_theme.SelectedIndex = cb_theme.Items.Count - 2;

                    MessageBox.Show(Str_FrmSettings.themeSavedSuccessfullyWithID + _newTheme.ThemeID + Environment.NewLine + Str_FrmSettings.youCanStyleNow, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ll_saveChangesToSelectedTheme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmSettings.savingConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (_SaveChangesToSelectedTheme()) {
                lbl_selectedTheme.Text = SelectedThemeText;
                _LoadColorPaletteValues(_selectedColorPalette);
                _userChangedSelectedTheme = false;

                MessageBox.Show(Resources.msg_dataSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show(Resources.msg_somethingWentWrongWhileSaving, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _SaveChangesToSelectedTheme() {
            _selectedColorPalette.BaseBackColor = btn_baseBackColor.BackColor;
            _selectedColorPalette.SurfaceBackColor = btn_surfaceBackColor.BackColor;
            _selectedColorPalette.BaseForeColor = btn_baseForeColor.BackColor;
            _selectedColorPalette.StrongForeColor = btn_strongForeColor.BackColor;
            _selectedColorPalette.AccentForeColor = btn_accentForeColor.BackColor;
            _selectedColorPalette.BaseLinkColor = btn_baseLinkColor.BackColor;
            _selectedColorPalette.InactiveForeColor = btn_inactiveForeColor.BackColor;
            _selectedColorPalette.SurfaceBorderColor = btn_surfaceBorderColor.BackColor;
            _selectedColorPalette.SurfaceHoverColor = btn_surfaceHoverColor.BackColor;
            _selectedColorPalette.InactiveTabBackColor = btn_inactiveTabColor.BackColor;
            _selectedColorPalette.GridHeaderCellColor = btn_gridHeaderCellColor.BackColor;
            _selectedColorPalette.GridHeaderCellHighlightColor = btn_gridHeaderHighlightColor.BackColor;

            _selectedColorPalette.MainMenuStripColor = btn_mainMenuBackColor.BackColor;
            _selectedColorPalette.MenuStripItemHoverBackColor = btn_menuItemHoverColor.BackColor;
            _selectedColorPalette.MenuStripItemBorderColor = btn_menuItemHoverBorderColor.BackColor;

            return _selectedColorPalette.Save();
        }

        private void ll_renameSelectedTheme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_EnterThemeName _frmEnterThemeName = new Frm_EnterThemeName(_selectedTheme.ThemeName, Str_FrmSettings.renameTheme)) {
                if (_frmEnterThemeName.ShowDialog() == DialogResult.OK) {
                    _selectedTheme.ThemeName = _frmEnterThemeName.InputValue;

                    if (_selectedTheme.Save()) {
                        cb_theme.Items[cb_theme.SelectedIndex] = _selectedTheme.ThemeName;
                        lbl_selectedTheme.Text = _userChangedSelectedTheme ? SelectedThemeText + '*' : SelectedThemeText;

                        MessageBox.Show(Resources.msg_dataSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(Resources.msg_somethingWentWrongWhileSaving, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ll_deleteSelectedTheme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmSettings.deletingConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (_selectedTheme.Delete()) {
                cb_theme.Items.RemoveAt(cb_theme.SelectedIndex);
                cb_theme.Text = Theme.Find(Settings.Default.CurrentThemeID).ThemeName;

                MessageBox.Show(Str_FrmSettings.themeDeletedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show(Resources.msg_errorDeleting, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
            Button _causer = contextMenuStrip1.SourceControl as Button;
            byte _causerTag = byte.Parse(_causer.Tag as string);

            switch (_causerTag) {
                case 0: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.BaseBackColor);
                    break;
                case 1: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.SurfaceBackColor);
                    break;
                case 2: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.BaseForeColor);
                    break;
                case 3: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.StrongForeColor);
                    break;
                case 4: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.AccentForeColor);
                    break;
                case 5: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.BaseLinkColor);
                    break;
                case 6: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.InactiveForeColor);
                    break;
                case 7: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.SurfaceBorderColor);
                    break;
                case 8: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.SurfaceHoverColor);
                    break;
                case 9: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.InactiveTabBackColor);
                    break;
                case 10: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.GridHeaderCellColor);
                    break;
                case 11: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.GridHeaderCellHighlightColor);
                    break;
                case 12: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.MainMenuStripColor);
                    break;
                case 13: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.MenuStripItemHoverBackColor);
                    break;
                case 14: 
                    _SetButtonColorDisplay(_causer, _selectedColorPalette.MenuStripItemBorderColor);
                    break;
            }
        }

        private void cb_language_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_language.SelectedIndex == (int) Settings.Default.CurrentLanguage) {
                lbl_language.Font = _bigRegularFont;
                lbl_language.Text = Str_FrmSettings.language;
            } else {
                lbl_language.Font = _bigItalicFont;
                lbl_language.Text = Str_FrmSettings.language + '*';
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            if (GlobalFields.ToolStripRenderer.ImageMarginBackColor.IsLight()) { //We need black
                if ((byte) resetToolStripMenuItem.Tag == 0) { //Currently white
                    resetToolStripMenuItem.Image = Resources.Reset_Black_16;
                    resetToolStripMenuItem.Tag = (byte) 1;
                }
            } else if ((byte) resetToolStripMenuItem.Tag == 1) { //We need white -- Currently black
                resetToolStripMenuItem.Image = Resources.Reset_White_16;
                resetToolStripMenuItem.Tag = (byte) 0;
            }
        }

        private void _SetButtonColorDisplay(Button target, Color value, bool _italicUnderline = false) {
            target.BackColor = value;
            target.ForeColor = value.GetContrastingTextColor();
            target.Text = value.ToHex();
            target.Font = _italicUnderline ? _smallItalicFont : _smallRegularFont;
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_language.Enabled = cb_language.Enabled = permissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.ChangeLanguage);
            lbl_colorMode.Enabled = cb_colorMode.Enabled = permissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.ChangeColorMode);
            lbl_theme.Enabled = cb_theme.Enabled = permissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.ChangeTheme);
            ll_saveChangesToSelectedTheme.Enabled = pnl_themeValues.Enabled = gb_menuItemsStyle.Enabled = permissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.EditThemeValues);
            ll_branchIntoNewTheme.Enabled = permissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.CreateNewTheme);
            ll_renameSelectedTheme.Enabled = permissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.RenameTheme);
            ll_deleteSelectedTheme.Enabled = permissions.ApplicationSettings.HasFlag(ApplicationSettingsAccess.DeleteTheme);
        }
    }
}
