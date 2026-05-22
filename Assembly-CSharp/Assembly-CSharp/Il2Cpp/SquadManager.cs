using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A5 RID: 421
	public class SquadManager : MonoBehaviour
	{
		// Token: 0x0600305F RID: 12383 RVA: 0x000B97D8 File Offset: 0x000B79D8
		// Note: this type is marked as 'beforefieldinit'.
		static SquadManager()
		{
			Il2CppClassPointerStore<SquadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SquadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SquadManager>.NativeClassPtr);
			SquadManager.NativeFieldInfoPtr_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquadManager>.NativeClassPtr, "leader");
			SquadManager.NativeFieldInfoPtr_guards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquadManager>.NativeClassPtr, "guards");
			SquadManager.NativeFieldInfoPtr_states = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquadManager>.NativeClassPtr, "states");
			SquadManager.NativeFieldInfoPtr_followDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquadManager>.NativeClassPtr, "followDist");
			SquadManager.NativeFieldInfoPtr_followWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SquadManager>.NativeClassPtr, "followWidth");
			SquadManager.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquadManager>.NativeClassPtr, 100667084);
			SquadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquadManager>.NativeClassPtr, 100667085);
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000B9894 File Offset: 0x000B7A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84291, XrefRangeEnd = 84370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquadManager.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x000B98C8 File Offset: 0x000B7AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquadManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SquadManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x0002146C File Offset: 0x0001F66C
		public SquadManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x000B9904 File Offset: 0x000B7B04
		// (set) Token: 0x06003064 RID: 12388 RVA: 0x00021475 File Offset: 0x0001F675
		public unsafe GuardState leader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_leader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_leader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x000B9934 File Offset: 0x000B7B34
		// (set) Token: 0x06003066 RID: 12390 RVA: 0x00021494 File Offset: 0x0001F694
		public unsafe Il2CppReferenceArray<GameObject> guards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_guards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_guards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x000B9964 File Offset: 0x000B7B64
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x000214B3 File Offset: 0x0001F6B3
		public unsafe Il2CppReferenceArray<GuardState> states
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_states);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuardState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_states), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x000B9994 File Offset: 0x000B7B94
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x000214D2 File Offset: 0x0001F6D2
		public unsafe float followDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_followDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_followDist)) = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x000B99BC File Offset: 0x000B7BBC
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x000214ED File Offset: 0x0001F6ED
		public unsafe float followWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_followWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SquadManager.NativeFieldInfoPtr_followWidth)) = value;
			}
		}

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeFieldInfoPtr_leader;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeFieldInfoPtr_guards;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeFieldInfoPtr_states;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeFieldInfoPtr_followDist;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeFieldInfoPtr_followWidth;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
