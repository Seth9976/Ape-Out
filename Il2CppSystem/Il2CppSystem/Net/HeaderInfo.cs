using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000103 RID: 259
	public class HeaderInfo : Object
	{
		// Token: 0x06000E3A RID: 3642 RVA: 0x000465BC File Offset: 0x000447BC
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderInfo()
		{
			Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr);
			HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsRequestRestricted");
			HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsResponseRestricted");
			HeaderInfo.NativeFieldInfoPtr_Parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "Parser");
			HeaderInfo.NativeFieldInfoPtr_HeaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "HeaderName");
			HeaderInfo.NativeFieldInfoPtr_AllowMultiValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "AllowMultiValues");
			HeaderInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100665356);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00046664 File Offset: 0x00044864
		[CallerCount(0)]
		public unsafe HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestRestricted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref responseRestricted;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0000787F File Offset: 0x00005A7F
		public HeaderInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x000466EC File Offset: 0x000448EC
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00007888 File Offset: 0x00005A88
		public unsafe bool IsRequestRestricted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00046714 File Offset: 0x00044914
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x000078A3 File Offset: 0x00005AA3
		public unsafe bool IsResponseRestricted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted)) = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0004673C File Offset: 0x0004493C
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x000078BE File Offset: 0x00005ABE
		public unsafe HeaderParser Parser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Parser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Parser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0004676C File Offset: 0x0004496C
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x000078DD File Offset: 0x00005ADD
		public unsafe string HeaderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00046794 File Offset: 0x00044994
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x000078FC File Offset: 0x00005AFC
		public unsafe bool AllowMultiValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowMultiValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowMultiValues)) = value;
			}
		}

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeFieldInfoPtr_IsRequestRestricted;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeFieldInfoPtr_IsResponseRestricted;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeFieldInfoPtr_Parser;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeFieldInfoPtr_HeaderName;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_AllowMultiValues;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0;
	}
}
