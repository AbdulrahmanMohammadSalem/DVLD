using DVLD.Common;
using DVLD_Business;
using Salem.Controls.Renderers;
using Salem.Drawing;
using Salem.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DVLD.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        
        public Settings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }

        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }

        internal void ApplyDataGridViewStyleSettings(DataGridView dgv) {
            dgv.DefaultCellStyle.BackColor = dgv.AlternatingRowsDefaultCellStyle.BackColor = SurfaceBackColor;
            dgv.DefaultCellStyle.ForeColor = dgv.AlternatingRowsDefaultCellStyle.ForeColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor = BaseForeColor;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = dgv.RowHeadersDefaultCellStyle.BackColor = GridHeaderCellColor;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = GridHeaderCellHighlightColor;
            dgv.ColumnHeadersDefaultCellStyle.Font = SystemFonts.IconTitleFont;
        }

        internal void ApplyTabControlStyleSettings(Manina.Windows.Forms.TabControl tc) {
            tc.Renderer = new Manina.Windows.Forms.TabControl.TabControlRenderer(tc) {
                UseTabColors = false,
                SeparatorColor = InactiveTabBackColor,
                BorderColor = SurfaceBorderColor,
                InactiveTabBackColor = InactiveTabBackColor,
                ActiveTabBackColor = BaseBackColor,
                ActiveTabForeColor = BaseForeColor,
                InactiveTabForeColor = BaseForeColor,
                HotAndActiveTabBackColor = BaseBackColor,
                HotTabForeColor = BaseForeColor,
                HotTabBackColor = Color.Gray
            };
        }

        internal void ApplyToolStripRendererStyleSettings(SalToolStripRenderer renderer) {
            renderer.DropDownArrowColor = BaseForeColor;
            renderer.DroppedDownSurfaceBackColor = SurfaceBackColor;
            renderer.DropDownArrowSize = 5F;
            renderer.DropDownArrowStyle = ArrowStyles.FilledTriangle;
            renderer.DroppedDownSurfaceBorderColor = Color.Gray;
            renderer.IgnoreItemStyleProperties = true;
            renderer.ImageMarginBackColor = Default.MenuStripBackColor;
            renderer.ItemBorderColor = MenuStripItemBorderColor;
            renderer.ItemBorderSize = 1;
            renderer.ItemForeColor = BaseForeColor;
            renderer.ItemMouseOverBackColor = MenuStripItemHoverBackColor;
            renderer.ItemMouseOverForeColor = MenuStripItemHoverBackColor.IsLight() ? Color.Black : Color.White;
            renderer.MouseOverDropDownArrowColor = BaseForeColor;
            renderer.ToolStripBorderColor = SurfaceBorderColor;
            renderer.TopLevelItemBackColor = MenuStripBackColor;
            renderer.SeparatorForeColor = SurfaceBorderColor;
            renderer.UseFullWidthSeparator = false;
        }

        internal void ApplyColorPaletteSettings(ThemeColorPalette palette) {
            TitleBarColorMode = (ColorModes) palette.TitleBarColorMode;
            BaseBackColor = palette.BaseBackColor;
            SurfaceBackColor = palette.SurfaceBackColor;
            BaseForeColor = palette.BaseForeColor;
            AccentForeColor = palette.AccentForeColor;
            BaseLinkColor = palette.BaseLinkColor;
            InactiveForeColor = palette.InactiveForeColor;
            StrongForeColor = palette.StrongForeColor;
            MenuStripBackColor = palette.MainMenuStripColor;
            GridHeaderCellColor = palette.GridHeaderCellColor;
            GridHeaderCellHighlightColor = palette.GridHeaderCellHighlightColor;
            SurfaceBorderColor = palette.SurfaceBorderColor;
            SurfaceHoverColor = palette.SurfaceHoverColor;
            InactiveTabBackColor = palette.InactiveTabBackColor;
            DateTimePickerStyle = (Syncfusion.Windows.Forms.VisualStyle) palette.DateTimePickerStyle;
            SyncTextBoxStyle = (Syncfusion.Windows.Forms.Tools.TextBoxExt.theme) palette.SyncTextBoxStyle;
            MenuStripItemBorderColor = palette.MenuStripItemBorderColor;
            MenuStripItemHoverBackColor = palette.MenuStripItemHoverBackColor;
        }

        internal ColorModes GetCurrentColorMode() => CurrentThemeColorMode == ColorModes.System ? DrawingHelpers.GetSystemTheme() : CurrentThemeColorMode;

        internal void ApplyChartStyleSettings(Chart chrt) {
            Color _legendBackColor, _legendBorderColor, _stripLineBackColor, _stripLineBorderColor, _axisMajorGridLineColor, _axisMinorGridLineColor;

            if (SurfaceBackColor.IsLight()) {
                _legendBackColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() - 0.04F);
                _legendBorderColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() - 0.14F);
                _stripLineBackColor = _axisMinorGridLineColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() - 0.137F);
                _stripLineBorderColor = _axisMajorGridLineColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() - 0.247F);
            } else {
                _legendBackColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() + 0.04F);
                _legendBorderColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() + 0.14F);
                _stripLineBackColor = _axisMinorGridLineColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() + 0.137F);
                _stripLineBorderColor = _axisMajorGridLineColor = HslColor.ToColor(SurfaceBackColor.A, SurfaceBackColor.GetHue(), SurfaceBackColor.GetSaturation(), SurfaceBackColor.GetBrightness() + 0.247F);
            }                

            foreach (var _title in chrt.Titles)
                _title.ForeColor = chrt.Enabled ? BaseForeColor : InactiveForeColor;

            foreach (var _legend in chrt.Legends) {
                _legend.BackColor = _legendBackColor;
                _legend.BackSecondaryColor = SurfaceBackColor;
                _legend.BorderColor = _legendBorderColor;
                _legend.ForeColor = BaseForeColor;
            }

            foreach (var _chartArea in chrt.ChartAreas) {
                _chartArea.BackColor = SurfaceBackColor;

                byte _lastAxis = (byte) (Convert.ToBoolean(_chartArea.Tag ?? false) ? 4 : 2);

                for (byte i = 0; i < _lastAxis; i++) {
                    _chartArea.Axes[i].TitleForeColor = _chartArea.Axes[i].LineColor = _chartArea.Axes[i].LabelStyle.ForeColor = _chartArea.Axes[i].MajorTickMark.LineColor = BaseForeColor;
                    _chartArea.Axes[i].MajorGrid.LineColor = _chartArea.Axes[i].MinorTickMark.LineColor = _axisMajorGridLineColor;
                    _chartArea.Axes[i].MinorGrid.LineColor = _axisMinorGridLineColor;
                }

                foreach (var _axis in _chartArea.Axes)
                    foreach (var _stripLine in _axis.StripLines) {
                        _stripLine.BackColor = _stripLineBackColor;
                        _stripLine.BackSecondaryColor = SurfaceBackColor;
                        _stripLine.BorderColor = _stripLineBorderColor;
                    }
            }
        }
    }
}
