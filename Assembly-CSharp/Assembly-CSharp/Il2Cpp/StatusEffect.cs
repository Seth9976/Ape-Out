using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001AC RID: 428
	public class StatusEffect : global::Il2CppSystem.Object
	{
		// Token: 0x060030B7 RID: 12471 RVA: 0x000BA710 File Offset: 0x000B8910
		// Note: this type is marked as 'beforefieldinit'.
		static StatusEffect()
		{
			Il2CppClassPointerStore<StatusEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr);
			StatusEffect.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "mode");
			StatusEffect.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "state");
			StatusEffect.NativeFieldInfoPtr_nam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "nam");
			StatusEffect.NativeFieldInfoPtr_objs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "objs");
			StatusEffect.NativeFieldInfoPtr_delList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "delList");
			StatusEffect.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, 100667114);
			StatusEffect.NativeMethodInfoPtr_CleanObjList_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, 100667115);
			StatusEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, 100667116);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x000BA7E0 File Offset: 0x000B89E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusEffect.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x000BA81C File Offset: 0x000B8A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84597, XrefRangeEnd = 84632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CleanObjList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusEffect.NativeMethodInfoPtr_CleanObjList_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000BA858 File Offset: 0x000B8A58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0002176E File Offset: 0x0001F96E
		public StatusEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x000BA894 File Offset: 0x000B8A94
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x00021777 File Offset: 0x0001F977
		public unsafe GuardMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_mode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_mode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x000BA8C4 File Offset: 0x000B8AC4
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x00021796 File Offset: 0x0001F996
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x000BA8F4 File Offset: 0x000B8AF4
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x000217B5 File Offset: 0x0001F9B5
		public unsafe string nam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_nam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_nam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x000BA91C File Offset: 0x000B8B1C
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x000217D4 File Offset: 0x0001F9D4
		public unsafe List<GameObject> objs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_objs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_objs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x000BA94C File Offset: 0x000B8B4C
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x000217F3 File Offset: 0x0001F9F3
		public unsafe List<int> delList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_delList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusEffect.NativeFieldInfoPtr_delList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeFieldInfoPtr_nam;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeFieldInfoPtr_objs;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeFieldInfoPtr_delList;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_CleanObjList_Public_Virtual_New_Void_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
