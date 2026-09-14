# Plan: Mover layout de SellerReportControl y ManagerReportControl al Designer

## Objetivo
Mover la estructura de layout de ambos controles al `Designer.cs` para poder editarlos visualmente, agregar header con icono+titulo (patrón SaleView), y conservar todo el contenido existente sin modificar datos.

## Patrón a seguir (SaleView)
```
UserControl (1680x930, BackColor=50,50,50)
├── picTitle (IconPictureBox) → Location(690,3), Size(89,75), IconSize=75, IconColor=White
├── lblTitle (MaterialLabel) → Location(785,6), Font=Roboto Light 60F H2, ForeColor=White
└── tlpMain (TableLayoutPanel) → Dock=Bottom, Location(0,84), Size(1680,846)
    └── [contenido]
```

---

## 1. SellerReportControl

### 1.1 Designer.cs — Estructura a crear

**Controles del header:**
- `picSellerTitle` (IconPictureBox) — IconChar.ChartLine, IconColor=White, IconSize=75, Location(690,3), Size(89,75)
- `lblSellerTitle` (MaterialLabel) — "Reportes de Vendedor", Font=Roboto Light 60F H2, ForeColor=White, Location(785,6)

**tlpMain** (TableLayoutPanel) — Dock=Bottom, Size(1680,846), Padding(12,12,12,12), BackColor=FondoPrincipal(50,50,50)
- 1 columna (100%), 3 filas: 20% / 45% / 35%

**Fila 0 (20%) — KPIs:**
- `pnlKpisRow` (Panel) — Dock=Fill, BackColor=FondoPrincipal(50,50,50)
  - `tlpKpis` (TableLayoutPanel) — Dock=Fill, 4 columnas (25% c/u), 1 fila, BackColor=FondoPrincipal(50,50,50)
  - *(Las 4 tarjetas KPI se agregan en code-behind, ya que reciben parámetros dinámicos)*

**Fila 1 (45%) — Evolución:**
- `pnlEvolucion` (Panel) — Dock=Fill, BackColor=FondoTarjeta(60,60,60), Margin(6)
  - `lblEvolucionTitle` (MaterialLabel) — Dock=Top, Height=32, "Evolución de Ventas Diarias", ForeColor=White, Font=Roboto 11F
  - *(El CartesianChart se agrega en code-behind con Dock=Fill)*

**Fila 2 (35%) — Distribución:**
- `tlpDistribucion` (TableLayoutPanel) — Dock=Fill, 2 columnas (50% c/u), 1 fila, BackColor=FondoPrincipal(50,50,50)
  - [0,0] `pnlTopProductos` (Panel) — Dock=Fill, BackColor=FondoTarjeta(60,60,60), Margin(6)
    - `lblTopProductosTitle` (MaterialLabel) — Dock=Top, Height=32, "Mis Top 5 Productos", ForeColor=White, Font=Roboto 11F
    - *(El CartesianChart se agrega en code-behind con Dock=Fill)*
  - [1,0] `pnlMarcas` (Panel) — Dock=Fill, BackColor=FondoTarjeta(60,60,60), Margin(6)
    - `lblMarcasTitle` (MaterialLabel) — Dock=Top, Height=32, "Rendimiento por Marca", ForeColor=White, Font=Roboto 11F
    - *(El PieChart se agrega en code-behind con Dock=Fill)*

**Control principal:**
```csharp
Controls.Add(tlpMain);
Controls.Add(lblSellerTitle);
Controls.Add(picSellerTitle);
BackColor = Color.FromArgb(50, 50, 50);
Size = new Size(1680, 930);
```

### 1.2 .cs — Cambios

**Eliminar/Modificar:**
- `ConfigurarLayout()` se simplifica: ya no crea tlpPrincipal ni los contenedores. Solo:
  1. `BackColor = FondoPrincipal`
  2. Agrega 4 tarjetas KPI a `tlpKpis` (llamando a `CrearTarjetaKpi()` existente)
  3. Crea CartesianChart de evolución, Dock=Fill, lo agrega a `pnlEvolucion`
  4. Crea CartesianChart top productos, Dock=Fill, lo agrega a `pnlTopProductos`
  5. Crea PieChart marcas, Dock=Fill, lo agrega a `pnlMarcas`
- Eliminar métodos que ya no se necesitan:
  - `CrearFilaKpis()` (la estructura TLP de 4 cols está en designer)
  - `CrearFilaEvolucion()` (el Panel + título están en designer)
  - `CrearFilaDistribucion()` (el TLP de 2 cols está en designer)
  - `CrearCajaGrafico()` (Panel + título + layout ya están en designer)

**Conservar sin cambios:**
- `CrearTarjetaKpi()` — crea las tarjetas KPI dinámicas
- `CrearChartEvolucionMensual()` — crea el chart de evolución
- `CrearChartTopProductos()` — crea el chart de barras
- `CrearPieMarcas()` — crea el pie chart
- Todas las constantes de colores

---

## 2. ManagerReportControl

### 2.1 Designer.cs — Estructura a crear

**Controles del header:**
- `picManagerTitle` (IconPictureBox) — IconChar.ChartPie, IconColor=White, IconSize=75, Location(690,3), Size(89,75)
- `lblManagerTitle` (MaterialLabel) — "Reportes de Manager", Font=Roboto Light 60F H2, ForeColor=White, Location(785,6)

**tlpMain** (TableLayoutPanel) — Dock=Bottom, Size(1680,846), Padding(12,12,12,12), BackColor=FondoPrincipal(50,50,50)
- 1 columna (100%), 3 filas: 20% / 40% / 40%

**Fila 0 (20%) — KPIs:**
- `pnlKpisRow` (Panel) — Dock=Fill, BackColor=FondoPrincipal(50,50,50)
  - `tlpKpis` (TableLayoutPanel) — Dock=Fill, 4 columnas (25% c/u), 1 fila

**Fila 1 (40%) — Gráficos:**
- `tlpGraficos` (TableLayoutPanel) — Dock=Fill, 2 columnas (50% c/u), 1 fila, BackColor=FondoPrincipal(50,50,50)
  - [0,0] `pnlTopProductos` (Panel) — Dock=Fill, BackColor=FondoTarjeta(60,60,60), Margin(6)
    - `lblTopProductosTitle` (MaterialLabel) — Dock=Top, Height=32, "Top 5 Productos más vendidos"
  - [1,0] `pnlMarcas` (Panel) — Dock=Fill, BackColor=FondoTarjeta(60,60,60), Margin(6)
    - `lblMarcasTitle` (MaterialLabel) — Dock=Top, Height=32, "Ventas por Marca"

**Fila 2 (40%) — Tablas:**
- `tlpTablas` (TableLayoutPanel) — Dock=Fill, 2 columnas (50% c/u), 1 fila, BackColor=FondoPrincipal(50,50,50)
  - [0,0] `pnlStockAlerts` (Panel) — Dock=Fill, BackColor=FondoTarjeta(60,60,60), Margin(6)
    - `lblStockAlertsTitle` (MaterialLabel) — Dock=Top, Height=32, "Alertas de Stock"
  - [1,0] `pnlTopSellers` (Panel) — Dock=Fill, BackColor=FondoTarjeta(60,60,60), Margin(6)
    - `lblTopSellersTitle` (MaterialLabel) — Dock=Top, Height=32, "Top Sellers"

**Control principal:**
```csharp
Controls.Add(tlpMain);
Controls.Add(lblManagerTitle);
Controls.Add(picManagerTitle);
BackColor = Color.FromArgb(50, 50, 50);
Size = new Size(1680, 930);
```

### 2.2 .cs — Cambios

**Eliminar/Modificar:**
- `ConfigurarLayout()` se simplifica: solo poblaba contenedores pre-existentes
- Eliminar: `CrearFilaKpis()`, `CrearFilaGraficos()`, `CrearFilaTablas()`, `CrearCajaGrafico()`, `CrearCajaTabla()`, `CrearDataGridView()`, `AgregarColumna()`

**Conservar sin cambios:**
- `CrearTarjetaKpi()` — crea tarjetas KPI dinámicas (diferente a la de Seller: sin subtítulo, 3 filas en vez de 4)
- `CrearCartesianTop5()` — chart de barras
- `CrearPieMarcas()` — pie chart
- Las constantes de colores
- Los campos `dgvStockAlerts` y `dgvTopSellers` se siguen usando en code-behind

**ConfigurarLayout() nuevo:**
1. `BackColor = FondoPrincipal`
2. Agrega 4 tarjetas KPI a `tlpKpis`
3. Crea CartesianChart top5, Dock=Fill, agrega a `pnlTopProductos`
4. Crea PieChart marcas, Dock=Fill, agrega a `pnlMarcas`
5. Crea `dgvStockAlerts` con columnas, Dock=Fill, agrega a `pnlStockAlerts`
6. Crea `dgvTopSellers` con columnas, Dock=Fill, agrega a `pnlTopSellers`

---

## Archivos a modificar (4 archivos)
1. `MobileSolutions.UILayer/SellerReportControl.Designer.cs` — reescribir completamente
2. `MobileSolutions.UILayer/SellerReportControl.cs` — simplificar ConfigurarLayout, eliminar helpers冗entes
3. `MobileSolutions.UILayer/ManagerReportControl.Designer.cs` — reescribir completamente
4. `MobileSolutions.UILayer/ManagerReportControl.cs` — simplificar ConfigurarLayout, eliminar helpers冗entes

## Verificación
- Compilar el proyecto con `dotnet build`
- Verificar que ambos controles se renderizan correctamente en el diseñador
- Los datos, colores, charts y KPIs deben ser idénticos al original
