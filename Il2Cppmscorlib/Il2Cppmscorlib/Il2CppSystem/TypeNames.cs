using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000141 RID: 321
	public class TypeNames : Object
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x00007F2D File Offset: 0x0000612D
		// Note: this type is marked as 'beforefieldinit'.
		static TypeNames()
		{
			Il2CppClassPointerStore<TypeNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNames>.NativeClassPtr);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00007F52 File Offset: 0x00006152
		public TypeNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020005B1 RID: 1457
		public class ATypeName : Object
		{
			// Token: 0x0600519B RID: 20891 RVA: 0x00171514 File Offset: 0x0016F714
			// Note: this type is marked as 'beforefieldinit'.
			static ATypeName()
			{
				Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeNames>.NativeClassPtr, "ATypeName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr);
				TypeNames.ATypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667206);
				TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667207);
				TypeNames.ATypeName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667208);
				TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667209);
				TypeNames.ATypeName.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr, 100667210);
			}

			// Token: 0x170014E3 RID: 5347
			// (get) Token: 0x0600519C RID: 20892 RVA: 0x001715A4 File Offset: 0x0016F7A4
			public unsafe virtual string DisplayName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600519D RID: 20893 RVA: 0x001715E8 File Offset: 0x0016F7E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178582, XrefRangeEnd = 178585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Equals(TypeName other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600519E RID: 20894 RVA: 0x00171638 File Offset: 0x0016F838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178585, XrefRangeEnd = 178586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600519F RID: 20895 RVA: 0x00171680 File Offset: 0x0016F880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178586, XrefRangeEnd = 178592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeNames.ATypeName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051A0 RID: 20896 RVA: 0x001716D8 File Offset: 0x0016F8D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ATypeName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeNames.ATypeName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNames.ATypeName.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051A1 RID: 20897 RVA: 0x0001EAAA File Offset: 0x0001CCAA
			public ATypeName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400425E RID: 16990
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400425F RID: 16991
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypeName_0;

			// Token: 0x04004260 RID: 16992
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04004261 RID: 16993
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004262 RID: 16994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}
	}
}
