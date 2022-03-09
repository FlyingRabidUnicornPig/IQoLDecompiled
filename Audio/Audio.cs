/*
Importance of this class: Potentially highly important. Signs point to old/unused code.

Purpose of this class: A general "Audio" object for music or sound effects.
Expected to be managed by LuaEnvironment (unsure how LuaEnviros are used)

Deobf status: Will not recompile in current state! Could be worse*/

using System;
using UnityEngine;

// Token: 0x020004C9 RID: 1225
public class Audio
{
	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06010209 RID: 66057 RVA: 0x000A3762 File Offset: 0x000A1962
	// (set) Token: 0x06010236 RID: 66102 RVA: 0x000A38D2 File Offset: 0x000A1AD2
	public bool activated { get; private set; }

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x0601022E RID: 66094 RVA: 0x000A37C0 File Offset: 0x000A19C0
	// (set) Token: 0x0601020A RID: 66058 RVA: 0x000A376A File Offset: 0x000A196A
	public bool stopping { get; private set; }

	// Token: 0x0601020B RID: 66059 RVA: 0x000A3773 File Offset: 0x000A1973
	public void GKCNAEMPANF(float DPNHODJHGJL)
	{
		this.<ECBIHDHGMMO>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601020C RID: 66060 RVA: 0x000A377C File Offset: 0x000A197C
	public AudioSource AKHKFKHDAEK()
	{
		return this.<BIEKOBGKLGM>k__BackingField;
	}

	// Token: 0x0601020E RID: 66062 RVA: 0x000A3784 File Offset: 0x000A1984
	public void LANNCDEJFOG(bool DPNHODJHGJL)
	{
		this.<INFLLAMBHEH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x06010220 RID: 66080 RVA: 0x000A383B File Offset: 0x000A1A3B
	// (set) Token: 0x0601020F RID: 66063 RVA: 0x000A378D File Offset: 0x000A198D
	public bool loop { get; set; }

	// Token: 0x06010210 RID: 66064 RVA: 0x0054EE4C File Offset: 0x0054D04C
	private void JPFMCDJKGLK(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		this._audiosource = new GameObject(BKGCLBJFADE.name).transform;
		this._audiosource.transform.SetParent(this.OKDDLALOEME);
		this._audiosource.transform.localPosition = Vector3.zero;
		this.audioSource = this._audiosource.gameObject.AddComponent<AudioSource>();
		this.audioSource.clip = BKGCLBJFADE;
		this.audioSource.loop = AIPGGFGKNFE;
		this.audioSource.volume = 0f;
		if (this.OKDDLALOEME != Singleton<SoundManager>.Instance.gameObject.transform)
		{
			this.audioSource.spatialBlend = 1f;
		}
	}

	// Token: 0x06010211 RID: 66065 RVA: 0x000A3796 File Offset: 0x000A1996
	public void Resume()
	{
		this.audioSource.UnPause();
		this.paused = false;
	}

	// Token: 0x06010212 RID: 66066 RVA: 0x000A3784 File Offset: 0x000A1984
	public void HJKKFKPLEBC(bool DPNHODJHGJL)
	{
		this.<INFLLAMBHEH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x06010213 RID: 66067 RVA: 0x000A37AA File Offset: 0x000A19AA
	public void NBAPCMJFNLL(float MEMALLLANHH)
	{
		this.EFBNFACGJLI().maxDistance = MEMALLLANHH;
	}

	// Token: 0x06010214 RID: 66068 RVA: 0x000A37B8 File Offset: 0x000A19B8
	public float AOINJLFJHIL()
	{
		return this.<HMPINPCDONH>k__BackingField;
	}

	// Token: 0x06010215 RID: 66069 RVA: 0x000A37C0 File Offset: 0x000A19C0
	public bool LEFMMNMAGFH()
	{
		return this.<DDPKOPCMGJE>k__BackingField;
	}

	// Token: 0x06010216 RID: 66070 RVA: 0x000A37C8 File Offset: 0x000A19C8
	public void FHBCEACPFHN(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		this.POCJBONPHKG(IFNAPFNEGMP);
		this.NBAPCMJFNLL(MEMALLLANHH);
	}

	// Token: 0x06010217 RID: 66071 RVA: 0x000A37D8 File Offset: 0x000A19D8
	public void Set3DMaxDistance(float MEMALLLANHH)
	{
		this.audioSource.maxDistance = MEMALLLANHH;
	}

	// Token: 0x06010218 RID: 66072 RVA: 0x000A37E6 File Offset: 0x000A19E6
	public void Stop()
	{
		this.HCCAAMOMPHF = 0f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = 0f;
		this.stopping = true;
	}

	// Token: 0x06010219 RID: 66073 RVA: 0x000A3811 File Offset: 0x000A1A11
	public void ELBJMOEMHNM(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		this.Set3DMinDistance(IFNAPFNEGMP);
		this.Set3DMaxDistance(MEMALLLANHH);
	}

	// Token: 0x0601021A RID: 66074 RVA: 0x000A3821 File Offset: 0x000A1A21
	private void PEANIIBIIJP(int DPNHODJHGJL)
	{
		this.<AAJKLPLJBCI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x0601021B RID: 66075 RVA: 0x000A382A File Offset: 0x000A1A2A
	// (set) Token: 0x0601021F RID: 66079 RVA: 0x000A3832 File Offset: 0x000A1A32
	public bool paused { get; private set; }

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x06010235 RID: 66101 RVA: 0x000A38E4 File Offset: 0x000A1AE4
	// (set) Token: 0x0601021C RID: 66076 RVA: 0x000A3773 File Offset: 0x000A1973
	public float fadeOutSeconds { get; set; }

	// Token: 0x0601021D RID: 66077 RVA: 0x000A37B8 File Offset: 0x000A19B8
	public float IAKKKEHGBEP()
	{
		return this.<HMPINPCDONH>k__BackingField;
	}

	// Token: 0x0601021E RID: 66078 RVA: 0x0054EF08 File Offset: 0x0054D108
	public void Play(float BDICHAELIJE)
	{
		if (this.audioSource == null)
		{
			this.JPFMCDJKGLK(this.JPIBNPJDMFM, this.loop);
		}
		this.audioSource.Play();
		this.playing = true;
		this.HCCAAMOMPHF = 0f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = BDICHAELIJE;
	}

	// Token: 0x06010221 RID: 66081 RVA: 0x000A377C File Offset: 0x000A197C
	public AudioSource EFBNFACGJLI()
	{
		return this.<BIEKOBGKLGM>k__BackingField;
	}

	// Token: 0x06010222 RID: 66082 RVA: 0x000A3843 File Offset: 0x000A1A43
	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		this.OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		this.HCCAAMOMPHF = 0f;
		this.OAJPIBOLJII = GOHKPLNBDCI;
		this.JGLODIINJAF = CEAKGNGMEEH;
	}

	// Token: 0x06010223 RID: 66083 RVA: 0x000A386A File Offset: 0x000A1A6A
	public void Set3DMinDistance(float IFNAPFNEGMP)
	{
		this.audioSource.minDistance = IFNAPFNEGMP;
	}

	// Token: 0x06010224 RID: 66084 RVA: 0x000A3878 File Offset: 0x000A1A78
	public void DACMEPBBOFI(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		this.OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		this.HCCAAMOMPHF = 1562f;
		this.OAJPIBOLJII = GOHKPLNBDCI;
		this.JGLODIINJAF = CEAKGNGMEEH;
	}

	// Token: 0x06010225 RID: 66085 RVA: 0x000A378D File Offset: 0x000A198D
	public void CEOPCECBLGE(bool DPNHODJHGJL)
	{
		this.<CMBMPMDFPAD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x06010226 RID: 66086 RVA: 0x0054EF68 File Offset: 0x0054D168
	public Audio(Audio.AudioType MJNLBJIKABL, AudioClip BKGCLBJFADE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float BDICHAELIJE, float DKNMPJDJNAE, float BCOIOGINLKJ, Transform OKDDLALOEME)
	{
		this.OKDDLALOEME = ((!(OKDDLALOEME != null)) ? Singleton<SoundManager>.Instance.gameObject.transform : OKDDLALOEME);
		this.audioID = Audio.BCIGGJPJBOK;
		Audio.BCIGGJPJBOK++;
		this.MJNLBJIKABL = MJNLBJIKABL;
		this.JPIBNPJDMFM = BKGCLBJFADE;
		this.loop = AIPGGFGKNFE;
		this.persist = HHBOIFFNPPL;
		this.OFPKJBHHLGK = BDICHAELIJE;
		this.EHBJNJAFFHP = BDICHAELIJE;
		this.JGLODIINJAF = -1f;
		this.BDICHAELIJE = BDICHAELIJE;
		this.fadeInSeconds = DKNMPJDJNAE;
		this.fadeOutSeconds = BCOIOGINLKJ;
		this.playing = false;
		this.paused = false;
		this.activated = false;
		this.JPFMCDJKGLK(BKGCLBJFADE, AIPGGFGKNFE);
		this.Play();
	}

	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x0601022F RID: 66095 RVA: 0x000A38BC File Offset: 0x000A1ABC
	// (set) Token: 0x06010227 RID: 66087 RVA: 0x000A389F File Offset: 0x000A1A9F
	public bool persist { get; set; }

	// Token: 0x06010228 RID: 66088 RVA: 0x000A386A File Offset: 0x000A1A6A
	public void POCJBONPHKG(float IFNAPFNEGMP)
	{
		this.audioSource.minDistance = IFNAPFNEGMP;
	}

	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x06010244 RID: 66116 RVA: 0x000A392B File Offset: 0x000A1B2B
	// (set) Token: 0x06010229 RID: 66089 RVA: 0x000A3821 File Offset: 0x000A1A21
	public int audioID { get; private set; }

	// Token: 0x0601022A RID: 66090 RVA: 0x000A38A8 File Offset: 0x000A1AA8
	public void Pause()
	{
		this.audioSource.Pause();
		this.paused = true;
	}

	// Token: 0x0601022B RID: 66091 RVA: 0x0054F030 File Offset: 0x0054D230
	public void EFGFFEECBAF(float BDICHAELIJE)
	{
		if (this.AKHKFKHDAEK() == null)
		{
			this.JPFMCDJKGLK(this.JPIBNPJDMFM, this.BJFJBACHCCD());
		}
		this.audioSource.Play();
		this.LANNCDEJFOG(false);
		this.HCCAAMOMPHF = 49f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = BDICHAELIJE;
	}

	// Token: 0x0601022C RID: 66092 RVA: 0x000A378D File Offset: 0x000A198D
	public void CDCNJEMHLPK(bool DPNHODJHGJL)
	{
		this.<CMBMPMDFPAD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601022D RID: 66093 RVA: 0x000A3821 File Offset: 0x000A1A21
	private void BGPLHOCOJJE(int DPNHODJHGJL)
	{
		this.<AAJKLPLJBCI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x06010230 RID: 66096 RVA: 0x000A38C4 File Offset: 0x000A1AC4
	public void LMCBKNINIKN()
	{
		this.EFGFFEECBAF(this.EHBJNJAFFHP);
	}

	// Token: 0x06010231 RID: 66097 RVA: 0x000A378D File Offset: 0x000A198D
	public void BJBCEEIGLPL(bool DPNHODJHGJL)
	{
		this.<CMBMPMDFPAD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x06010232 RID: 66098 RVA: 0x000A3811 File Offset: 0x000A1A11
	public void EFMLHJDDGPJ(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		this.Set3DMinDistance(IFNAPFNEGMP);
		this.Set3DMaxDistance(MEMALLLANHH);
	}

	// Token: 0x06010233 RID: 66099 RVA: 0x000A38D2 File Offset: 0x000A1AD2
	private void IMAJCFHBHGI(bool DPNHODJHGJL)
	{
		this.<ONIFIPLNHGN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x0601023F RID: 66111 RVA: 0x000A37B8 File Offset: 0x000A19B8
	// (set) Token: 0x06010234 RID: 66100 RVA: 0x000A38DB File Offset: 0x000A1ADB
	public float fadeInSeconds { get; set; }

	// Token: 0x06010237 RID: 66103 RVA: 0x000A38EC File Offset: 0x000A1AEC
	public void DEKJCKHCACJ(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		this.DACMEPBBOFI(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x06010238 RID: 66104 RVA: 0x000A38FC File Offset: 0x000A1AFC
	// (set) Token: 0x06010241 RID: 66113 RVA: 0x000A3784 File Offset: 0x000A1984
	public bool playing { get; set; }

	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x0601024E RID: 66126 RVA: 0x000A377C File Offset: 0x000A197C
	// (set) Token: 0x06010239 RID: 66105 RVA: 0x000A3904 File Offset: 0x000A1B04
	public AudioSource audioSource { get; private set; }

	// Token: 0x0601023A RID: 66106 RVA: 0x000A378D File Offset: 0x000A198D
	public void HPPNKFOMDKC(bool DPNHODJHGJL)
	{
		this.<CMBMPMDFPAD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601023B RID: 66107 RVA: 0x000A38FC File Offset: 0x000A1AFC
	public bool PNEPMOGOEKP()
	{
		return this.<INFLLAMBHEH>k__BackingField;
	}

	// Token: 0x0601023C RID: 66108 RVA: 0x000A3821 File Offset: 0x000A1A21
	private void LNAHKFJNNCD(int DPNHODJHGJL)
	{
		this.<AAJKLPLJBCI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601023D RID: 66109 RVA: 0x000A37B8 File Offset: 0x000A19B8
	public float FECJFOLBBCJ()
	{
		return this.<HMPINPCDONH>k__BackingField;
	}

	// Token: 0x0601023E RID: 66110 RVA: 0x000A390D File Offset: 0x000A1B0D
	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		this.SetVolume(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	// Token: 0x06010240 RID: 66112 RVA: 0x0054F090 File Offset: 0x0054D290
	public void EAOPPLGPBEN(float BDICHAELIJE)
	{
		if (this.AKHKFKHDAEK() == null)
		{
			this.JPFMCDJKGLK(this.JPIBNPJDMFM, this.loop);
		}
		this.audioSource.Play();
		this.playing = false;
		this.HCCAAMOMPHF = 538f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = BDICHAELIJE;
	}

	// Token: 0x06010242 RID: 66114 RVA: 0x000A37AA File Offset: 0x000A19AA
	public void HCOLFILANBE(float MEMALLLANHH)
	{
		this.EFBNFACGJLI().maxDistance = MEMALLLANHH;
	}

	// Token: 0x06010243 RID: 66115 RVA: 0x000A391D File Offset: 0x000A1B1D
	public void Play()
	{
		this.Play(this.EHBJNJAFFHP);
	}

	// Token: 0x06010245 RID: 66117 RVA: 0x0054F0F0 File Offset: 0x0054D2F0
	public void Update()
	{
		if (this.audioSource == null)
		{
			return;
		}
		this.activated = true;
		if (this.BDICHAELIJE != this.OFPKJBHHLGK)
		{
			this.BDICHAELIJE = this.OFPKJBHHLGK;
		}
		else if (this.JGLODIINJAF != -1f)
		{
			this.JGLODIINJAF = -1f;
		}
		Audio.AudioType mjnlbjikabl = this.MJNLBJIKABL;
		if (mjnlbjikabl != Audio.AudioType.Music)
		{
			if (mjnlbjikabl == Audio.AudioType.Sound)
			{
				this.audioSource.volume = this.BDICHAELIJE;
			}
		}
		else
		{
			this.audioSource.volume = this.BDICHAELIJE;
		}
		if (this.BDICHAELIJE == 0f && this.stopping)
		{
			this.audioSource.Stop();
			this.stopping = false;
			this.playing = false;
			this.paused = false;
		}
		if (this.audioSource.isPlaying != this.playing)
		{
			this.playing = this.audioSource.isPlaying;
		}
	}

	// Token: 0x06010246 RID: 66118 RVA: 0x000A389F File Offset: 0x000A1A9F
	public void IBNHGNKAILN(bool DPNHODJHGJL)
	{
		this.<CJPNMJAAGBI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x06010247 RID: 66119 RVA: 0x000A3933 File Offset: 0x000A1B33
	public AudioClip clip
	{
		get
		{
			return (!(this.audioSource == null)) ? this.audioSource.clip : this.JPIBNPJDMFM;
		}
	}

	// Token: 0x06010248 RID: 66120 RVA: 0x000A3762 File Offset: 0x000A1962
	public bool JAAOFJFLLHN()
	{
		return this.<ONIFIPLNHGN>k__BackingField;
	}

	// Token: 0x06010249 RID: 66121 RVA: 0x000A3784 File Offset: 0x000A1984
	public void MIDCEKKDEBJ(bool DPNHODJHGJL)
	{
		this.<INFLLAMBHEH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601024A RID: 66122 RVA: 0x000A38FC File Offset: 0x000A1AFC
	public bool AHADHELAKAM()
	{
		return this.<INFLLAMBHEH>k__BackingField;
	}

	// Token: 0x0601024B RID: 66123 RVA: 0x000A395C File Offset: 0x000A1B5C
	public void KMCICHOPOPB()
	{
		this.HCCAAMOMPHF = 1277f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = 425f;
		this.stopping = false;
	}

	// Token: 0x0601024C RID: 66124 RVA: 0x000A3987 File Offset: 0x000A1B87
	public void SetVolume(float BDICHAELIJE)
	{
		if (BDICHAELIJE > this.OFPKJBHHLGK)
		{
			this.SetVolume(BDICHAELIJE, this.fadeOutSeconds);
		}
		else
		{
			this.SetVolume(BDICHAELIJE, this.fadeInSeconds);
		}
	}

	// Token: 0x0601024D RID: 66125 RVA: 0x000A3811 File Offset: 0x000A1A11
	public void Set3DDistances(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		this.Set3DMinDistance(IFNAPFNEGMP);
		this.Set3DMaxDistance(MEMALLLANHH);
	}

	// Token: 0x0601024F RID: 66127 RVA: 0x0054F1FC File Offset: 0x0054D3FC
	public void HLDFOJMHKNL()
	{
		if (this.audioSource == null)
		{
			return;
		}
		this.activated = false;
		if (this.BDICHAELIJE != this.OFPKJBHHLGK)
		{
			this.BDICHAELIJE = this.OFPKJBHHLGK;
		}
		else if (this.JGLODIINJAF != 188f)
		{
			this.JGLODIINJAF = 1166f;
		}
		Audio.AudioType mjnlbjikabl = this.MJNLBJIKABL;
		if (mjnlbjikabl != Audio.AudioType.Music)
		{
			if (mjnlbjikabl == Audio.AudioType.Sound)
			{
				this.audioSource.volume = this.BDICHAELIJE;
			}
		}
		else
		{
			this.audioSource.volume = this.BDICHAELIJE;
		}
		if (this.BDICHAELIJE == 1120f && this.stopping)
		{
			this.AKHKFKHDAEK().Stop();
			this.stopping = false;
			this.HJKKFKPLEBC(false);
			this.paused = true;
		}
		if (this.EFBNFACGJLI().isPlaying != this.AHADHELAKAM())
		{
			this.MIDCEKKDEBJ(this.EFBNFACGJLI().isPlaying);
		}
	}

	// Token: 0x06010250 RID: 66128 RVA: 0x000A383B File Offset: 0x000A1A3B
	public bool BJFJBACHCCD()
	{
		return this.<CMBMPMDFPAD>k__BackingField;
	}

	// Token: 0x04001F23 RID: 7971
	private static int BCIGGJPJBOK;

	// Token: 0x04001F24 RID: 7972
	private float BDICHAELIJE;

	// Token: 0x04001F25 RID: 7973
	private float OFPKJBHHLGK;

	// Token: 0x04001F26 RID: 7974
	private float EHBJNJAFFHP;

	// Token: 0x04001F27 RID: 7975
	private float JGLODIINJAF;

	// Token: 0x04001F28 RID: 7976
	private float HCCAAMOMPHF;

	// Token: 0x04001F29 RID: 7977
	private float OAJPIBOLJII;

	// Token: 0x04001F2A RID: 7978
	private Audio.AudioType MJNLBJIKABL;

	// Token: 0x04001F2B RID: 7979
	private AudioClip JPIBNPJDMFM;

	// Token: 0x04001F2C RID: 7980
	private Transform OKDDLALOEME;

	// Token: 0x04001F37 RID: 7991
	public Transform _audiosource;

	// Token: 0x020004CA RID: 1226
	public enum AudioType
	{
		// Token: 0x04001F39 RID: 7993
		Music,
		// Token: 0x04001F3A RID: 7994
		Sound
	}
}
