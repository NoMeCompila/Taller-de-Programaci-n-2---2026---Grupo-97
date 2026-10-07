using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    public class ProductDal
    {
        private readonly DatabaseConnection _dbConnection;
        public ProductDal()
        {
            _dbConnection = new DatabaseConnection();
        }

        private static int GetOrdinalSafe(SqlDataReader reader, params string[] columnNames)
        {
            foreach (var name in columnNames)
            {
                try
                {
                    return reader.GetOrdinal(name);
                }
                catch (IndexOutOfRangeException)
                {
                    // Continuar buscando con el siguiente alias
                }
            }
            return -1;
        }

        private static Product MapProductFromReader(
            SqlDataReader reader,
            int ordProductId,
            int ordBrandId,
            int ordBrandName,
            int ordProductCode,
            int ordName,
            int ordStock,
            int ordPurchasePrice,
            int ordSalePrice,
            int ordImage)
        {
            return new Product
            {
                ProductId = ordProductId >= 0 && !reader.IsDBNull(ordProductId) ? reader.GetInt32(ordProductId) : 0,
                BrandId = ordBrandId >= 0 && !reader.IsDBNull(ordBrandId) ? reader.GetInt32(ordBrandId) : 0,
                BrandName = ordBrandName >= 0 && !reader.IsDBNull(ordBrandName) ? reader.GetString(ordBrandName) : string.Empty,
                ProductCode = ordProductCode >= 0 && !reader.IsDBNull(ordProductCode) ? reader.GetString(ordProductCode) : string.Empty,
                Name = ordName >= 0 && !reader.IsDBNull(ordName) ? reader.GetString(ordName) : string.Empty,
                Stock = ordStock >= 0 && !reader.IsDBNull(ordStock) ? reader.GetInt32(ordStock) : 0,
                PurchasePrice = ordPurchasePrice >= 0 && !reader.IsDBNull(ordPurchasePrice) ? reader.GetDecimal(ordPurchasePrice) : 0m,
                SalePrice = ordSalePrice >= 0 && !reader.IsDBNull(ordSalePrice) ? reader.GetDecimal(ordSalePrice) : 0m,
                Image = ordImage >= 0 && !reader.IsDBNull(ordImage) ? reader.GetString(ordImage) : null
            };
        }

        public List<Product> GetActiveProducts()
        {
            var products = new List<Product>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetActiveProducts", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30; // 30 segundos de timeout estándar
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordBrandName = GetOrdinalSafe(reader, "Marca", "BrandName", "brand_name");
                    int ordProductCode = GetOrdinalSafe(reader, "Codigo", "ProductCode", "product_code");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordStock = GetOrdinalSafe(reader, "Stock", "stock");
                    int ordPurchasePrice = GetOrdinalSafe(reader, "PrecioCompra", "PurchasePrice", "purchase_price");
                    int ordSalePrice = GetOrdinalSafe(reader, "PrecioVenta", "SalePrice", "sale_price");
                    int ordImage = GetOrdinalSafe(reader, "Imagen", "Image", "image");
                    int ordProductId = GetOrdinalSafe(reader, "product_id", "ProductId");
                    int ordBrandId = GetOrdinalSafe(reader, "brand_id", "BrandId");

                    while (reader.Read())
                    {
                        products.Add(MapProductFromReader(
                            reader,
                            ordProductId,
                            ordBrandId,
                            ordBrandName,
                            ordProductCode,
                            ordName,
                            ordStock,
                            ordPurchasePrice,
                            ordSalePrice,
                            ordImage));
                    }
                }
            }
            return products;
        }

        public List<Product> GetInactiveProducts()
        {
            var products = new List<Product>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetInactiveProducts", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordBrandName = GetOrdinalSafe(reader, "Marca", "BrandName", "brand_name");
                    int ordProductCode = GetOrdinalSafe(reader, "Codigo", "ProductCode", "product_code");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordStock = GetOrdinalSafe(reader, "Stock", "stock");
                    int ordPurchasePrice = GetOrdinalSafe(reader, "PrecioCompra", "PurchasePrice", "purchase_price");
                    int ordSalePrice = GetOrdinalSafe(reader, "PrecioVenta", "SalePrice", "sale_price");
                    int ordImage = GetOrdinalSafe(reader, "Imagen", "Image", "image");
                    int ordProductId = GetOrdinalSafe(reader, "product_id", "ProductId");
                    int ordBrandId = GetOrdinalSafe(reader, "brand_id", "BrandId");

                    while (reader.Read())
                    {
                        products.Add(MapProductFromReader(
                            reader,
                            ordProductId,
                            ordBrandId,
                            ordBrandName,
                            ordProductCode,
                            ordName,
                            ordStock,
                            ordPurchasePrice,
                            ordSalePrice,
                            ordImage));
                    }
                }
            }
            return products;
        }

        public List<Product> SearchActiveProducts(string? searchTerm)
        {
            var products = new List<Product>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchActiveProducts", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                // Parámetro seguro para prevenir inyección SQL
                object dbValue = string.IsNullOrWhiteSpace(searchTerm)
                    ? DBNull.Value
                    : searchTerm.Trim();

                command.Parameters.Add(new SqlParameter("@SearchTerm", SqlDbType.NVarChar, 100)
                {
                    Value = dbValue
                });

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordBrandName = GetOrdinalSafe(reader, "Marca", "BrandName", "brand_name");
                    int ordProductCode = GetOrdinalSafe(reader, "Codigo", "ProductCode", "product_code");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordStock = GetOrdinalSafe(reader, "Stock", "stock");
                    int ordPurchasePrice = GetOrdinalSafe(reader, "PrecioCompra", "PurchasePrice", "purchase_price");
                    int ordSalePrice = GetOrdinalSafe(reader, "PrecioVenta", "SalePrice", "sale_price");
                    int ordImage = GetOrdinalSafe(reader, "Imagen", "Image", "image");
                    int ordProductId = GetOrdinalSafe(reader, "product_id", "ProductId");
                    int ordBrandId = GetOrdinalSafe(reader, "brand_id", "BrandId");

                    while (reader.Read())
                    {
                        products.Add(MapProductFromReader(
                            reader,
                            ordProductId,
                            ordBrandId,
                            ordBrandName,
                            ordProductCode,
                            ordName,
                            ordStock,
                            ordPurchasePrice,
                            ordSalePrice,
                            ordImage));
                    }
                }
            }
            return products;
        }

        public List<Product> SearchInactiveProducts(string? searchTerm)
        {
            var products = new List<Product>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchInactiveProducts", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                object dbValue = string.IsNullOrWhiteSpace(searchTerm)
                    ? DBNull.Value
                    : searchTerm.Trim();

                command.Parameters.Add(new SqlParameter("@SearchTerm", SqlDbType.NVarChar, 100)
                {
                    Value = dbValue
                });

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordBrandName = GetOrdinalSafe(reader, "Marca", "BrandName", "brand_name");
                    int ordProductCode = GetOrdinalSafe(reader, "Codigo", "ProductCode", "product_code");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordStock = GetOrdinalSafe(reader, "Stock", "stock");
                    int ordPurchasePrice = GetOrdinalSafe(reader, "PrecioCompra", "PurchasePrice", "purchase_price");
                    int ordSalePrice = GetOrdinalSafe(reader, "PrecioVenta", "SalePrice", "sale_price");
                    int ordImage = GetOrdinalSafe(reader, "Imagen", "Image", "image");
                    int ordProductId = GetOrdinalSafe(reader, "product_id", "ProductId");
                    int ordBrandId = GetOrdinalSafe(reader, "brand_id", "BrandId");

                    while (reader.Read())
                    {
                        products.Add(MapProductFromReader(
                            reader,
                            ordProductId,
                            ordBrandId,
                            ordBrandName,
                            ordProductCode,
                            ordName,
                            ordStock,
                            ordPurchasePrice,
                            ordSalePrice,
                            ordImage));
                    }
                }
            }
            return products;
        }

        public int CreateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (string.IsNullOrWhiteSpace(product.ProductCode))
                throw new ArgumentException("El código del producto es requerido.", nameof(product.ProductCode));

            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ArgumentException("El nombre del producto es requerido.", nameof(product.Name));

            if (product.Stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.", nameof(product.Stock));

            if (product.PurchasePrice < 0 || product.SalePrice < 0)
                throw new ArgumentException("Los precios no pueden ser negativos.", nameof(product.PurchasePrice));

            if (product.SalePrice < product.PurchasePrice)
                throw new ArgumentException("El precio de venta no puede ser menor al precio de compra.", nameof(product.SalePrice));

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_CreateProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@brand_id", SqlDbType.Int).Value = product.BrandId;
                command.Parameters.Add("@product_code", SqlDbType.VarChar, 100).Value = product.ProductCode;
                command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = product.Name;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = product.Stock;

                SqlParameter purchasePriceParam = command.Parameters.Add("@purchase_price", SqlDbType.Decimal, 18);
                purchasePriceParam.Scale = 2;
                purchasePriceParam.Value = product.PurchasePrice;

                SqlParameter salePriceParam = command.Parameters.Add("@sale_price", SqlDbType.Decimal, 18);
                salePriceParam.Scale = 2;
                salePriceParam.Value = product.SalePrice;

                command.Parameters.Add("@image", SqlDbType.VarChar, 255).Value = (object?)product.Image ?? DBNull.Value;

                connection.Open();
                object? result = command.ExecuteScalar();
                return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        public bool UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (string.IsNullOrWhiteSpace(product.ProductCode))
                throw new ArgumentException("El código del producto es requerido.", nameof(product.ProductCode));

            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ArgumentException("El nombre del producto es requerido.", nameof(product.Name));

            if (product.Stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.", nameof(product.Stock));

            if (product.PurchasePrice < 0 || product.SalePrice < 0)
                throw new ArgumentException("Los precios no pueden ser negativos.", nameof(product.PurchasePrice));

            if (product.SalePrice < product.PurchasePrice)
                throw new ArgumentException("El precio de venta no puede ser menor al precio de compra.", nameof(product.SalePrice));

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_UpdateProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@product_id", SqlDbType.Int).Value = product.ProductId;
                command.Parameters.Add("@brand_id", SqlDbType.Int).Value = product.BrandId;
                command.Parameters.Add("@product_code", SqlDbType.VarChar, 100).Value = product.ProductCode;
                command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = product.Name;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = product.Stock;

                SqlParameter purchasePriceParam = command.Parameters.Add("@purchase_price", SqlDbType.Decimal, 18);
                purchasePriceParam.Scale = 2;
                purchasePriceParam.Value = product.PurchasePrice;

                SqlParameter salePriceParam = command.Parameters.Add("@sale_price", SqlDbType.Decimal, 18);
                salePriceParam.Scale = 2;
                salePriceParam.Value = product.SalePrice;

                command.Parameters.Add("@image", SqlDbType.VarChar, 255).Value = (object?)product.Image ?? DBNull.Value;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public bool SoftDeleteProduct(int productId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_DeleteProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@product_id", SqlDbType.Int).Value = productId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public bool ReactivateProduct(int productId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_ReactivateProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@product_id", SqlDbType.Int).Value = productId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public List<Brand> GetActiveBrands()
        {
            var brands = new List<Brand>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetActiveBrands", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordBrandId = GetOrdinalSafe(reader, "brand_id", "BrandId");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name", "Name");

                    while (reader.Read())
                    {
                        brands.Add(new Brand
                        {
                            BrandId = ordBrandId >= 0 && !reader.IsDBNull(ordBrandId) ? reader.GetInt32(ordBrandId) : 0,
                            Name = ordName >= 0 && !reader.IsDBNull(ordName) ? reader.GetString(ordName) : string.Empty
                        });
                    }
                }
            }
            return brands;
        }
    }
}
