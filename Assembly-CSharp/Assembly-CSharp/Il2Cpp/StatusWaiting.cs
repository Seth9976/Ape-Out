using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001B6 RID: 438
	public class StatusWaiting : StatusEffect
	{
		// Token: 0x060030F0 RID: 12528 RVA: 0x000BB078 File Offset: 0x000B9278
		// Note: this type is marked as 'beforefieldinit'.
		static StatusWaiting()
		{
			Il2CppClassPointerStore<StatusWaiting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusWaiting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusWaiting>.NativeClassPtr);
			StatusWaiting.NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusWaiting>.NativeClassPtr, 100667131);
			StatusWaiting.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusWaiting>.NativeClassPtr, 100667132);
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x000BB0D0 File Offset: 0x000B92D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84752, XrefRangeEnd = 84769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusWaiting(GuardState st, GameObject obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusWaiting>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusWaiting.NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x000BB130 File Offset: 0x000B9330
		[CallerCount(0)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusWaiting.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x000219D2 File Offset: 0x0001FBD2
		public StatusWaiting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
