/*
Importance of this class: Used to be important, now only decryption is used.

Purpose of this class: The Encryption Class disgusing itself as the dev-console. Encrypted v3 maps, the save file.
*/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class Console
{
	// Encrypt
	public static string Log(string KDGOMEPJIKK, string JBKAHNLOKCE = null)
	{
		if (string.IsNullOrEmpty(KDGOMEPJIKK))
		{
			throw new ArgumentNullException("plainText");
		}
		if (string.IsNullOrEmpty(JBKAHNLOKCE))
		{
			JBKAHNLOKCE = global::Console.IPHNACIJKDE;
		}
		string result = null;
		RijndaelManaged rijndaelManaged = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
				memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(KDGOMEPJIKK);
					}
				}
				result = Convert.ToBase64String(memoryStream.ToArray());
			}
		}
		finally
		{
			if (rijndaelManaged != null)
			{
				rijndaelManaged.Clear();
			}
		}
		return result;
	}

	// Encrypt Bytes
	public static byte[] LogBytes(byte[] FMFLEPJIKAI, string JBKAHNLOKCE)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(FMFLEPJIKAI, 0, FMFLEPJIKAI.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	// Decrypt Bytes
	public static byte[] ErrorBytes(byte[] FMFLEPJIKAI, string JBKAHNLOKCE)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(FMFLEPJIKAI, 0, FMFLEPJIKAI.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	// Decrypt
	public static string Error(string FDIAENDNILM, string JBKAHNLOKCE = null)
	{
		if (string.IsNullOrEmpty(FDIAENDNILM))
		{
			throw new ArgumentNullException("cipherText");
		}
		if (string.IsNullOrEmpty(JBKAHNLOKCE))
		{
			JBKAHNLOKCE = global::Console.IPHNACIJKDE;
		}
		RijndaelManaged rijndaelManaged = null;
		string result = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
			byte[] buffer = Convert.FromBase64String(FDIAENDNILM);
			using (MemoryStream memoryStream = new MemoryStream(buffer))
			{
				rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = global::Console.CLBDFHMODLI(memoryStream);
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
				{
					using (StreamReader streamReader = new StreamReader(cryptoStream))
					{
						result = streamReader.ReadToEnd();
					}
				}
			}
		}
		finally
		{
			if (rijndaelManaged != null)
			{
				rijndaelManaged.Clear();
			}
		}
		return result;
	}

	private static byte[] CLBDFHMODLI(Stream BDIMLMKEEKO)
	{
		byte[] array = new byte[4];
		if (BDIMLMKEEKO.Read(array, 0, array.Length) != array.Length)
		{
			throw new SystemException("Stream did not contain properly formatted byte array");
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (BDIMLMKEEKO.Read(array2, 0, array2.Length) != array2.Length)
		{
			throw new SystemException("Did not read byte array properly");
		}
		return array2;
	}

    /* Fake Salt and key iirc. The actual salt and key are hidden vars not readable by dnSpy.
       They can still be found tho. If they're in the client, they're in the game somewhere. Just find the variable reference...
       Good job making everyone's lives but hacker's harder, Oxy, the exact opposite of what this was supposed to do. */
    // Probably can't change names, that's ok they're useless.
	private static string IPHNACIJKDE = "88f00bdf0ad61b16b803971ebe071962";
	private static byte[] GJHHINOMDIN = Encoding.ASCII.GetBytes("d264dbba9c2410771b4ad918903b3f4cd9e276a9");
}
