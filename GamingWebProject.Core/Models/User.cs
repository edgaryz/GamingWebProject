using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GamingWebProject.Core.Models;

public class User
{
    [NotMapped]
    [JsonIgnore]
    [BsonId]
    public ObjectId MongoUserId { get; set; }
    [Key]
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    
    public User() { }

    public User(string userName, string email)
    {
        UserName = userName;
        Email = email;
    }

    public User(int id, string userName, string email)
    {
        Id = id;
        UserName = userName;
        Email = email;
    }
}