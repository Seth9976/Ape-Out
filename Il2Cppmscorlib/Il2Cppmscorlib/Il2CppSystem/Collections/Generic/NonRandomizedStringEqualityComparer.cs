using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000498 RID: 1176
	[Serializable]
	public sealed class NonRandomizedStringEqualityComparer : EqualityComparer<string>
	{
		// Token: 0x060047AB RID: 18347 RVA: 0x0014ABFC File Offset: 0x00148DFC
		// Note: this type is marked as 'beforefieldinit'.
		static NonRandomizedStringEqualityComparer()
		{
			Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "NonRandomizedStringEqualityComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr);
			NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr, 100674007);
			NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr, 100674008);
			NonRandomizedStringEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr, 100674009);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x0014AC68 File Offset: 0x00148E68
		[CallerCount(0)]
		public unsafe override bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x0014ACC8 File Offset: 0x00148EC8
		[CallerCount(0)]
		public unsafe override int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x0014AD18 File Offset: 0x00148F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231131, XrefRangeEnd = 231132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonRandomizedStringEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonRandomizedStringEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x0001AFC5 File Offset: 0x000191C5
		public NonRandomizedStringEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003A37 RID: 14903
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_String_String_0;

		// Token: 0x04003A38 RID: 14904
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_String_0;

		// Token: 0x04003A39 RID: 14905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
