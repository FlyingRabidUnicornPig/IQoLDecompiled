// Global Helper class
// Kinda a miscball of shit
// Needs some deobf, last 1000 lines are bs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;

public static class Helpers
{
	public static string GetGameVersion()
	{
		return "Intralism QoL Mod";
	}

	public static bool IsStoryboardEvent(string eventName)
	{
		return (!string.IsNullOrEmpty(eventName) && !eventName.Equals("checkpoint") && !Helpers.eventsMap.Exists((EditorEventFunctionInfo x) => x.id == eventName)) || Helpers.eventsMap.Exists((EditorEventFunctionInfo x) => x.id == eventName && x.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard);
	}

	private static double FindArcDifficultyIthink(int AFMLIFBPDPG)
	{
		return -((double)(AFMLIFBPDPG * AFMLIFBPDPG) / 4.0) + (double)(1.3f * (float)AFMLIFBPDPG);
	}

	private static double FindSpeedDifficulty(double KEDDLFDAIDE)
	{
		return KEDDLFDAIDE / 14.0;
	}

	private static double FindZoomDifficulty(double playerDistance)
	{
		if (true)
		{
			return 1.0;
		}
		playerDistance = Math.Max(playerDistance, 4.0);
		playerDistance = Math.Min(playerDistance, 40.0);
		if (playerDistance < 14.0)
		{
			return 14.0 / playerDistance;
		}
		return playerDistance * playerDistance / 196.0 - playerDistance / 7.0 + 2.0;
	}

	// TODO: Make these compilable
	public static float GetMapDifficulty(MapData data)
	{
		MapData mapData = new MapData(data);
		if (mapData.configVersion >= 3 && !string.IsNullOrEmpty(mapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(mapData.e, Singleton<SaveSystem>.Instance.folder));
				mapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		double keddlfdaide = (double)mapData.speed;
		double playerDistance = 14.0;
		double num = 0.0;
		double num2 = (double)mapData.musicTime;
		bool flag = false;
		double maxTime = (double)mapData.musicTime;
		foreach (MapEvent mapEvent in from x in mapData.events
		where x.data[0].Equals("MapEnd")
		select x)
		{
			maxTime = (((double)mapEvent.time < maxTime) ? ((double)mapEvent.time) : maxTime);
		}
		IEnumerable<MapEvent> events = mapData.events;
		Func<MapEvent, bool> <>9__1;
		Func<MapEvent, bool> predicate;
		if ((predicate = <>9__1) == null)
		{
			predicate = (<>9__1 = ((MapEvent x) => (double)x.time <= maxTime));
		}
		foreach (MapEvent mapEvent2 in events.Where(predicate))
		{
			if (mapEvent2.data[0] == "SpawnObj")
			{
				if (!flag)
				{
					num = (double)mapEvent2.time;
					flag = true;
				}
				num2 = (double)mapEvent2.time;
			}
		}
		if (!flag || num == num2)
		{
			return 0f;
		}
		double num3 = Helpers.FindZoomDifficulty(playerDistance);
		double num4 = Helpers.FindSpeedDifficulty(keddlfdaide);
		double num5 = 0.0;
		int num6 = 0;
		double num7 = 0.0;
		int num8 = 0;
		List<double> list = new List<double>();
		Func<MapEvent, bool> <>9__2;
		for (int i = 0; i < (int)Math.Ceiling(num2); i++)
		{
			int num9 = 0;
			double num10 = 0.0;
			IEnumerable<MapEvent> events2 = mapData.events;
			Func<MapEvent, bool> predicate2;
			if ((predicate2 = <>9__2) == null)
			{
				predicate2 = (<>9__2 = ((MapEvent x) => (double)x.time <= maxTime));
			}
			foreach (MapEvent mapEvent3 in events2.Where(predicate2))
			{
				if (mapEvent3.time >= (float)i && mapEvent3.time < (float)(i + 1))
				{
					if (mapEvent3.data[0] == "MapEnd")
					{
						break;
					}
					if (mapEvent3.data[0] == "SpawnObj")
					{
						IEnumerable<char> source = mapEvent3.data[1];
						if (Helpers.LNIJKGECNME == null)
						{
							Helpers.LNIJKGECNME = new Func<char, bool>(Helpers.LFJDIMOEADJ);
						}
						int num11 = source.Count(Helpers.LNIJKGECNME) + 1;
						num9 += num11;
						double num12 = Helpers.FindArcDifficultyIthink(num11);
						num10 += num12 * num3 * num4;
					}
					if (mapEvent3.data[0] == "SetPlayerDistance")
					{
						num3 = Helpers.FindZoomDifficulty((double)float.Parse(mapEvent3.data[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo));
					}
					if (mapEvent3.data[0] == "SetSpeed")
					{
						num4 = Helpers.FindSpeedDifficulty((double)float.Parse(mapEvent3.data[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo));
					}
				}
			}
			if (num9 > 0)
			{
				num8++;
			}
			if (num7 < num10)
			{
				num7 = num10;
			}
			if (num10 > 0.0)
			{
				num5 += num10;
				num6++;
				list.Add(num10);
			}
		}
		int num13 = (int)Math.Ceiling((double)num8 * 0.33);
		double num14 = 0.0;
		for (int j = 0; j < num13; j++)
		{
			double num15 = (from x in list
			orderby -x
			select x).ToList<double>()[j];
			num14 += num15;
		}
		double num16 = num14 / (double)num13;
		return (float)Math.Round(Math.Log((double)num8, 60.0) * num16, 2);
	}

	public static int GetMapMaxScore(MapData CLCBMMEKBBC)
	{
		MapData mapData = new MapData(CLCBMMEKBBC);
		if (mapData.configVersion >= 3 && !string.IsNullOrEmpty(mapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(mapData.e, Singleton<SaveSystem>.Instance.folder));
				mapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		IEnumerable<MapEvent> events = mapData.events;
		if (Helpers.HCLEECLNOEA == null)
		{
			Helpers.HCLEECLNOEA = new Func<MapEvent, bool>(Helpers.NDFPKEBFAGM);
		}
		List<MapEvent> list = events.Where(Helpers.HCLEECLNOEA).ToList<MapEvent>();
		int num = 0;
		int num2 = 0;
		foreach (MapEvent mapEvent in list)
		{
			int num3 = mapEvent.data[1].Split(new char[]
			{
				'-'
			}).Length;
			for (int i = 0; i < num3; i++)
			{
				num2++;
				num += num2;
			}
		}
		return num;
	}

	public static Color HexToColor(string MLPCOMHPPNH)
	{
		MLPCOMHPPNH = MLPCOMHPPNH.Replace("0x", string.Empty);
		MLPCOMHPPNH = MLPCOMHPPNH.Replace("#", string.Empty);
		byte a = byte.MaxValue;
		byte r = byte.Parse(MLPCOMHPPNH.Substring(0, 2), NumberStyles.HexNumber);
		byte g = byte.Parse(MLPCOMHPPNH.Substring(2, 2), NumberStyles.HexNumber);
		byte b = byte.Parse(MLPCOMHPPNH.Substring(4, 2), NumberStyles.HexNumber);
		if (MLPCOMHPPNH.Length == 8)
		{
			a = byte.Parse(MLPCOMHPPNH.Substring(6, 2), NumberStyles.HexNumber);
		}
		return new Color32(r, g, b, a);
	}

	public static string ColorToHex(Color HABLFKCCKLN)
	{
		return ColorUtility.ToHtmlStringRGBA(HABLFKCCKLN);
	}

	public static int GetPlayerLevel(int EEGKDDBECBE)
	{
		int num = 0;
		int num2 = EEGKDDBECBE;
		for (int i = 0; i <= num2; i = num * 500)
		{
			num2 -= i;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num++;
		}
		return num;
	}

	public static Transform FindDeepChild(this Transform INBEMGANDKE, string JNOIHECMHJJ)
	{
		Transform transform = INBEMGANDKE.Find(JNOIHECMHJJ);
		if (transform != null)
		{
			return transform;
		}
		IEnumerator enumerator = INBEMGANDKE.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform inbemgandke = (Transform)obj;
				transform = inbemgandke.FindDeepChild(JNOIHECMHJJ);
				if (transform != null)
				{
					return transform;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		return null;
	}

	public static float GetPlayerLevelProgress()
	{
		int num = 0;
		int num2 = Helpers.GetStat("player.xp");
		int i;
		for (i = 0; i <= num2; i = num * 500)
		{
			num2 -= i;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num++;
		}
		return (float)num2 / (float)i;
	}

	public static void ObtainAchievement(int JMMILEFMACB)
	{
		if (GameManager.IsOwner())
		{
			string text = "NEW_ACHIEVEMENT_1_" + JMMILEFMACB.ToString();
			bool flag = false;
			if (SteamUserStats.GetAchievement(text, out flag) && !flag)
			{
				SteamUserStats.SetAchievement(text);
				SteamUserStats.StoreStats();
			}
		}
	}

	public static void ObtainAchievementProgress(int JMMILEFMACB, int IADPPJHIMBG)
	{
		if (GameManager.IsOwner())
		{
			string pchName = "NEW_ACHIEVEMENT_1_" + JMMILEFMACB.ToString();
			bool flag = false;
			if (SteamUserStats.GetAchievement(pchName, out flag) && !flag)
			{
				SteamUserStats.SetStat("achievements.id" + JMMILEFMACB + ".progress", IADPPJHIMBG);
				SteamUserStats.StoreStats();
			}
		}
	}

	public static int GetStat(string JMMILEFMACB)
	{
		int result = 0;
		if (SteamUserStats.GetStat(JMMILEFMACB, out result))
		{
			return result;
		}
		return result;
	}

	public static float GetStatFloat(string JMMILEFMACB)
	{
		float result = 0f;
		if (SteamUserStats.GetStat(JMMILEFMACB, out result))
		{
			return result;
		}
		return result;
	}

	public static void SetStat(string JMMILEFMACB, int DPNHODJHGJL)
	{
		if (GameManager.IsOwner())
		{
			SteamUserStats.SetStat(JMMILEFMACB, DPNHODJHGJL);
			SteamUserStats.StoreStats();
		}
	}

	public static void AddToStat(string JMMILEFMACB, int DPNHODJHGJL)
	{
		if (GameManager.IsOwner())
		{
			int stat = Helpers.GetStat(JMMILEFMACB);
			SteamUserStats.SetStat(JMMILEFMACB, stat + DPNHODJHGJL);
			SteamUserStats.StoreStats();
		}
	}

	public static int GetIndex(Dictionary<string, FullMapData> BNBPKEFNIFI, string HFEFHOPOLIK)
	{
		for (int i = 0; i < BNBPKEFNIFI.Count; i++)
		{
			if (BNBPKEFNIFI.Skip(i).First<KeyValuePair<string, FullMapData>>().Key == HFEFHOPOLIK)
			{
				return i;
			}
		}
		return -1;
	}

	public static Color StringToColor(string KLOGENNCEPK)
	{
		string[] array = KLOGENNCEPK.Split(new char[]
		{
			','
		});
		Color result = new Color(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]));
		return result;
	}

	public static string ColorToString(Color HABLFKCCKLN)
	{
		return string.Concat(new object[]
		{
			string.Empty,
			HABLFKCCKLN.r,
			",",
			HABLFKCCKLN.g,
			",",
			HABLFKCCKLN.b
		});
	}

	public static string CalculateMD5(string DDAOMDPAIEP)
	{
		string result;
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(DDAOMDPAIEP))
			{
				byte[] value = md.ComputeHash(fileStream);
				result = BitConverter.ToString(value).Replace("-", string.Empty).ToLowerInvariant();
			}
		}
		return result;
	}

	public static string Md5Sum(string FPNPDIKFPEG)
	{
		if (!string.IsNullOrEmpty(FPNPDIKFPEG))
		{
			UTF8Encoding utf8Encoding = new UTF8Encoding();
			byte[] bytes = utf8Encoding.GetBytes(FPNPDIKFPEG);
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = md5CryptoServiceProvider.ComputeHash(bytes);
			string text = string.Empty;
			for (int i = 0; i < array.Length; i++)
			{
				text += Convert.ToString(array[i], 16).PadLeft(2, '0');
			}
			return text.PadLeft(32, '0');
		}
		return null;
	}

	public static string GetDirectory(string NBEBMKFPBEP)
	{
		NBEBMKFPBEP = Application.dataPath + "/../" + NBEBMKFPBEP;
		return NBEBMKFPBEP;
	}

	public static void DirectoryCopy(string DLJFEBLOHAE, string JODLOJBNAEH, bool BHOINKKEABD)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(DLJFEBLOHAE);
		if (!directoryInfo.Exists)
		{
			throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + DLJFEBLOHAE);
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		if (!Directory.Exists(JODLOJBNAEH))
		{
			Directory.CreateDirectory(JODLOJBNAEH);
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			string destFileName = Path.Combine(JODLOJBNAEH, fileInfo.Name);
			fileInfo.CopyTo(destFileName, false);
		}
		if (BHOINKKEABD)
		{
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				string jodlojbnaeh = Path.Combine(JODLOJBNAEH, directoryInfo2.Name);
				Helpers.DirectoryCopy(directoryInfo2.FullName, jodlojbnaeh, BHOINKKEABD);
			}
		}
	}

	public static Color ColorGradient(Color MGHJCGBNEPL, Color NBPMHDANECK, float DPNHODJHGJL)
	{
		Gradient gradient = new Gradient();
		GradientColorKey[] array = new GradientColorKey[2];
		array[0].color = NBPMHDANECK;
		array[0].time = 0f;
		array[1].color = MGHJCGBNEPL;
		array[1].time = 1f;
		GradientAlphaKey[] array2 = new GradientAlphaKey[2];
		array2[0].alpha = 1f;
		array2[0].time = 0f;
		array2[1].alpha = 1f;
		array2[1].time = 1f;
		gradient.SetKeys(array, array2);
		return gradient.Evaluate(DPNHODJHGJL);
	}

	public static void ClearDirectory(string LFLCJFDDFAG)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(LFLCJFDDFAG);
		foreach (FileInfo fileInfo in directoryInfo.GetFiles())
		{
			fileInfo.Delete();
		}
		foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
		{
			Helpers.ClearDirectory(directoryInfo2.FullName);
			directoryInfo2.Delete();
		}
	}

	public static void CheckDirectory(string BOGDHCDIMHN)
	{
		if (!Directory.Exists(BOGDHCDIMHN))
		{
			Directory.CreateDirectory(BOGDHCDIMHN);
		}
	}

	public static IEnumerator LoadAudio(string NBEBMKFPBEP, bool NFJAJLPOOCA = false)
	{
		Helpers.resultAudio = null;
		if (!NFJAJLPOOCA)
		{
			NBEBMKFPBEP = Helpers.GetDirectory(NBEBMKFPBEP);
		}
		WWW www = new WWW("file://" + NBEBMKFPBEP);
		yield return www;
		Helpers.resultAudio = www.GetAudioClip(false);
		yield return Helpers.resultAudio;
		yield break;
	}

	public static IEnumerator GetAudioLength(string NBEBMKFPBEP, bool NFJAJLPOOCA = false)
	{
		Helpers.resultAudioLength = 0f;
		if (!NFJAJLPOOCA)
		{
			NBEBMKFPBEP = Helpers.GetDirectory(NBEBMKFPBEP);
		}
		WWW www = new WWW("file://" + NBEBMKFPBEP);
		yield return www;
		Helpers.resultAudioLength = www.GetAudioClip(false, new FileInfo(NBEBMKFPBEP).Extension.ToLower() != ".mp3").length;
		yield return Helpers.resultAudioLength;
		yield break;
	}

	public static IEnumerator LoadText(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string key = HAEBGHHMEBH;
		string value = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		yield return true;
		if (!Helpers.textResult.ContainsKey(key))
		{
			Helpers.textResult.Add(key, value);
		}
		else
		{
			Helpers.textResult[key] = value;
		}
		yield break;
	}

	public static string LoadTextString(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string result = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			result = File.ReadAllText(fullName);
		}
		return result;
	}

	public static void LoadMapConfig(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string key = HAEBGHHMEBH;
		string value = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(GameManager.Decrypt(fullName));
		}
		if (!Helpers.textResult.ContainsKey(key))
		{
			Helpers.textResult.Add(key, value);
		}
		else
		{
			Helpers.textResult[key] = value;
		}
	}

	public static IEnumerator SaveFile(string HAEBGHHMEBH, string NOJGGCLPPAM, bool HIIOLMMOCPN = false)
	{
		if (!HIIOLMMOCPN)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		if (File.Exists(HAEBGHHMEBH))
		{
			File.Delete(HAEBGHHMEBH);
		}
		File.WriteAllText(HAEBGHHMEBH, NOJGGCLPPAM);
		yield return null;
		yield break;
	}

	public static void SetColor(string EBEHBBDKDFJ, Color HABLFKCCKLN)
	{
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".r", HABLFKCCKLN.r, null);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".g", HABLFKCCKLN.g, null);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".b", HABLFKCCKLN.b, null);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".a", HABLFKCCKLN.a, null);
	}

	public static Color GetColor(string EBEHBBDKDFJ, Color HABLFKCCKLN)
	{
		return new Color(0f, 0f, 0f, 0f)
		{
			r = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".r", HABLFKCCKLN.r, null),
			g = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".g", HABLFKCCKLN.g, null),
			b = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".b", HABLFKCCKLN.b, null),
			a = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".a", HABLFKCCKLN.a, null)
		};
	}

	public static void DeleteColorKey(string EBEHBBDKDFJ)
	{
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".r", null);
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".g", null);
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".b", null);
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".a", null);
	}

	public static Texture2D FlipTexture(Texture2D LMHCHLAIMJH)
	{
		if (LMHCHLAIMJH != null)
		{
			Texture2D texture2D = new Texture2D(LMHCHLAIMJH.width, LMHCHLAIMJH.height);
			int width = LMHCHLAIMJH.width;
			int height = LMHCHLAIMJH.height;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					texture2D.SetPixel(i, height - j - 1, LMHCHLAIMJH.GetPixel(i, j));
				}
			}
			texture2D.Apply();
			return texture2D;
		}
		return new Texture2D(2, 2);
	}

	public static Texture2D GetSteamImageAsTexture2D(int JLGNPNGBLOA)
	{
		Texture2D texture2D = null;
		uint num;
		uint num2;
		bool flag = SteamUtils.GetImageSize(JLGNPNGBLOA, out num, out num2);
		if (flag)
		{
			byte[] array = new byte[num * num2 * 4U];
			flag = SteamUtils.GetImageRGBA(JLGNPNGBLOA, array, (int)(num * num2 * 4U));
			if (flag)
			{
				texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, false);
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
		}
		return Helpers.FlipTexture(texture2D);
	}

	public static float[] GetWaveform(AudioClip LDJFFDCLEFG, int FEKLGMEFABB)
	{
		FEKLGMEFABB = LDJFFDCLEFG.frequency / FEKLGMEFABB;
		float[] array = new float[LDJFFDCLEFG.samples * LDJFFDCLEFG.channels];
		float[] array2 = new float[array.Length / (FEKLGMEFABB * LDJFFDCLEFG.channels)];
		LDJFFDCLEFG.GetData(array, 0);
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = 0f;
			for (int j = 0; j < FEKLGMEFABB; j++)
			{
				array2[i] += Mathf.Abs(array[i * LDJFFDCLEFG.channels * FEKLGMEFABB + j]);
			}
			array2[i] /= (float)FEKLGMEFABB;
		}
		return array2;
	}

	public static Texture2D PaintWaveformSpectrum(float[] IPAAACMOHAB, int PBMAGEKDPLI, Color ONHIBAJJACC, Color NCFLAHLHKPI)
	{
		Texture2D texture2D = new Texture2D(IPAAACMOHAB.Length, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		for (int i = 0; i < IPAAACMOHAB.Length; i++)
		{
			int num = 0;
			while ((float)num <= (float)PBMAGEKDPLI / 2f)
			{
				texture2D.SetPixel(i, num, NCFLAHLHKPI);
				texture2D.SetPixel(i, -num, NCFLAHLHKPI);
				num++;
			}
		}
		for (int j = 0; j < IPAAACMOHAB.Length; j++)
		{
			int num2 = 0;
			while ((float)num2 <= IPAAACMOHAB[j] * (float)PBMAGEKDPLI / 2f)
			{
				texture2D.SetPixel(j, PBMAGEKDPLI / 2 + num2, ONHIBAJJACC);
				texture2D.SetPixel(j, PBMAGEKDPLI / 2 - num2, ONHIBAJJACC);
				num2++;
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	public static float DbToNormal(float HDAMKJKNKJI)
	{
		return Mathf.Pow(10f, HDAMKJKNKJI / 20f);
	}

	public static float NormalToDb(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 0f) ? -80f : (20f * Mathf.Log10(JCLIHOKDOHN));
	}

	public static string GetRelativeDateTime(DateTime MJHMIFPOJEA)
	{
		string result = string.Empty;
		TimeSpan t = DateTime.Now.Subtract(MJHMIFPOJEA);
		if (t <= TimeSpan.FromSeconds(60.0))
		{
			result = string.Format("{0} seconds ago", t.Seconds);
		}
		else if (t <= TimeSpan.FromMinutes(60.0))
		{
			result = ((t.Minutes <= 1) ? "a minute ago" : string.Format("{0} minutes ago", t.Minutes));
		}
		else if (t <= TimeSpan.FromHours(24.0))
		{
			result = ((t.Hours <= 1) ? "an hour ago" : string.Format("{0} hours ago", t.Hours));
		}
		else if (t <= TimeSpan.FromDays(30.0))
		{
			result = ((t.Days <= 1) ? "yesterday" : string.Format("{0} days ago", t.Days));
		}
		else if (t <= TimeSpan.FromDays(365.0))
		{
			result = ((t.Days <= 30) ? "a month ago" : string.Format("{0} months ago", t.Days / 30));
		}
		else
		{
			result = ((t.Days <= 365) ? "a year ago" : string.Format("{0} years ago", t.Days / 365));
		}
		return result;
	}

	public static string RemoveSpecialCharacters(string DPNHODJHGJL, char[] MPOJANPJEHH)
	{
		return new string(DPNHODJHGJL.Except(MPOJANPJEHH).ToArray<char>());
	}

	public static List<EditorEventFunctionInfo> GetAvailableEditorEvents(int vers)
	{
		return (from x in Helpers.eventsMap
		where x.minConfigVersion <= vers && (x.maxConfigVersion < 0 || (x.maxConfigVersion > 0 && x.maxConfigVersion >= vers))
		select x).ToList<EditorEventFunctionInfo>();
	}

	public static string FormatTime(float HHGFDGOKNMD, bool BLCMJNECOGL = false)
	{
		int num = (int)Mathf.Abs(HHGFDGOKNMD / 60f);
		int num2 = (int)(HHGFDGOKNMD % 60f);
		string text = string.Empty + (HHGFDGOKNMD % 1f).ToString("0.000").Remove(0, 1);
		return num.ToString("00") + ":" + num2.ToString("00") + (BLCMJNECOGL ? text : string.Empty);
	}

	public static string ToReadableAgeString(this TimeSpan NMCHKFGKGFJ)
	{
		return string.Format("{0:0}", (double)NMCHKFGKGFJ.Days / 365.25);
	}

	public static string ToReadableString(this TimeSpan NMCHKFGKGFJ)
	{
		string text = string.Empty;
		if (NMCHKFGKGFJ.Duration().Days > 1)
		{
			text = string.Format("{0}", (NMCHKFGKGFJ.Duration().Days <= 0) ? string.Empty : string.Format("{0:0} day{1}, ", NMCHKFGKGFJ.Days, (NMCHKFGKGFJ.Days != 1) ? "s" : string.Empty));
		}
		else if (NMCHKFGKGFJ.Duration().Hours > 0)
		{
			text = string.Format("{0}{1}{2}", (NMCHKFGKGFJ.Duration().Days <= 0) ? string.Empty : string.Format("{0:0} day{1}, ", NMCHKFGKGFJ.Days, (NMCHKFGKGFJ.Days != 1) ? "s" : string.Empty), (NMCHKFGKGFJ.Duration().Hours <= 0) ? string.Empty : string.Format("{0:0} hour{1}, ", NMCHKFGKGFJ.Hours, (NMCHKFGKGFJ.Hours != 1) ? "s" : string.Empty), (NMCHKFGKGFJ.Duration().Minutes <= 0) ? string.Empty : string.Format("{0:0} minute{1}, ", NMCHKFGKGFJ.Minutes, (NMCHKFGKGFJ.Minutes != 1) ? "s" : string.Empty));
		}
		else if (NMCHKFGKGFJ.Duration().Minutes > 0)
		{
			text = string.Format("{0}", (NMCHKFGKGFJ.Duration().Minutes <= 0) ? string.Empty : string.Format("{0:0} minute{1}, ", NMCHKFGKGFJ.Minutes, (NMCHKFGKGFJ.Minutes != 1) ? "s" : string.Empty));
		}
		else
		{
			text = string.Format("{0}", (NMCHKFGKGFJ.Duration().Seconds < 0) ? string.Empty : string.Format("{0:0} second{1}", NMCHKFGKGFJ.Seconds, (NMCHKFGKGFJ.Seconds != 1) ? "s" : string.Empty));
		}
		if (text.EndsWith(", "))
		{
			text = text.Substring(0, text.Length - 2);
		}
		if (string.IsNullOrEmpty(text))
		{
			text = "0 seconds";
		}
		return text;
	}

	public static bool isChallengeUnlocked(string EKFAHHJOJHE)
	{
		if (string.IsNullOrEmpty(EKFAHHJOJHE))
		{
			return true;
		}
		bool result = true;
		foreach (string str in EKFAHHJOJHE.Replace(" ", string.Empty).Split(new char[]
		{
			','
		}).ToList<string>())
		{
			if (Singleton<SaveSystem>.Instance.GetInt("challenges." + str + ".status", null) < 2)
			{
				result = false;
			}
		}
		return result;
	}

	// TODO: GET RID OF THESE
	[CompilerGenerated]
	private static bool LFJDIMOEADJ(char HBJIMONFKNL)
	{
		return HBJIMONFKNL == '-';
	}
	[CompilerGenerated]
	private static bool NDFPKEBFAGM(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "SpawnObj";
	}

	public static float Damp(float source, float target, float smoothing, float dt)
	{
		if (!Helpers.Approximately(source, target, 1E-05f) && smoothing != 0f)
		{
			return Mathf.Lerp(source, target, 1f - Mathf.Exp(-smoothing * dt));
		}
		return target;
	}

	public static Vector3 Damp(Vector3 source, Vector3 target, float smoothing, float dt)
	{
		if (!Helpers.FuzzyEqual(source, target, Helpers.epsilon) && smoothing != 0f)
		{
			return new Vector3(Helpers.Damp(source.x, target.x, smoothing, dt), Helpers.Damp(source.y, target.y, smoothing, dt), Helpers.Damp(source.z, target.z, smoothing, dt));
		}
		return target;
	}

	public static Quaternion Damp(Quaternion source, Quaternion target, float smoothing, float dt)
	{
		if (!Helpers.Approximately(source, target, 1E-05f) && smoothing != 0f)
		{
			return Quaternion.Lerp(source, target, 1f - Mathf.Exp(-smoothing * dt));
		}
		return target;
	}

	public static Vector3 Damp(Vector3 source, Vector3 target, float smoothing)
	{
		return Helpers.Damp(source, target, smoothing, Time.deltaTime);
	}

	public static float Damp(float source, float target, float smoothing)
	{
		return Helpers.Damp(source, target, smoothing, Time.deltaTime);
	}

	public static Quaternion Damp(Quaternion source, Quaternion target, float smoothing)
	{
		return Helpers.Damp(source, target, smoothing, Time.deltaTime);
	}

	public static Color Damp(Color source, Color target, float smoothing, float dt)
	{
		if (!Helpers.Approximately(source, target, 0.004f) && smoothing != 0f)
		{
			return Color.Lerp(source, target, 1f - Mathf.Exp(-smoothing * dt));
		}
		return target;
	}

	public static Color Damp(Color source, Color target, float smoothing)
	{
		return Helpers.Damp(source, target, smoothing, Time.deltaTime);
	}

	public static bool Approximately(float x, float y, float tolerance = 1E-05f)
	{
		float num = Mathf.Abs(x - y);
		return num <= tolerance || num <= Mathf.Max(Math.Abs(x), Math.Abs(y)) * tolerance;
	}

	public static bool Approximately(Vector3 x, Vector3 y, float tolerance = 1E-05f)
	{
		return Helpers.Approximately(x.x, y.x, tolerance) && Helpers.Approximately(x.y, y.y, tolerance) && Helpers.Approximately(x.z, y.z, tolerance);
	}

	public static bool Approximately(Quaternion x, Quaternion y, float tolerance = 1E-05f)
	{
		return Helpers.Approximately(x.x, y.x, tolerance) && Helpers.Approximately(x.y, y.y, tolerance) && Helpers.Approximately(x.z, y.z, tolerance) && Helpers.Approximately(x.w, y.w, tolerance);
	}

	public static bool Approximately(Color x, Color y, float tolerance = 0.004f)
	{
		return Helpers.Approximately(x.r, y.r, tolerance) && Helpers.Approximately(x.g, y.g, tolerance) && Helpers.Approximately(x.b, y.b, tolerance) && Helpers.Approximately(x.a, y.a, tolerance);
	}

	// TODO: maybe?
	public static bool IsModdedData(MapEvent mapEvent)
	{
		return false;
	}

	public static bool IsModdedData(MapEvent mapEvent, out int startIndex)
	{
		if (mapEvent.data[0].Equals("SetPlayerDistance") && mapEvent.data[1].Split(new char[]
		{
			','
		}).Length > 1)
		{
			startIndex = 1;
			return true;
		}
		startIndex = -1;
		return false;
	}

	public static bool FuzzyEqual(float a, float b, float epsilon)
	{
		return Math.Abs(a - b) < epsilon;
	}

	public static bool FuzzyEqual(Vector3 a, Vector3 b, float epsilon)
	{
		return Helpers.FuzzyEqual(Vector3.SqrMagnitude(a - b), 0f, epsilon);
	}

	// Figure out where the caret should go when going back to editor
	public static float PlayTestLastTime
	{
		get
		{
			float result = Helpers.playTestLastTime;
			Helpers.playTestLastTime = 0f;
			return result;
		}
		set
		{
			Helpers.playTestLastTime = value;
		}
	}

	public static Vector3 Clamp(Vector3 vec, float min, float max)
	{
		Vector3 result = vec;
		result.x = Mathf.Clamp(vec.x, min, max);
		result.y = Mathf.Clamp(vec.y, min, max);
		result.z = Mathf.Clamp(vec.z, min, max);
		return result;
	}

	public static Vector3 Clamp(Vector3 vec, Vector3 min, Vector3 max)
	{
		Vector3 result = vec;
		result.x = Mathf.Clamp(vec.x, min.x, max.y);
		result.y = Mathf.Clamp(vec.y, min.y, max.y);
		result.z = Mathf.Clamp(vec.z, min.z, max.z);
		return result;
	}

	public static string levelConfigFileName = "config.txt";
	public static string mapEncodedConfigFileName = "map.data";
	public static string workshopConfigFileName = "workshop.txt";

	public static string newsURL = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510";
	public static string newsGIDURL = "/GetNews/pinnednewsid";

	// Modded Tags
	public static List<string> specialTags = new List<string>
	{
		"NoTag"
	};

	// Genre tags, vanilla
	public static List<string> tags = new List<string>
	{
		"Alternative",
		"Anime",
		"Blues",
		"Children",
		"Classical",
		"Dance",
		"Electronic",
		"Folk",
		"Hip-hop",
		"Indie",
		"Instrumental",
		"Jazz",
		"Metal",
		"Pop",
		"Rap",
		"Rock",
		"Soundtrack",
		"Other"
	};

	public static List<string> patternsMap = new List<string>
	{
		"[Up]",
		"[Right]",
		"[Down]",
		"[Left]",
		"[Up-Right-Left]",
		"[Up-Right-Down]",
		"[Right-Down-Left]",
		"[Up-Down-Left]",
		"[Up-Right-Down-Left]",
		"[PowerUp]",
		"[Up-Right]",
		"[Up-Down]",
		"[Up-Left]",
		"[Right-Down]",
		"[Right-Left]",
		"[Down-Left]"
	};

	public static string eventsMapLine = "\n";

	// Event Editor events
	// TODO: Move this somwhere more relevant?
	public static List<EditorEventFunctionInfo> eventsMap = new List<EditorEventFunctionInfo>
	{
		new EditorEventFunctionInfo("SpawnObj", "Arc", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("arc", EditorEventFunctionInfo.EditorEventParametrType.ArcSelector, string.Empty, null),
			new EditorEventFunctionInfo.EditorEventParametr("hand", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - default, 1 - left, 2 - right", "0,2,true,0")
		}, "Spawn arc to be pressed at this time", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetSpeed", "Set Arcs Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,15")
		}, "Set arcs speed. Base value - 15", 2, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetPlayerDistance", "Set Player Distance", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("Distance", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,14"),
			new EditorEventFunctionInfo.EditorEventParametr("Lerp Speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "How fast the camera moves. Higher is quicker, lower is slower. Use 0 for instant. Use decimals (i.e. 0.5) for extreme slow. Base value - 5", "float,5")
		}, "Set camera (or player) distance. Base player distance - 14", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetPlayerPosition", "Set Player Position", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("X", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("Y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("Lerp Speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "How fast the camera moves. Higher is quicker, lower is slower. Use 0 for instant. Use decimals (i.e. 0.5) for extreme slow. Base value - 5", "float,5")
		}, "Set camera (or player) location. X is left-right. Y is up-down. Base value - 0,0", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetPlayerRotation", "Set Player Rotation", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("X", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("Y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("Z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("Lerp Speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "How fast the camera moves. Higher is quicker, lower is slower. Use 0 for instant. Use decimals (i.e. 0.5) for extreme slow. Base value - 5", "float,5")
		}, "Set the camera (or player) rotation. X is Up/Down. Y is Left/Right. Z is Tilt. Base value - 0, 0, 0", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetBPM", "Set BPM", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("BPM", EditorEventFunctionInfo.EditorEventParametrType.InputField, "beats per minute", "float,120"),
			new EditorEventFunctionInfo.EditorEventParametr("Split", EditorEventFunctionInfo.EditorEventParametrType.Slider, "how many subdivisions (most songs only use 1, 2, 3, 4, 6, 8, 12, 16)", "1,16,true,0")
		}, "Set the BPM. When the caret passes over this event the editor will change the BPM tool.", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("MapEnd", "Music End", new List<EditorEventFunctionInfo.EditorEventParametr>(), "Set the end of the map. Use this if you want to cut the long music.", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("ShowSprite", "Show Image", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("resource id", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, null),
			new EditorEventFunctionInfo.EditorEventParametr("position", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - background, 1 - foreground", "0,1,true,0"),
			new EditorEventFunctionInfo.EditorEventParametr(string.Empty, EditorEventFunctionInfo.EditorEventParametrType.Toggle, string.Empty, "keep aspect ratio"),
			new EditorEventFunctionInfo.EditorEventParametr("duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "in seconds. 0 - forever", "float,10"),
			new EditorEventFunctionInfo.EditorEventParametr("fade in duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "seconds", "float,0.5"),
			new EditorEventFunctionInfo.EditorEventParametr("fade out duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "seconds", "float,0.5")
		}, "Show image from resources by id at the center of the screen at foreground or background", 1, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("ShowTitle", "Show Title", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("title", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, null),
			new EditorEventFunctionInfo.EditorEventParametr("duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Message duration multiplier. Recomended 1", "float,1")
		}, "Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", 1, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetBGColor", "Set Background Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("red", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("green", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("blue", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Lerp speed. Recomended 10", "float,10")
		}, "Set camera background color", 1, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetTrailZoomSpeed", "Set Trail Zoom Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Zoom speed. Base 1.5", "float,1.5")
		}, "Set Trail Zoom (player camera move forward effect). Base value - 1.5", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("AddEnvironmentObject", "Add Environment Object", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("type", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - sun, 1 - satellite, 2 - particles emitter", "0,2,true,0"),
			new EditorEventFunctionInfo.EditorEventParametr("set id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null)
		}, "Spawn new environment object (sun, satellite etc) and sets its id", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("RemoveEnvironmentObject", "Remove Environment Object", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null)
		}, "Despawn environment object by id", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("ClearEnvironment", "Clear Environment", new List<EditorEventFunctionInfo.EditorEventParametr>(), "Destroy all spawned environment objects", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetPosition", "Set Object Position", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Move environment object to the position", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetRotation", "Set Object Rotation", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Rotate environment object to the rotation", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetScale", "Set Object Scale", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Scale environment object by the values", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParent", "Set Parent", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("Object ID", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("Parent ID", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Parent object ID. Case-Sensitive", null)
		}, "Set object anchor to another object", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunColors", "Set Sun Colors", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("max. lives color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null),
			new EditorEventFunctionInfo.EditorEventParametr("no lives color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null)
		}, "Set sun colors", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunEmission", "Set Sun Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set sun emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunInput", "Set Sun Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set sun audio input", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunLerpSpeed", "Set Sun Lerp Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set sun lerp speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunSensitivity", "Set Sun Sensitivity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,50")
		}, "Set sun beat detection sensitivity", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunMinSize", "Set Sun MinSize", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set sun min/max size", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunMaxSize", "Set Sun MaxSize", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set sun min/max size", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunDirectionVector", "Set Sun DirectionVector", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set sun directionVector - in which direction sun will grow on beat", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteColor", "Set Satellite Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null)
		}, "Set satellite color", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteEmission", "Set Satellite Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set satellite emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteInput", "Set Satellite Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set satellite audio input", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteLerpSpeed", "Set Satellite Lerp Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set satellite lerp speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteSensitivity", "Set Satellite Sensitivity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,50")
		}, "Set satellite beat detection sensitivity", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteRotationSpeed", "SetSatelliteRotationSpeed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,40")
		}, "Set satellite clockwise rotattion speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteRadius", "Set Satellite Radius", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite radius (offset)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteTrailLength", "Set Satellite Trail Length", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite trail length in seconds", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteTrailWidth", "Set Satellite Trail Width", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite trail width", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteTrailMinVertexDistance", "Set Satellite Trail MinVertexDistance", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite MinVertexDistance - how much distance should be between to points of the trail line", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetCrosshairColor", "Set Crosshair Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Lerp speed. Recomended 10", "float,10")
		}, "Set crosshair color", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetCrosshairEmission", "Set Crosshair Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set crosshair emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesColor", "Set Particles Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null)
		}, "Set particles color", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesEmission", "Set Particles Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set particless emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesParticleSize", "Set Particle Size", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set particles size", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesGravity", "Set Particles Gravity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles gravity", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesParticleSpeed", "Set Particles Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles start speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesCountPerBeat", "Set Particles Count Per Beat", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles count per one beat", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesInput", "Set Particles Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set particles audio input", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("AddEnvironmentSprite", "Add Environment Sprite", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("resource id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "(from resources)", null),
			new EditorEventFunctionInfo.EditorEventParametr("set environment id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", "float,10"),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Start Color's hex value #RRGGBBAA", "#FFFFFFFF")
		}, "Spawn new environment sprite (image) and sets its id", 3, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetEnvSpriteImage", "Set EnvSprite Image", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("image", EditorEventFunctionInfo.EditorEventParametrType.InputField, "New resource ID. Case-Sensitive", null)
		}, "Switch environment sprite image", 3, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetEnvSpriteColor", "Set EnvSprite Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Color's hex value #RRGGBBAA", "#FFFFFFFF"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", "float,10")
		}, "Set environment sprite color and alpha.", 3, -1, EditorEventFunctionInfo.EditorEventType.Storyboard)
	};

	public static Dictionary<string, string> textResult = new Dictionary<string, string>();
	public static Sprite resultImage = null;
	public static Dictionary<string, bool> resultLevelNotModified = new Dictionary<string, bool>();
	public static bool resultSubmitNewHash = false;
	public static AudioClip resultAudio = null;
	public static float resultAudioLength = 0f;

	[CompilerGenerated]
	private static Func<char, bool> LNIJKGECNME;

	[CompilerGenerated]
	private static Func<double, double> CLCBJCKCBDD;

	[CompilerGenerated]
	private static Func<MapEvent, bool> HCLEECLNOEA;

	public const float EPSILON = 1E-06f;
	private static float epsilon = 1E-05f;

	private static float playTestLastTime;

	

	// TODO:
	// Figure out what uses these so we can fix it and then get rid of these blocks

	// Token: 0x02000426 RID: 1062
	[CompilerGenerated]
	private sealed class CEMBABEIJBO
	{
		// Token: 0x0600E2B5 RID: 58037 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool NIFPHAJMPFC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2B6 RID: 58038 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool HJNKOEGPEMO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2B7 RID: 58039 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool AHBIANHNBBC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2B8 RID: 58040 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool AGFDCBCBAGI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2B9 RID: 58041 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool HJKJAANIFLL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2BA RID: 58042 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		internal bool ABGMHCAMGEG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2BB RID: 58043 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool MJHMNKHNMHF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2BC RID: 58044 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool FFEGPHJKMFK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2BD RID: 58045 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool DNIMHEKGJHB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2BE RID: 58046 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool HIKCHCCKLJG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2BF RID: 58047 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool DBFPGFHEGKA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2C0 RID: 58048 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool GBKBDKHPLKG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2C2 RID: 58050 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool JDELIMPGFDJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2C3 RID: 58051 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool DBOEBFFAOFJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2C4 RID: 58052 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		internal bool PCAFEACHAAC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2C5 RID: 58053 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool KFNBKFELFLH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2C6 RID: 58054 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool LJDLIIIPIIJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2C7 RID: 58055 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool MEMPOPNAEDN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool PKAPLCFHDOC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2C9 RID: 58057 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool FHFECFLBHMA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2CA RID: 58058 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool DKGPCPBNDPK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2CB RID: 58059 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		internal bool KFNPHCCAJFD(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2CC RID: 58060 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool OMJJLDBPEHI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2CD RID: 58061 RVA: 0x0009B9CC File Offset: 0x00099BCC
		internal bool PHGILLBNBME(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2CE RID: 58062 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool OMBHIBNMFNB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2CF RID: 58063 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool NJGBIMFOOKP(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D0 RID: 58064 RVA: 0x0009B9CC File Offset: 0x00099BCC
		internal bool NLALPCHCOPE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2D1 RID: 58065 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool IHKIFALHGHN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D2 RID: 58066 RVA: 0x0009B9CC File Offset: 0x00099BCC
		internal bool BOPKCHEPEEB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2D3 RID: 58067 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool MOJKEOEEEDF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D4 RID: 58068 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool PIJAOCFAPKC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D5 RID: 58069 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool LOEAMHGMMPK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool BDGDIDPDBHG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D7 RID: 58071 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool LLNDDFGPOPL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D8 RID: 58072 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool HBJFIOJFBHC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2D9 RID: 58073 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool GLLCFMBPDEG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2DA RID: 58074 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool FIPCLHEKKCA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2DB RID: 58075 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool HMMBBDJNGGL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2DC RID: 58076 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool BKNHHGBPLGH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2DD RID: 58077 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool INCKLCFEMJK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2DE RID: 58078 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool FJDBPPKABJE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool JBAJEMGOPDL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool LHHFJBIAHCN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool KGKMOLCPDIH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2E2 RID: 58082 RVA: 0x0009B9CC File Offset: 0x00099BCC
		internal bool CHBEFOHEEGK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2E3 RID: 58083 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool AKDOOLPMPMG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2E4 RID: 58084 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		internal bool BPJGFELFEDC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2E5 RID: 58085 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool GDFBBMNOGGD(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool OFLDIMDDLHM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool DFPLMEODJAM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool FKCDLJELMNN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool OLIGLEMPFOP(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2EA RID: 58090 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool BJMAIJDIKCN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2EB RID: 58091 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool CBHLHPPBCIG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2EC RID: 58092 RVA: 0x0009B960 File Offset: 0x00099B60
		internal bool MKLOGMNMFAF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool JBCHBMKPDAJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2EE RID: 58094 RVA: 0x0009B9CC File Offset: 0x00099BCC
		internal bool HKCAPINMNFF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2EF RID: 58095 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool ECGDAHDOPBO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2F0 RID: 58096 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool OFHCGKJFGDI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x0009B984 File Offset: 0x00099B84
		internal bool PHDFIAGENEE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		internal bool PLINPGHDODA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool PBCAHKDLFPE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E2F4 RID: 58100 RVA: 0x0009B94D File Offset: 0x00099B4D
		internal bool EKHOOPGPPGE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x04001B04 RID: 6916
		internal string JMMILEFMACB;
	}

	// Token: 0x0200042B RID: 1067
	[CompilerGenerated]
	private sealed class GONBBDCKFPG
	{
		// Token: 0x0600E442 RID: 58434 RVA: 0x004DFB74 File Offset: 0x004DDD74
		internal bool BJMAIJDIKCN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E443 RID: 58435 RVA: 0x004DFBC4 File Offset: 0x004DDDC4
		internal bool GLHKGBNIHFH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E444 RID: 58436 RVA: 0x004DFC14 File Offset: 0x004DDE14
		internal bool OLIGLEMPFOP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E445 RID: 58437 RVA: 0x004DFC64 File Offset: 0x004DDE64
		internal bool FDAIFOAGDLA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E446 RID: 58438 RVA: 0x004DFC14 File Offset: 0x004DDE14
		internal bool FJDBPPKABJE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E447 RID: 58439 RVA: 0x004DFCB4 File Offset: 0x004DDEB4
		internal bool BKNHHGBPLGH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E448 RID: 58440 RVA: 0x004DFD04 File Offset: 0x004DDF04
		internal bool LNDGINDKPFA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x004DFC64 File Offset: 0x004DDE64
		internal bool AGFDCBCBAGI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E44A RID: 58442 RVA: 0x004DFD54 File Offset: 0x004DDF54
		internal bool FMIHBNPKEEO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600E44B RID: 58443 RVA: 0x004DFDA4 File Offset: 0x004DDFA4
		internal bool HBJFIOJFBHC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600E44C RID: 58444 RVA: 0x004DFDF4 File Offset: 0x004DDFF4
		internal bool BDGDIDPDBHG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E44D RID: 58445 RVA: 0x004DFE44 File Offset: 0x004DE044
		internal bool FHFECFLBHMA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x004DFE94 File Offset: 0x004DE094
		internal bool MAGEPMCPGOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600E44F RID: 58447 RVA: 0x004DFEE4 File Offset: 0x004DE0E4
		internal bool JBCHBMKPDAJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E450 RID: 58448 RVA: 0x004DFF34 File Offset: 0x004DE134
		internal bool PCDFLCEIHFF(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E451 RID: 58449 RVA: 0x004DFB74 File Offset: 0x004DDD74
		internal bool EKHOOPGPPGE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x004DFE44 File Offset: 0x004DE044
		internal bool GBKBDKHPLKG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x004DFF84 File Offset: 0x004DE184
		internal bool JDELIMPGFDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E454 RID: 58452 RVA: 0x004DFFD4 File Offset: 0x004DE1D4
		internal bool IGFOBPKFCDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600E455 RID: 58453 RVA: 0x004E0024 File Offset: 0x004DE224
		internal bool AEINPAGJFME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600E456 RID: 58454 RVA: 0x004E0074 File Offset: 0x004DE274
		internal bool LHHFJBIAHCN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E457 RID: 58455 RVA: 0x004DFCB4 File Offset: 0x004DDEB4
		internal bool MPGGBMMPNDH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E458 RID: 58456 RVA: 0x004E00C4 File Offset: 0x004DE2C4
		internal bool JKEDCEOCPJO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600E459 RID: 58457 RVA: 0x004E0114 File Offset: 0x004DE314
		internal bool OFHCGKJFGDI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E45A RID: 58458 RVA: 0x004E0164 File Offset: 0x004DE364
		internal bool FHIJCPPECHA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E45B RID: 58459 RVA: 0x004DFDF4 File Offset: 0x004DDFF4
		internal bool DBFPGFHEGKA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E45C RID: 58460 RVA: 0x004DFCB4 File Offset: 0x004DDEB4
		internal bool EFAPFFFGOOA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E45D RID: 58461 RVA: 0x004DFC64 File Offset: 0x004DDE64
		internal bool PKAPLCFHDOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E45E RID: 58462 RVA: 0x004DFD54 File Offset: 0x004DDF54
		internal bool EGKGJJGAPMN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600E45F RID: 58463 RVA: 0x004DFF84 File Offset: 0x004DE184
		internal bool KGKMOLCPDIH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E460 RID: 58464 RVA: 0x004E01B4 File Offset: 0x004DE3B4
		internal bool MEMPOPNAEDN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E461 RID: 58465 RVA: 0x004E0204 File Offset: 0x004DE404
		internal bool DKGPCPBNDPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII;
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x004E0254 File Offset: 0x004DE454
		internal bool KFNBKFELFLH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x004E02A4 File Offset: 0x004DE4A4
		internal bool AEIFJLBBKBP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x004DFE94 File Offset: 0x004DE094
		internal bool LLNDDFGPOPL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600E465 RID: 58469 RVA: 0x004E02F4 File Offset: 0x004DE4F4
		internal bool MGENGAEDACG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E466 RID: 58470 RVA: 0x004E0344 File Offset: 0x004DE544
		internal bool LOEAMHGMMPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E467 RID: 58471 RVA: 0x004E0394 File Offset: 0x004DE594
		internal bool BEBAENEJFLD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E468 RID: 58472 RVA: 0x004E03E4 File Offset: 0x004DE5E4
		internal bool AGJKEBOPIOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E469 RID: 58473 RVA: 0x004E0434 File Offset: 0x004DE634
		internal bool FFEGPHJKMFK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E46A RID: 58474 RVA: 0x004E0484 File Offset: 0x004DE684
		internal bool LJDLIIIPIIJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600E46B RID: 58475 RVA: 0x004E0344 File Offset: 0x004DE544
		internal bool FCAGEDLBBHD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E46C RID: 58476 RVA: 0x004E04D4 File Offset: 0x004DE6D4
		internal bool EDGAPOPEIJF(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x004DFC64 File Offset: 0x004DDE64
		internal bool BFEABMIFIEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x004DFC14 File Offset: 0x004DDE14
		internal bool OFLDIMDDLHM(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E46F RID: 58479 RVA: 0x004E0524 File Offset: 0x004DE724
		internal bool BBIADFAPKDL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600E471 RID: 58481 RVA: 0x004E0074 File Offset: 0x004DE274
		internal bool FIPCLHEKKCA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E472 RID: 58482 RVA: 0x004E0574 File Offset: 0x004DE774
		internal bool OMBHIBNMFNB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E473 RID: 58483 RVA: 0x004E05C4 File Offset: 0x004DE7C4
		internal bool DNIMHEKGJHB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600E474 RID: 58484 RVA: 0x004E0614 File Offset: 0x004DE814
		internal bool BMAOCLKPNNC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600E475 RID: 58485 RVA: 0x004E0434 File Offset: 0x004DE634
		internal bool AKDOOLPMPMG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E476 RID: 58486 RVA: 0x004DFC64 File Offset: 0x004DDE64
		internal bool PBCAHKDLFPE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E477 RID: 58487 RVA: 0x004DFD04 File Offset: 0x004DDF04
		internal bool JBAJEMGOPDL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E478 RID: 58488 RVA: 0x004E0664 File Offset: 0x004DE864
		internal bool INHOEMCLAAP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x004E0574 File Offset: 0x004DE774
		internal bool PIJAOCFAPKC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x04001B1F RID: 6943
		internal int NCCNGCFMNII;
	}
}
