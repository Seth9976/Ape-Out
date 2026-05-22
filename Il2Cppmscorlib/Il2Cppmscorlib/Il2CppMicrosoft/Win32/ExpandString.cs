using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000044 RID: 68
	public class ExpandString : Object
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x00033858 File Offset: 0x00031A58
		// Note: this type is marked as 'beforefieldinit'.
		static ExpandString()
		{
			Il2CppClassPointerStore<ExpandString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "ExpandString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandString>.NativeClassPtr);
			ExpandString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandString>.NativeClassPtr, "value");
			ExpandString.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandString>.NativeClassPtr, 100663928);
			ExpandString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandString>.NativeClassPtr, 100663929);
			ExpandString.NativeMethodInfoPtr_Expand_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandString>.NativeClassPtr, 100663930);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000338D8 File Offset: 0x00031AD8
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandString(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandString>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandString.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00033924 File Offset: 0x00031B24
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00033968 File Offset: 0x00031B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137516, RefRangeEnd = 137517, XrefRangeStart = 137494, XrefRangeEnd = 137516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Expand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandString.NativeMethodInfoPtr_Expand_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00003C32 File Offset: 0x00001E32
		public ExpandString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000339A0 File Offset: 0x00031BA0
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00003C3B File Offset: 0x00001E3B
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandString.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandString.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_Expand_Public_String_0;
	}
}
