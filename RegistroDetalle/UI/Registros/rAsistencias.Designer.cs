namespace RegistroDetalle.UI.Registros
{
    partial class rAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsistencias));
            this.IDLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AsistenciasIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.AgregarEstudianteDataButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.PresenteCheckBox = new System.Windows.Forms.CheckBox();
            this.AgregarEstudiantebutton = new System.Windows.Forms.Button();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.EstudianteLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.AsignaturaLabel = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciasIdNumericUpDown)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(21, 32);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(22, 20);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(191, 23);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(38, 40);
            this.BuscarButton.TabIndex = 1;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(22, 458);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(94, 36);
            this.NuevoButton.TabIndex = 2;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // AsistenciasIdNumericUpDown
            // 
            this.AsistenciasIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsistenciasIdNumericUpDown.Location = new System.Drawing.Point(60, 31);
            this.AsistenciasIdNumericUpDown.Name = "AsistenciasIdNumericUpDown";
            this.AsistenciasIdNumericUpDown.Size = new System.Drawing.Size(97, 24);
            this.AsistenciasIdNumericUpDown.TabIndex = 5;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(312, 23);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(209, 24);
            this.FechaDateTimePicker.TabIndex = 6;
            this.FechaDateTimePicker.Value = new System.DateTime(2019, 10, 9, 0, 1, 2, 0);
            this.FechaDateTimePicker.ValueChanged += new System.EventHandler(this.FechaDateTimePicker_ValueChanged);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.CantidadTextBox);
            this.GroupBox.Controls.Add(this.CantidadLabel);
            this.GroupBox.Controls.Add(this.AgregarEstudianteDataButton);
            this.GroupBox.Controls.Add(this.DetalleDataGridView);
            this.GroupBox.Controls.Add(this.PresenteCheckBox);
            this.GroupBox.Controls.Add(this.AgregarEstudiantebutton);
            this.GroupBox.Controls.Add(this.EstudianteComboBox);
            this.GroupBox.Controls.Add(this.EstudianteLabel);
            this.GroupBox.Location = new System.Drawing.Point(22, 132);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(499, 304);
            this.GroupBox.TabIndex = 7;
            this.GroupBox.TabStop = false;
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTextBox.Location = new System.Drawing.Point(125, 267);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.ReadOnly = true;
            this.CantidadTextBox.Size = new System.Drawing.Size(342, 24);
            this.CantidadTextBox.TabIndex = 14;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(35, 270);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(66, 18);
            this.CantidadLabel.TabIndex = 13;
            this.CantidadLabel.Text = "Cantidad";
            // 
            // AgregarEstudianteDataButton
            // 
            this.AgregarEstudianteDataButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarEstudianteDataButton.Image")));
            this.AgregarEstudianteDataButton.Location = new System.Drawing.Point(425, 36);
            this.AgregarEstudianteDataButton.Name = "AgregarEstudianteDataButton";
            this.AgregarEstudianteDataButton.Size = new System.Drawing.Size(42, 34);
            this.AgregarEstudianteDataButton.TabIndex = 6;
            this.AgregarEstudianteDataButton.UseVisualStyleBackColor = true;
            this.AgregarEstudianteDataButton.Click += new System.EventHandler(this.AgregarEstudianteDataButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.AllowUserToDeleteRows = false;
            this.DetalleDataGridView.AllowUserToOrderColumns = true;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(34, 88);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.RowTemplate.Height = 24;
            this.DetalleDataGridView.Size = new System.Drawing.Size(433, 164);
            this.DetalleDataGridView.TabIndex = 5;
            this.DetalleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleDataGridView_CellContentClick);
            // 
            // PresenteCheckBox
            // 
            this.PresenteCheckBox.AutoSize = true;
            this.PresenteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresenteCheckBox.Location = new System.Drawing.Point(290, 41);
            this.PresenteCheckBox.Name = "PresenteCheckBox";
            this.PresenteCheckBox.Size = new System.Drawing.Size(98, 24);
            this.PresenteCheckBox.TabIndex = 3;
            this.PresenteCheckBox.Text = "Presente";
            this.PresenteCheckBox.UseVisualStyleBackColor = true;
            // 
            // AgregarEstudiantebutton
            // 
            this.AgregarEstudiantebutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarEstudiantebutton.Image")));
            this.AgregarEstudiantebutton.Location = new System.Drawing.Point(171, 36);
            this.AgregarEstudiantebutton.Name = "AgregarEstudiantebutton";
            this.AgregarEstudiantebutton.Size = new System.Drawing.Size(36, 34);
            this.AgregarEstudiantebutton.TabIndex = 2;
            this.AgregarEstudiantebutton.UseVisualStyleBackColor = true;
            this.AgregarEstudiantebutton.Click += new System.EventHandler(this.AgregarEstudiantebutton_Click);
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(34, 46);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(121, 24);
            this.EstudianteComboBox.TabIndex = 1;
            this.EstudianteComboBox.SelectedIndexChanged += new System.EventHandler(this.EstudianteComboBox_SelectedIndexChanged);
            // 
            // EstudianteLabel
            // 
            this.EstudianteLabel.AutoSize = true;
            this.EstudianteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteLabel.Location = new System.Drawing.Point(30, 18);
            this.EstudianteLabel.Name = "EstudianteLabel";
            this.EstudianteLabel.Size = new System.Drawing.Size(97, 20);
            this.EstudianteLabel.TabIndex = 0;
            this.EstudianteLabel.Text = "Estudiantes";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(239, 26);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 20);
            this.FechaLabel.TabIndex = 8;
            this.FechaLabel.Text = "Fecha";
            // 
            // AsignaturaLabel
            // 
            this.AsignaturaLabel.AutoSize = true;
            this.AsignaturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaLabel.Location = new System.Drawing.Point(21, 87);
            this.AsignaturaLabel.Name = "AsignaturaLabel";
            this.AsignaturaLabel.Size = new System.Drawing.Size(98, 20);
            this.AsignaturaLabel.TabIndex = 9;
            this.AsignaturaLabel.Text = "Asignaturas";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(227, 458);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(104, 36);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Borrarbutton.Image")));
            this.Borrarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrarbutton.Location = new System.Drawing.Point(431, 458);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(90, 36);
            this.Borrarbutton.TabIndex = 12;
            this.Borrarbutton.Text = "Borrar";
            this.Borrarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Borrarbutton.UseVisualStyleBackColor = true;
            this.Borrarbutton.Click += new System.EventHandler(this.Borrarbutton_Click);
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(191, 87);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(330, 24);
            this.AsignaturaComboBox.TabIndex = 13;
            this.AsignaturaComboBox.SelectedIndexChanged += new System.EventHandler(this.AsignaturaComboBox_SelectedIndexChanged);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 529);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.Borrarbutton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AsignaturaLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.AsistenciasIdNumericUpDown);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IDLabel);
            this.Name = "rAsistencias";
            this.Text = "Registro de asistencias";
            this.Load += new System.EventHandler(this.RAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciasIdNumericUpDown)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.NumericUpDown AsistenciasIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label AsignaturaLabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.CheckBox PresenteCheckBox;
        private System.Windows.Forms.Button AgregarEstudiantebutton;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
        private System.Windows.Forms.Label EstudianteLabel;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Button AgregarEstudianteDataButton;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}