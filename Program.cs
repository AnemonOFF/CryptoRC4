using Crypto;

var data = "megasecrettext";

#region RC4
Console.WriteLine("RC4");
var key = "AB";
var encrypted = RC4.Encrypt(key, data);
Console.WriteLine($"Encrypted: {Utils.ByteArrToString(encrypted)}");
var decrypted = RC4.DecryptToString(key, encrypted);
Console.WriteLine($"Decrypted: {decrypted}");
#endregion

#region MD5
Console.WriteLine("MD5");
var hashed = MD5.Calculate(Utils.StringToByteArr(data));
Console.WriteLine($"Hashed: {hashed}");
#endregion