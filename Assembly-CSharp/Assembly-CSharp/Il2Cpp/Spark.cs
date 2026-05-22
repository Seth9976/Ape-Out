using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200019E RID: 414
	public class Spark : MonoBehaviour
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x000B89A4 File Offset: 0x000B6BA4
		// Note: this type is marked as 'beforefieldinit'.
		static Spark()
		{
			Il2CppClassPointerStore<Spark>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Spark");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spark>.NativeClassPtr);
			Spark.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spark>.NativeClassPtr, "depth");
			Spark.NativeFieldInfoPtr_desDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spark>.NativeClassPtr, "desDist");
			Spark.NativeFieldInfoPtr_dad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spark>.NativeClassPtr, "dad");
			Spark.NativeFieldInfoPtr_vel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spark>.NativeClassPtr, "vel");
			Spark.NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spark>.NativeClassPtr, "drag");
			Spark.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spark>.NativeClassPtr, 100667051);
			Spark.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spark>.NativeClassPtr, 100667052);
			Spark.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spark>.NativeClassPtr, 100667053);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000B8A74 File Offset: 0x000B6C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83929, XrefRangeEnd = 83961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spark.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000B8AA8 File Offset: 0x000B6CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83961, XrefRangeEnd = 84011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spark.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000B8ADC File Offset: 0x000B6CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spark()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spark>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spark.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00021128 File Offset: 0x0001F328
		public Spark(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x000B8B18 File Offset: 0x000B6D18
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x00021131 File Offset: 0x0001F331
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x000B8B40 File Offset: 0x000B6D40
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x0002114C File Offset: 0x0001F34C
		public unsafe float desDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_desDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_desDist)) = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x000B8B68 File Offset: 0x000B6D68
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x00021167 File Offset: 0x0001F367
		public unsafe Transform dad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_dad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_dad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x000B8B98 File Offset: 0x000B6D98
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x00021186 File Offset: 0x0001F386
		public unsafe Vector2 vel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_vel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_vel)) = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x000B8BC0 File Offset: 0x000B6DC0
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x000211A1 File Offset: 0x0001F3A1
		public unsafe float drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_drag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spark.NativeFieldInfoPtr_drag)) = value;
			}
		}

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeFieldInfoPtr_desDist;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeFieldInfoPtr_dad;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeFieldInfoPtr_vel;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeFieldInfoPtr_drag;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
