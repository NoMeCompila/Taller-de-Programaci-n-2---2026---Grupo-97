# Reglas de Escalado UI y Tamaños en WinForms

Esta regla se aplica a todos los archivos relacionados con la interfaz gráfica de WinForms (principalmente `.Designer.cs`).

1. **Auto-escalado Desactivado**: 
   - **NUNCA** utilices `AutoScaleMode.Font` o `AutoScaleMode.Dpi`.
   - **SIEMPRE** debes asegurar de configurar `AutoScaleMode = AutoScaleMode.None;` (o `this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;`).
   - *Razón*: Diferentes resoluciones o configuraciones de DPI/Fuentes en Windows causan que Visual Studio auto-escale y desordene los elementos, rompiendo el diseño al compartir código en el equipo.

2. **Tamaño por Defecto**: 
   - Todos los formularios principales y UserControls raíz deben tener por defecto `Size = new Size(1680, 930)` y/o `ClientSize = new Size(1680, 930)`.
   
3. **Acoplamiento (Docking)**: 
   - Cuando agregues un UserControl o Panel a un Formulario o TabPage, asegurate siempre de configurar su propiedad `Dock = DockStyle.Fill` para que se adapte al contenedor padre dinámicamente sin superponerse ni cortarse.
