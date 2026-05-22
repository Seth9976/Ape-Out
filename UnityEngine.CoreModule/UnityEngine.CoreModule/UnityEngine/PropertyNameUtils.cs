using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000BA RID: 186
	public class PropertyNameUtils : Object
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x000487B4 File Offset: 0x000469B4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyNameUtils()
		{
			Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyNameUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100664754);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100664755);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0004880C File Offset: 0x00046A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493655, XrefRangeEnd = 493657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyName PropertyNameFromString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00048850 File Offset: 0x00046A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493657, XrefRangeEnd = 493661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropertyNameFromString_Injected(string name, out PropertyName ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0000A545 File Offset: 0x00008745
		public PropertyNameUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0;
	}
}
