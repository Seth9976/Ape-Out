using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002E RID: 46
	public class SurfaceEffector2D : Effector2D
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000437E File Offset: 0x0000257E
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00004390 File Offset: 0x00002590
		public float speed
		{
			get
			{
				return SurfaceEffector2D.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000043A3 File Offset: 0x000025A3
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000043B5 File Offset: 0x000025B5
		public float speedVariation
		{
			get
			{
				return SurfaceEffector2D.get_speedVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_speedVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000043DA File Offset: 0x000025DA
		public float forceScale
		{
			get
			{
				return SurfaceEffector2D.get_forceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_forceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000043ED File Offset: 0x000025ED
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000043FF File Offset: 0x000025FF
		public bool useContactForce
		{
			get
			{
				return SurfaceEffector2D.get_useContactForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useContactForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00004412 File Offset: 0x00002612
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00004424 File Offset: 0x00002624
		public bool useFriction
		{
			get
			{
				return SurfaceEffector2D.get_useFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00004437 File Offset: 0x00002637
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00004449 File Offset: 0x00002649
		public bool useBounce
		{
			get
			{
				return SurfaceEffector2D.get_useBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040002B0 RID: 688
		private static readonly SurfaceEffector2D.get_speedDelegate get_speedDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_speedDelegate>("UnityEngine.SurfaceEffector2D::get_speed");

		// Token: 0x040002B1 RID: 689
		private static readonly SurfaceEffector2D.set_speedDelegate set_speedDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_speedDelegate>("UnityEngine.SurfaceEffector2D::set_speed");

		// Token: 0x040002B2 RID: 690
		private static readonly SurfaceEffector2D.get_speedVariationDelegate get_speedVariationDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_speedVariationDelegate>("UnityEngine.SurfaceEffector2D::get_speedVariation");

		// Token: 0x040002B3 RID: 691
		private static readonly SurfaceEffector2D.set_speedVariationDelegate set_speedVariationDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_speedVariationDelegate>("UnityEngine.SurfaceEffector2D::set_speedVariation");

		// Token: 0x040002B4 RID: 692
		private static readonly SurfaceEffector2D.get_forceScaleDelegate get_forceScaleDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_forceScaleDelegate>("UnityEngine.SurfaceEffector2D::get_forceScale");

		// Token: 0x040002B5 RID: 693
		private static readonly SurfaceEffector2D.set_forceScaleDelegate set_forceScaleDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_forceScaleDelegate>("UnityEngine.SurfaceEffector2D::set_forceScale");

		// Token: 0x040002B6 RID: 694
		private static readonly SurfaceEffector2D.get_useContactForceDelegate get_useContactForceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useContactForceDelegate>("UnityEngine.SurfaceEffector2D::get_useContactForce");

		// Token: 0x040002B7 RID: 695
		private static readonly SurfaceEffector2D.set_useContactForceDelegate set_useContactForceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useContactForceDelegate>("UnityEngine.SurfaceEffector2D::set_useContactForce");

		// Token: 0x040002B8 RID: 696
		private static readonly SurfaceEffector2D.get_useFrictionDelegate get_useFrictionDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useFrictionDelegate>("UnityEngine.SurfaceEffector2D::get_useFriction");

		// Token: 0x040002B9 RID: 697
		private static readonly SurfaceEffector2D.set_useFrictionDelegate set_useFrictionDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useFrictionDelegate>("UnityEngine.SurfaceEffector2D::set_useFriction");

		// Token: 0x040002BA RID: 698
		private static readonly SurfaceEffector2D.get_useBounceDelegate get_useBounceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useBounceDelegate>("UnityEngine.SurfaceEffector2D::get_useBounce");

		// Token: 0x040002BB RID: 699
		private static readonly SurfaceEffector2D.set_useBounceDelegate set_useBounceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useBounceDelegate>("UnityEngine.SurfaceEffector2D::set_useBounce");

		// Token: 0x020001D0 RID: 464
		// (Invoke) Token: 0x06000776 RID: 1910
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x020001D1 RID: 465
		// (Invoke) Token: 0x06000778 RID: 1912
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x020001D2 RID: 466
		// (Invoke) Token: 0x0600077A RID: 1914
		private delegate float get_speedVariationDelegate(IntPtr @this);

		// Token: 0x020001D3 RID: 467
		// (Invoke) Token: 0x0600077C RID: 1916
		private delegate void set_speedVariationDelegate(IntPtr @this, float value);

		// Token: 0x020001D4 RID: 468
		// (Invoke) Token: 0x0600077E RID: 1918
		private delegate float get_forceScaleDelegate(IntPtr @this);

		// Token: 0x020001D5 RID: 469
		// (Invoke) Token: 0x06000780 RID: 1920
		private delegate void set_forceScaleDelegate(IntPtr @this, float value);

		// Token: 0x020001D6 RID: 470
		// (Invoke) Token: 0x06000782 RID: 1922
		private delegate bool get_useContactForceDelegate(IntPtr @this);

		// Token: 0x020001D7 RID: 471
		// (Invoke) Token: 0x06000784 RID: 1924
		private delegate void set_useContactForceDelegate(IntPtr @this, bool value);

		// Token: 0x020001D8 RID: 472
		// (Invoke) Token: 0x06000786 RID: 1926
		private delegate bool get_useFrictionDelegate(IntPtr @this);

		// Token: 0x020001D9 RID: 473
		// (Invoke) Token: 0x06000788 RID: 1928
		private delegate void set_useFrictionDelegate(IntPtr @this, bool value);

		// Token: 0x020001DA RID: 474
		// (Invoke) Token: 0x0600078A RID: 1930
		private delegate bool get_useBounceDelegate(IntPtr @this);

		// Token: 0x020001DB RID: 475
		// (Invoke) Token: 0x0600078C RID: 1932
		private delegate void set_useBounceDelegate(IntPtr @this, bool value);
	}
}
