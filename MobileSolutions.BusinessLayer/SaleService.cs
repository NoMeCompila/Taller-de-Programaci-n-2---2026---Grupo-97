using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    public class SaleService
    {
        private readonly SaleDal _saleDal;

        public SaleService()
        {
            _saleDal = new SaleDal();
        }

        #region Métodos de Consulta (Lectura)

        public List<SaleHeader> GetActiveSales()
        {
            return _saleDal.GetActiveSales();
        }

        public List<SaleHeader> GetInactiveSales()
        {
            return _saleDal.GetInactiveSales();
        }

        public List<SaleHeader> SearchSales(string? searchTerm)
        {
            return SearchSalesByStatus(searchTerm, isInactiveMode: false);
        }

        public List<SaleHeader> SearchSalesByStatus(string? searchTerm, bool isInactiveMode)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return isInactiveMode ? GetInactiveSales() : GetActiveSales();
            }

            string cleanSearchTerm = searchTerm.Trim();
            return isInactiveMode
                ? _saleDal.SearchInactiveSales(cleanSearchTerm)
                : _saleDal.SearchActiveSales(cleanSearchTerm);
        }

        public List<SaleDetail> GetSaleDetailsBySaleId(int saleId)
        {
            if (saleId <= 0)
            {
                return new List<SaleDetail>();
            }

            return _saleDal.GetSaleDetailsBySaleId(saleId);
        }

        public SaleHeader? GetSaleById(int saleId)
        {
            if (saleId <= 0)
            {
                return null;
            }

            return _saleDal.GetSaleById(saleId);
        }

        #endregion

        #region Métodos de Operación (Escritura)

        public (bool Success, string Message, int SaleId, string SaleNumber, decimal TotalSale) CreateSale(SaleHeader sale)
        {
            if (sale == null)
            {
                return (false, "Los datos de la venta no pueden estar vacíos.", 0, string.Empty, 0m);
            }

            if (sale.CustomerId <= 0)
            {
                return (false, "Debe seleccionar un cliente válido para la venta.", 0, string.Empty, 0m);
            }

            if (sale.UserId <= 0)
            {
                return (false, "El vendedor autenticado no es válido.", 0, string.Empty, 0m);
            }

            if (sale.PaymentTypeId <= 0)
            {
                return (false, "Debe seleccionar un método de pago válido.", 0, string.Empty, 0m);
            }

            if (sale.Details == null || sale.Details.Count == 0)
            {
                return (false, "La venta debe contener al menos un producto en el detalle.", 0, string.Empty, 0m);
            }

            foreach (var detail in sale.Details)
            {
                if (detail.ProductId <= 0)
                {
                    return (false, "Uno de los productos seleccionados no es válido.", 0, string.Empty, 0m);
                }

                if (detail.Quantity <= 0)
                {
                    return (false, $"La cantidad del producto '{detail.ProductName}' debe ser mayor a cero.", 0, string.Empty, 0m);
                }

                if (detail.UnitPrice < 0)
                {
                    return (false, $"El precio unitario del producto '{detail.ProductName}' no puede ser negativo.", 0, string.Empty, 0m);
                }
            }

            try
            {
                var result = _saleDal.CreateSale(sale);

                if (result.SaleId > 0)
                {
                    return (true, $"Venta {result.SaleNumber} registrada exitosamente.", result.SaleId, result.SaleNumber, result.TotalSale);
                }

                return (false, "No se pudo registrar la venta en la base de datos.", 0, string.Empty, 0m);
            }
            catch (SqlException ex)
            {
                return (false, ex.Message, 0, string.Empty, 0m);
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al procesar la venta: {ex.Message}", 0, string.Empty, 0m);
            }
        }

        public (bool Success, string Message) CancelSale(int saleId)
        {
            if (saleId <= 0)
            {
                return (false, "Identificador de venta no válido para la cancelación.");
            }

            try
            {
                bool cancelled = _saleDal.CancelSale(saleId);

                if (cancelled)
                {
                    return (true, "Venta cancelada correctamente. El stock ha sido restituido.");
                }

                return (false, "No se pudo cancelar la venta en la base de datos.");
            }
            catch (SqlException ex)
            {
                return (false, ex.Message);
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al cancelar la venta: {ex.Message}");
            }
        }

        public (bool Success, string Message) ReactivateSale(int saleId)
        {
            if (saleId <= 0)
            {
                return (false, "Identificador de venta no válido para la reactivación.");
            }

            try
            {
                bool reactivated = _saleDal.ReactivateSale(saleId);

                if (reactivated)
                {
                    return (true, "Venta reactivada correctamente. El stock ha sido descontado nuevamente.");
                }

                return (false, "No se pudo reactivar la venta en la base de datos.");
            }
            catch (SqlException ex)
            {
                return (false, ex.Message);
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al reactivar la venta: {ex.Message}");
            }
        }

        #endregion
    }
}

