using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DE RID: 222
	public class Authorization : Object
	{
		// Token: 0x06000C8F RID: 3215 RVA: 0x00040378 File Offset: 0x0003E578
		// Note: this type is marked as 'beforefieldinit'.
		static Authorization()
		{
			Il2CppClassPointerStore<Authorization>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Authorization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Authorization>.NativeClassPtr);
			Authorization.NativeFieldInfoPtr_m_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "m_Message");
			Authorization.NativeFieldInfoPtr_m_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "m_Complete");
			Authorization.NativeFieldInfoPtr_ModuleAuthenticationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "ModuleAuthenticationType");
			Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100665142);
			Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100665143);
			Authorization.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100665144);
			Authorization.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100665145);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00040434 File Offset: 0x0003E634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 376584, RefRangeEnd = 376586, XrefRangeStart = 376581, XrefRangeEnd = 376584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization(string token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authorization>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00040480 File Offset: 0x0003E680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376586, XrefRangeEnd = 376589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization(string token, bool finished)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authorization>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finished;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x000404DC File Offset: 0x0003E6DC
		public unsafe string Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00040514 File Offset: 0x0003E714
		public unsafe bool Complete
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00006EB3 File Offset: 0x000050B3
		public Authorization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00040550 File Offset: 0x0003E750
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00006EBC File Offset: 0x000050BC
		public unsafe string m_Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00040578 File Offset: 0x0003E778
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00006EDB File Offset: 0x000050DB
		public unsafe bool m_Complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Complete)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000405A0 File Offset: 0x0003E7A0
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00006EF6 File Offset: 0x000050F6
		public unsafe string ModuleAuthenticationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_ModuleAuthenticationType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_ModuleAuthenticationType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_m_Message;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_m_Complete;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_ModuleAuthenticationType;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0;
	}
}
