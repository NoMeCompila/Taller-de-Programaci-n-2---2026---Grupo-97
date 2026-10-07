using System;
using System.Collections.Generic;
using MobileSolutions.DataLayer;
using MobileSolutions.BusinessLayer.Models; 

namespace MobileSolutions.BusinessLayer
{
    public class ProductService
    {
        private readonly ProductDal _productDal;
        private readonly DatabaseConnection _dbConnection;

        public ProductService()
        {
            _productDal = new ProductDal();
            _dbConnection = new DatabaseConnection();
        }

        public List<Product> GetActiveProducts()
        {
            return _productDal.GetActiveProducts();
        }

        public List<Product> GetInactiveProducts()
        {
            return _productDal.GetInactiveProducts();
        }

        public List<Brand> GetActiveBrands()
        {
            return _productDal.GetActiveBrands();
        }

        public List<Product> SearchProducts(string? searchTerm)
        {
            return SearchProductsByStatus(searchTerm, isInactiveMode: false);
        }

        public List<Product> SearchProductsByStatus(string? searchTerm, bool isInactiveMode)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return isInactiveMode ? GetInactiveProducts() : GetActiveProducts();
            }

            string cleanSearchTerm = searchTerm.Trim();
            return isInactiveMode
                ? _productDal.SearchInactiveProducts(cleanSearchTerm)
                : _productDal.SearchActiveProducts(cleanSearchTerm);
        }

        public (bool Success, string Message) CreateProduct(Product product)
        {
            if (product == null)
                return (false, "Los campos del producto no pueden estar vacíos.");
            if (product.BrandId <= 0)
                return (false, "Debe seleccionar una marca válida para el producto.");
            if (string.IsNullOrWhiteSpace(product.ProductCode))
                return (false, "El código del producto es obligatorio.");
            if (string.IsNullOrWhiteSpace(product.Name))
                return (false, "El nombre del producto es obligatorio.");
            if (product.Stock < 0)
                return (false, "El stock no puede ser negativo.");
            if (product.PurchasePrice < 0 || product.SalePrice < 0)
                return (false, "Los precios no pueden ser negativos.");
            if (product.SalePrice < product.PurchasePrice)
                return (false, "El precio de venta no puede ser menor al precio de compra.");

            try
            {
                int newProductId = _productDal.CreateProduct(product);
                if (newProductId > 0)
                {
                    return (true, $"Producto creado exitosamente con ID: {newProductId}");
                }

                return (false, "No se pudo registrar el producto en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violación de restricciones UNIQUE y FOREIGN KEY
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Product_Code"))
                        return (false, "Ya existe un producto con ese código.");

                    return (false, "Ya existe un registro con datos duplicados.");
                }
                if (ex.Number == 547 && ex.Message.Contains("FK_Product_Brand"))
                {
                    return (false, "La marca indicada no existe o no está activa.");
                }

                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al guardar el producto: {ex.Message}");
            }
        }

        public (bool Success, string Message) UpdateProduct(Product product)
        {
            if (product == null)
                return (false, "Los datos del producto no pueden ser nulos.");
            if (product.ProductId <= 0)
                return (false, "Identificador de producto no válido para la actualización.");
            if (product.BrandId <= 0)
                return (false, "Debe seleccionar una marca válida para el producto.");
            if (string.IsNullOrWhiteSpace(product.ProductCode))
                return (false, "El código del producto es obligatorio.");
            if (string.IsNullOrWhiteSpace(product.Name))
                return (false, "El nombre del producto es obligatorio.");
            if (product.Stock < 0)
                return (false, "El stock no puede ser negativo.");
            if (product.PurchasePrice < 0 || product.SalePrice < 0)
                return (false, "Los precios no pueden ser negativos.");
            if (product.SalePrice < product.PurchasePrice)
                return (false, "El precio de venta no puede ser menor al precio de compra.");

            try
            {
                bool updated = _productDal.UpdateProduct(product);
                if (updated)
                {
                    return (true, "Producto actualizado correctamente.");
                }

                return (false, "No se pudo actualizar el producto en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violación de restricciones UNIQUE y FOREIGN KEY
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Product_Code"))
                        return (false, "Ya existe un producto con ese código.");

                    return (false, "Ya existe un registro con datos duplicados.");
                }
                if (ex.Number == 547 && ex.Message.Contains("FK_Product_Brand"))
                {
                    return (false, "La marca indicada no existe o no está activa.");
                }

                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al intentar actualizar el producto: {ex.Message}");
            }
        }

        public (bool Success, string Message) SoftDeleteProduct(int productId)
        {
            if (productId <= 0)
            {
                return (false, "Identificador de producto no válido para la baja lógica.");
            }

            try
            {
                bool deleted = _productDal.SoftDeleteProduct(productId);
                if (deleted)
                {
                    return (true, "Producto dado de baja correctamente.");
                }

                return (false, "No se pudo dar de baja al producto en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al dar de baja al producto: {ex.Message}");
            }
        }

        public (bool Success, string Message) ReactivateProduct(int productId)
        {
            if (productId <= 0)
            {
                return (false, "Identificador de producto no válido para la reactivación.");
            }

            try
            {
                bool reactivated = _productDal.ReactivateProduct(productId);
                if (reactivated)
                {
                    return (true, "Producto reactivado correctamente.");
                }

                return (false, "No se pudo reactivar el producto en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al reactivar el producto: {ex.Message}");
            }
        }

        public (bool IsConnected, string? ErrorMessage) CheckDatabaseConnection()
        {
            return _dbConnection.TestConnection();
        }
    }
}
