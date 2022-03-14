/*
Importance of this class: Unknown. Likely a part of Photon/Network shit.

Purpose of this class: Seems to be a basic object of sorts.

Deobf status: Awful
*/

using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200033F RID: 831
public class CellTreeNode
{
	// Token: 0x0600BCCF RID: 48335 RVA: 0x00449060 File Offset: 0x00447260
	public void AGLKKDBMAIH(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)3)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.GNMJGLGICGB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.FELLGOKLPKB(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.GMAKJMJLJHH(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCD0 RID: 48336 RVA: 0x00449130 File Offset: 0x00447330
	public bool GMAKJMJLJHH(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BCD1 RID: 48337 RVA: 0x0000420A File Offset: 0x0000240A
	public void DIKHLOJLCME()
	{
	}

	// Token: 0x0600BCD2 RID: 48338 RVA: 0x0000420A File Offset: 0x0000240A
	public void LFGPIPAJDJA()
	{
	}

	// Token: 0x0600BCD3 RID: 48339 RVA: 0x004491DC File Offset: 0x004473DC
	public void LOFFINJKDHG(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)8)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.LOFFINJKDHG(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.FELLGOKLPKB(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.IIBBOPHLEKC(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCD4 RID: 48340 RVA: 0x0000420A File Offset: 0x0000240A
	public void DHDDGIEELKJ()
	{
	}

	// Token: 0x0600BCD5 RID: 48341 RVA: 0x004492AC File Offset: 0x004474AC
	public bool HKJJBLKLMNB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 666f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1365f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BCD6 RID: 48342 RVA: 0x0000420A File Offset: 0x0000240A
	public void ODLGCHBFCPF()
	{
	}

	// Token: 0x0600BCD7 RID: 48343 RVA: 0x0000420A File Offset: 0x0000240A
	public void Draw()
	{
	}

	// Token: 0x0600BCD8 RID: 48344 RVA: 0x00449320 File Offset: 0x00447520
	public void GetActiveCells(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.GetActiveCells(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.IsPointNearCell(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.IsPointInsideCell(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCD9 RID: 48345 RVA: 0x004493F0 File Offset: 0x004475F0
	public void CCIKBIKMOMH(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)8)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.GNMJGLGICGB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.ILIOBKGDLGL(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.GMAKJMJLJHH(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCDA RID: 48346 RVA: 0x004494C0 File Offset: 0x004476C0
	public bool MDGFCKNGJPA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600BCDB RID: 48347 RVA: 0x0044956C File Offset: 0x0044776C
	public bool FELLGOKLPKB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 628f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 181f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BCDC RID: 48348 RVA: 0x0008FFB6 File Offset: 0x0008E1B6
	public void CGKJMMOHJOK(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCDD RID: 48349 RVA: 0x004495E0 File Offset: 0x004477E0
	public bool BJIPDJACEMM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600BCDE RID: 48350 RVA: 0x0044968C File Offset: 0x0044788C
	public void HONILALBABF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)4)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.HONILALBABF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.IsPointNearCell(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.ODCMPNMLEPA(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCDF RID: 48351 RVA: 0x0008FFB6 File Offset: 0x0008E1B6
	public void CADHBIGOLKK(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCE0 RID: 48352 RVA: 0x0008FFDB File Offset: 0x0008E1DB
	public void AddChild(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCE1 RID: 48353 RVA: 0x0044975C File Offset: 0x0044795C
	public void GNMJGLGICGB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)5)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.LBHDCICHMNN(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.MDGFCKNGJPA(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCE2 RID: 48354 RVA: 0x0008FFDB File Offset: 0x0008E1DB
	public void NHHBPLBJJEJ(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCE3 RID: 48355 RVA: 0x0000420A File Offset: 0x0000240A
	public void FHPEOMJCKIH()
	{
	}

	// Token: 0x0600BCE4 RID: 48356 RVA: 0x0044982C File Offset: 0x00447A2C
	public bool PKJHBIPKCLI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1752f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 731f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BCE5 RID: 48357 RVA: 0x004498A0 File Offset: 0x00447AA0
	public bool ODCMPNMLEPA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BCE6 RID: 48358 RVA: 0x0044994C File Offset: 0x00447B4C
	public void CKNGPLDAGEB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)8)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.AGLKKDBMAIH(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.PNGAIKBAMLB(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCE7 RID: 48359 RVA: 0x00090000 File Offset: 0x0008E200
	public CellTreeNode(byte JMMILEFMACB, CellTreeNode.ENodeType CKEACKJDOPA, CellTreeNode OJICGBOIKNA)
	{
		this.Id = JMMILEFMACB;
		this.NodeType = CKEACKJDOPA;
		this.Parent = OJICGBOIKNA;
	}

	// Token: 0x0600BCE8 RID: 48360 RVA: 0x0000420A File Offset: 0x0000240A
	public void GADLADPKCNE()
	{
	}

	// Token: 0x0600BCE9 RID: 48361 RVA: 0x0008FFDB File Offset: 0x0008E1DB
	public void PPDAGHKHLBL(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCEA RID: 48362 RVA: 0x00449A1C File Offset: 0x00447C1C
	public bool IIBBOPHLEKC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BCEB RID: 48363 RVA: 0x00449130 File Offset: 0x00447330
	public bool FFBIALNCLMP(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BCEC RID: 48364 RVA: 0x0000420A File Offset: 0x0000240A
	public void JCCMGLEJKAO()
	{
	}

	// Token: 0x0600BCED RID: 48365 RVA: 0x0000420A File Offset: 0x0000240A
	public void KNIJFMBAFGE()
	{
	}

	// Token: 0x0600BCEE RID: 48366 RVA: 0x0008FFB6 File Offset: 0x0008E1B6
	public void FNEHKFAHOLP(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCEF RID: 48367 RVA: 0x00449AC8 File Offset: 0x00447CC8
	public bool OIIDAKNCFHI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 607f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1634f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BCF0 RID: 48368 RVA: 0x00449B3C File Offset: 0x00447D3C
	public void LBHDCICHMNN(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Node)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.LOFFINJKDHG(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.FLBJIGIGCIE(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.FFBIALNCLMP(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCF1 RID: 48369 RVA: 0x00449C0C File Offset: 0x00447E0C
	public void EPHCAFNANAP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)4)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.ELMBCNNBICM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.GMAKJMJLJHH(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BCF2 RID: 48370 RVA: 0x00449CDC File Offset: 0x00447EDC
	public bool PNGAIKBAMLB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BCF3 RID: 48371 RVA: 0x0008FFB6 File Offset: 0x0008E1B6
	public void BDELMHBAKOI(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCF4 RID: 48372 RVA: 0x00449D88 File Offset: 0x00447F88
	public bool HFJFIGKDLIK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 914f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1178f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BCF5 RID: 48373 RVA: 0x0000420A File Offset: 0x0000240A
	public void OEKFHIGBMHG()
	{
	}

	// Token: 0x0600BCF6 RID: 48374 RVA: 0x0000420A File Offset: 0x0000240A
	public void HPFPCKDOFBJ()
	{
	}

	// Token: 0x0600BCF7 RID: 48375 RVA: 0x00449DFC File Offset: 0x00447FFC
	public bool GADPIKNPCJG(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 164f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1205f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BCF8 RID: 48376 RVA: 0x00449E70 File Offset: 0x00448070
	public bool LCCNJDFCDLN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BCF9 RID: 48377 RVA: 0x0000420A File Offset: 0x0000240A
	public void JEHPCCANKDJ()
	{
	}

	// Token: 0x0600BCFA RID: 48378 RVA: 0x00449F1C File Offset: 0x0044811C
	public bool IEHKKLFKNOI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1195f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1328f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BCFB RID: 48379 RVA: 0x0008FFDB File Offset: 0x0008E1DB
	public void MPDCNPHDBBO(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BCFC RID: 48380 RVA: 0x0000420A File Offset: 0x0000240A
	public void FBKBMIKIEKE()
	{
	}

	// Token: 0x0600BCFD RID: 48381 RVA: 0x0000420A File Offset: 0x0000240A
	public void NJLEDOJJFJN()
	{
	}

	// Token: 0x0600BCFE RID: 48382 RVA: 0x00003C5E File Offset: 0x00001E5E
	public CellTreeNode()
	{
	}

	// Token: 0x0600BCFF RID: 48383 RVA: 0x00449F90 File Offset: 0x00448190
	public void HOHFPFFAOOO(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Node)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.GetActiveCells(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.IEHKKLFKNOI(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.MDGFCKNGJPA(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BD00 RID: 48384 RVA: 0x004498A0 File Offset: 0x00447AA0
	public bool IsPointInsideCell(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BD01 RID: 48385 RVA: 0x0044A060 File Offset: 0x00448260
	public bool JIMAMEJHCOC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1395f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1348f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD02 RID: 48386 RVA: 0x0044A0D4 File Offset: 0x004482D4
	public void ELMBCNNBICM(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)4)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.AGLKKDBMAIH(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.JIMAMEJHCOC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.KLODKGLMOAD(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BD03 RID: 48387 RVA: 0x0044A1A4 File Offset: 0x004483A4
	public bool AKGEDOANLJA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1053f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 19f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD04 RID: 48388 RVA: 0x0044A218 File Offset: 0x00448418
	public bool FLBJIGIGCIE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1992f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1098f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD05 RID: 48389 RVA: 0x0044A28C File Offset: 0x0044848C
	public bool FAHCBALMBLN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 293f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 656f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD06 RID: 48390 RVA: 0x0044A300 File Offset: 0x00448500
	public bool AAHGPKANPHO(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BD07 RID: 48391 RVA: 0x0000420A File Offset: 0x0000240A
	public void HNAFFBPAHMG()
	{
	}

	// Token: 0x0600BD08 RID: 48392 RVA: 0x0008FFB6 File Offset: 0x0008E1B6
	public void PKBCCPADPFG(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BD09 RID: 48393 RVA: 0x0000420A File Offset: 0x0000240A
	public void FHCKMAHODHN()
	{
	}

	// Token: 0x0600BD0A RID: 48394 RVA: 0x0044A3AC File Offset: 0x004485AC
	public bool NEALOMJLOJD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1029f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1602f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD0B RID: 48395 RVA: 0x0008FFDB File Offset: 0x0008E1DB
	public void AMMKMACNAOL(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BD0C RID: 48396 RVA: 0x0044A300 File Offset: 0x00448500
	public bool KLODKGLMOAD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BD0D RID: 48397 RVA: 0x0044A420 File Offset: 0x00448620
	public bool ILIOBKGDLGL(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 612f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 909f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD0E RID: 48398 RVA: 0x0044A494 File Offset: 0x00448694
	public bool LIIPAJKMKKE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 959f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 970f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD0F RID: 48399 RVA: 0x0044A508 File Offset: 0x00448708
	public bool EMIEDEMKFLI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1070f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1284f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BD10 RID: 48400 RVA: 0x0044A57C File Offset: 0x0044877C
	public bool IsPointNearCell(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 0f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 2f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0400161C RID: 5660
	public byte Id;

	// Token: 0x0400161D RID: 5661
	public Vector3 Center;

	// Token: 0x0400161E RID: 5662
	public Vector3 Size;

	// Token: 0x0400161F RID: 5663
	public Vector3 TopLeft;

	// Token: 0x04001620 RID: 5664
	public Vector3 BottomRight;

	// Token: 0x04001621 RID: 5665
	public CellTreeNode.ENodeType NodeType;

	// Token: 0x04001622 RID: 5666
	public CellTreeNode Parent;

	// Token: 0x04001623 RID: 5667
	public List<CellTreeNode> Childs;

	// Token: 0x04001624 RID: 5668
	private float CNPIACHIHKD;

	// Token: 0x02000340 RID: 832
	public enum ENodeType
	{
		// Token: 0x04001626 RID: 5670
		Root,
		// Token: 0x04001627 RID: 5671
		Node,
		// Token: 0x04001628 RID: 5672
		Leaf
	}
}
