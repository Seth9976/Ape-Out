using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044E RID: 1102
	public sealed class DllImportAttribute : Attribute
	{
		// Token: 0x060043DE RID: 17374 RVA: 0x00139654 File Offset: 0x00137854
		// Note: this type is marked as 'beforefieldinit'.
		static DllImportAttribute()
		{
			Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DllImportAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr);
			DllImportAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "_val");
			DllImportAttribute.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "EntryPoint");
			DllImportAttribute.NativeFieldInfoPtr_CharSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CharSet");
			DllImportAttribute.NativeFieldInfoPtr_SetLastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "SetLastError");
			DllImportAttribute.NativeFieldInfoPtr_ExactSpelling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ExactSpelling");
			DllImportAttribute.NativeFieldInfoPtr_PreserveSig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "PreserveSig");
			DllImportAttribute.NativeFieldInfoPtr_CallingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CallingConvention");
			DllImportAttribute.NativeFieldInfoPtr_BestFitMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "BestFitMapping");
			DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ThrowOnUnmappableChar");
			DllImportAttribute.NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100673183);
			DllImportAttribute.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100673184);
			DllImportAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100673185);
			DllImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100673186);
			DllImportAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100673187);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x0013979C File Offset: 0x0013799C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226797, RefRangeEnd = 226799, XrefRangeStart = 226790, XrefRangeEnd = 226797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(RuntimeMethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
			}
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x001397E0 File Offset: 0x001379E0
		[CallerCount(0)]
		public unsafe static bool IsDefined(RuntimeMethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x00139824 File Offset: 0x00137A24
		[CallerCount(0)]
		public unsafe DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charSet;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exactSpelling;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLastError;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSig;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callingConvention;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bestFitMapping;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnUnmappableChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x001398E4 File Offset: 0x00137AE4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllImportAttribute(string dllName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x00139930 File Offset: 0x00137B30
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x00019DC5 File Offset: 0x00017FC5
		public DllImportAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x00139968 File Offset: 0x00137B68
		// (set) Token: 0x060043E6 RID: 17382 RVA: 0x00019DCE File Offset: 0x00017FCE
		public unsafe string _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr__val);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr__val), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x00139990 File Offset: 0x00137B90
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x00019DED File Offset: 0x00017FED
		public unsafe string EntryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_EntryPoint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_EntryPoint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x001399B8 File Offset: 0x00137BB8
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x00019E0C File Offset: 0x0001800C
		public unsafe CharSet CharSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CharSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CharSet)) = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x001399E0 File Offset: 0x00137BE0
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x00019E27 File Offset: 0x00018027
		public unsafe bool SetLastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_SetLastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_SetLastError)) = value;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x00139A08 File Offset: 0x00137C08
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x00019E42 File Offset: 0x00018042
		public unsafe bool ExactSpelling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ExactSpelling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ExactSpelling)) = value;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x00139A30 File Offset: 0x00137C30
		// (set) Token: 0x060043F0 RID: 17392 RVA: 0x00019E5D File Offset: 0x0001805D
		public unsafe bool PreserveSig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_PreserveSig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_PreserveSig)) = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x00139A58 File Offset: 0x00137C58
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x00019E78 File Offset: 0x00018078
		public unsafe CallingConvention CallingConvention
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CallingConvention);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CallingConvention)) = value;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x00139A80 File Offset: 0x00137C80
		// (set) Token: 0x060043F4 RID: 17396 RVA: 0x00019E93 File Offset: 0x00018093
		public unsafe bool BestFitMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_BestFitMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_BestFitMapping)) = value;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x00139AA8 File Offset: 0x00137CA8
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x00019EAE File Offset: 0x000180AE
		public unsafe bool ThrowOnUnmappableChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar)) = value;
			}
		}

		// Token: 0x04003760 RID: 14176
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04003761 RID: 14177
		private static readonly IntPtr NativeFieldInfoPtr_EntryPoint;

		// Token: 0x04003762 RID: 14178
		private static readonly IntPtr NativeFieldInfoPtr_CharSet;

		// Token: 0x04003763 RID: 14179
		private static readonly IntPtr NativeFieldInfoPtr_SetLastError;

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeFieldInfoPtr_ExactSpelling;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeFieldInfoPtr_PreserveSig;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeFieldInfoPtr_CallingConvention;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeFieldInfoPtr_BestFitMapping;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeFieldInfoPtr_ThrowOnUnmappableChar;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
