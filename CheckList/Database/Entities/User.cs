namespace CheckList.Database.Entities;

internal class User
{
    /// <summary>
    /// Id пользователя.
    /// </summary>
    public int Id { get; set; }
        
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Email пользователя.
    /// </summary>
    public string? Email { get; set; }
}

