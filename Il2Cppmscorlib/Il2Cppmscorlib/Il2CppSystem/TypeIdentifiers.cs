using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000142 RID: 322
	public class TypeIdentifiers : Object
	{
		// Token: 0x060016F3 RID: 5875 RVA: 0x00007F5B File Offset: 0x0000615B
		// Note: this type is marked as 'beforefieldinit'.
		static TypeIdentifiers()
		{
			Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeIdentifiers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr);
			TypeIdentifiers.NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, 100667211);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0008BACC File Offset: 0x00089CCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178613, RefRangeEnd = 178617, XrefRangeStart = 178610, XrefRangeEnd = 178613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeIdentifier FromDisplay(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00007F94 File Offset: 0x00006194
		public TypeIdentifiers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0;

		// Token: 0x020005B2 RID: 1458
		public class Display : TypeNames.ATypeName
		{
			// Token: 0x060051A2 RID: 20898 RVA: 0x00171714 File Offset: 0x0016F914
			// Note: this type is marked as 'beforefieldinit'.
			static Display()
			{
				Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, "Display");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr);
				TypeIdentifiers.Display.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, "displayName");
				TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, "internal_name");
				TypeIdentifiers.Display.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667212);
				TypeIdentifiers.Display.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667213);
				TypeIdentifiers.Display.NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667214);
				TypeIdentifiers.Display.NativeMethodInfoPtr_GetInternalName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667215);
			}

			// Token: 0x060051A3 RID: 20899 RVA: 0x001717B8 File Offset: 0x0016F9B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 116529, RefRangeEnd = 116531, XrefRangeStart = 116529, XrefRangeEnd = 116531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Display(string displayName)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170014E6 RID: 5350
			// (get) Token: 0x060051A4 RID: 20900 RVA: 0x00171804 File Offset: 0x0016FA04
			public unsafe override string DisplayName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeIdentifiers.Display.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014E7 RID: 5351
			// (get) Token: 0x060051A5 RID: 20901 RVA: 0x00171848 File Offset: 0x0016FA48
			public unsafe virtual string InternalName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178592, XrefRangeEnd = 178593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060051A6 RID: 20902 RVA: 0x00171880 File Offset: 0x0016FA80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 178609, RefRangeEnd = 178610, XrefRangeStart = 178593, XrefRangeEnd = 178609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetInternalName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr_GetInternalName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060051A7 RID: 20903 RVA: 0x0001EAB3 File Offset: 0x0001CCB3
			public Display(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014E4 RID: 5348
			// (get) Token: 0x060051A8 RID: 20904 RVA: 0x001718B8 File Offset: 0x0016FAB8
			// (set) Token: 0x060051A9 RID: 20905 RVA: 0x0001EABC File Offset: 0x0001CCBC
			public unsafe string displayName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_displayName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014E5 RID: 5349
			// (get) Token: 0x060051AA RID: 20906 RVA: 0x001718E0 File Offset: 0x0016FAE0
			// (set) Token: 0x060051AB RID: 20907 RVA: 0x0001EADB File Offset: 0x0001CCDB
			public unsafe string internal_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004263 RID: 16995
			private static readonly IntPtr NativeFieldInfoPtr_displayName;

			// Token: 0x04004264 RID: 16996
			private static readonly IntPtr NativeFieldInfoPtr_internal_name;

			// Token: 0x04004265 RID: 16997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

			// Token: 0x04004266 RID: 16998
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0;

			// Token: 0x04004267 RID: 16999
			private static readonly IntPtr NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04004268 RID: 17000
			private static readonly IntPtr NativeMethodInfoPtr_GetInternalName_Private_String_0;
		}
	}
}
