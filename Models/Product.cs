namespace ComputerShop.Models
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public Guid Id { get; set; } = new Guid();

        /// <summary>
        /// Код продукта
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Наименование продукта
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Закупочная цена (оптовая)
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Рыночная цена
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Наличие товара
        /// </summary>
        public bool Availability { get; set; }

        /// <summary>
        /// Поставка
        /// </summary>
        public Supply Supply { get; set; }
    }
}
