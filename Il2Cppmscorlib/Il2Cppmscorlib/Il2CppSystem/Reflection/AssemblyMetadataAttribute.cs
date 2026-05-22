using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200019B RID: 411
	public sealed class AssemblyMetadataAttribute : Attribute
	{
		// Token: 0x06001BF0 RID: 7152 RVA: 0x000A2340 File Offset: 0x000A0540
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyMetadataAttribute()
		{
			Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyMetadataAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr);
			AssemblyMetadataAttribute.NativeFieldInfoPtr_m_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr, "m_key");
			AssemblyMetadataAttribute.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr, "m_value");
			AssemblyMetadataAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr, 100668032);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000A23AC File Offset: 0x000A05AC
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyMetadataAttribute(string key, string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyMetadataAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00009835 File Offset: 0x00007A35
		public AssemblyMetadataAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x000A240C File Offset: 0x000A060C
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0000983E File Offset: 0x00007A3E
		public unsafe string m_key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr_m_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr_m_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x000A2434 File Offset: 0x000A0634
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0000985D File Offset: 0x00007A5D
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeFieldInfoPtr_m_key;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
