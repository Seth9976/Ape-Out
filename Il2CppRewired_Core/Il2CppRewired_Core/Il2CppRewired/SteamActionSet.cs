using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x0200002C RID: 44
	public class SteamActionSet : Object
	{
		// Token: 0x06000357 RID: 855 RVA: 0x0003A9E8 File Offset: 0x00038BE8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamActionSet()
		{
			Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "SteamActionSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr);
			SteamActionSet.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr, "name");
			SteamActionSet.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr, "handle");
			SteamActionSet.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr, "actions");
			SteamActionSet.NativeMethodInfoPtr__ctor_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr, 100663845);
			SteamActionSet.NativeMethodInfoPtr_AddAction_Public_Void_SteamAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr, 100663846);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0003AA7C File Offset: 0x00038C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244590, XrefRangeEnd = 244595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamActionSet(string name, ulong handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamActionSet>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamActionSet.NativeMethodInfoPtr__ctor_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244595, XrefRangeEnd = 244597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAction(SteamAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamActionSet.NativeMethodInfoPtr_AddAction_Public_Void_SteamAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003167 File Offset: 0x00001367
		public SteamActionSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0003AB1C File Offset: 0x00038D1C
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00003170 File Offset: 0x00001370
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamActionSet.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamActionSet.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0003AB44 File Offset: 0x00038D44
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000318F File Offset: 0x0000138F
		public unsafe ulong handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamActionSet.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamActionSet.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0003AB6C File Offset: 0x00038D6C
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000031AA File Offset: 0x000013AA
		public unsafe Dictionary<string, SteamAction> actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamActionSet.NativeFieldInfoPtr_actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SteamAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamActionSet.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_actions;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UInt64_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_AddAction_Public_Void_SteamAction_0;
	}
}
