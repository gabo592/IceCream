namespace IceCream.Presentacion.Principal
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.TblPnlImagen = new System.Windows.Forms.TableLayoutPanel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FrmStyles = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.TbPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TxtClave = new Bunifu.UI.WinForms.BunifuTextBox();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnIniciarSesion = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnSalir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TblPnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.TbPnlDatos.SuspendLayout();
            this.FlwPnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblPnlImagen
            // 
            this.TblPnlImagen.ColumnCount = 1;
            this.TblPnlImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnlImagen.Controls.Add(this.PbLogo, 0, 1);
            this.TblPnlImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblPnlImagen.Location = new System.Drawing.Point(0, 0);
            this.TblPnlImagen.Name = "TblPnlImagen";
            this.TblPnlImagen.RowCount = 2;
            this.TblPnlImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.293706F));
            this.TblPnlImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.70629F));
            this.TblPnlImagen.Size = new System.Drawing.Size(370, 143);
            this.TblPnlImagen.TabIndex = 0;
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbLogo.Image = global::IceCream.Properties.Resources.ice_cream;
            this.PbLogo.Location = new System.Drawing.Point(3, 11);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(364, 129);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 143);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(370, 40);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "¡Bienvenido de vuelta!";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStyles
            // 
            this.FrmStyles.ButtonSpecs.FormClose.Image = global::IceCream.Properties.Resources.mc_red;
            this.FrmStyles.ButtonSpecs.FormClose.ImageStates.ImageNormal = global::IceCream.Properties.Resources.mc_red;
            this.FrmStyles.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::IceCream.Properties.Resources.mc_red;
            this.FrmStyles.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::IceCream.Properties.Resources.mc_red;
            this.FrmStyles.ButtonSpecs.FormMax.Image = global::IceCream.Properties.Resources.mc_yellw;
            this.FrmStyles.ButtonSpecs.FormMax.ImageStates.ImageNormal = global::IceCream.Properties.Resources.mc_yellw;
            this.FrmStyles.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::IceCream.Properties.Resources.mc_yellw;
            this.FrmStyles.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::IceCream.Properties.Resources.mc_yellw;
            this.FrmStyles.ButtonSpecs.FormMin.Image = global::IceCream.Properties.Resources.mc_green;
            this.FrmStyles.ButtonSpecs.FormMin.ImageStates.ImageNormal = global::IceCream.Properties.Resources.mc_green;
            this.FrmStyles.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::IceCream.Properties.Resources.mc_green;
            this.FrmStyles.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::IceCream.Properties.Resources.mc_green;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Back.ColorAngle = 47F;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Border.ColorAngle = 47F;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Border.Rounding = 10;
            this.FrmStyles.FormStyles.FormCommon.StateCommon.Border.Width = 1;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 47F;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Border.ColorAngle = 47F;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(-1, -1, 1, -1);
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.FrmStyles.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.ColorAngle = 47F;
            // 
            // TbPnlDatos
            // 
            this.TbPnlDatos.ColumnCount = 3;
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TbPnlDatos.Controls.Add(this.TxtNombre, 1, 0);
            this.TbPnlDatos.Controls.Add(this.TxtClave, 1, 1);
            this.TbPnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlDatos.Location = new System.Drawing.Point(0, 183);
            this.TbPnlDatos.Name = "TbPnlDatos";
            this.TbPnlDatos.RowCount = 3;
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TbPnlDatos.Size = new System.Drawing.Size(370, 109);
            this.TbPnlDatos.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AcceptsReturn = false;
            this.TxtNombre.AcceptsTab = false;
            this.TxtNombre.AnimationSpeed = 200;
            this.TxtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtNombre.AutoSizeHeight = true;
            this.TxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtNombre.BackgroundImage")));
            this.TxtNombre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            this.TxtNombre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtNombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            this.TxtNombre.BorderColorIdle = System.Drawing.Color.White;
            this.TxtNombre.BorderRadius = 15;
            this.TxtNombre.BorderThickness = 1;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.DefaultText = "";
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.FillColor = System.Drawing.Color.White;
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.HideSelection = true;
            this.TxtNombre.IconLeft = global::IceCream.Properties.Resources.user;
            this.TxtNombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.IconPadding = 10;
            this.TxtNombre.IconRight = null;
            this.TxtNombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.Lines = new string[0];
            this.TxtNombre.Location = new System.Drawing.Point(21, 3);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtNombre.Modified = false;
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            stateProperties3.ForeColor = System.Drawing.Color.Black;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.OnIdleState = stateProperties4;
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(3);
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.PlaceholderText = "Nombre de Usuario";
            this.TxtNombre.ReadOnly = false;
            this.TxtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.ShortcutsEnabled = true;
            this.TxtNombre.Size = new System.Drawing.Size(327, 41);
            this.TxtNombre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombre.TextMarginBottom = 0;
            this.TxtNombre.TextMarginLeft = 7;
            this.TxtNombre.TextMarginTop = 1;
            this.TxtNombre.TextPlaceholder = "Nombre de Usuario";
            this.TxtNombre.UseSystemPasswordChar = false;
            this.TxtNombre.WordWrap = true;
            // 
            // TxtClave
            // 
            this.TxtClave.AcceptsReturn = false;
            this.TxtClave.AcceptsTab = false;
            this.TxtClave.AnimationSpeed = 200;
            this.TxtClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtClave.AutoSizeHeight = true;
            this.TxtClave.BackColor = System.Drawing.Color.Transparent;
            this.TxtClave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtClave.BackgroundImage")));
            this.TxtClave.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            this.TxtClave.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtClave.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            this.TxtClave.BorderColorIdle = System.Drawing.Color.White;
            this.TxtClave.BorderRadius = 15;
            this.TxtClave.BorderThickness = 1;
            this.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.DefaultText = "";
            this.TxtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClave.FillColor = System.Drawing.Color.White;
            this.TxtClave.ForeColor = System.Drawing.Color.Black;
            this.TxtClave.HideSelection = true;
            this.TxtClave.IconLeft = global::IceCream.Properties.Resources._lock;
            this.TxtClave.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.IconPadding = 10;
            this.TxtClave.IconRight = null;
            this.TxtClave.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.Lines = new string[0];
            this.TxtClave.Location = new System.Drawing.Point(21, 50);
            this.TxtClave.MaxLength = 32767;
            this.TxtClave.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtClave.Modified = false;
            this.TxtClave.Multiline = false;
            this.TxtClave.Name = "TxtClave";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            stateProperties5.FillColor = System.Drawing.Color.White;
            stateProperties5.ForeColor = System.Drawing.Color.Black;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtClave.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtClave.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            stateProperties7.ForeColor = System.Drawing.Color.Black;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtClave.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtClave.OnIdleState = stateProperties8;
            this.TxtClave.Padding = new System.Windows.Forms.Padding(3);
            this.TxtClave.PasswordChar = '\0';
            this.TxtClave.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtClave.PlaceholderText = "Contraseña";
            this.TxtClave.ReadOnly = false;
            this.TxtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.ShortcutsEnabled = true;
            this.TxtClave.Size = new System.Drawing.Size(327, 41);
            this.TxtClave.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtClave.TabIndex = 1;
            this.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtClave.TextMarginBottom = 0;
            this.TxtClave.TextMarginLeft = 7;
            this.TxtClave.TextMarginTop = 1;
            this.TxtClave.TextPlaceholder = "Contraseña";
            this.TxtClave.UseSystemPasswordChar = true;
            this.TxtClave.WordWrap = true;
            // 
            // FlwPnlBotones
            // 
            this.FlwPnlBotones.Controls.Add(this.BtnIniciarSesion);
            this.FlwPnlBotones.Controls.Add(this.BtnSalir);
            this.FlwPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlwPnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPnlBotones.Location = new System.Drawing.Point(0, 292);
            this.FlwPnlBotones.Name = "FlwPnlBotones";
            this.FlwPnlBotones.Size = new System.Drawing.Size(370, 54);
            this.FlwPnlBotones.TabIndex = 3;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.AllowAnimations = true;
            this.BtnIniciarSesion.AllowMouseEffects = true;
            this.BtnIniciarSesion.AllowToggling = false;
            this.BtnIniciarSesion.AnimationSpeed = 200;
            this.BtnIniciarSesion.AutoGenerateColors = false;
            this.BtnIniciarSesion.AutoRoundBorders = false;
            this.BtnIniciarSesion.AutoSizeLeftIcon = true;
            this.BtnIniciarSesion.AutoSizeRightIcon = true;
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciarSesion.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIniciarSesion.BackgroundImage")));
            this.BtnIniciarSesion.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.ButtonText = "Iniciar Sesión";
            this.BtnIniciarSesion.ButtonTextMarginLeft = 0;
            this.BtnIniciarSesion.ColorContrastOnClick = 45;
            this.BtnIniciarSesion.ColorContrastOnHover = 45;
            this.BtnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnIniciarSesion.CustomizableEdges = borderEdges1;
            this.BtnIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnIniciarSesion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnIniciarSesion.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.IconLeft = null;
            this.BtnIniciarSesion.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciarSesion.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnIniciarSesion.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnIniciarSesion.IconMarginLeft = 11;
            this.BtnIniciarSesion.IconPadding = 10;
            this.BtnIniciarSesion.IconRight = null;
            this.BtnIniciarSesion.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciarSesion.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnIniciarSesion.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnIniciarSesion.IconSize = 25;
            this.BtnIniciarSesion.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.IdleBorderRadius = 0;
            this.BtnIniciarSesion.IdleBorderThickness = 0;
            this.BtnIniciarSesion.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnIniciarSesion.IdleIconLeftImage = null;
            this.BtnIniciarSesion.IdleIconRightImage = null;
            this.BtnIniciarSesion.IndicateFocus = false;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(217, 3);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnIniciarSesion.OnDisabledState.BorderRadius = 17;
            this.BtnIniciarSesion.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.OnDisabledState.BorderThickness = 1;
            this.BtnIniciarSesion.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnIniciarSesion.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnIniciarSesion.OnDisabledState.IconLeftImage = null;
            this.BtnIniciarSesion.OnDisabledState.IconRightImage = null;
            this.BtnIniciarSesion.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIniciarSesion.onHoverState.BorderRadius = 17;
            this.BtnIniciarSesion.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.onHoverState.BorderThickness = 1;
            this.BtnIniciarSesion.onHoverState.FillColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnIniciarSesion.onHoverState.IconLeftImage = null;
            this.BtnIniciarSesion.onHoverState.IconRightImage = null;
            this.BtnIniciarSesion.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIniciarSesion.OnIdleState.BorderRadius = 17;
            this.BtnIniciarSesion.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.OnIdleState.BorderThickness = 1;
            this.BtnIniciarSesion.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIniciarSesion.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.OnIdleState.IconLeftImage = null;
            this.BtnIniciarSesion.OnIdleState.IconRightImage = null;
            this.BtnIniciarSesion.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIniciarSesion.OnPressedState.BorderRadius = 17;
            this.BtnIniciarSesion.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIniciarSesion.OnPressedState.BorderThickness = 1;
            this.BtnIniciarSesion.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIniciarSesion.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.OnPressedState.IconLeftImage = null;
            this.BtnIniciarSesion.OnPressedState.IconRightImage = null;
            this.BtnIniciarSesion.Size = new System.Drawing.Size(150, 39);
            this.BtnIniciarSesion.TabIndex = 0;
            this.BtnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIniciarSesion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnIniciarSesion.TextMarginLeft = 0;
            this.BtnIniciarSesion.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnIniciarSesion.UseDefaultRadiusAndThickness = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AllowAnimations = true;
            this.BtnSalir.AllowMouseEffects = true;
            this.BtnSalir.AllowToggling = false;
            this.BtnSalir.AnimationSpeed = 200;
            this.BtnSalir.AutoGenerateColors = false;
            this.BtnSalir.AutoRoundBorders = false;
            this.BtnSalir.AutoSizeLeftIcon = true;
            this.BtnSalir.AutoSizeRightIcon = true;
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.ButtonText = "Salir";
            this.BtnSalir.ButtonTextMarginLeft = 0;
            this.BtnSalir.ColorContrastOnClick = 45;
            this.BtnSalir.ColorContrastOnHover = 45;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnSalir.CustomizableEdges = borderEdges2;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSalir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSalir.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnSalir.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnSalir.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.IconLeft = null;
            this.BtnSalir.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnSalir.IconMarginLeft = 11;
            this.BtnSalir.IconPadding = 10;
            this.BtnSalir.IconRight = null;
            this.BtnSalir.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnSalir.IconSize = 25;
            this.BtnSalir.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnSalir.IdleBorderRadius = 0;
            this.BtnSalir.IdleBorderThickness = 0;
            this.BtnSalir.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnSalir.IdleIconLeftImage = null;
            this.BtnSalir.IdleIconRightImage = null;
            this.BtnSalir.IndicateFocus = false;
            this.BtnSalir.Location = new System.Drawing.Point(61, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSalir.OnDisabledState.BorderRadius = 17;
            this.BtnSalir.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.OnDisabledState.BorderThickness = 1;
            this.BtnSalir.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnSalir.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnSalir.OnDisabledState.IconLeftImage = null;
            this.BtnSalir.OnDisabledState.IconRightImage = null;
            this.BtnSalir.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            this.BtnSalir.onHoverState.BorderRadius = 17;
            this.BtnSalir.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.onHoverState.BorderThickness = 1;
            this.BtnSalir.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            this.BtnSalir.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.onHoverState.IconLeftImage = null;
            this.BtnSalir.onHoverState.IconRightImage = null;
            this.BtnSalir.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            this.BtnSalir.OnIdleState.BorderRadius = 17;
            this.BtnSalir.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.OnIdleState.BorderThickness = 1;
            this.BtnSalir.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnSalir.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.OnIdleState.IconLeftImage = null;
            this.BtnSalir.OnIdleState.IconRightImage = null;
            this.BtnSalir.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            this.BtnSalir.OnPressedState.BorderRadius = 17;
            this.BtnSalir.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.OnPressedState.BorderThickness = 1;
            this.BtnSalir.OnPressedState.FillColor = System.Drawing.Color.White;
            this.BtnSalir.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.OnPressedState.IconLeftImage = null;
            this.BtnSalir.OnPressedState.IconRightImage = null;
            this.BtnSalir.Size = new System.Drawing.Size(150, 39);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSalir.TextMarginLeft = 0;
            this.BtnSalir.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnSalir.UseDefaultRadiusAndThickness = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 343);
            this.Controls.Add(this.FlwPnlBotones);
            this.Controls.Add(this.TbPnlDatos);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TblPnlImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Palette = this.FrmStyles;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TblPnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.TbPnlDatos.ResumeLayout(false);
            this.FlwPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPnlImagen;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label LblTitulo;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette FrmStyles;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatos;
        private Bunifu.UI.WinForms.BunifuTextBox TxtNombre;
        private Bunifu.UI.WinForms.BunifuTextBox TxtClave;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnIniciarSesion;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnSalir;
    }
}