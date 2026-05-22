using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038D RID: 909
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		// Token: 0x06003C2B RID: 15403 RVA: 0x0011E364 File Offset: 0x0011C564
		// Note: this type is marked as 'beforefieldinit'.
		static ActivatedServiceTypeEntry()
		{
			Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ActivatedServiceTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr);
			ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, "obj_type");
			ActivatedServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100672253);
			ActivatedServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100672254);
			ActivatedServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100672255);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x0011E3E4 File Offset: 0x0011C5E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219060, RefRangeEnd = 219062, XrefRangeStart = 219056, XrefRangeEnd = 219060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivatedServiceTypeEntry(string typeName, string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x0011E444 File Offset: 0x0011C644
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x0011E484 File Offset: 0x0011C684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219062, XrefRangeEnd = 219063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivatedServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x000166DD File Offset: 0x000148DD
		public ActivatedServiceTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x0011E4C8 File Offset: 0x0011C6C8
		// (set) Token: 0x06003C31 RID: 15409 RVA: 0x000166E6 File Offset: 0x000148E6
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
