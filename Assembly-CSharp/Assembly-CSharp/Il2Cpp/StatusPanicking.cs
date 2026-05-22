using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001B1 RID: 433
	public class StatusPanicking : StatusEffect
	{
		// Token: 0x060030D8 RID: 12504 RVA: 0x000BAC68 File Offset: 0x000B8E68
		// Note: this type is marked as 'beforefieldinit'.
		static StatusPanicking()
		{
			Il2CppClassPointerStore<StatusPanicking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusPanicking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusPanicking>.NativeClassPtr);
			StatusPanicking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusPanicking>.NativeClassPtr, 100667123);
			StatusPanicking.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusPanicking>.NativeClassPtr, 100667124);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x000BACC0 File Offset: 0x000B8EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84730, RefRangeEnd = 84732, XrefRangeStart = 84713, XrefRangeEnd = 84730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusPanicking(GuardState st, GameObject obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusPanicking>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusPanicking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x000BAD20 File Offset: 0x000B8F20
		[CallerCount(0)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusPanicking.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x000218E2 File Offset: 0x0001FAE2
		public StatusPanicking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
