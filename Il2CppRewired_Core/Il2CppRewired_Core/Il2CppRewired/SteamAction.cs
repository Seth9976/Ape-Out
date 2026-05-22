using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200002B RID: 43
	public class SteamAction : Object
	{
		// Token: 0x06000350 RID: 848 RVA: 0x0003A8D0 File Offset: 0x00038AD0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAction()
		{
			Il2CppClassPointerStore<SteamAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "SteamAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAction>.NativeClassPtr);
			SteamAction.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAction>.NativeClassPtr, "name");
			SteamAction.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAction>.NativeClassPtr, "handle");
			SteamAction.NativeMethodInfoPtr__ctor_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAction>.NativeClassPtr, 100663844);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0003A93C File Offset: 0x00038B3C
		[CallerCount(0)]
		public unsafe SteamAction(string name, ulong handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAction.NativeMethodInfoPtr__ctor_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003124 File Offset: 0x00001324
		public SteamAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0003A998 File Offset: 0x00038B98
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0000312D File Offset: 0x0000132D
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamAction.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamAction.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0003A9C0 File Offset: 0x00038BC0
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0000314C File Offset: 0x0000134C
		public unsafe ulong handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamAction.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamAction.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UInt64_0;
	}
}
