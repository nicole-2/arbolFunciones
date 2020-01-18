namespace arbolFunciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.arbolNod = new System.Windows.Forms.TreeView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAgrNod = new System.Windows.Forms.Button();
            this.txtHijo = new System.Windows.Forms.TextBox();
            this.btnAddElm = new System.Windows.Forms.Button();
            this.btnDelNod = new System.Windows.Forms.Button();
            this.btnDelArb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arbolNod
            // 
            this.arbolNod.Location = new System.Drawing.Point(12, 12);
            this.arbolNod.Name = "arbolNod";
            this.arbolNod.Size = new System.Drawing.Size(172, 300);
            this.arbolNod.TabIndex = 0;
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(206, 25);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 1;
            // 
            // btnAgrNod
            // 
            this.btnAgrNod.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAgrNod.Location = new System.Drawing.Point(348, 23);
            this.btnAgrNod.Name = "btnAgrNod";
            this.btnAgrNod.Size = new System.Drawing.Size(121, 23);
            this.btnAgrNod.TabIndex = 2;
            this.btnAgrNod.Text = "Añadir Nodo Padre";
            this.btnAgrNod.UseVisualStyleBackColor = true;
            this.btnAgrNod.Click += new System.EventHandler(this.btnAgrNod_Click);
            // 
            // txtHijo
            // 
            this.txtHijo.Location = new System.Drawing.Point(206, 63);
            this.txtHijo.Name = "txtHijo";
            this.txtHijo.Size = new System.Drawing.Size(100, 20);
            this.txtHijo.TabIndex = 3;
            // 
            // btnAddElm
            // 
            this.btnAddElm.Location = new System.Drawing.Point(348, 63);
            this.btnAddElm.Name = "btnAddElm";
            this.btnAddElm.Size = new System.Drawing.Size(121, 23);
            this.btnAddElm.TabIndex = 4;
            this.btnAddElm.Text = "Añadir Hijo";
            this.btnAddElm.UseVisualStyleBackColor = true;
            this.btnAddElm.Click += new System.EventHandler(this.btnAddElm_Click);
            // 
            // btnDelNod
            // 
            this.btnDelNod.Location = new System.Drawing.Point(348, 130);
            this.btnDelNod.Name = "btnDelNod";
            this.btnDelNod.Size = new System.Drawing.Size(121, 20);
            this.btnDelNod.TabIndex = 6;
            this.btnDelNod.Text = "Eliminar Nodo";
            this.btnDelNod.UseVisualStyleBackColor = true;
            this.btnDelNod.Click += new System.EventHandler(this.btnDelNod_Click);
            // 
            // btnDelArb
            // 
            this.btnDelArb.Location = new System.Drawing.Point(348, 165);
            this.btnDelArb.Name = "btnDelArb";
            this.btnDelArb.Size = new System.Drawing.Size(121, 23);
            this.btnDelArb.TabIndex = 7;
            this.btnDelArb.Text = "Eliminar Árbol";
            this.btnDelArb.UseVisualStyleBackColor = true;
            this.btnDelArb.Click += new System.EventHandler(this.btnDelArb_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(348, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Editar Nodo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(206, 104);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEdit.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 327);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelArb);
            this.Controls.Add(this.btnDelNod);
            this.Controls.Add(this.btnAddElm);
            this.Controls.Add(this.txtHijo);
            this.Controls.Add(this.btnAgrNod);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.arbolNod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView arbolNod;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAgrNod;
        private System.Windows.Forms.TextBox txtHijo;
        private System.Windows.Forms.Button btnAddElm;
        private System.Windows.Forms.Button btnDelNod;
        private System.Windows.Forms.Button btnDelArb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEdit;
    }
}

