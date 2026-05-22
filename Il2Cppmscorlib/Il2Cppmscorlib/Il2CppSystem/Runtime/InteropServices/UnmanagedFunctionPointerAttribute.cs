using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200043C RID: 1084
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		// Token: 0x0600439E RID: 17310 RVA: 0x00138D9C File Offset: 0x00136F9C
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedFunctionPointerAttribute()
		{
			Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "UnmanagedFunctionPointerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr);
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "m_callingConvention");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_CharSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "CharSet");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_BestFitMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "BestFitMapping");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "ThrowOnUnmappableChar");
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_SetLastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "SetLastError");
			UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, 100673169);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00138E44 File Offset: 0x00137044
		[CallerCount(0)]
		public unsafe UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callingConvention;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00019AE7 File Offset: 0x00017CE7
		public UnmanagedFunctionPointerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x00138E8C File Offset: 0x0013708C
		// (set) Token: 0x060043A2 RID: 17314 RVA: 0x00019AF0 File Offset: 0x00017CF0
		public unsafe CallingConvention m_callingConvention
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention)) = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x00138EB4 File Offset: 0x001370B4
		// (set) Token: 0x060043A4 RID: 17316 RVA: 0x00019B0B File Offset: 0x00017D0B
		public unsafe CharSet CharSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_CharSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_CharSet)) = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x00138EDC File Offset: 0x001370DC
		// (set) Token: 0x060043A6 RID: 17318 RVA: 0x00019B26 File Offset: 0x00017D26
		public unsafe bool BestFitMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_BestFitMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_BestFitMapping)) = value;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x00138F04 File Offset: 0x00137104
		// (set) Token: 0x060043A8 RID: 17320 RVA: 0x00019B41 File Offset: 0x00017D41
		public unsafe bool ThrowOnUnmappableChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar)) = value;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x00138F2C File Offset: 0x0013712C
		// (set) Token: 0x060043AA RID: 17322 RVA: 0x00019B5C File Offset: 0x00017D5C
		public unsafe bool SetLastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_SetLastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_SetLastError)) = value;
			}
		}

		// Token: 0x040036E1 RID: 14049
		private static readonly IntPtr NativeFieldInfoPtr_m_callingConvention;

		// Token: 0x040036E2 RID: 14050
		private static readonly IntPtr NativeFieldInfoPtr_CharSet;

		// Token: 0x040036E3 RID: 14051
		private static readonly IntPtr NativeFieldInfoPtr_BestFitMapping;

		// Token: 0x040036E4 RID: 14052
		private static readonly IntPtr NativeFieldInfoPtr_ThrowOnUnmappableChar;

		// Token: 0x040036E5 RID: 14053
		private static readonly IntPtr NativeFieldInfoPtr_SetLastError;

		// Token: 0x040036E6 RID: 14054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0;
	}
}
