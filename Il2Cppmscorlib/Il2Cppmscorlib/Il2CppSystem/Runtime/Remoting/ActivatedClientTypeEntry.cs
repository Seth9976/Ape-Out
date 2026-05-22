using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038C RID: 908
	public class ActivatedClientTypeEntry : TypeEntry
	{
		// Token: 0x06003C20 RID: 15392 RVA: 0x0011E0E4 File Offset: 0x0011C2E4
		// Note: this type is marked as 'beforefieldinit'.
		static ActivatedClientTypeEntry()
		{
			Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ActivatedClientTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr);
			ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, "applicationUrl");
			ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, "obj_type");
			ActivatedClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672248);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672249);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672250);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672251);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672252);
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x0011E1A0 File Offset: 0x0011C3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219054, RefRangeEnd = 219055, XrefRangeStart = 219050, XrefRangeEnd = 219054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x0011E210 File Offset: 0x0011C410
		public unsafe string ApplicationUrl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x0011E248 File Offset: 0x0011C448
		public unsafe Il2CppReferenceArray<IContextAttribute> ContextAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IContextAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x0011E288 File Offset: 0x0011C488
		public unsafe Type ObjectType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x0011E2C8 File Offset: 0x0011C4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219055, XrefRangeEnd = 219056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivatedClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x00016696 File Offset: 0x00014896
		public ActivatedClientTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x0011E30C File Offset: 0x0011C50C
		// (set) Token: 0x06003C28 RID: 15400 RVA: 0x0001669F File Offset: 0x0001489F
		public unsafe string applicationUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x0011E334 File Offset: 0x0011C534
		// (set) Token: 0x06003C2A RID: 15402 RVA: 0x000166BE File Offset: 0x000148BE
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeFieldInfoPtr_applicationUrl;

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
