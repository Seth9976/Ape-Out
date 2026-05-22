using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A0 RID: 416
	public class SparkMover : MonoBehaviour
	{
		// Token: 0x06003023 RID: 12323 RVA: 0x000B8E54 File Offset: 0x000B7054
		// Note: this type is marked as 'beforefieldinit'.
		static SparkMover()
		{
			Il2CppClassPointerStore<SparkMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SparkMover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparkMover>.NativeClassPtr);
			SparkMover.NativeFieldInfoPtr_dests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkMover>.NativeClassPtr, "dests");
			SparkMover.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkMover>.NativeClassPtr, "speed");
			SparkMover.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkMover>.NativeClassPtr, "timer");
			SparkMover.NativeFieldInfoPtr_moveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkMover>.NativeClassPtr, "moveTime");
			SparkMover.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkMover>.NativeClassPtr, "dest");
			SparkMover.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkMover>.NativeClassPtr, 100667064);
			SparkMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkMover>.NativeClassPtr, 100667065);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x000B8F10 File Offset: 0x000B7110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84118, XrefRangeEnd = 84133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkMover.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x000B8F44 File Offset: 0x000B7144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparkMover()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparkMover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x0002123D File Offset: 0x0001F43D
		public SparkMover(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x000B8F80 File Offset: 0x000B7180
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x00021246 File Offset: 0x0001F446
		public unsafe Il2CppReferenceArray<Transform> dests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_dests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_dests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x000B8FB0 File Offset: 0x000B71B0
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x00021265 File Offset: 0x0001F465
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000B8FD8 File Offset: 0x000B71D8
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x00021280 File Offset: 0x0001F480
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x000B9000 File Offset: 0x000B7200
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x0002129B File Offset: 0x0001F49B
		public unsafe float moveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_moveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_moveTime)) = value;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x000B9028 File Offset: 0x000B7228
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x000212B6 File Offset: 0x0001F4B6
		public unsafe int dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkMover.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeFieldInfoPtr_dests;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr_moveTime;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
