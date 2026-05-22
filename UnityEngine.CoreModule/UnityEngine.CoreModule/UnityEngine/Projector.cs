using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000216 RID: 534
	public sealed class Projector : Behaviour
	{
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x000116E9 File Offset: 0x0000F8E9
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x000116FB File Offset: 0x0000F8FB
		public float nearClipPlane
		{
			get
			{
				return Projector.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x0001170E File Offset: 0x0000F90E
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x00011720 File Offset: 0x0000F920
		public float farClipPlane
		{
			get
			{
				return Projector.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x00011733 File Offset: 0x0000F933
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x00011745 File Offset: 0x0000F945
		public float fieldOfView
		{
			get
			{
				return Projector.get_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x00011758 File Offset: 0x0000F958
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x0001176A File Offset: 0x0000F96A
		public float aspectRatio
		{
			get
			{
				return Projector.get_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x0001177D File Offset: 0x0000F97D
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x0001178F File Offset: 0x0000F98F
		public bool orthographic
		{
			get
			{
				return Projector.get_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x000117A2 File Offset: 0x0000F9A2
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x000117B4 File Offset: 0x0000F9B4
		public float orthographicSize
		{
			get
			{
				return Projector.get_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x000117C7 File Offset: 0x0000F9C7
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x000117D9 File Offset: 0x0000F9D9
		public int ignoreLayers
		{
			get
			{
				return Projector.get_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x00075B44 File Offset: 0x00073D44
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x000117EC File Offset: 0x0000F9EC
		public Material material
		{
			get
			{
				IntPtr intPtr = Projector.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				Projector.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AE2 RID: 6882
		private static readonly Projector.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_nearClipPlaneDelegate>("UnityEngine.Projector::get_nearClipPlane");

		// Token: 0x04001AE3 RID: 6883
		private static readonly Projector.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_nearClipPlaneDelegate>("UnityEngine.Projector::set_nearClipPlane");

		// Token: 0x04001AE4 RID: 6884
		private static readonly Projector.get_farClipPlaneDelegate get_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_farClipPlaneDelegate>("UnityEngine.Projector::get_farClipPlane");

		// Token: 0x04001AE5 RID: 6885
		private static readonly Projector.set_farClipPlaneDelegate set_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_farClipPlaneDelegate>("UnityEngine.Projector::set_farClipPlane");

		// Token: 0x04001AE6 RID: 6886
		private static readonly Projector.get_fieldOfViewDelegate get_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.get_fieldOfViewDelegate>("UnityEngine.Projector::get_fieldOfView");

		// Token: 0x04001AE7 RID: 6887
		private static readonly Projector.set_fieldOfViewDelegate set_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.set_fieldOfViewDelegate>("UnityEngine.Projector::set_fieldOfView");

		// Token: 0x04001AE8 RID: 6888
		private static readonly Projector.get_aspectRatioDelegate get_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.get_aspectRatioDelegate>("UnityEngine.Projector::get_aspectRatio");

		// Token: 0x04001AE9 RID: 6889
		private static readonly Projector.set_aspectRatioDelegate set_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.set_aspectRatioDelegate>("UnityEngine.Projector::set_aspectRatio");

		// Token: 0x04001AEA RID: 6890
		private static readonly Projector.get_orthographicDelegate get_orthographicDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicDelegate>("UnityEngine.Projector::get_orthographic");

		// Token: 0x04001AEB RID: 6891
		private static readonly Projector.set_orthographicDelegate set_orthographicDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicDelegate>("UnityEngine.Projector::set_orthographic");

		// Token: 0x04001AEC RID: 6892
		private static readonly Projector.get_orthographicSizeDelegate get_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicSizeDelegate>("UnityEngine.Projector::get_orthographicSize");

		// Token: 0x04001AED RID: 6893
		private static readonly Projector.set_orthographicSizeDelegate set_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicSizeDelegate>("UnityEngine.Projector::set_orthographicSize");

		// Token: 0x04001AEE RID: 6894
		private static readonly Projector.get_ignoreLayersDelegate get_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.get_ignoreLayersDelegate>("UnityEngine.Projector::get_ignoreLayers");

		// Token: 0x04001AEF RID: 6895
		private static readonly Projector.set_ignoreLayersDelegate set_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.set_ignoreLayersDelegate>("UnityEngine.Projector::set_ignoreLayers");

		// Token: 0x04001AF0 RID: 6896
		private static readonly Projector.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<Projector.get_materialDelegate>("UnityEngine.Projector::get_material");

		// Token: 0x04001AF1 RID: 6897
		private static readonly Projector.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<Projector.set_materialDelegate>("UnityEngine.Projector::set_material");

		// Token: 0x02000B32 RID: 2866
		// (Invoke) Token: 0x060034C4 RID: 13508
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000B33 RID: 2867
		// (Invoke) Token: 0x060034C6 RID: 13510
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000B34 RID: 2868
		// (Invoke) Token: 0x060034C8 RID: 13512
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000B35 RID: 2869
		// (Invoke) Token: 0x060034CA RID: 13514
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000B36 RID: 2870
		// (Invoke) Token: 0x060034CC RID: 13516
		private delegate float get_fieldOfViewDelegate(IntPtr @this);

		// Token: 0x02000B37 RID: 2871
		// (Invoke) Token: 0x060034CE RID: 13518
		private delegate void set_fieldOfViewDelegate(IntPtr @this, float value);

		// Token: 0x02000B38 RID: 2872
		// (Invoke) Token: 0x060034D0 RID: 13520
		private delegate float get_aspectRatioDelegate(IntPtr @this);

		// Token: 0x02000B39 RID: 2873
		// (Invoke) Token: 0x060034D2 RID: 13522
		private delegate void set_aspectRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000B3A RID: 2874
		// (Invoke) Token: 0x060034D4 RID: 13524
		private delegate bool get_orthographicDelegate(IntPtr @this);

		// Token: 0x02000B3B RID: 2875
		// (Invoke) Token: 0x060034D6 RID: 13526
		private delegate void set_orthographicDelegate(IntPtr @this, bool value);

		// Token: 0x02000B3C RID: 2876
		// (Invoke) Token: 0x060034D8 RID: 13528
		private delegate float get_orthographicSizeDelegate(IntPtr @this);

		// Token: 0x02000B3D RID: 2877
		// (Invoke) Token: 0x060034DA RID: 13530
		private delegate void set_orthographicSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000B3E RID: 2878
		// (Invoke) Token: 0x060034DC RID: 13532
		private delegate int get_ignoreLayersDelegate(IntPtr @this);

		// Token: 0x02000B3F RID: 2879
		// (Invoke) Token: 0x060034DE RID: 13534
		private delegate void set_ignoreLayersDelegate(IntPtr @this, int value);

		// Token: 0x02000B40 RID: 2880
		// (Invoke) Token: 0x060034E0 RID: 13536
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000B41 RID: 2881
		// (Invoke) Token: 0x060034E2 RID: 13538
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
