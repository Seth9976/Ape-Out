using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001AE RID: 430
	public class StatusFleeing : StatusEffect
	{
		// Token: 0x060030C9 RID: 12489 RVA: 0x000BA9C8 File Offset: 0x000B8BC8
		// Note: this type is marked as 'beforefieldinit'.
		static StatusFleeing()
		{
			Il2CppClassPointerStore<StatusFleeing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusFleeing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusFleeing>.NativeClassPtr);
			StatusFleeing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusFleeing>.NativeClassPtr, 100667118);
			StatusFleeing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusFleeing>.NativeClassPtr, 100667119);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000BAA20 File Offset: 0x000B8C20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84651, RefRangeEnd = 84653, XrefRangeStart = 84634, XrefRangeEnd = 84651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusFleeing(GuardState st, GameObject obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusFleeing>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusFleeing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000BAA80 File Offset: 0x000B8C80
		[CallerCount(0)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusFleeing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00021854 File Offset: 0x0001FA54
		public StatusFleeing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_GameObject_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
