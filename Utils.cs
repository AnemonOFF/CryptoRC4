namespace Crypto;

public static class Utils
{
  public static byte[] StringToByteArr(string str) => str.Select(c => (byte)c).ToArray();
  public static string ByteArrToString(byte[] arr) => new(arr.Select(b => (char)b).ToArray());
}