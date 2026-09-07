using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin.Controls;

namespace MobileSolutions.UILayer
{
    public partial class SaleView : UserControl
    {
        public SaleView()
        {
            InitializeComponent();

            // Asignar íconos FontAwesome a los botones de acción
            btnAddDetail.Icon = IconChar.CartPlus.ToBitmap(Color.White);
            btnTotalSale.Icon = IconChar.Coins.ToBitmap(Color.White);
            btnConfirmSale.Icon = IconChar.CircleCheck.ToBitmap(Color.White);
            btnCancelSale.Icon = IconChar.Trash.ToBitmap(Color.White);

            // Íconos de los botones pequeños junto a cada campo
            btnCustomer.Icon = IconChar.UserTag.ToBitmap(Color.White);
            btnSaleNumber.Icon = IconChar.Barcode.ToBitmap(Color.White);
            btnPaymentType.Icon = IconChar.MoneyCheckDollar.ToBitmap(Color.White);
            btnQuantity.Icon = IconChar.LayerGroup.ToBitmap(Color.White);
            btnUnitaryPrice.Icon = IconChar.DollarSign.ToBitmap(Color.White);
            btnProductCode.Icon = IconChar.Barcode.ToBitmap(Color.White);

            // Ícono del título del panel
            picSaleTitle.IconChar = IconChar.Shopify;
            picSaleTitle.IconColor = Color.White;
        }

        
    }

}
