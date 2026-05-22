using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A7 RID: 935
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		// Token: 0x06003DC5 RID: 15813 RVA: 0x0012449C File Offset: 0x0012269C
		// Note: this type is marked as 'beforefieldinit'.
		static WellKnownServiceTypeEntry()
		{
			Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "WellKnownServiceTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr);
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_type");
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_uri");
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_mode");
			WellKnownServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672457);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672458);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672459);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672460);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672461);
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x0012456C File Offset: 0x0012276C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221384, RefRangeEnd = 221385, XrefRangeStart = 221380, XrefRangeEnd = 221384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x001245EC File Offset: 0x001227EC
		public unsafe WellKnownObjectMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x00124628 File Offset: 0x00122828
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x00124668 File Offset: 0x00122868
		public unsafe string ObjectUri
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x001246A0 File Offset: 0x001228A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221385, XrefRangeEnd = 221416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WellKnownServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x0001709A File Offset: 0x0001529A
		public WellKnownServiceTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x001246E4 File Offset: 0x001228E4
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x000170A3 File Offset: 0x000152A3
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x00124714 File Offset: 0x00122914
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x000170C2 File Offset: 0x000152C2
		public unsafe string obj_uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x0012473C File Offset: 0x0012293C
		// (set) Token: 0x06003DD1 RID: 15825 RVA: 0x000170E1 File Offset: 0x000152E1
		public unsafe WellKnownObjectMode obj_mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode)) = value;
			}
		}

		// Token: 0x04003329 RID: 13097
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x0400332A RID: 13098
		private static readonly IntPtr NativeFieldInfoPtr_obj_uri;

		// Token: 0x0400332B RID: 13099
		private static readonly IntPtr NativeFieldInfoPtr_obj_mode;

		// Token: 0x0400332C RID: 13100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0;

		// Token: 0x0400332D RID: 13101
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0;

		// Token: 0x0400332E RID: 13102
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x0400332F RID: 13103
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0;

		// Token: 0x04003330 RID: 13104
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
