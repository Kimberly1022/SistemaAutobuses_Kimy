
namespace CapaPresentacion
{
    partial class Administrar_Viajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar_Viajes));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Formulario = new System.Windows.Forms.Panel();
            this.cbxRuta = new System.Windows.Forms.ComboBox();
            this.cbxAutobus = new System.Windows.Forms.ComboBox();
            this.cbxChofer = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.Formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopFormulario
            // 
            this.TopFormulario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TopFormulario.Controls.Add(this.btn_Cerrar);
            this.TopFormulario.Controls.Add(this.label1);
            this.TopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFormulario.Location = new System.Drawing.Point(0, 0);
            this.TopFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopFormulario.Name = "TopFormulario";
            this.TopFormulario.Size = new System.Drawing.Size(1233, 50);
            this.TopFormulario.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = global::CapaPresentacion.Properties.Resources.delete_48px;
            this.btn_Cerrar.Location = new System.Drawing.Point(1171, 0);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(62, 50);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRAR VIAJES";
            // 
            // Formulario
            // 
            this.Formulario.Controls.Add(this.cbxRuta);
            this.Formulario.Controls.Add(this.cbxAutobus);
            this.Formulario.Controls.Add(this.cbxChofer);
            this.Formulario.Controls.Add(this.btn_Reset);
            this.Formulario.Controls.Add(this.txt_ID);
            this.Formulario.Controls.Add(this.label7);
            this.Formulario.Controls.Add(this.btn_Guardar);
            this.Formulario.Controls.Add(this.btn_Eliminar);
            this.Formulario.Controls.Add(this.btn_Editar);
            this.Formulario.Controls.Add(this.textBox1);
            this.Formulario.Controls.Add(this.pictureBox2);
            this.Formulario.Controls.Add(this.pictureBox1);
            this.Formulario.Controls.Add(this.label4);
            this.Formulario.Controls.Add(this.label3);
            this.Formulario.Controls.Add(this.dataGridView1);
            this.Formulario.Controls.Add(this.label2);
            this.Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formulario.Location = new System.Drawing.Point(0, 50);
            this.Formulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(1233, 520);
            this.Formulario.TabIndex = 1;
            // 
            // cbxRuta
            // 
            this.cbxRuta.FormattingEnabled = true;
            this.cbxRuta.Location = new System.Drawing.Point(919, 446);
            this.cbxRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRuta.Name = "cbxRuta";
            this.cbxRuta.Size = new System.Drawing.Size(269, 28);
            this.cbxRuta.TabIndex = 77;
            // 
            // cbxAutobus
            // 
            this.cbxAutobus.FormattingEnabled = true;
            this.cbxAutobus.Location = new System.Drawing.Point(920, 358);
            this.cbxAutobus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAutobus.Name = "cbxAutobus";
            this.cbxAutobus.Size = new System.Drawing.Size(269, 28);
            this.cbxAutobus.TabIndex = 76;
            // 
            // cbxChofer
            // 
            this.cbxChofer.FormattingEnabled = true;
            this.cbxChofer.Location = new System.Drawing.Point(920, 276);
            this.cbxChofer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChofer.Name = "cbxChofer";
            this.cbxChofer.Size = new System.Drawing.Size(269, 28);
            this.cbxChofer.TabIndex = 75;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Reset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reset.BorderRadius = 0;
            this.btn_Reset.ButtonText = "RESET";
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Reset.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Reset.Iconimage = global::CapaPresentacion.Properties.Resources.available_updates_64px;
            this.btn_Reset.Iconimage_right = null;
            this.btn_Reset.Iconimage_right_Selected = null;
            this.btn_Reset.Iconimage_Selected = null;
            this.btn_Reset.IconMarginLeft = 0;
            this.btn_Reset.IconMarginRight = 0;
            this.btn_Reset.IconRightVisible = false;
            this.btn_Reset.IconRightZoom = 0D;
            this.btn_Reset.IconVisible = true;
            this.btn_Reset.IconZoom = 60D;
            this.btn_Reset.IsTab = false;
            this.btn_Reset.Location = new System.Drawing.Point(18, 168);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Reset.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Reset.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Reset.Padding = new System.Windows.Forms.Padding(6);
            this.btn_Reset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Reset.selected = false;
            this.btn_Reset.Size = new System.Drawing.Size(184, 66);
            this.btn_Reset.TabIndex = 68;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reset.Textcolor = System.Drawing.Color.White;
            this.btn_Reset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Location = new System.Drawing.Point(920, 204);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(268, 26);
            this.txt_ID.TabIndex = 74;
            this.txt_ID.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(915, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 25);
            this.label7.TabIndex = 72;
            this.label7.Text = "ID";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.BorderRadius = 0;
            this.btn_Guardar.ButtonText = "GUARDAR";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Iconimage = global::CapaPresentacion.Properties.Resources.GUARDAR;
            this.btn_Guardar.Iconimage_right = null;
            this.btn_Guardar.Iconimage_right_Selected = null;
            this.btn_Guardar.Iconimage_Selected = null;
            this.btn_Guardar.IconMarginLeft = 0;
            this.btn_Guardar.IconMarginRight = 0;
            this.btn_Guardar.IconRightVisible = true;
            this.btn_Guardar.IconRightZoom = 0D;
            this.btn_Guardar.IconVisible = true;
            this.btn_Guardar.IconZoom = 60D;
            this.btn_Guardar.IsTab = false;
            this.btn_Guardar.Location = new System.Drawing.Point(666, 168);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Guardar.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Guardar.selected = false;
            this.btn_Guardar.Size = new System.Drawing.Size(222, 66);
            this.btn_Guardar.TabIndex = 71;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.btn_Guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.BorderRadius = 0;
            this.btn_Eliminar.ButtonText = "ELIMINAR";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Iconimage = global::CapaPresentacion.Properties.Resources.ELIMINAR;
            this.btn_Eliminar.Iconimage_right = null;
            this.btn_Eliminar.Iconimage_right_Selected = null;
            this.btn_Eliminar.Iconimage_Selected = null;
            this.btn_Eliminar.IconMarginLeft = 0;
            this.btn_Eliminar.IconMarginRight = 0;
            this.btn_Eliminar.IconRightVisible = true;
            this.btn_Eliminar.IconRightZoom = 0D;
            this.btn_Eliminar.IconVisible = true;
            this.btn_Eliminar.IconZoom = 60D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(441, 166);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Eliminar.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(216, 66);
            this.btn_Eliminar.TabIndex = 70;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.White;
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Editar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.BorderRadius = 0;
            this.btn_Editar.ButtonText = "EDITAR";
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.Iconimage = global::CapaPresentacion.Properties.Resources.EDITAR2;
            this.btn_Editar.Iconimage_right = null;
            this.btn_Editar.Iconimage_right_Selected = null;
            this.btn_Editar.Iconimage_Selected = null;
            this.btn_Editar.IconMarginLeft = 0;
            this.btn_Editar.IconMarginRight = 0;
            this.btn_Editar.IconRightVisible = true;
            this.btn_Editar.IconRightZoom = 0D;
            this.btn_Editar.IconVisible = true;
            this.btn_Editar.IconZoom = 60D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(217, 168);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Editar.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(215, 65);
            this.btn_Editar.TabIndex = 69;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(915, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "RUTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "AUTOBUS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(20, 239);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(867, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(915, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "CHOFER";
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.TopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.TEXTBUSCAR;
            this.pictureBox1.Location = new System.Drawing.Point(26, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(37, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 40);
            this.textBox1.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Buscar;
            this.pictureBox2.Location = new System.Drawing.Point(290, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Administrar_Viajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 570);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Administrar_Viajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar_Viajes";
            this.Load += new System.EventHandler(this.Administrar_Viajes_Load);
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.Panel Formulario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reset;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Guardar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private System.Windows.Forms.ComboBox cbxChofer;
        private System.Windows.Forms.ComboBox cbxAutobus;
        private System.Windows.Forms.ComboBox cbxRuta;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}