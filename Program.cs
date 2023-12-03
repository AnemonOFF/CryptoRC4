#region RC4
using Crypto;

var key = "AB";
var data = "megasecrettext";
var encrypted = RC4.Encrypt(key, data);
Console.WriteLine($"Encrypted: {RC4.ByteArrToString(encrypted)}");
var decrypted = RC4.DecryptToString(key, encrypted);
Console.WriteLine($"Decrypted: {decrypted}");
#endregion

#region MD5
#endregion