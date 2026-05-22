using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000235 RID: 565
	public class LODGroup : Component
	{
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x00075E7C File Offset: 0x0007407C
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x0001199F File Offset: 0x0000FB9F
		public Vector3 localReferencePoint
		{
			get
			{
				Vector3 vector;
				this.get_localReferencePoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_localReferencePoint_Injected(ref value);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000119A9 File Offset: 0x0000FBA9
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x000119BB File Offset: 0x0000FBBB
		public float size
		{
			get
			{
				return LODGroup.get_sizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_sizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000119CE File Offset: 0x0000FBCE
		public int lodCount
		{
			get
			{
				return LODGroup.get_lodCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x000119E0 File Offset: 0x0000FBE0
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x000119F2 File Offset: 0x0000FBF2
		public LODFadeMode fadeMode
		{
			get
			{
				return LODGroup.get_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00011A05 File Offset: 0x0000FC05
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00011A17 File Offset: 0x0000FC17
		public bool animateCrossFading
		{
			get
			{
				return LODGroup.get_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x00011A2A File Offset: 0x0000FC2A
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x00011A3C File Offset: 0x0000FC3C
		public bool enabled
		{
			get
			{
				return LODGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00011A4F File Offset: 0x0000FC4F
		public void RecalculateBounds()
		{
			LODGroup.RecalculateBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00011A61 File Offset: 0x0000FC61
		public void ForceLOD(int index)
		{
			LODGroup.ForceLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x00011A74 File Offset: 0x0000FC74
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x00011A80 File Offset: 0x0000FC80
		public static float crossFadeAnimationDuration
		{
			get
			{
				return LODGroup.get_crossFadeAnimationDurationDelegateField();
			}
			set
			{
				LODGroup.set_crossFadeAnimationDurationDelegateField(value);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x00075E94 File Offset: 0x00074094
		public Vector3 worldReferencePoint
		{
			get
			{
				Vector3 vector;
				this.get_worldReferencePoint_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00011A8D File Offset: 0x0000FC8D
		public void get_localReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00011AA0 File Offset: 0x0000FCA0
		public void set_localReferencePoint_Injected(ref Vector3 value)
		{
			LODGroup.set_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00011AB3 File Offset: 0x0000FCB3
		public void get_worldReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_worldReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04001B7F RID: 7039
		private static readonly LODGroup.get_sizeDelegate get_sizeDelegateField = IL2CPP.ResolveICall<LODGroup.get_sizeDelegate>("UnityEngine.LODGroup::get_size");

		// Token: 0x04001B80 RID: 7040
		private static readonly LODGroup.set_sizeDelegate set_sizeDelegateField = IL2CPP.ResolveICall<LODGroup.set_sizeDelegate>("UnityEngine.LODGroup::set_size");

		// Token: 0x04001B81 RID: 7041
		private static readonly LODGroup.get_lodCountDelegate get_lodCountDelegateField = IL2CPP.ResolveICall<LODGroup.get_lodCountDelegate>("UnityEngine.LODGroup::get_lodCount");

		// Token: 0x04001B82 RID: 7042
		private static readonly LODGroup.get_fadeModeDelegate get_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.get_fadeModeDelegate>("UnityEngine.LODGroup::get_fadeMode");

		// Token: 0x04001B83 RID: 7043
		private static readonly LODGroup.set_fadeModeDelegate set_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.set_fadeModeDelegate>("UnityEngine.LODGroup::set_fadeMode");

		// Token: 0x04001B84 RID: 7044
		private static readonly LODGroup.get_animateCrossFadingDelegate get_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.get_animateCrossFadingDelegate>("UnityEngine.LODGroup::get_animateCrossFading");

		// Token: 0x04001B85 RID: 7045
		private static readonly LODGroup.set_animateCrossFadingDelegate set_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.set_animateCrossFadingDelegate>("UnityEngine.LODGroup::set_animateCrossFading");

		// Token: 0x04001B86 RID: 7046
		private static readonly LODGroup.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.get_enabledDelegate>("UnityEngine.LODGroup::get_enabled");

		// Token: 0x04001B87 RID: 7047
		private static readonly LODGroup.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.set_enabledDelegate>("UnityEngine.LODGroup::set_enabled");

		// Token: 0x04001B88 RID: 7048
		private static readonly LODGroup.RecalculateBoundsDelegate RecalculateBoundsDelegateField = IL2CPP.ResolveICall<LODGroup.RecalculateBoundsDelegate>("UnityEngine.LODGroup::RecalculateBounds");

		// Token: 0x04001B89 RID: 7049
		private static readonly LODGroup.ForceLODDelegate ForceLODDelegateField = IL2CPP.ResolveICall<LODGroup.ForceLODDelegate>("UnityEngine.LODGroup::ForceLOD");

		// Token: 0x04001B8A RID: 7050
		private static readonly LODGroup.get_crossFadeAnimationDurationDelegate get_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.get_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::get_crossFadeAnimationDuration");

		// Token: 0x04001B8B RID: 7051
		private static readonly LODGroup.set_crossFadeAnimationDurationDelegate set_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.set_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::set_crossFadeAnimationDuration");

		// Token: 0x04001B8C RID: 7052
		private static readonly LODGroup.get_localReferencePoint_InjectedDelegate get_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_localReferencePoint_Injected");

		// Token: 0x04001B8D RID: 7053
		private static readonly LODGroup.set_localReferencePoint_InjectedDelegate set_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::set_localReferencePoint_Injected");

		// Token: 0x04001B8E RID: 7054
		private static readonly LODGroup.get_worldReferencePoint_InjectedDelegate get_worldReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_worldReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_worldReferencePoint_Injected");

		// Token: 0x02000B57 RID: 2903
		// (Invoke) Token: 0x0600350E RID: 13582
		private delegate float get_sizeDelegate(IntPtr @this);

		// Token: 0x02000B58 RID: 2904
		// (Invoke) Token: 0x06003510 RID: 13584
		private delegate void set_sizeDelegate(IntPtr @this, float value);

		// Token: 0x02000B59 RID: 2905
		// (Invoke) Token: 0x06003512 RID: 13586
		private delegate int get_lodCountDelegate(IntPtr @this);

		// Token: 0x02000B5A RID: 2906
		// (Invoke) Token: 0x06003514 RID: 13588
		private delegate LODFadeMode get_fadeModeDelegate(IntPtr @this);

		// Token: 0x02000B5B RID: 2907
		// (Invoke) Token: 0x06003516 RID: 13590
		private delegate void set_fadeModeDelegate(IntPtr @this, LODFadeMode value);

		// Token: 0x02000B5C RID: 2908
		// (Invoke) Token: 0x06003518 RID: 13592
		private delegate bool get_animateCrossFadingDelegate(IntPtr @this);

		// Token: 0x02000B5D RID: 2909
		// (Invoke) Token: 0x0600351A RID: 13594
		private delegate void set_animateCrossFadingDelegate(IntPtr @this, bool value);

		// Token: 0x02000B5E RID: 2910
		// (Invoke) Token: 0x0600351C RID: 13596
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000B5F RID: 2911
		// (Invoke) Token: 0x0600351E RID: 13598
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000B60 RID: 2912
		// (Invoke) Token: 0x06003520 RID: 13600
		private delegate void RecalculateBoundsDelegate(IntPtr @this);

		// Token: 0x02000B61 RID: 2913
		// (Invoke) Token: 0x06003522 RID: 13602
		private delegate void ForceLODDelegate(IntPtr @this, int index);

		// Token: 0x02000B62 RID: 2914
		// (Invoke) Token: 0x06003524 RID: 13604
		private delegate float get_crossFadeAnimationDurationDelegate();

		// Token: 0x02000B63 RID: 2915
		// (Invoke) Token: 0x06003526 RID: 13606
		private delegate void set_crossFadeAnimationDurationDelegate(float value);

		// Token: 0x02000B64 RID: 2916
		// (Invoke) Token: 0x06003528 RID: 13608
		private delegate void get_localReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B65 RID: 2917
		// (Invoke) Token: 0x0600352A RID: 13610
		private delegate void set_localReferencePoint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B66 RID: 2918
		// (Invoke) Token: 0x0600352C RID: 13612
		private delegate void get_worldReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
