using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	public sealed class DistanceJoint2D : AnchoredJoint2D
	{
		// Token: 0x06000359 RID: 857 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		// Note: this type is marked as 'beforefieldinit'.
		static DistanceJoint2D()
		{
			Il2CppClassPointerStore<DistanceJoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "DistanceJoint2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistanceJoint2D>.NativeClassPtr);
			DistanceJoint2D.get_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_autoConfigureDistanceDelegate>("UnityEngine.DistanceJoint2D::get_autoConfigureDistance");
			DistanceJoint2D.set_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_autoConfigureDistanceDelegate>("UnityEngine.DistanceJoint2D::set_autoConfigureDistance");
			DistanceJoint2D.get_distanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_distanceDelegate>("UnityEngine.DistanceJoint2D::get_distance");
			DistanceJoint2D.set_distanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_distanceDelegate>("UnityEngine.DistanceJoint2D::set_distance");
			DistanceJoint2D.get_maxDistanceOnlyDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_maxDistanceOnlyDelegate>("UnityEngine.DistanceJoint2D::get_maxDistanceOnly");
			DistanceJoint2D.set_maxDistanceOnlyDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_maxDistanceOnlyDelegate>("UnityEngine.DistanceJoint2D::set_maxDistanceOnly");
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003688 File Offset: 0x00001888
		public DistanceJoint2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00003691 File Offset: 0x00001891
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000036A3 File Offset: 0x000018A3
		public bool autoConfigureDistance
		{
			get
			{
				return DistanceJoint2D.get_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000036B6 File Offset: 0x000018B6
		// (set) Token: 0x0600035E RID: 862 RVA: 0x000036C8 File Offset: 0x000018C8
		public float distance
		{
			get
			{
				return DistanceJoint2D.get_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000036DB File Offset: 0x000018DB
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000036ED File Offset: 0x000018ED
		public bool maxDistanceOnly
		{
			get
			{
				return DistanceJoint2D.get_maxDistanceOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_maxDistanceOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001EE RID: 494
		private static readonly DistanceJoint2D.get_autoConfigureDistanceDelegate get_autoConfigureDistanceDelegateField;

		// Token: 0x040001EF RID: 495
		private static readonly DistanceJoint2D.set_autoConfigureDistanceDelegate set_autoConfigureDistanceDelegateField;

		// Token: 0x040001F0 RID: 496
		private static readonly DistanceJoint2D.get_distanceDelegate get_distanceDelegateField;

		// Token: 0x040001F1 RID: 497
		private static readonly DistanceJoint2D.set_distanceDelegate set_distanceDelegateField;

		// Token: 0x040001F2 RID: 498
		private static readonly DistanceJoint2D.get_maxDistanceOnlyDelegate get_maxDistanceOnlyDelegateField;

		// Token: 0x040001F3 RID: 499
		private static readonly DistanceJoint2D.set_maxDistanceOnlyDelegate set_maxDistanceOnlyDelegateField;

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000626 RID: 1574
		private delegate bool get_autoConfigureDistanceDelegate(IntPtr @this);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x06000628 RID: 1576
		private delegate void set_autoConfigureDistanceDelegate(IntPtr @this, bool value);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x0600062A RID: 1578
		private delegate float get_distanceDelegate(IntPtr @this);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate void set_distanceDelegate(IntPtr @this, float value);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate bool get_maxDistanceOnlyDelegate(IntPtr @this);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate void set_maxDistanceOnlyDelegate(IntPtr @this, bool value);
	}
}
