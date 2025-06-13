using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

public class User
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }

    private static readonly string filePath = "users.json";

    public static bool IsValid(string username, string password, out string error)
    {
        error = "";
        if (username.Length < 4 || username.Length > 20 || !Regex.IsMatch(username, @"^[a-zA-Z]+$"))
        {
            error = "Username harus 4-20 huruf alfabet.";
            return false;
        }
        if (password.Length < 8 || !Regex.IsMatch(password, @"[0-9]") || !Regex.IsMatch(password, @"[!@#$%^&*]") || password.Contains(username))
        {
            error = "Password harus >=8 karakter, mengandung angka & simbol, tidak mengandung username.";
            return false;
        }
        return true;
    }

    public static string Hash(string input)
    {
        using var sha = SHA256.Create();
        var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
        return Convert.ToBase64String(bytes);
    }

    public static List<User> LoadUsers()
    {
        if (!File.Exists(filePath)) return new List<User>();
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }

    public static void SaveUsers(List<User> users)
    {
        var json = JsonSerializer.Serialize(users);
        File.WriteAllText(filePath, json);
    }

    public static bool Register(string username, string password, out string error)
    {
        var users = LoadUsers();
        if (users.Any(u => u.Username == username))
        {
            error = "Username sudah digunakan.";
            return false;
        }

        if (!IsValid(username, password, out error)) return false;

        users.Add(new User { Username = username, PasswordHash = Hash(password) });
        SaveUsers(users);
        return true;
    }

    public static bool Login(string username, string password)
    {
        var users = LoadUsers();
        return users.Any(u => u.Username == username && u.PasswordHash == Hash(password));
    }
}
