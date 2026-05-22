using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000020 RID: 32
	public static class BinaryCompatibility : Object
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00019E30 File Offset: 0x00018030
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCompatibility()
		{
			Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinaryCompatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
			BinaryCompatibility.NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "_targetsAtLeast_Desktop_V4_5_2");
			BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100663479);
			BinaryCompatibility.NativeMethodInfoPtr_RunningOnCheck_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100663480);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00019E9C File Offset: 0x0001809C
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389693, XrefRangeEnd = 389697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00019ECC File Offset: 0x000180CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389697, XrefRangeEnd = 389717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RunningOnCheck(string propertyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCompatibility.NativeMethodInfoPtr_RunningOnCheck_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002C41 File Offset: 0x00000E41
		public BinaryCompatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00019F10 File Offset: 0x00018110
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002C4A File Offset: 0x00000E4A
		public unsafe static bool _targetsAtLeast_Desktop_V4_5_2
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2, (void*)(&value));
			}
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Internal_Static_get_Boolean_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_RunningOnCheck_Private_Static_Boolean_String_0;
	}
}
