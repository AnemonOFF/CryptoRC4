namespace Crypto;

public class RC4
{
  public static byte[] Encrypt(string key, string data)
  {
    return Encrypt(Utils.StringToByteArr(key), Utils.StringToByteArr(data));
  }

  public static byte[] Encrypt(byte[] key, byte[] data)
  {
    var S = new int[256];
    var cipher = new byte[data.Length];

    for (var i = 0; i < 256; i++)
      S[i] = i;

    var j = 0;
    for (var i = 0; i < 256; i++)
    {
      j = (j + S[i] + key[i % key.Length]) % 256;
      (S[j], S[i]) = (S[i], S[j]);
    }

    for (int i = 0, a = 0, b = 0; i < data.Length; i++)
    {
      a = a++ % 256;
      b = (b + S[a]) % 256;
      (S[b], S[a]) = (S[a], S[b]);

      var t = (S[a] + S[b]) % 256;
      var k = S[t];

      cipher[i] = (byte)(data[i] ^ k);
    }

    return cipher;
  }

  public static byte[] Decrypt(byte[] key, byte[] data)
  {
    return Encrypt(key, data);
  }

  public static string DecryptToString(byte[] key, byte[] data)
  {
    return Utils.ByteArrToString(Decrypt(key, data));
  }

  public static string DecryptToString(string key, byte[] data)
  {
    return Utils.ByteArrToString(Decrypt(Utils.StringToByteArr(key), data));
  }
}