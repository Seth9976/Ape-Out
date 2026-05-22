using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000355 RID: 853
	public sealed class BinaryAssemblyInfo : Object
	{
		// Token: 0x06003768 RID: 14184 RVA: 0x0010EDC0 File Offset: 0x0010CFC0
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryAssemblyInfo()
		{
			Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryAssemblyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr);
			BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assemblyString");
			BinaryAssemblyInfo.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assembly");
			BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671876);
			BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671877);
			BinaryAssemblyInfo.NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671878);
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x0010EE54 File Offset: 0x0010D054
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssemblyInfo(string assemblyString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x0010EEA0 File Offset: 0x0010D0A0
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssemblyInfo(string assemblyString, Assembly assembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0010EF00 File Offset: 0x0010D100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215784, XrefRangeEnd = 215788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly GetAssembly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00013B8E File Offset: 0x00011D8E
		public BinaryAssemblyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x0010EF40 File Offset: 0x0010D140
		// (set) Token: 0x0600376E RID: 14190 RVA: 0x00013B97 File Offset: 0x00011D97
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x0010EF68 File Offset: 0x0010D168
		// (set) Token: 0x06003770 RID: 14192 RVA: 0x00013BB6 File Offset: 0x00011DB6
		public unsafe Assembly assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0;
	}
}
