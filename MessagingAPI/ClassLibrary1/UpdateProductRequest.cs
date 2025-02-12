namespace MessagingAPI;

public class UpdateProductRequest
{
    public int ProductId { get; set; }

    public int? CategoryId { get; set; }

    public string? ProductName { get; set; }

    public string? ShortDesc { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? ThumbnailImageUrl { get; set; } = "https://cdn2.cellphones.com.vn/insecure/rs:fill:358:358/q:90/plain/https://cellphones.com.vn/media/catalog/product/i/p/iphone-16-pro-max.png";
    
    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public bool Active { get; set; }

    public int? UnitsInStock { get; set; }
    
    //public string? Video { get; set; }

    //public int? Discount { get; set; }
    
    //public string? Tags { get; set; }

    //public string? Title { get; set; }

    //public string? Alias { get; set; }

    //public string? MetaDesc { get; set; }

    //public string? MetaKey { get; set; }
    
    // public virtual Category? Cat { get; set; }
}