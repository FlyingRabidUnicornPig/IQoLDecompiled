/*
Importance of this class: The real encryption class. Used more than the fake.

Purpose of this class: Idfk why the hell there is two of these classes why. Don't solo-dev, kids.
*/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class Crypto
{
	public static string EncryptStringAES(string KDGOMEPJIKK, string JBKAHNLOKCE = null)
	{
		if (string.IsNullOrEmpty(KDGOMEPJIKK))
		{
			throw new ArgumentNullException("plainText");
		}
		if (string.IsNullOrEmpty(JBKAHNLOKCE))
		{
			JBKAHNLOKCE = Crypto.EBLIPECJNIL;
		}
		string result = null;
		RijndaelManaged rijndaelManaged = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(JBKAHNLOKCE, Crypto.GJHHINOMDIN);
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

	public static byte[] EncryptBytesAES(byte[] FMFLEPJIKAI, string JBKAHNLOKCE)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(JBKAHNLOKCE, Crypto.GJHHINOMDIN);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(FMFLEPJIKAI, 0, FMFLEPJIKAI.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] DecryptBytesAES(byte[] FMFLEPJIKAI, string JBKAHNLOKCE)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(JBKAHNLOKCE, Crypto.GJHHINOMDIN);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(FMFLEPJIKAI, 0, FMFLEPJIKAI.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string DecryptStringAES(string FDIAENDNILM, string JBKAHNLOKCE = null)
	{
		if (string.IsNullOrEmpty(FDIAENDNILM))
		{
			throw new ArgumentNullException("cipherText");
		}
		if (string.IsNullOrEmpty(JBKAHNLOKCE))
		{
			JBKAHNLOKCE = Crypto.EBLIPECJNIL;
		}
		RijndaelManaged rijndaelManaged = null;
		string result = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(JBKAHNLOKCE, Crypto.GJHHINOMDIN);
			byte[] buffer = Convert.FromBase64String(FDIAENDNILM);
			using (MemoryStream memoryStream = new MemoryStream(buffer))
			{
				rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = Crypto.CLBDFHMODLI(memoryStream);
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

	private static string EBLIPECJNIL = "88f00bdf0ad61b16b803971ebe071962";

	private static byte[] GJHHINOMDIN = Encoding.ASCII.GetBytes("d264dbba9c2410771b4ad918903b3f4cd9e276a9");
}
